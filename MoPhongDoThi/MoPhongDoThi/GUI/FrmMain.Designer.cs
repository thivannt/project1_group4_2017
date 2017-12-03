namespace MoPhongDoThi
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barDijkstra = new DevExpress.XtraBars.BarButtonItem();
            this.barFordBellman = new DevExpress.XtraBars.BarButtonItem();
            this.barHamilton = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panelMain = new DevExpress.XtraEditors.PanelControl();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barDijkstra,
            this.barFordBellman,
            this.barHamilton});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(2);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.ShowCategoryInCaption = false;
            this.ribbonControl1.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.Size = new System.Drawing.Size(1201, 115);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barDijkstra
            // 
            this.barDijkstra.Caption = "Thuật toán Dijkstra";
            this.barDijkstra.Glyph = ((System.Drawing.Image)(resources.GetObject("barDijkstra.Glyph")));
            this.barDijkstra.Id = 1;
            this.barDijkstra.Name = "barDijkstra";
            this.barDijkstra.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barDijkstra.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDijkstra_ItemClick);
            // 
            // barFordBellman
            // 
            this.barFordBellman.Caption = "Thuật toán Ford-Bellman";
            this.barFordBellman.Glyph = ((System.Drawing.Image)(resources.GetObject("barFordBellman.Glyph")));
            this.barFordBellman.Id = 4;
            this.barFordBellman.Name = "barFordBellman";
            this.barFordBellman.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barFordBellman.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barFordBellman_ItemClick);
            // 
            // barHamilton
            // 
            this.barHamilton.Caption = "Thuật toán Hamilton";
            this.barHamilton.Glyph = ((System.Drawing.Image)(resources.GetObject("barHamilton.Glyph")));
            this.barHamilton.Id = 5;
            this.barHamilton.Name = "barHamilton";
            this.barHamilton.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barHamilton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barHamilton_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Chức năng";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barDijkstra);
            this.ribbonPageGroup1.ItemLinks.Add(this.barFordBellman);
            this.ribbonPageGroup1.ItemLinks.Add(this.barHamilton);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // panelMain
            // 
            this.panelMain.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Appearance.Options.UseBackColor = true;
            this.panelMain.ContentImage = global::MoPhongDoThi.Properties.Resources.logo_news;
            this.panelMain.ContentImageAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 115);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1201, 580);
            this.panelMain.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(748, 450);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(407, 33);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bành Công Minh  - 15110077";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(748, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(405, 33);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lê Quang Sơn      - 15110118";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(748, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nguyễn Trần Thi Văn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tahoma", 23F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(615, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 37);
            this.label4.TabIndex = 1;
            this.label4.Text = "SVTH:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 23F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(615, 356);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "GVHD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 29F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(295, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(883, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÔ PHỎNG THUẬT TOÁN LÍ THUYẾT ĐỒ THỊ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1201, 695);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mô Phỏng Thuật Toán";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem barDijkstra;
        private DevExpress.XtraBars.BarButtonItem barFordBellman;
        private DevExpress.XtraBars.BarButtonItem barHamilton;     
        private DevExpress.XtraEditors.PanelControl panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}

