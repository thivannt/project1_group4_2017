using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace DoAn1
{
    class ViewGraphic
    {
        Font stringFont;
        private Size point = new Size(20, 20); // Kích thước của điểm (sizeCircle)
        private Bitmap bitmap;
        private  int radius = 10; // bán kính của điểm ( _RADIUS )
        private  int width = 20; // chiều rộng của điểm ( _WIDTH )
        private  int height = 20; // chiều cao của điểm ( _HEIGHT )

       
        public ViewGraphic(int width, int height)
        {
            bitmap = new Bitmap(width, height);
        }

        public int RADIUS
        {
            get { return radius; }
        }
        public int HEIGHT
        {
            get { return height; }
        }

        public int WIDTH
        {
            get { return width; }
        }

        // vẽ đừơng đi
        private void DrawLine(Graphics g, Pen pLine, Point ptStart, Point ptEnd)
        {
            g.DrawLine(pLine, ptStart, ptEnd);
        }
        // vẽ điểm
        private void DrawNode(Graphics g, Brush bFillNode, Pen pEllipse, Rectangle rect, Point p, string name)
        {

            // Vẽ hình tròn
            g.FillEllipse(bFillNode, rect);
            //vẽ đường tròn
            g.DrawEllipse(pEllipse, rect);
            //font cho tên của điểm
            stringFont = new Font("Arial", 9);

            //Lấy giá trị chiều rộng và chiều cao của điểm
            SizeF stringSize = g.MeasureString(name, stringFont);

            // Vẽ tên ở chính giữa
            g.DrawString(name, stringFont, Brushes.Black,
                        p.X + (WIDTH - stringSize.Width) / 2,
                        p.Y + (HEIGHT - stringSize.Height) / 2);
        }

        //
        // tao 1 bitmap do thi
        public Bitmap CreateGraphics(List<List<int>> canhke, List<Point> lstPointVertex)
        {
            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            g.Clear(Color.White);
            Pen pLine = new Pen(Color.FromArgb(100, 149, 237), 3);
            Brush cbrush = new SolidBrush(Color.Wheat);
            Pen pCircle = new Pen(Color.Black, 2);

            // lam min bitmap

            Point ptStart, ptEnd;
            


            // Vẽ đường thẳng nối các đỉnh
            for (int index = 0; index < canhke.Count; ++index)
            {
                List<int> row = new List<int>(canhke[index]);
                // Điểm đầu của đường thẳng
                ptStart = new Point(lstPointVertex[index].X, lstPointVertex[index].Y);

                foreach (int col in row)
                {
                    // Điểm cuối của đường thẳng
                    ptEnd = new Point(lstPointVertex[col].X, lstPointVertex[col].Y);
                    // nối các điểm lại với nhau
                    DrawLine(g, pLine, ptStart, ptEnd);
                  
                }
            }

            // ve node
            for (int index = 0; index < canhke.Count; ++index)
            {
                // toa do ve duong tron 
                Point pt = new Point(lstPointVertex[index].X - RADIUS,
                                     lstPointVertex[index].Y - RADIUS);
                // tao rect cho node
                Rectangle rect = new Rectangle(pt, point);
                DrawNode(g, cbrush, pCircle, rect, pt, (index + 1).ToString());
            }
            g.Dispose();
            pLine.Dispose();
            cbrush.Dispose();
            pCircle.Dispose();
            return bitmap;
        }// #end create graphics

        // draw path
        public Bitmap DrawPath(List<int> ReportPath, List<Point> lstPointVertices)
        {
            Graphics g = Graphics.FromImage(bitmap);

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen pLine = new Pen(Color.Red, 3); // pen for line
            Pen pClear = new Pen(Color.White, 3); // pen clear
            pLine.DashStyle = DashStyle.Dash; // dash type for pen line
            Brush cbrush = new SolidBrush(Color.Yellow); // fill ecllipse

            Pen pCircle = new Pen(Color.Black); // pen for circle

            // hightlight duong di
            for (int index = 0; index < ReportPath.Count - 1; ++index)
            {
                this.DrawLine(g, pClear, lstPointVertices[ReportPath[index]], lstPointVertices[ReportPath[index + 1]]); // clear line
                this.DrawLine(g, pLine, lstPointVertices[ReportPath[index]], lstPointVertices[ReportPath[index + 1]]);
            }

            // hightlight node nam tren duong di
            for (int index = 0; index < ReportPath.Count; ++index)
            {
                Point ptCircle = new Point(lstPointVertices[ReportPath[index]].X - this.RADIUS,
                                    lstPointVertices[ReportPath[index]].Y - this.RADIUS);
                Rectangle rect = new Rectangle(ptCircle, point);

                this.DrawNode(g, cbrush, pCircle, rect, ptCircle, (ReportPath[index] + 1).ToString());

            }

            g.Dispose();
            pLine.Dispose();
            cbrush.Dispose();
            pClear.Dispose();
            pCircle.Dispose();

            return bitmap;
  
        }
        public Bitmap Reset(List<List<int>> adjacent, List<Point> lstPointVertices)
        {
            return this.CreateGraphics(adjacent, lstPointVertices);
        }
       
    } // #End class 
      //
}

