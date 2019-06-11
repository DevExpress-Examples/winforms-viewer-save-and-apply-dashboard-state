# How to Set the Initial Dashboard State in the WinForms Viewer

This example shows how to manage the dashboard state to save and restore selected master filter values, current drill-down levels and other selections such as the selected Choropleth Map's layer.

![](/image.png)

The saved dashboard state contains the following settings:

- The ChoroplethMap's **LayerIndex** is set to **1**.
- The ChoroplethMap's **Master-Filter value** is set to **Wyoming**.
- The Grid's **Drill-Down value** is set to **Bikes**.

When the dashboard is closed, the [DashboardViewer.GetDashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.GetDashboardState) method obtains a dashboard state object. It is serialized to XML and added to the **XElement** object stored in the [Dashboard.UserData](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.Dashboard.UserData) property. Subsequently, the dashboard with the dashboard state data is saved to the dashboard xml file.

When the application starts, the **DashboardViewer** loads the dashboard and the [DashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardCommon.DashboardState) object is deserialized in the [DashboardViewer.DashboardLoaded](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardLoaded) event.

The dashboard state is restored using the [DashboardViewer.SetDashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.SetDashboardState(DevExpress.DashboardCommon.DashboardState)) method in the [DashboardViewer.SetInitialDashboardState](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.SetInitialDashboardState) event.

## See Also

- [Manage Dashboard State](https://docs.devexpress.com/Dashboard/400729/create-the-designer-and-viewer-applications/winforms-viewer/manage-dashboard-state)
- [How to Set the Initial Dashboard State in the WinForms Designer](https://github.com/DevExpress-Examples/winforms-designer-save-and-apply-dashboard-state)
