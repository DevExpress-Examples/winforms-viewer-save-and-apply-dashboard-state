namespace WinFormsViewerSaveAndApplyDashboarState
{
    partial class ViewerForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dashboardViewer = new DevExpress.DashboardWin.DashboardViewer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // dashboardViewer
            // 
            this.dashboardViewer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.dashboardViewer.Appearance.Options.UseBackColor = true;
            this.dashboardViewer.DashboardSource = "";
            this.dashboardViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardViewer.Location = new System.Drawing.Point(0, 0);
            this.dashboardViewer.Name = "dashboardViewer";
            this.dashboardViewer.Size = new System.Drawing.Size(986, 628);
            this.dashboardViewer.TabIndex = 0;
            this.dashboardViewer.UseNeutralFilterMode = true;
            this.dashboardViewer.DashboardLoaded += new DevExpress.DashboardWin.DashboardLoadedEventHandler(this.dashboardViewer_DashboardLoaded);
            this.dashboardViewer.SetInitialDashboardState += new DevExpress.DashboardWin.SetInitialDashboardStateEventHandler(this.dashboardViewer_SetInitialDashboardState);
            // 
            // ViewerForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 628);
            this.Controls.Add(this.dashboardViewer);
            this.Name = "ViewerForm1";
            this.Text = "Dashboard Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewerForm1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dashboardViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.DashboardWin.DashboardViewer dashboardViewer;
    }
}

