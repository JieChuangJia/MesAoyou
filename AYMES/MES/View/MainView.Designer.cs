namespace AYMES
{
    partial class MainView
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.cms_Log = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.清空ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.nbc_MainMenu = new DevExpress.XtraNavBar.NavBarControl();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.sb_Start = new DevExpress.XtraEditors.SimpleButton();
            this.styleController1 = new DevExpress.XtraEditors.StyleController(this.components);
            this.sb_Stop = new DevExpress.XtraEditors.SimpleButton();
            this.sb_Exit = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.lc_Version = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            this.cms_Log.SuspendLayout();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbc_MainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel2,
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl"});
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.dockPanel2.ID = new System.Guid("57d5cd12-05d7-4e04-b27f-7bf47909df5d");
            this.dockPanel2.Location = new System.Drawing.Point(0, 873);
            this.dockPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.Options.AllowDockAsTabbedDocument = false;
            this.dockPanel2.Options.AllowDockFill = false;
            this.dockPanel2.Options.AllowDockLeft = false;
            this.dockPanel2.Options.AllowDockRight = false;
            this.dockPanel2.Options.AllowDockTop = false;
            this.dockPanel2.Options.AllowFloating = false;
            this.dockPanel2.Options.FloatOnDblClick = false;
            this.dockPanel2.Options.ShowCloseButton = false;
            this.dockPanel2.OriginalSize = new System.Drawing.Size(200, 142);
            this.dockPanel2.Size = new System.Drawing.Size(1520, 142);
            this.dockPanel2.Text = "日志";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.richTextBoxLog);
            this.dockPanel2_Container.Location = new System.Drawing.Point(6, 38);
            this.dockPanel2_Container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(1508, 98);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.ContextMenuStrip = this.cms_Log;
            this.richTextBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxLog.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxLog.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.Size = new System.Drawing.Size(1508, 98);
            this.richTextBoxLog.TabIndex = 29;
            this.richTextBoxLog.Text = "";
            // 
            // cms_Log
            // 
            this.cms_Log.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cms_Log.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空ToolStripMenuItem});
            this.cms_Log.Name = "cms_Log";
            this.cms_Log.Size = new System.Drawing.Size(117, 32);
            // 
            // 清空ToolStripMenuItem
            // 
            this.清空ToolStripMenuItem.Name = "清空ToolStripMenuItem";
            this.清空ToolStripMenuItem.Size = new System.Drawing.Size(116, 28);
            this.清空ToolStripMenuItem.Text = "清空";
            this.清空ToolStripMenuItem.Click += new System.EventHandler(this.清空ToolStripMenuItem_Click);
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("b2f18c8b-33ad-4b05-a9c1-cc3be20b490a");
            this.dockPanel1.Location = new System.Drawing.Point(0, 114);
            this.dockPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.AllowDockAsTabbedDocument = false;
            this.dockPanel1.Options.AllowDockBottom = false;
            this.dockPanel1.Options.AllowDockFill = false;
            this.dockPanel1.Options.AllowDockRight = false;
            this.dockPanel1.Options.AllowDockTop = false;
            this.dockPanel1.Options.AllowFloating = false;
            this.dockPanel1.Options.FloatOnDblClick = false;
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(200, 200);
            this.dockPanel1.Size = new System.Drawing.Size(200, 759);
            this.dockPanel1.Text = "导航";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.nbc_MainMenu);
            this.dockPanel1_Container.Location = new System.Drawing.Point(6, 35);
            this.dockPanel1_Container.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(185, 718);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // nbc_MainMenu
            // 
            this.nbc_MainMenu.ActiveGroup = null;
            this.nbc_MainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nbc_MainMenu.Location = new System.Drawing.Point(0, 0);
            this.nbc_MainMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nbc_MainMenu.Name = "nbc_MainMenu";
            this.nbc_MainMenu.OptionsNavPane.ExpandedWidth = 185;
            this.nbc_MainMenu.Size = new System.Drawing.Size(185, 718);
            this.nbc_MainMenu.TabIndex = 0;
            this.nbc_MainMenu.Text = "navBarControl1";
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            this.standaloneBarDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.standaloneBarDockControl1.Location = new System.Drawing.Point(0, 0);
            this.standaloneBarDockControl1.Manager = null;
            this.standaloneBarDockControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            this.standaloneBarDockControl1.Size = new System.Drawing.Size(1520, 114);
            this.standaloneBarDockControl1.Text = "standaloneBarDockControl1";
            // 
            // bar2
            // 
            this.bar2.BarName = "Standard";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(38, 139);
            this.bar2.Text = "Standard";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(3, 3);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(283, 98);
            this.pictureEdit1.TabIndex = 7;
            // 
            // sb_Start
            // 
            this.sb_Start.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb_Start.Appearance.Options.UseFont = true;
            this.sb_Start.Image = ((System.Drawing.Image)(resources.GetObject("sb_Start.Image")));
            this.sb_Start.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.sb_Start.Location = new System.Drawing.Point(306, 16);
            this.sb_Start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sb_Start.Name = "sb_Start";
            this.sb_Start.Size = new System.Drawing.Size(156, 66);
            this.sb_Start.StyleController = this.styleController1;
            this.sb_Start.TabIndex = 12;
            this.sb_Start.Text = "启动";
            this.sb_Start.Click += new System.EventHandler(this.sb_Start_Click);
            // 
            // styleController1
            // 
            this.styleController1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.styleController1.LookAndFeel.SkinName = "Springtime";
            // 
            // sb_Stop
            // 
            this.sb_Stop.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb_Stop.Appearance.Options.UseFont = true;
            this.sb_Stop.Image = ((System.Drawing.Image)(resources.GetObject("sb_Stop.Image")));
            this.sb_Stop.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.sb_Stop.Location = new System.Drawing.Point(470, 16);
            this.sb_Stop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sb_Stop.Name = "sb_Stop";
            this.sb_Stop.Size = new System.Drawing.Size(156, 66);
            this.sb_Stop.StyleController = this.styleController1;
            this.sb_Stop.TabIndex = 13;
            this.sb_Stop.Text = "停止";
            this.sb_Stop.Click += new System.EventHandler(this.sb_Stop_Click);
            // 
            // sb_Exit
            // 
            this.sb_Exit.Appearance.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sb_Exit.Appearance.Options.UseFont = true;
            this.sb_Exit.Image = ((System.Drawing.Image)(resources.GetObject("sb_Exit.Image")));
            this.sb_Exit.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.sb_Exit.Location = new System.Drawing.Point(634, 16);
            this.sb_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sb_Exit.Name = "sb_Exit";
            this.sb_Exit.Size = new System.Drawing.Size(156, 66);
            this.sb_Exit.StyleController = this.styleController1;
            this.sb_Exit.TabIndex = 14;
            this.sb_Exit.Text = "退出";
            this.sb_Exit.Click += new System.EventHandler(this.sb_Exit_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // lc_Version
            // 
            this.lc_Version.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lc_Version.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.lc_Version.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lc_Version.Appearance.Options.UseBackColor = true;
            this.lc_Version.Appearance.Options.UseFont = true;
            this.lc_Version.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lc_Version.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lc_Version.Location = new System.Drawing.Point(1268, 29);
            this.lc_Version.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lc_Version.Name = "lc_Version";
            this.lc_Version.Size = new System.Drawing.Size(239, 72);
            this.lc_Version.TabIndex = 25;
            this.lc_Version.Text = "版本：V1.0.0\r\n日期：2018-01-01";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 1015);
            this.Controls.Add(this.lc_Version);
            this.Controls.Add(this.sb_Exit);
            this.Controls.Add(this.sb_Stop);
            this.Controls.Add(this.sb_Start);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.dockPanel2);
            this.Controls.Add(this.standaloneBarDockControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainView";
            this.Text = "遨优MES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainView_FormClosing);
            this.Load += new System.EventHandler(this.MainView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            this.cms_Log.ResumeLayout(false);
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbc_MainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraNavBar.NavBarControl nbc_MainMenu;
        private DevExpress.XtraEditors.SimpleButton sb_Exit;
        private DevExpress.XtraEditors.SimpleButton sb_Stop;
        private DevExpress.XtraEditors.SimpleButton sb_Start;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl lc_Version;
        private System.Windows.Forms.ContextMenuStrip cms_Log;
        private System.Windows.Forms.ToolStripMenuItem 清空ToolStripMenuItem;
        private DevExpress.XtraEditors.StyleController styleController1;
    }
}

