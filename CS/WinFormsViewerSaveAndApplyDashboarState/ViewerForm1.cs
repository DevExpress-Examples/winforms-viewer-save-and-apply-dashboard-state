using DevExpress.DashboardCommon;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsViewerSaveAndApplyDashboardState
{
    public partial class ViewerForm1: XtraForm
    {
        public static readonly string PropertyName = "DashboardState";
        const string path = @"..\..\Dashboards\dashboardWithSavedState.xml";
        public ViewerForm1() {
            InitializeComponent();
            dashboardViewer.SetInitialDashboardState += dashboardViewer_SetInitialDashboardState;
            dashboardViewer.DashboardSource = path;
        }

        DashboardState GetDataFromString(string customPropertyValue) {
            DashboardState dState = new DashboardState();
            if(!string.IsNullOrEmpty(customPropertyValue)) {
                var xmlStateEl = XDocument.Parse(customPropertyValue);
                dState.LoadFromXml(xmlStateEl);
            }
            return dState;
        }
        private void dashboardViewer_SetInitialDashboardState(object sender,
            DevExpress.DashboardWin.SetInitialDashboardStateEventArgs e) {
            var state = GetDataFromString(dashboardViewer.Dashboard.CustomProperties.GetValue(PropertyName));
            e.InitialState = state;
        }

        private void ViewerForm1_FormClosing(object sender,FormClosingEventArgs e) {
            var dState = dashboardViewer.GetDashboardState();
            var stateValue = dState.SaveToXml().ToString(SaveOptions.DisableFormatting);
            dashboardViewer.Dashboard.CustomProperties.SetValue("DashboardState", stateValue);
            dashboardViewer.Dashboard.SaveToXml(path);
        }
    }
}
