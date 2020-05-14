namespace VisioTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnFile = new DevExpress.XtraBars.BarSubItem();
            this.btnOpenFile = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveFile = new DevExpress.XtraBars.BarButtonItem();
            this.btnNewFile = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveAs = new DevExpress.XtraBars.BarButtonItem();
            this.btnShapeGroup = new DevExpress.XtraBars.BarSubItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.DrawingPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.galleryDropDown1 = new DevExpress.XtraBars.Ribbon.GalleryDropDown(this.components);
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.axDrawingControl1 = new AxMicrosoft.Office.Interop.VisOcx.AxDrawingControl();
            this.ShapeFile = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.DrawingPanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axDrawingControl1)).BeginInit();
            this.ShapeFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnFile,
            this.btnOpenFile,
            this.btnSaveFile,
            this.btnNewFile,
            this.barButtonItem4,
            this.barButtonItem5,
            this.btnShapeGroup,
            this.btnSaveAs});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 10;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnShapeGroup)});
            this.bar1.Text = "Tools";
            // 
            // btnFile
            // 
            this.btnFile.Caption = "文件";
            this.btnFile.Id = 2;
            this.btnFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnOpenFile, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnNewFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveAs)});
            this.btnFile.Name = "btnFile";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Caption = "打开";
            this.btnOpenFile.Id = 3;
            this.btnOpenFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.ImageOptions.Image")));
            this.btnOpenFile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.ImageOptions.LargeImage")));
            this.btnOpenFile.Name = "btnOpenFile";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Caption = "保存";
            this.btnSaveFile.Id = 4;
            this.btnSaveFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveFile.ImageOptions.Image")));
            this.btnSaveFile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaveFile.ImageOptions.LargeImage")));
            this.btnSaveFile.Name = "btnSaveFile";
            // 
            // btnNewFile
            // 
            this.btnNewFile.Caption = "新建";
            this.btnNewFile.Id = 5;
            this.btnNewFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNewFile.ImageOptions.Image")));
            this.btnNewFile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNewFile.ImageOptions.LargeImage")));
            this.btnNewFile.Name = "btnNewFile";
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Caption = "另存为";
            this.btnSaveAs.Id = 9;
            this.btnSaveAs.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.ImageOptions.Image")));
            this.btnSaveAs.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaveAs.ImageOptions.LargeImage")));
            this.btnSaveAs.Name = "btnSaveAs";
            // 
            // btnShapeGroup
            // 
            this.btnShapeGroup.Caption = "形状";
            this.btnShapeGroup.Id = 8;
            this.btnShapeGroup.Name = "btnShapeGroup";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlTop.Size = new System.Drawing.Size(1257, 65);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 602);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1257, 26);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 65);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 537);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1257, 65);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 537);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.DrawingPanel,
            this.ShapeFile});
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
            // DrawingPanel
            // 
            this.DrawingPanel.Controls.Add(this.dockPanel1_Container);
            this.DrawingPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.DrawingPanel.ID = new System.Guid("63f2458e-2baa-4657-9736-10d2bf9f0be1");
            this.DrawingPanel.Location = new System.Drawing.Point(219, 65);
            this.DrawingPanel.Name = "DrawingPanel";
            this.DrawingPanel.OriginalSize = new System.Drawing.Size(1038, 200);
            this.DrawingPanel.Size = new System.Drawing.Size(1038, 537);
            this.DrawingPanel.Text = "DrawingPanel";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.axDrawingControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(9, 35);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(1023, 496);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.ActAsDropDown = true;
            this.barButtonItem1.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem1.Caption = "文件";
            this.barButtonItem1.DropDownControl = this.popupMenu1;
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // popupMenu1
            // 
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.ActAsDropDown = true;
            this.barButtonItem2.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.DropDownControl = this.galleryDropDown1;
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // galleryDropDown1
            // 
            this.galleryDropDown1.Manager = this.barManager1;
            this.galleryDropDown1.Name = "galleryDropDown1";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 7;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // axDrawingControl1
            // 
            this.axDrawingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axDrawingControl1.Enabled = true;
            this.axDrawingControl1.Location = new System.Drawing.Point(0, 0);
            this.axDrawingControl1.Name = "axDrawingControl1";
            this.axDrawingControl1.Size = new System.Drawing.Size(1023, 496);
            this.axDrawingControl1.TabIndex = 0;
            // 
            // ShapeFile
            // 
            this.ShapeFile.Controls.Add(this.dockPanel2_Container);
            this.ShapeFile.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.ShapeFile.ID = new System.Guid("00a875ce-f781-48e4-815a-0e0a057a487e");
            this.ShapeFile.Location = new System.Drawing.Point(0, 65);
            this.ShapeFile.Name = "ShapeFile";
            this.ShapeFile.OriginalSize = new System.Drawing.Size(219, 200);
            this.ShapeFile.Size = new System.Drawing.Size(219, 537);
            this.ShapeFile.Text = "形状";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Location = new System.Drawing.Point(6, 35);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(204, 496);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 628);
            this.Controls.Add(this.ShapeFile);
            this.Controls.Add(this.DrawingPanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.DrawingPanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.galleryDropDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axDrawingControl1)).EndInit();
            this.ShapeFile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem btnFile;
        private DevExpress.XtraBars.BarButtonItem btnOpenFile;
        private DevExpress.XtraBars.BarButtonItem btnSaveFile;
        private DevExpress.XtraBars.BarButtonItem btnNewFile;
        private DevExpress.XtraBars.BarButtonItem btnSaveAs;
        private DevExpress.XtraBars.BarSubItem btnShapeGroup;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        //private AxMicrosoft.Office.Interop.VisOcx.AxDrawingControl axDrawingControl1;
        private DevExpress.XtraBars.Docking.DockPanel DrawingPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.GalleryDropDown galleryDropDown1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private AxMicrosoft.Office.Interop.VisOcx.AxDrawingControl axDrawingControl1;
        private DevExpress.XtraBars.Docking.DockPanel ShapeFile;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
    }
}

