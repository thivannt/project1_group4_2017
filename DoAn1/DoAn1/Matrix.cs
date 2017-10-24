using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace DoAn1
{
    class Matrix
    {
        private int dinh; // dinh   ( _vertices)
        private List<List<int>> canhke; // danh canh ke  (_adjacent)

        public List<List<int>> Adjacent
        {
            get { return canhke; }
            set { canhke = value; }
        }

        public int Vertices
        {
            get { return dinh; }
            set { dinh = value; }
        }
        // them columnheader cho list view
        private ColumnHeader AddColunmListView(string text)
        {
            ColumnHeader headerCol = new ColumnHeader();
            headerCol.Text = text;
            headerCol.Width = 24;
            headerCol.TextAlign = HorizontalAlignment.Center;
            headerCol.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            return headerCol;
        }
        public List<List<int>> LoadFile(string fileName, ListView lv, ComboBox cboFrom, ComboBox cboTo)
        {
            StreamReader fin = new StreamReader(fileName);

            // danh sach can ke
            canhke = new List<List<int>>();
            this.Vertices = Convert.ToInt32(fin.ReadLine());
            string line = "";
            List<int> row;

            lv.Columns.Add(AddColunmListView(""));

            for (int X = 0; X < Vertices; ++X)
            {
                line = fin.ReadLine();
                string[] words = line.Split(' ');

                cboFrom.Items.Add((X + 1).ToString()); // them item vao comboBox From
                cboTo.Items.Add((X + 1).ToString()); // them item vao comboBox To

                lv.Columns.Add(AddColunmListView((X + 1).ToString()));

                // them dong vao list view
                ListViewItem lvi = new ListViewItem((X + 1).ToString());
                lvi.UseItemStyleForSubItems = false;

                row = new List<int>();
                for (int Y = 0; Y < this.Vertices; ++Y)
                {
                    // list view sub item
                    ListViewItem.ListViewSubItem col = lvi.SubItems.Add(words[Y]);
                    col.ForeColor = Color.Blue; // mau cua list view subitem
                    if (words[Y] != "0")
                        row.Add(Y);
                }
                canhke.Add(row);
                lv.Items.Add(lvi);
            }
            fin.Close();
            return canhke;
        }
    }
}
