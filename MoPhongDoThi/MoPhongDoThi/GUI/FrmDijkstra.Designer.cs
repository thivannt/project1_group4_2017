namespace MoPhongDoThi.GUI
{
    partial class FrmDijkstra
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
            DevExpress.XtraGrid.Columns.GridColumn TrongSo;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDijkstra));
            this.panelDanhSach = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgvDsCanh = new DevExpress.XtraGrid.GridControl();
            this.dgvDsCanhMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDCanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STTCanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dinh1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Dinh2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LoaiCanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnThemCanh = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaCanh = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnThemDinh = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaDinh = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dgvDsDinh = new DevExpress.XtraGrid.GridControl();
            this.dgvDsDinhMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STTDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TenDinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.X = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Y = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelChinh = new DevExpress.XtraEditors.PanelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            this.contextMenuChucNang = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ThemDinhTaiViTri = new System.Windows.Forms.ToolStripMenuItem();
            this.ThemCanh = new System.Windows.Forms.ToolStripMenuItem();
            this.XoaTatCaCacDinh = new System.Windows.Forms.ToolStripMenuItem();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnOpen = new DevExpress.XtraEditors.SimpleButton();
            this.btnDieuKhienChay = new DevExpress.XtraEditors.SimpleButton();
            this.btnLyThuyetVaGiaMa = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            TrongSo = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelDanhSach)).BeginInit();
            this.panelDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsCanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsCanhMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDinhMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelChinh)).BeginInit();
            this.panelChinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.contextMenuChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrongSo
            // 
            TrongSo.Caption = "Trọng số";
            TrongSo.FieldName = "TrongSo";
            TrongSo.Name = "TrongSo";
            TrongSo.Visible = true;
            TrongSo.VisibleIndex = 3;
            TrongSo.Width = 89;
            // 
            // panelDanhSach
            // 
            this.panelDanhSach.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.panelDanhSach.Controls.Add(this.groupControl2);
            this.panelDanhSach.Controls.Add(this.panelControl2);
            this.panelDanhSach.Controls.Add(this.panelControl1);
            this.panelDanhSach.Controls.Add(this.groupControl1);
            this.panelDanhSach.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDanhSach.Location = new System.Drawing.Point(0, 0);
            this.panelDanhSach.Name = "panelDanhSach";
            this.panelDanhSach.Size = new System.Drawing.Size(360, 586);
            this.panelDanhSach.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgvDsCanh);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(2, 281);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(356, 261);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Danh sách cạnh";
            // 
            // dgvDsCanh
            // 
            this.dgvDsCanh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDsCanh.Location = new System.Drawing.Point(2, 21);
            this.dgvDsCanh.MainView = this.dgvDsCanhMain;
            this.dgvDsCanh.Name = "dgvDsCanh";
            this.dgvDsCanh.Size = new System.Drawing.Size(352, 238);
            this.dgvDsCanh.TabIndex = 0;
            this.dgvDsCanh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDsCanhMain});
            // 
            // dgvDsCanhMain
            // 
            this.dgvDsCanhMain.ColumnPanelRowHeight = 25;
            this.dgvDsCanhMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDCanh,
            this.STTCanh,
            this.Dinh1,
            this.Dinh2,
            TrongSo,
            this.LoaiCanh});
            this.dgvDsCanhMain.GridControl = this.dgvDsCanh;
            this.dgvDsCanhMain.Name = "dgvDsCanhMain";
            this.dgvDsCanhMain.OptionsBehavior.Editable = false;
            this.dgvDsCanhMain.OptionsBehavior.ReadOnly = true;
            this.dgvDsCanhMain.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvDsCanhMain.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.dgvDsCanhMain.OptionsView.ShowGroupPanel = false;
            this.dgvDsCanhMain.PaintStyleName = "UltraFlat";
            this.dgvDsCanhMain.RowHeight = 25;
            // 
            // IDCanh
            // 
            this.IDCanh.Caption = "ID";
            this.IDCanh.FieldName = "ID";
            this.IDCanh.Name = "IDCanh";
            this.IDCanh.Width = 91;
            // 
            // STTCanh
            // 
            this.STTCanh.Caption = "STT";
            this.STTCanh.FieldName = "STT";
            this.STTCanh.Name = "STTCanh";
            this.STTCanh.Visible = true;
            this.STTCanh.VisibleIndex = 0;
            this.STTCanh.Width = 34;
            // 
            // Dinh1
            // 
            this.Dinh1.Caption = "Đỉnh 1";
            this.Dinh1.FieldName = "Dinh1";
            this.Dinh1.Name = "Dinh1";
            this.Dinh1.Visible = true;
            this.Dinh1.VisibleIndex = 1;
            this.Dinh1.Width = 52;
            // 
            // Dinh2
            // 
            this.Dinh2.Caption = "Đỉnh 2";
            this.Dinh2.FieldName = "Dinh2";
            this.Dinh2.Name = "Dinh2";
            this.Dinh2.Visible = true;
            this.Dinh2.VisibleIndex = 2;
            this.Dinh2.Width = 69;
            // 
            // LoaiCanh
            // 
            this.LoaiCanh.Caption = "Loại cạnh";
            this.LoaiCanh.FieldName = "LoaiCanh";
            this.LoaiCanh.Name = "LoaiCanh";
            this.LoaiCanh.Visible = true;
            this.LoaiCanh.VisibleIndex = 4;
            this.LoaiCanh.Width = 93;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.btnThemCanh);
            this.panelControl2.Controls.Add(this.btnXoaCanh);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(2, 542);
            this.panelControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(356, 42);
            this.panelControl2.TabIndex = 2;
            // 
            // btnThemCanh
            // 
            this.btnThemCanh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThemCanh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThemCanh.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCanh.Image")));
            this.btnThemCanh.Location = new System.Drawing.Point(3, 3);
            this.btnThemCanh.Name = "btnThemCanh";
            this.btnThemCanh.Size = new System.Drawing.Size(175, 36);
            this.btnThemCanh.TabIndex = 1;
            this.btnThemCanh.Text = "Thêm cạnh";
            this.btnThemCanh.Click += new System.EventHandler(this.btnThemCanh_Click);
            // 
            // btnXoaCanh
            // 
            this.btnXoaCanh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoaCanh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXoaCanh.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCanh.Image")));
            this.btnXoaCanh.Location = new System.Drawing.Point(178, 3);
            this.btnXoaCanh.Name = "btnXoaCanh";
            this.btnXoaCanh.Size = new System.Drawing.Size(175, 36);
            this.btnXoaCanh.TabIndex = 0;
            this.btnXoaCanh.Text = "Xóa cạnh";
            this.btnXoaCanh.Click += new System.EventHandler(this.btnXoaCanh_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btnThemDinh);
            this.panelControl1.Controls.Add(this.btnXoaDinh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 239);
            this.panelControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(356, 42);
            this.panelControl1.TabIndex = 1;
            // 
            // btnThemDinh
            // 
            this.btnThemDinh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThemDinh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnThemDinh.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDinh.Image")));
            this.btnThemDinh.Location = new System.Drawing.Point(3, 3);
            this.btnThemDinh.Name = "btnThemDinh";
            this.btnThemDinh.Size = new System.Drawing.Size(175, 36);
            this.btnThemDinh.TabIndex = 1;
            this.btnThemDinh.Text = "Thêm đỉnh";
            this.btnThemDinh.Click += new System.EventHandler(this.btnThemDinh_Click);
            // 
            // btnXoaDinh
            // 
            this.btnXoaDinh.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnXoaDinh.Appearance.Options.UseForeColor = true;
            this.btnXoaDinh.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoaDinh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnXoaDinh.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaDinh.Image")));
            this.btnXoaDinh.Location = new System.Drawing.Point(178, 3);
            this.btnXoaDinh.Name = "btnXoaDinh";
            this.btnXoaDinh.Size = new System.Drawing.Size(175, 36);
            this.btnXoaDinh.TabIndex = 0;
            this.btnXoaDinh.Text = "Xóa đỉnh";
            this.btnXoaDinh.Click += new System.EventHandler(this.btnXoaDinh_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dgvDsDinh);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(356, 237);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Danh sách đỉnh";
            // 
            // dgvDsDinh
            // 
            this.dgvDsDinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDsDinh.Location = new System.Drawing.Point(2, 21);
            this.dgvDsDinh.MainView = this.dgvDsDinhMain;
            this.dgvDsDinh.Name = "dgvDsDinh";
            this.dgvDsDinh.Size = new System.Drawing.Size(352, 214);
            this.dgvDsDinh.TabIndex = 0;
            this.dgvDsDinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDsDinhMain});
            // 
            // dgvDsDinhMain
            // 
            this.dgvDsDinhMain.ColumnPanelRowHeight = 25;
            this.dgvDsDinhMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDDinh,
            this.STTDinh,
            this.TenDinh,
            this.X,
            this.Y});
            this.dgvDsDinhMain.GridControl = this.dgvDsDinh;
            this.dgvDsDinhMain.Name = "dgvDsDinhMain";
            this.dgvDsDinhMain.OptionsBehavior.Editable = false;
            this.dgvDsDinhMain.OptionsBehavior.ReadOnly = true;
            this.dgvDsDinhMain.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.dgvDsDinhMain.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.dgvDsDinhMain.OptionsView.ShowGroupPanel = false;
            this.dgvDsDinhMain.PaintStyleName = "UltraFlat";
            this.dgvDsDinhMain.RowHeight = 25;
            // 
            // IDDinh
            // 
            this.IDDinh.Caption = "ID đỉnh";
            this.IDDinh.FieldName = "ID";
            this.IDDinh.Name = "IDDinh";
            // 
            // STTDinh
            // 
            this.STTDinh.Caption = "STT";
            this.STTDinh.FieldName = "STT";
            this.STTDinh.Name = "STTDinh";
            this.STTDinh.Visible = true;
            this.STTDinh.VisibleIndex = 0;
            this.STTDinh.Width = 73;
            // 
            // TenDinh
            // 
            this.TenDinh.Caption = "Tên đỉnh";
            this.TenDinh.FieldName = "TenDinh";
            this.TenDinh.Name = "TenDinh";
            this.TenDinh.Visible = true;
            this.TenDinh.VisibleIndex = 1;
            this.TenDinh.Width = 235;
            // 
            // X
            // 
            this.X.Caption = "Hoành độ X";
            this.X.FieldName = "X";
            this.X.Name = "X";
            this.X.Visible = true;
            this.X.VisibleIndex = 2;
            this.X.Width = 184;
            // 
            // Y
            // 
            this.Y.Caption = "Tung độ Y";
            this.Y.FieldName = "Y";
            this.Y.Name = "Y";
            this.Y.Visible = true;
            this.Y.VisibleIndex = 3;
            this.Y.Width = 188;
            // 
            // panelChinh
            // 
            this.panelChinh.Controls.Add(this.groupControl3);
            this.panelChinh.Controls.Add(this.panelControl3);
            this.panelChinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChinh.Location = new System.Drawing.Point(360, 0);
            this.panelChinh.Name = "panelChinh";
            this.panelChinh.Size = new System.Drawing.Size(674, 586);
            this.panelChinh.TabIndex = 1;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.panelMain);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(2, 2);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(670, 540);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Đồ thị Dijkstra";
            // 
            // panelMain
            // 
            this.panelMain.ContextMenuStrip = this.contextMenuChucNang;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(2, 21);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(666, 517);
            this.panelMain.TabIndex = 0;
            // 
            // contextMenuChucNang
            // 
            this.contextMenuChucNang.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuChucNang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ThemDinhTaiViTri,
            this.ThemCanh,
            this.XoaTatCaCacDinh});
            this.contextMenuChucNang.Name = "contextMenuStrip1";
            this.contextMenuChucNang.Size = new System.Drawing.Size(197, 70);
            this.contextMenuChucNang.Text = "Thao tác";
            // 
            // ThemDinhTaiViTri
            // 
            this.ThemDinhTaiViTri.Name = "ThemDinhTaiViTri";
            this.ThemDinhTaiViTri.Size = new System.Drawing.Size(196, 22);
            this.ThemDinhTaiViTri.Text = "Thêm đỉnh tại vị trí này";
            this.ThemDinhTaiViTri.Click += new System.EventHandler(this.ThemDinhTaiViTri_Click);
            // 
            // ThemCanh
            // 
            this.ThemCanh.Name = "ThemCanh";
            this.ThemCanh.Size = new System.Drawing.Size(196, 22);
            this.ThemCanh.Text = "Thêm cạnh";
            this.ThemCanh.Click += new System.EventHandler(this.ThemCanh_Click);
            // 
            // XoaTatCaCacDinh
            // 
            this.XoaTatCaCacDinh.Name = "XoaTatCaCacDinh";
            this.XoaTatCaCacDinh.Size = new System.Drawing.Size(196, 22);
            this.XoaTatCaCacDinh.Text = "Xóa tất cả các đỉnh";
            this.XoaTatCaCacDinh.Click += new System.EventHandler(this.XoaTatCaCacDinh_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.White;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Controls.Add(this.btnLuu);
            this.panelControl3.Controls.Add(this.btnOpen);
            this.panelControl3.Controls.Add(this.btnDieuKhienChay);
            this.panelControl3.Controls.Add(this.btnLyThuyetVaGiaMa);
            this.panelControl3.Controls.Add(this.btnDong);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 542);
            this.panelControl3.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.panelControl3.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(670, 42);
            this.panelControl3.TabIndex = 2;
            // 
            // btnLuu
            // 
            this.btnLuu.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(-258, 3);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(185, 36);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu đồ thị";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpen.Image = ((System.Drawing.Image)(resources.GetObject("btnOpen.Image")));
            this.btnOpen.Location = new System.Drawing.Point(-73, 3);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(185, 36);
            this.btnOpen.TabIndex = 3;
            this.btnOpen.Text = "Load đồ thị";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDieuKhienChay
            // 
            this.btnDieuKhienChay.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDieuKhienChay.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDieuKhienChay.Image = ((System.Drawing.Image)(resources.GetObject("btnDieuKhienChay.Image")));
            this.btnDieuKhienChay.Location = new System.Drawing.Point(112, 3);
            this.btnDieuKhienChay.Name = "btnDieuKhienChay";
            this.btnDieuKhienChay.Size = new System.Drawing.Size(185, 36);
            this.btnDieuKhienChay.TabIndex = 2;
            this.btnDieuKhienChay.Text = "Điều khiển chạy";
            this.btnDieuKhienChay.Click += new System.EventHandler(this.btnDieuKhienChay_Click);
            // 
            // btnLyThuyetVaGiaMa
            // 
            this.btnLyThuyetVaGiaMa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnLyThuyetVaGiaMa.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLyThuyetVaGiaMa.Image = ((System.Drawing.Image)(resources.GetObject("btnLyThuyetVaGiaMa.Image")));
            this.btnLyThuyetVaGiaMa.Location = new System.Drawing.Point(297, 3);
            this.btnLyThuyetVaGiaMa.Name = "btnLyThuyetVaGiaMa";
            this.btnLyThuyetVaGiaMa.Size = new System.Drawing.Size(185, 36);
            this.btnLyThuyetVaGiaMa.TabIndex = 1;
            this.btnLyThuyetVaGiaMa.Text = "Lý thuyết và mã giả";
            this.btnLyThuyetVaGiaMa.Click += new System.EventHandler(this.btnLyThuyetVaGiaMa_Click);
            // 
            // btnDong
            // 
            this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDong.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(482, 3);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(185, 36);
            this.btnDong.TabIndex = 0;
            this.btnDong.Text = "Đóng chức năng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // FrmDijkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 586);
            this.Controls.Add(this.panelChinh);
            this.Controls.Add(this.panelDanhSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDijkstra";
            this.Text = "FrmDijkstra";
            this.Load += new System.EventHandler(this.FrmDijkstra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelDanhSach)).EndInit();
            this.panelDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsCanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsCanhMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsDinhMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelChinh)).EndInit();
            this.panelChinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.contextMenuChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelDanhSach;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl dgvDsDinh;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDsDinhMain;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoaDinh;
        private DevExpress.XtraEditors.SimpleButton btnThemDinh;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl dgvDsCanh;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDsCanhMain;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnThemCanh;
        private DevExpress.XtraEditors.SimpleButton btnXoaCanh;
        private DevExpress.XtraEditors.PanelControl panelChinh;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnLyThuyetVaGiaMa;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnDieuKhienChay;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.PanelControl panelMain;
        private DevExpress.XtraGrid.Columns.GridColumn IDDinh;
        private DevExpress.XtraGrid.Columns.GridColumn STTDinh;
        private DevExpress.XtraGrid.Columns.GridColumn TenDinh;
        private DevExpress.XtraGrid.Columns.GridColumn X;
        private DevExpress.XtraGrid.Columns.GridColumn Y;
        private System.Windows.Forms.ContextMenuStrip contextMenuChucNang;
        private System.Windows.Forms.ToolStripMenuItem ThemDinhTaiViTri;
        private System.Windows.Forms.ToolStripMenuItem XoaTatCaCacDinh;
        private DevExpress.XtraGrid.Columns.GridColumn IDCanh;
        private DevExpress.XtraGrid.Columns.GridColumn STTCanh;
        private DevExpress.XtraGrid.Columns.GridColumn Dinh1;
        private DevExpress.XtraGrid.Columns.GridColumn Dinh2;
        private DevExpress.XtraGrid.Columns.GridColumn LoaiCanh;
        private System.Windows.Forms.ToolStripMenuItem ThemCanh;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnOpen;
    }
}