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
        List<List<int>> canhke;
        int dinh; // so dinh
        string FileName;       
        List<Point> lstPointVertices; // danh sach toa do cac dinh
        ViewGraphic g;           //Khai báo 1 ViewGraphic
        public const int PicturePadding = 50; // picture padding

        public FrmMain()
        {
            InitializeComponent();
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
                    btnRungTungBuoc.Enabled = true;

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
            groupDraw.Enabled = true;
            groupTool.Enabled = true;
            btnDiChuyen.Enabled = true;
        }

        private void radioDemo_CheckedChanged(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;

            groupDraw.Enabled = false; 
            btnDiChuyen.Enabled = true;
            groupTool.Enabled = true;
            btnDiChuyen.Enabled = true;
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
            groupTool.Enabled = false; 
            groupDraw.Enabled = false;
            btnOpen.Enabled = false;
            btnRunAll.Enabled = false;
            btnRungTungBuoc.Enabled = false;
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

            int start = this.cboFrom.SelectedIndex;
            int end = this.cboTo.SelectedIndex;

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
                MessageBox.Show(string.Format(text, start + 1, end + 1), "Find Path");
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

                // ve duong di len bitmap
                picGraphics.Image = g.DrawPath(res, lstPointVertices);
            }
        }
    }
}
