﻿using MoPhongDoThi.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoPhongDoThi
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        #region sự kiện
        private void barDijkstra_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmDijkstra form = new FrmDijkstra();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.Show();
        }       

        private void barFordBellman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmFordBellman form = new FrmFordBellman();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void barHamilton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmHamilton form = new FrmHamilton();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(form);
            form.Show();
        }
        #endregion  
    }
}
