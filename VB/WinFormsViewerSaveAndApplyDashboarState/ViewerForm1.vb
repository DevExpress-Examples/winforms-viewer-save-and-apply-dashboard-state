Imports DevExpress.DashboardCommon
Imports DevExpress.XtraEditors
Imports System
Imports System.Windows.Forms
Imports System.Xml.Linq

Namespace WinFormsViewerSaveAndApplyDashboardState
	Partial Public Class ViewerForm1
		Inherits XtraForm
		Public Shared ReadOnly PropertyName As String = "DashboardState"
		Private Const path As String = "..\..\Dashboards\dashboardWithSavedState.xml"
		Public Sub New()
			InitializeComponent()
			AddHandler dashboardViewer.SetInitialDashboardState, AddressOf dashboardViewer_SetInitialDashboardState
			dashboardViewer.DashboardSource = path
		End Sub

		Private Function GetDataFromString(ByVal customPropertyValue As String) As DashboardState
			Dim dState As New DashboardState()
			If (Not String.IsNullOrEmpty(customPropertyValue)) Then
				Dim xmlStateEl = XDocument.Parse(customPropertyValue)
				dState.LoadFromXml(xmlStateEl)
			End If
			Return dState
		End Function

		Private Sub dashboardViewer_SetInitialDashboardState(ByVal sender As Object, ByVal e As DevExpress.DashboardWin.SetInitialDashboardStateEventArgs)
			Dim state = GetDataFromString(dashboardViewer.Dashboard.CustomProperties.GetValue(PropertyName))
			e.InitialState = state
		End Sub

		Private Sub ViewerForm1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles Me.FormClosing
			Dim dState = dashboardViewer.GetDashboardState()
			Dim stateValue = dState.SaveToXml().ToString(SaveOptions.DisableFormatting)
			dashboardViewer.Dashboard.CustomProperties.SetValue("DashboardState", stateValue)
			dashboardViewer.Dashboard.SaveToXml(path)
		End Sub
	End Class
End Namespace
