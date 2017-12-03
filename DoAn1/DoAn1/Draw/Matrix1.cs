using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DoAn1.Draw
{
    class Matrix1 : Control
    {
        const int OFFSET = 20;
        const int HANDLE_SIZE = 6;

        Point _p;
        Point _pRightBottom;

        int[,] _data;
        public DijkstraCell[,] DijkstraData;
        float _size;

        // position of handles
        Rectangle _rectHandle1, _rectHandle2, _rectHandle3, _rectHandle4;
        int _handleIndex = -1;

        bool _selected = false;
        bool _resizing = false;

        public Matrix1()
        {
            _rectHandle1 = new Rectangle(0, 0, HANDLE_SIZE, HANDLE_SIZE);
            this.MinimumSize = new Size(20, 20);
            this.Size = new Size(160, 160);
            this.DoubleBuffered = true;
        }
        public void Reset()
        {
            _data = null;
            DijkstraData = null;
        }
        public int[,] Data
        {
            get { return _data; }
            set
            {
                _data = value;
                _size = (this.Width - OFFSET) / Data.GetLength(0);
                Dijkstra1();
                Invalidate();
            }
        }
        public void Dijkstra1()
        {
            if (Data == null)
                return;
            int n = Data.GetLength(0);

            DijkstraData = new DijkstraCell[n, n];

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    DijkstraData[i, j] = new DijkstraCell(Data[i, j]);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (DijkstraData[j, i].Value > 0)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            if (DijkstraData[i, k].Value > 0)
                            {
                                if (DijkstraData[j, k].Value < 0 || DijkstraData[j, i].Value + DijkstraData[i, k].Value < DijkstraData[j, k].Value)
                                {
                                    DijkstraData[j, k].Value = DijkstraData[j, i].Value + DijkstraData[i, k].Value;

                                    DijkstraData[j, k].Previous = i;
                                }
                            }
                        }
                    }
                }
            }
        }
        protected override void OnMouseHover(EventArgs e)
        {
            _selected = true;

            Invalidate();
            base.OnMouseHover(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            _selected = false;
            Invalidate();
            base.OnMouseLeave(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _p = e.Location;

                Invalidate();

                _resizing = true;

                Rectangle cursor = new Rectangle(e.Location, new Size(0, 0));

                _pRightBottom = new Point(this.Right, this.Bottom);

                // Kiem tra cursor co nam tren handle nao khong
                if (_rectHandle1.IntersectsWith(cursor)) _handleIndex = 0;
                else if (_rectHandle2.IntersectsWith(cursor)) _handleIndex = 1;
                else if (_rectHandle3.IntersectsWith(cursor)) _handleIndex = 2;
                else if (_rectHandle4.IntersectsWith(cursor)) _handleIndex = 3;
                else
                    _resizing = false;
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                if (_resizing)
                {
                    // thay doi vi tri va kich thuoc dua vao handle duoc dung
                    if (_handleIndex == 0)
                    {
                        this.Cursor = Cursors.SizeNWSE;
                        this.Location = this.Parent.PointToClient(this.PointToScreen(e.Location));
                        this.Width = _pRightBottom.X - this.Left;
                        this.Height = _pRightBottom.Y - this.Top;
                    }
                    else if (_handleIndex == 1)
                    {
                        this.Cursor = Cursors.SizeNESW;
                        this.Width = e.X;

                        this.Top = this.Parent.PointToClient(this.PointToScreen(e.Location)).Y;
                        this.Height = _pRightBottom.Y - this.Top;
                    }
                    else if (_handleIndex == 2)
                    {
                        this.Cursor = Cursors.SizeNWSE;
                        this.Width = e.X;
                        this.Height = e.Y;
                    }
                    else if (_handleIndex == 3)
                    {
                        this.Cursor = Cursors.SizeNESW;
                        this.Left = this.Parent.PointToClient(this.PointToScreen(e.Location)).X;
                        this.Width = _pRightBottom.X - this.Left;

                        this.Height = e.Y;
                    }

                }
                else
                {
                    this.Cursor = Cursors.SizeAll;

                    Point p = this.Parent.PointToClient(this.PointToScreen(e.Location));
                    p.X -= _p.X;
                    p.Y -= _p.Y;
                    this.Location = p;
                }
                Invalidate();
            }

            base.OnMouseMove(e);
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            this.Cursor = Cursors.Arrow;
            base.OnMouseUp(e);
        }
        protected override void OnSizeChanged(EventArgs e)
        {


            base.OnSizeChanged(e);
        }
        protected override void OnResize(EventArgs e)
        {


            if (Data != null)
                _size = (this.Width - OFFSET) / Data.GetLength(0);
            this.Height = this.Width;

            _rectHandle2 = new Rectangle(this.Width - HANDLE_SIZE - 1, 0, HANDLE_SIZE, HANDLE_SIZE);
            _rectHandle3 = new Rectangle(this.Width - HANDLE_SIZE - 1, this.Height - HANDLE_SIZE - 1, HANDLE_SIZE, HANDLE_SIZE);
            _rectHandle4 = new Rectangle(0, this.Height - HANDLE_SIZE - 1, HANDLE_SIZE, HANDLE_SIZE);
            Refresh();

            base.OnResize(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (Data == null)
                return;

            DrawMatrix(Data, e.Graphics);
            if (_selected)
            {
                // draw handles
                e.Graphics.FillRectangle(Brushes.White, _rectHandle1);
                e.Graphics.FillRectangle(Brushes.White, _rectHandle2);
                e.Graphics.FillRectangle(Brushes.White, _rectHandle3);
                e.Graphics.FillRectangle(Brushes.White, _rectHandle4);

                e.Graphics.DrawRectangle(Pens.Gray, _rectHandle1);
                e.Graphics.DrawRectangle(Pens.Gray, _rectHandle2);
                e.Graphics.DrawRectangle(Pens.Gray, _rectHandle3);
                e.Graphics.DrawRectangle(Pens.Gray, _rectHandle4);
            }
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, this.Width - 1, this.Height - 1);
            base.OnPaint(e);
        }
        void DrawMatrix(int[,] array, Graphics g)
        {
            int n = array.GetLength(0);
            for (int i = 0; i < n; i++)
            {
                float x = i * _size + OFFSET;
                string s = ((char)(i + '1')).ToString();
                g.DrawString(s, this.Font, Brushes.Blue, new PointF(0, x));
                g.DrawString(s, this.Font, Brushes.Blue, new PointF(x, 0));

                g.DrawLine(Pens.Gray, x, 0, x, this.Height);
                g.DrawLine(Pens.Gray, 0, x, this.Width, x);

                for (int j = 0; j < n; j++)
                {
                    string v;
                    if (array[i, j] < 0)
                    {
                        v = "-";
                        if (DijkstraData != null)
                        {
                            if (DijkstraData[i, j].Value > 0)
                            {
                                v = DijkstraData[i, j].Value.ToString();
                                g.FillRectangle(Brushes.LightGray, new RectangleF(x + 1, j * _size + OFFSET + 1, _size - 1, _size - 1));
                                g.DrawString(v, this.Font, Brushes.Red, new PointF(x, j * _size + OFFSET));
                                continue;
                            }
                        }
                    }
                    else
                        v = array[i, j].ToString();


                    g.DrawString(v, this.Font, Brushes.DarkMagenta, new PointF(x, j * _size + OFFSET));
                }
            }
        }

    }
    struct DijkstraCell
    {
        public int Previous;
        public int Value;

        public DijkstraCell(int value)
            : this(-1, value)
        { }
        public DijkstraCell(int previous, int value)
        {
            this.Previous = previous;
            this.Value = value;
        }
    }
}
