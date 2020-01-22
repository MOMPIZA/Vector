using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Graphics G; // Объект графики
        PointF[] Arr = new PointF[4]; // Исходный массив точек
        PictureBox[] pic1 = new PictureBox[100]; 
        int Fuctorial(int n) // Функция вычисления факториала
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
                res *= i;
            return res;
        }
        float polinom(int i, int n, float t)// Функция вычисления полинома Бернштейна
        {
            return (Fuctorial(n) / (Fuctorial(i) * Fuctorial(n - i))) * (float)Math.Pow(t, i) * (float)Math.Pow(1 - t, n - i);
        }
        void Draw()// Функция рисования кривой
        {
            //pictureBox2.Image = null;
           // G.Clear(Color.White);
            G.Clear(pictureBox2.BackColor);
            int j = 0;
            float step = 0.01f;// Возьмем шаг 0.01 для большей точности

            PointF[] result = new PointF[101];//Конечный массив точек кривой
            for (float t = 0; t < 1; t += step)
            {
                float ytmp = 0;
                float xtmp = 0;
                for (int i = 0; i < Arr.Length; i++)
                { // проходим по каждой точке
                    float b = polinom(i, Arr.Length - 1, t); // вычисляем наш полином Бернштейна
                    xtmp += Arr[i].X * b; // записываем и прибавляем результат
                    ytmp += Arr[i].Y * b;
                }
                result[j] = new PointF(xtmp, ytmp);
                j++;

            }
            G.DrawLines(new Pen(Color.Blue), result);// Рисуем полученную кривую Безье
        }


        private void button1_Click_1(object sender, EventArgs e)
        {


            PictureBox pic2 = new PictureBox();
            this.Controls.Add(pic2);
            pic2.Show();
            //pic2 = new PictureBox();
            pic2.Left = Cursor.Position.X;
            pic2.Top = Cursor.Position.Y;
            pic2.Height = 100;
            pic2.Width = 100;
            pic2.BackColor = Color.Red;
            G = pic2.CreateGraphics();
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Draw();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            PictureBox pic2 = new PictureBox();
            this.Controls.Add(pic2);
            pic2.Show();
            //pic2 = new PictureBox();
           // Point Control.PointToClient(Point point);
            pic2.Left = Cursor.Position.X;
            pic2.Top = Cursor.Position.Y;

            pic2.Height = 100;
            pic2.Width = 100;
            pic2.BackColor = Color.Red;
            G = pic2.CreateGraphics();
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Draw();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
          
            Arr[0] = new PointF(50, 0);
            int x1 = trackBar1.Value;
            int y1 = trackBar2.Value;
            int x2 = trackBar3.Value;
            int y2 = trackBar4.Value;
            Arr[1] = new PointF(x1, y1);
            Arr[2] = new PointF(x2, y2);
            Arr[3] = new PointF(0, 50);
            G = pictureBox2.CreateGraphics();
           // G = Graphics.FromHwnd(pictureBox2.Handle);
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Draw();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            Arr[0] = new PointF(50, 0);
            int x1 = trackBar1.Value;
            int y1 = trackBar2.Value;
            int x2 = trackBar3.Value;
            int y2 = trackBar4.Value;
            Arr[1] = new PointF(x1, y1);
            Arr[2] = new PointF(x2, y2);
            Arr[3] = new PointF(0, 50);
            G = pictureBox2.CreateGraphics();
            // G = Graphics.FromHwnd(pictureBox2.Handle);
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Draw();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            Arr[0] = new PointF(50, 0);
            int x1 = trackBar1.Value;
            int y1 = trackBar2.Value;
            int x2 = trackBar3.Value;
            int y2 = trackBar4.Value;
            Arr[1] = new PointF(x1, y1);
            Arr[2] = new PointF(x2, y2);
            Arr[3] = new PointF(0, 50);
            G = pictureBox2.CreateGraphics();
            // G = Graphics.FromHwnd(pictureBox2.Handle);
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Draw();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            Arr[0] = new PointF(50, 0);
            int x1 = trackBar1.Value;
            int y1 = trackBar2.Value;
            int x2 = trackBar3.Value;
            int y2 = trackBar4.Value;
            Arr[1] = new PointF(x1, y1);
            Arr[2] = new PointF(x2, y2);
            Arr[3] = new PointF(0, 50);
            G = pictureBox2.CreateGraphics();
            // G = Graphics.FromHwnd(pictureBox2.Handle);
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Draw();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pic2 = new PictureBox();
            this.Controls.Add(pic2);
            pic2.Show();
            //pic2 = new PictureBox();
            // Point Control.PointToClient(Point point);
            var location = e.Location;
            pic2.Left = location.X ;
            pic2.Top = location.Y ;
           

            pic2.Height = 100;
            pic2.Width = 100;
            pic2.BackColor = Color.Red;
            Arr[0] = new PointF(50, 0);
            int x1 = trackBar1.Value;
            int y1 = trackBar2.Value;
            int x2 = trackBar3.Value;
            int y2 = trackBar4.Value;
            Arr[1] = new PointF(x1, y1);
            Arr[2] = new PointF(x2, y2);
            Arr[3] = new PointF(0, 50);
            G = pic2.CreateGraphics();
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Draw();

        }
    }
}
