namespace DoAn1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupMatrix = new System.Windows.Forms.GroupBox();
            this.lvMatrix = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.thuậtToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dijsktraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupGraph = new System.Windows.Forms.GroupBox();
            this.graphUI1 = new DoAn1.GraphUI();
            this.picGraphics = new System.Windows.Forms.PictureBox();
            this.groupMoPhong = new System.Windows.Forms.GroupBox();
            this.listMoPhong = new System.Windows.Forms.ListView();
            this.groupTool = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboFrom = new System.Windows.Forms.ComboBox();
            this.cboTo = new System.Windows.Forms.ComboBox();
            this.btnRunAll = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.groupInput = new System.Windows.Forms.GroupBox();
            this.cKBoxCoHuong = new System.Windows.Forms.CheckBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.radioDemo = new System.Windows.Forms.RadioButton();
            this.radioDraw = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRunDraw = new System.Windows.Forms.Button();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupMatrix.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGraphics)).BeginInit();
            this.groupMoPhong.SuspendLayout();
            this.groupTool.SuspendLayout();
            this.groupInput.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMatrix
            // 
            this.groupMatrix.Controls.Add(this.lvMatrix);
            this.groupMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMatrix.Location = new System.Drawing.Point(13, 32);
            this.groupMatrix.Margin = new System.Windows.Forms.Padding(4);
            this.groupMatrix.Name = "groupMatrix";
            this.groupMatrix.Padding = new System.Windows.Forms.Padding(4);
            this.groupMatrix.Size = new System.Drawing.Size(375, 231);
            this.groupMatrix.TabIndex = 0;
            this.groupMatrix.TabStop = false;
            this.groupMatrix.Text = "Ma trận";
            // 
            // lvMatrix
            // 
            this.lvMatrix.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvMatrix.GridLines = true;
            this.lvMatrix.Location = new System.Drawing.Point(7, 19);
            this.lvMatrix.Name = "lvMatrix";
            this.lvMatrix.Size = new System.Drawing.Size(362, 205);
            this.lvMatrix.TabIndex = 2;
            this.lvMatrix.UseCompatibleStateImageBehavior = false;
            this.lvMatrix.View = System.Windows.Forms.View.Details;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tậpToolStripMenuItem,
            this.thuậtToánToolStripMenuItem,
            this.thongTinToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(964, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tậpToolStripMenuItem
            // 
            this.tậpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStrip,
            this.saveToolStrip,
            this.exitToolStrip});
            this.tậpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.tậpToolStripMenuItem.Name = "tậpToolStripMenuItem";
            this.tậpToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.tậpToolStripMenuItem.Text = "Tập Tin";
            // 
            // openToolStrip
            // 
            this.openToolStrip.Name = "openToolStrip";
            this.openToolStrip.Size = new System.Drawing.Size(143, 24);
            this.openToolStrip.Text = "Open File";
            this.openToolStrip.Click += new System.EventHandler(this.openToolStrip_Click);
            // 
            // saveToolStrip
            // 
            this.saveToolStrip.Name = "saveToolStrip";
            this.saveToolStrip.Size = new System.Drawing.Size(143, 24);
            this.saveToolStrip.Text = "Save File";
            this.saveToolStrip.Click += new System.EventHandler(this.saveToolStrip_Click);
            // 
            // exitToolStrip
            // 
            this.exitToolStrip.Name = "exitToolStrip";
            this.exitToolStrip.Size = new System.Drawing.Size(143, 24);
            this.exitToolStrip.Text = "Exit";
            this.exitToolStrip.Click += new System.EventHandler(this.exitToolStrip_Click);
            // 
            // thuậtToánToolStripMenuItem
            // 
            this.thuậtToánToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dijsktraToolStripMenuItem});
            this.thuậtToánToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.thuậtToánToolStripMenuItem.Name = "thuậtToánToolStripMenuItem";
            this.thuậtToánToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.thuậtToánToolStripMenuItem.Text = "Thuật Toán";
            // 
            // dijsktraToolStripMenuItem
            // 
            this.dijsktraToolStripMenuItem.Name = "dijsktraToolStripMenuItem";
            this.dijsktraToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.dijsktraToolStripMenuItem.Text = "Dijsktra";
            // 
            // thongTinToolStripMenuItem
            // 
            this.thongTinToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.thongTinToolStripMenuItem.Name = "thongTinToolStripMenuItem";
            this.thongTinToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.thongTinToolStripMenuItem.Text = "Thông Tin";
            this.thongTinToolStripMenuItem.Click += new System.EventHandler(this.thongTinToolStripMenuItem_Click);
            // 
            // groupGraph
            // 
            this.groupGraph.Controls.Add(this.graphUI1);
            this.groupGraph.Controls.Add(this.picGraphics);
            this.groupGraph.Location = new System.Drawing.Point(396, 32);
            this.groupGraph.Margin = new System.Windows.Forms.Padding(4);
            this.groupGraph.Name = "groupGraph";
            this.groupGraph.Padding = new System.Windows.Forms.Padding(4);
            this.groupGraph.Size = new System.Drawing.Size(553, 339);
            this.groupGraph.TabIndex = 2;
            this.groupGraph.TabStop = false;
            this.groupGraph.Text = "Đồ Thị";
            // 
            // graphUI1
            // 
            this.graphUI1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.graphUI1.IsUndirectedGraph = false;
            this.graphUI1.Location = new System.Drawing.Point(7, 19);
            this.graphUI1.Name = "graphUI1";
            this.graphUI1.Size = new System.Drawing.Size(539, 313);
            this.graphUI1.TabIndex = 2;
            this.graphUI1.Text = "graphUI1";
            this.graphUI1.ContentChanged += new System.EventHandler(this.graphUI1_ContentChanged);
            // 
            // picGraphics
            // 
            this.picGraphics.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picGraphics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picGraphics.Location = new System.Drawing.Point(7, 19);
            this.picGraphics.Name = "picGraphics";
            this.picGraphics.Size = new System.Drawing.Size(539, 313);
            this.picGraphics.TabIndex = 1;
            this.picGraphics.TabStop = false;
            // 
            // groupMoPhong
            // 
            this.groupMoPhong.Controls.Add(this.listMoPhong);
            this.groupMoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMoPhong.Location = new System.Drawing.Point(13, 447);
            this.groupMoPhong.Margin = new System.Windows.Forms.Padding(4);
            this.groupMoPhong.Name = "groupMoPhong";
            this.groupMoPhong.Padding = new System.Windows.Forms.Padding(4);
            this.groupMoPhong.Size = new System.Drawing.Size(936, 236);
            this.groupMoPhong.TabIndex = 3;
            this.groupMoPhong.TabStop = false;
            this.groupMoPhong.Text = "Mô Phỏng";
            // 
            // listMoPhong
            // 
            this.listMoPhong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.listMoPhong.GridLines = true;
            this.listMoPhong.Location = new System.Drawing.Point(7, 23);
            this.listMoPhong.Name = "listMoPhong";
            this.listMoPhong.Size = new System.Drawing.Size(922, 207);
            this.listMoPhong.TabIndex = 1;
            this.listMoPhong.UseCompatibleStateImageBehavior = false;
            this.listMoPhong.View = System.Windows.Forms.View.Details;
            // 
            // groupTool
            // 
            this.groupTool.Controls.Add(this.label4);
            this.groupTool.Controls.Add(this.label3);
            this.groupTool.Controls.Add(this.cboFrom);
            this.groupTool.Controls.Add(this.cboTo);
            this.groupTool.Location = new System.Drawing.Point(248, 270);
            this.groupTool.Name = "groupTool";
            this.groupTool.Size = new System.Drawing.Size(107, 115);
            this.groupTool.TabIndex = 2;
            this.groupTool.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Điểm cuối";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Điểm đầu";
            // 
            // cboFrom
            // 
            this.cboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFrom.FormattingEnabled = true;
            this.cboFrom.Location = new System.Drawing.Point(6, 30);
            this.cboFrom.Name = "cboFrom";
            this.cboFrom.Size = new System.Drawing.Size(91, 24);
            this.cboFrom.TabIndex = 7;
            // 
            // cboTo
            // 
            this.cboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTo.FormattingEnabled = true;
            this.cboTo.Location = new System.Drawing.Point(6, 85);
            this.cboTo.Name = "cboTo";
            this.cboTo.Size = new System.Drawing.Size(91, 24);
            this.cboTo.TabIndex = 9;
            // 
            // btnRunAll
            // 
            this.btnRunAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunAll.Location = new System.Drawing.Point(23, 362);
            this.btnRunAll.Name = "btnRunAll";
            this.btnRunAll.Size = new System.Drawing.Size(93, 23);
            this.btnRunAll.TabIndex = 11;
            this.btnRunAll.Text = "Tìm";
            this.btnRunAll.UseVisualStyleBackColor = true;
            this.btnRunAll.Click += new System.EventHandler(this.btnRunAll_Click);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(403, 378);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(539, 62);
            this.txtResult.TabIndex = 2;
            // 
            // groupInput
            // 
            this.groupInput.Controls.Add(this.cKBoxCoHuong);
            this.groupInput.Controls.Add(this.btnOpen);
            this.groupInput.Controls.Add(this.radioDemo);
            this.groupInput.Controls.Add(this.radioDraw);
            this.groupInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInput.Location = new System.Drawing.Point(13, 270);
            this.groupInput.Name = "groupInput";
            this.groupInput.Size = new System.Drawing.Size(216, 85);
            this.groupInput.TabIndex = 6;
            this.groupInput.TabStop = false;
            this.groupInput.Text = "Đầu Vào";
            // 
            // cKBoxCoHuong
            // 
            this.cKBoxCoHuong.Location = new System.Drawing.Point(106, 54);
            this.cKBoxCoHuong.Name = "cKBoxCoHuong";
            this.cKBoxCoHuong.Size = new System.Drawing.Size(89, 26);
            this.cKBoxCoHuong.TabIndex = 3;
            this.cKBoxCoHuong.Text = "Vô Hướng";
            this.cKBoxCoHuong.UseVisualStyleBackColor = true;
            this.cKBoxCoHuong.CheckedChanged += new System.EventHandler(this.cKBoxCoHuong_CheckedChanged);
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpen.Location = new System.Drawing.Point(106, 22);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(89, 26);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Mở File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // radioDemo
            // 
            this.radioDemo.Location = new System.Drawing.Point(37, 21);
            this.radioDemo.Name = "radioDemo";
            this.radioDemo.Size = new System.Drawing.Size(57, 27);
            this.radioDemo.TabIndex = 1;
            this.radioDemo.TabStop = true;
            this.radioDemo.Text = "Mẫu";
            this.radioDemo.UseVisualStyleBackColor = true;
            this.radioDemo.CheckedChanged += new System.EventHandler(this.radioDemo_CheckedChanged);
            // 
            // radioDraw
            // 
            this.radioDraw.Location = new System.Drawing.Point(40, 54);
            this.radioDraw.Name = "radioDraw";
            this.radioDraw.Size = new System.Drawing.Size(60, 22);
            this.radioDraw.TabIndex = 0;
            this.radioDraw.TabStop = true;
            this.radioDraw.Text = "Vẽ";
            this.radioDraw.UseVisualStyleBackColor = true;
            this.radioDraw.CheckedChanged += new System.EventHandler(this.radioDraw_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(136, 361);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 24);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRunDraw
            // 
            this.btnRunDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunDraw.Location = new System.Drawing.Point(23, 362);
            this.btnRunDraw.Name = "btnRunDraw";
            this.btnRunDraw.Size = new System.Drawing.Size(93, 23);
            this.btnRunDraw.TabIndex = 12;
            this.btnRunDraw.Text = "Tìm";
            this.btnRunDraw.UseVisualStyleBackColor = true;
            this.btnRunDraw.Click += new System.EventHandler(this.btnRunDraw_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(83, 49);
            this.toolStripButton1.Tag = "0";
            this.toolStripButton1.Text = "Di Chuyển";
            this.toolStripButton1.ToolTipText = "Move (1)";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(59, 49);
            this.toolStripButton2.Tag = "1";
            this.toolStripButton2.Text = "Thêm";
            this.toolStripButton2.ToolTipText = "Node (2)";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(79, 49);
            this.toolStripButton3.Tag = "2";
            this.toolStripButton3.Text = "Nối Điểm";
            this.toolStripButton3.ToolTipText = "Edge (3)";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(81, 49);
            this.toolStripButton4.Tag = "3";
            this.toolStripButton4.Text = "Xóa Điểm";
            this.toolStripButton4.ToolTipText = "Eraser (4)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(23, 388);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(359, 52);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "Vẽ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(964, 688);
            this.Controls.Add(this.btnRunDraw);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnRunAll);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupInput);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.groupTool);
            this.Controls.Add(this.groupMoPhong);
            this.Controls.Add(this.groupGraph);
            this.Controls.Add(this.groupMatrix);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupMatrix.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGraphics)).EndInit();
            this.groupMoPhong.ResumeLayout(false);
            this.groupTool.ResumeLayout(false);
            this.groupTool.PerformLayout();
            this.groupInput.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMatrix;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStrip;
        private System.Windows.Forms.ToolStripMenuItem saveToolStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStrip;
        private System.Windows.Forms.ToolStripMenuItem thuậtToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dijsktraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongTinToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupGraph;
        private System.Windows.Forms.PictureBox picGraphics;
        private System.Windows.Forms.GroupBox groupMoPhong;
        private System.Windows.Forms.ListView listMoPhong;
        private System.Windows.Forms.GroupBox groupTool;
        private System.Windows.Forms.Button btnRunAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboFrom;
        private System.Windows.Forms.ComboBox cboTo;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.GroupBox groupInput;
        private System.Windows.Forms.RadioButton radioDraw;
        private System.Windows.Forms.RadioButton radioDemo;
        private System.Windows.Forms.ListView lvMatrix;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnReset;
        private GraphUI graphUI1;
        private System.Windows.Forms.Button btnRunDraw;
        private System.Windows.Forms.CheckBox cKBoxCoHuong;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}

