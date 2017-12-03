using DoAn1.Draw;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoAn1
{
    public partial class FrmMain : Form
    {
        //private const string FILENAME = "data.bin";
        List<List<int>> canhke;
        int dinh; // so dinh
        string FileName;       
        List<Point> lstPointVertices; // danh sach toa do cac dinh
        ViewGraphic g;           //Khai báo 1 ViewGraphic
        public const int PicturePadding = 50; // picture padding

        public FrmMain()
        {
            InitializeComponent();
            this.Text = Application.ProductName + " " + Application.ProductVersion;

            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.Click += new EventHandler(toolStripButton_Click);
            }
            toolStripButton_Click(toolStripButton2, null);
        }

        private void exitToolStrip_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Thoát Khỏi Chương Trình?",
                                    "",
                                    MessageBoxButtons.OKCancel,
                                    MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void openToolStrip_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Document File(*.txt)|*.txt|All File(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {   
                    Matrix m = new Matrix();
                    //                 

                    FileName = ofd.FileName;
                    canhke = m.LoadFile(FileName, lvMatrix, cboFrom, cboTo);
                    
                    cboFrom.SelectedIndex = 0;
                    cboTo.SelectedIndex = 1;

                    dinh = m.Vertices;

                    // khoi tao graphics tool
                     g = new ViewGraphic(picGraphics.Width, picGraphics.Height);

                    // lay danh sach toa do cac dinh
                    lstPointVertices = new Vecto(dinh, picGraphics.Width - FrmMain.PicturePadding,
                                                picGraphics.Height - FrmMain.PicturePadding).getRandomPoint();


                    // tao bitmap do thi voi danh sach ke va danh sach toa cac dinh

                    picGraphics.Image = g.CreateGraphics(canhke, lstPointVertices);

                    btnRunAll.Enabled = true;


                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message, "Error");

                }
            }
            ofd.Dispose();
        }

        private void thongTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmThongTin = new FrmThongTin();
            frmThongTin.StartPosition = FormStartPosition.CenterScreen;
            frmThongTin.ShowDialog();
        }


        private void radioDraw_CheckedChanged(object sender, EventArgs e)
        {
            btnOpen.Enabled = false;
            btnRunDraw.Visible = true;
            btnRunAll.Visible = false;
            groupTool.Enabled = true;
            graphUI1.Visible = true;
            toolStrip1.Enabled = true;
            btnRunAll.Enabled = false;
            btnRunDraw.Enabled = true;
            cKBoxCoHuong.Enabled = true;
            btnReset.Enabled = false;

            lvMatrix.Clear();
         
            txtResult.Clear();
            listMoPhong.Clear();

        }

        private void radioDemo_CheckedChanged(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnRunAll.Enabled = true;
            btnRunDraw.Enabled = false;
            groupTool.Enabled = true;
            graphUI1.Visible = false;
            toolStrip1.Enabled = false;
            cKBoxCoHuong.Enabled = false;
           
            btnReset.Enabled = true;
            btnRunAll.Visible = true;
            btnRunDraw.Visible = false;

            cboFrom.DataSource = null;
            cboTo.DataSource = null;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openToolStrip_Click(sender, e); 
            
        }

        private void saveToolStrip_Click(object sender, EventArgs e)
        {

        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            //
            picGraphics.Visible = true;
            graphUI1.Visible = false;

            groupTool.Enabled = false;             
            btnOpen.Enabled = false;
            btnRunAll.Enabled = false;
            toolStrip1.Enabled = false;
            btnRunDraw.Visible = false;
            btnRunAll.Visible = true;
            cKBoxCoHuong.Enabled = false;
            btnReset.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lvMatrix.Clear();
            picGraphics.Image = null;
            txtResult.Clear();
            listMoPhong.Clear();

            cboFrom.Items.Clear();
            cboTo.Items.Clear();

        }

        private void btnRunAll_Click(object sender, EventArgs e)
        {
            Dijkstra dijkstra = new Dijkstra(canhke);

            int start = cboFrom.SelectedIndex;
            int end = cboTo.SelectedIndex;

            // reset picGraphics va txtResult
            picGraphics.Image = g.Reset(canhke, lstPointVertices);
            txtResult.Clear();

            if (start == end)
            {
                MessageBox.Show("Hai đỉnh trùng nhau.Vui lòng chọn lại.");
                return;
            }
            List<int> res = dijkstra.findPathbyBfs(dinh, start, end);

            if (res == null)
            {
                string text = "Không tìm được đường đi từ {0} đến {1}.";
                MessageBox.Show(string.Format(text, start + 1, end + 1), "Tìm đường đi");
                return;
            }
            else
            {

                int index;
                txtResult.Text = "Đường đi ngắn nhất tìm được là: ";

                // xuat ket qua ra text box
                for (index = 0; index < res.Count - 1; ++index)

                    txtResult.Text += (1 + res[index]).ToString() + " ---> ";
                txtResult.Text += (1 + res[index]).ToString();

                // ve mau duong di len bitmap
                picGraphics.Image = g.DrawPath(res, lstPointVertices);


            }
           
        }
      
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {             
                case Keys.D1:
                    toolStripButton_Click(toolStripButton1, null);
                    break;
                case Keys.D2:
                    toolStripButton_Click(toolStripButton2, null);
                    break;
                case Keys.D3:
                    toolStripButton_Click(toolStripButton3, null);
                    break;
                case Keys.D4:
                    toolStripButton_Click(toolStripButton4, null);
                    break;
                
                default:
                    break;
            }

            return base.ProcessDialogKey(keyData);
        }

        private void toolStripButton_Click(object sender, EventArgs e)
        {
            ToolStripButton btn = (ToolStripButton)sender;

            DrawingTools tool = (DrawingTools)(int.Parse(btn.Tag.ToString()));
            graphUI1.Tool = tool;

            foreach (ToolStripButton item in toolStrip1.Items)
            {
                item.Checked = false;
            }

            btn.Checked = true;
        }

        private void graphUI1_ContentChanged(object sender, EventArgs e)
        {
            int f = cboFrom.SelectedIndex;
            int t = cboTo.SelectedIndex;

            cboFrom.DataSource = graphUI1.NodeNames;
            cboTo.DataSource = graphUI1.NodeNames;

            if (cboFrom.Items.Count > f)
                cboFrom.SelectedIndex = f;
            if (cboTo.Items.Count > t)
                cboTo.SelectedIndex = t;
        }

        private void btnRunDraw_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cboFrom.Text) && !String.IsNullOrEmpty(cboTo.Text))
                graphUI1.FindShortestPath(cboFrom.Text[0] - '1', cboTo.Text[0] - '1');
        }

        private void cKBoxCoHuong_CheckedChanged(object sender, EventArgs e)
        {
            graphUI1.IsUndirectedGraph = cKBoxCoHuong.Checked;
        }






        //
    }
}
