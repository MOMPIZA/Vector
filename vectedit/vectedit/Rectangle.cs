using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace vectedit
{
    class Rect : Figure
    {
        public Rect(int x1, int y1, int width1, int height1, Graphics g1, Pen p1) : base (x1,y1,width1,height1,g1,p1)
        {

        }

        public override void Draw()
        {
            g.DrawRectangle(pen, x, y, width, height);
            //сделать фон пикчурбокса прозрачным, а саму штуку - нет
        }


    }
}
