using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1
{
    class Vecto
    {
        private int dinh;
        private int chieurong;
        private int chieucao;
        public Vecto(int vertices, int width, int height)
        {
            dinh = vertices;
            chieurong = width;
            chieucao = height;
        }

        public List<Point> getRandomPoint()
        {
            List<Point> lstPoint = new List<Point>();
            Random ran = new Random(100);
            int distance = (int)(chieurong / dinh);
            int x = 10, y = 0;
            for (int index = 1; index <= dinh; ++index)
            {
                x += distance;
                y = ran.Next(50, chieucao);
                lstPoint.Add(new Point(x, y));
            }
            return lstPoint;
        }
    }
}
