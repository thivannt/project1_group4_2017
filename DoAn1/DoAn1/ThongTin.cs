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
    public partial class FrmThongTin : Form
    {
        public FrmThongTin()
        {
            InitializeComponent();
            lblTenDeTai.Text += " Mô phỏng thuật toán";
            lblVersion.Text = " Version 1.0.0.1.0";
            lblNguon.Text = "Copyright by LTDT";
            lblNhom.Text += " Lê Quang Sơn_15110118." +
                " --  Bành Công Minh_15110070.";
            textBoxNoiDung.Text = "Thuật toán: ";
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
