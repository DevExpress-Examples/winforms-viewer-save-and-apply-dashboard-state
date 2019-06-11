Namespace WinFormsViewerSaveAndApplyDashboarState
	Partial Public Class ViewerForm1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.dashboardViewer = New DevExpress.DashboardWin.DashboardViewer(Me.components)
			CType(Me.dashboardViewer, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dashboardViewer
			' 
			Me.dashboardViewer.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(235)))), (CInt((CByte(236)))), (CInt((CByte(239)))))
			Me.dashboardViewer.Appearance.Options.UseBackColor = True
			Me.dashboardViewer.DashboardSource = ""
			Me.dashboardViewer.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dashboardViewer.Location = New System.Drawing.Point(0, 0)
			Me.dashboardViewer.Name = "dashboardViewer"
			Me.dashboardViewer.Size = New System.Drawing.Size(986, 628)
			Me.dashboardViewer.TabIndex = 0
			Me.dashboardViewer.UseNeutralFilterMode = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.dashboardViewer.DashboardLoaded += new DevExpress.DashboardWin.DashboardLoadedEventHandler(this.dashboardViewer_DashboardLoaded);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.dashboardViewer.SetInitialDashboardState += new DevExpress.DashboardWin.SetInitialDashboardStateEventHandler(this.dashboardViewer_SetInitialDashboardState);
			' 
			' ViewerForm1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(986, 628)
			Me.Controls.Add(Me.dashboardViewer)
			Me.Name = "ViewerForm1"
			Me.Text = "Dashboard Viewer"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewerForm1_FormClosing);
			CType(Me.dashboardViewer, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents dashboardViewer As DevExpress.DashboardWin.DashboardViewer
	End Class
End Namespace

