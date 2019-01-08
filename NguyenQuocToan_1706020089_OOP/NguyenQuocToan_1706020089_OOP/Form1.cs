using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenQuocToan_1706020089_OOP
{
    public partial class Form1 : Form
    {
        Dictionary<string, List<Diem>> data = new Dictionary<string, List<Diem>>();
        Graphics g;
        Pen pen = new Pen(Color.Blue, 1);
        bool canDraw = false;//kiểm tra điều kiện có thể vẽ hay không
        Diem begin = new Diem();
        Diem end = new Diem();
        Triangle Triangle = new Triangle();//tạo đối tượng hình tam giác
        Line line = new Line();//tao đối tượng đường thằng
     
        Rectangle rect = new Rectangle();
        bool pointer, isLine, istriangular;

        private void paper_MouseDown(object sender, MouseEventArgs e)
        {

            if (pointer == false)
            {
                canDraw = true;
                begin = new Diem(e.X, e.Y);
                rect.X = begin.x;
                rect.Y = begin.y;
            }
        }

        private void paper_MouseMove(object sender, MouseEventArgs e)
        {
            if (canDraw == true)
            {
                end = new Diem(e.X, e.Y);
                g.Clear(paper.BackColor);
                if (pointer)
                {
                    return;
                }
                else if (isLine == true)
                {
                    g.DrawLine(pen, begin.x, begin.y, e.X, e.Y);
                }
               
                Update();
            }
        }

        

        private void paper_MouseUp(object sender, MouseEventArgs e)
        {
            if (pointer == false)
            {
                end.x = e.X;
                end.y = e.Y;
                canDraw = false;
                if (isLine)
                {
                    line.begin = begin;
                    line.end = end;
                    line.AddPoint();
                }
                else if (istriangular)
                {
                    Triangle.begin = begin;
                    Triangle.end = end;
                    Triangle.AddPoint();
                }

            }
        }

        private void tsbDuongThang_Click(object sender, EventArgs e)
        {
            pointer = false;
            isLine = true;
            istriangular = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            pointer = true;
            istriangular = false;
            isLine = false;
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "json| *.json";
            save.ShowDialog();
            data.Add("line", line.SaveData());
            data.Add("TamGiac", Triangle.SaveData());
            StreamWriter writer = new StreamWriter(save.FileName);
            var json = JsonConvert.SerializeObject(data);
            writer.Write(json);
            writer.Close();
        }

        private void tsbTamGiac_Click(object sender, EventArgs e)
        {
            pointer = false;
            isLine = false;
            istriangular = true;
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            pointer = true;
            istriangular = false;
            isLine = false;
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "json| *.json";
            open.ShowDialog();
            StreamReader reader = new StreamReader(open.FileName);
            var json = reader.ReadToEnd();
            data = JsonConvert.DeserializeObject<Dictionary<string, List<Diem>>>(json);
            line.LoadData(data, "line");
            Triangle.LoadData(data, "TamGiac");
            reader.Close();
            Update();
        }

        public Form1()
        {
            InitializeComponent();
            g = paper.CreateGraphics();
            pointer = true;
            istriangular = true;
            isLine = false;
        }
        void Update()
        {
            for (int i = 0; i < line.save.Count - 1; i += 2)
            {
                line.Draw(g, pen);
            }
            for (int i = 0; i < Triangle.save.Count - 1; i += 2)
            {
                Triangle.Draw(g, pen);
            }

        }
    }
}
