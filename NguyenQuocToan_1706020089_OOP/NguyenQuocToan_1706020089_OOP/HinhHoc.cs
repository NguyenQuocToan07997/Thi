using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Drawing;

namespace NguyenQuocToan_1706020089_OOP
{
    class HinhHoc
    {
        public List<Diem> save = new List<Diem>();
        public virtual void Draw(Graphics g, Pen pen) { }

        public HinhHoc()
        {

        }
        /// <summary>
        /// dùng để load dữ liệu được lưu từ data chính và phần loại dữ liệu vào từng đối tượng khác nhau
        /// </summary>
        /// <param name="input"></param>
        /// <param name="input_Name"></param>

        public void LoadData(Dictionary<string, List<Diem>> input, string input_Name)
        {
            foreach (var item in input)
            {
                if (item.Key == input_Name)
                {
                    save = item.Value;
                }
            }
        }
        public List<Diem> SaveData()
        {
            List<Diem> temp = new List<Diem>();
            temp = save;
            return temp;
        }
    }
    class Line : HinhHoc
    {
        public Diem begin = new Diem();
        public Diem end = new Diem();
        public Line()
        {
            begin = new Diem(0, 0);
            end = new Diem(0, 0);
        }
        public Line(Diem A, Diem B)
        {
            begin = A;
            end = B;
        }

        public void Draw(Graphics g, Pen pen)
        {
            foreach (var item in save)
            {
                for (int i = 0; i < save.Count - 1; i += 2)
                {
                    g.DrawLine(pen, save[i].x, save[i].y, save[i + 1].x, save[i + 1].y);
                }
            }
        }

        public void AddPoint()
        {
            try
            {
                save.Add(begin);
                save.Add(end);
            }
            catch (Exception)
            {
            }
        }
    }

    class Triangle : HinhHoc
    {
        public Diem begin = new Diem();
        public Diem end = new Diem();
        public Diem fe = new Diem();
        public Triangle()
        {
            begin = new Diem(0, 0);
            end = new Diem(0, 0);
            fe = new Diem(0, 0);
        }
        public Triangle(Diem A, Diem B, Diem C)
        {
            begin = A;
            end = B;
            fe = C;
        }

        public override void Draw(Graphics g, Pen pen)
        {
            base.Draw(g, pen);
            Rectangle rect = new Rectangle();
            rect.Size = new Size(end.x - begin.x, end.y - end.y);
            rect.X = begin.x;
            rect.Y = begin.y;
            g.DrawLine(pen, rect.X, rect.Y + rect.Height, end.x, end.y);
            g.DrawLine(pen, rect.X, rect.Y, end.x, end.y);
            g.DrawLine(pen, rect.X, rect.Y, end.x - rect.Width, end.y);
        }
        public void AddPoint()
        {
            try
            {
                save.Add(begin);
                save.Add(end);
            }
            catch (Exception)
            {
            }
        }

    }
}

