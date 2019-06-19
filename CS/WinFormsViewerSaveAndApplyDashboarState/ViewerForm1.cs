using DevExpress.DashboardCommon;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WinFormsViewerSaveAndApplyDashboardState
{
    public partial class ViewerForm1: XtraForm
    {
        DashboardState dState = new DashboardState();
        const string path = @"..\..\Dashboards\dashboardWithSavedState.xml";
        public ViewerForm1() {
            InitializeComponent();
            dashboardViewer.DashboardLoaded += dashboardViewer_DashboardLoaded;
            dashboardViewer.SetInitialDashboardState += dashboardViewer_SetInitialDashboardState;
            dashboardViewer.DashboardSource = path;
        }

        private void dashboardViewer_DashboardLoaded(object sender,
            DevExpress.DashboardWin.DashboardLoadedEventArgs e) {
            XElement data = e.Dashboard.UserData;
                if(data != null) {
                    if(data.Element("DashboardState") != null) {
                        XDocument dStateDocument = XDocument.Parse(data.Element("DashboardState").Value);
                        dState.LoadFromXml(XDocument.Parse(data.Element("DashboardState").Value));
                    }
                }
            }

        private void dashboardViewer_SetInitialDashboardState(object sender,
            DevExpress.DashboardWin.SetInitialDashboardStateEventArgs e) {
            e.InitialState = dState;
        }

        private void ViewerForm1_FormClosing(object sender,FormClosingEventArgs e) {
            dState = dashboardViewer.GetDashboardState();
            XElement userData = new XElement("Root",
                new XElement("DateModified",DateTime.Now),
                new XElement("DashboardState",dState.SaveToXml().ToString(SaveOptions.DisableFormatting)));
            dashboardViewer.Dashboard.UserData = userData;
            dashboardViewer.Dashboard.SaveToXml(path);
        }
    }
}
