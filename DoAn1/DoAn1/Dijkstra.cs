﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1
{
    class Dijkstra
    {
        private Queue<int> VertexQueue = new Queue<int>(); // hang doi chua cac dinh
        private List<List<int>> _adjacent; // danh sach canh ke
        private List<int> _reportPath = new List<int>(); // danh sach dinh duong di
        

        public Dijkstra(List<List<int>> adjacent)
        {
            _adjacent = adjacent;
        }
        public List<int> findPathbyBfs(int tips, int start, int end)
        {
            if (_adjacent[start] == null || _adjacent[end] == null)
                return null;

            bool[] visited = new bool[tips]; // danh dau cac dinh da tham
            int[] previous = new int[tips + 1]; // luu dinh truoc


            // khoi tao mang visited va previous
            for (int index = 0; index < tips; ++index)
            {
                visited[index] = false;
                previous[index] = -1;
            }
            VertexQueue.Enqueue(start);
            visited[start] = true;
            while (VertexQueue.Count != 0)
            {
                int v = VertexQueue.Dequeue();

                List<int> row = new List<int>(_adjacent[v]);
                if (row != null)
                {
                    foreach (int col in row)
                    {
                        if (!visited[col])
                        {
                            VertexQueue.Enqueue(col);
                            previous[col] = v;
                            visited[col] = true;
                            // neu diem ket thu duoc tham thi ket thuc thuat toan.                         
                        }
                    }
                }
                // diem cuoi duoc tham thi ket thuc thuat toan
                if (visited[end]) break;
            }
            // neu diem ket thuc khong duoc tham thi tra ve null
            if (!visited[end]) return null;

            // truy vet duong di
            int current = end;
            _reportPath.Add(end);
            while (previous[current] != -1)
            {
                _reportPath.Add(previous[current]);
                current = previous[current];
            }
            _reportPath.Reverse();
            return _reportPath;
        }
    }
}
