using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace vectedit
{
    class Figure
    {
        protected int x;
        protected int y;
        protected int width;
        protected int height;
        protected Graphics g;
        protected Pen pen;

        public Figure()
        {
            x = 0;
            y = 0;
            width = 0;
            height = 0;
        }

        public Figure(int x1, int y1, int width1, int height1, Graphics g1, Pen p1)
        {
            x = x1;
            y = y1;
            width = width1;
            height = height1;
            g = g1;
            pen = p1;
        }

        virtual public void Draw()
        {
            // решить что делать с ручкой
        }

        public void Move(int x1, int y1)
        {
            x = x1;
            y = y1;
        }

        public void ChangeSize(int width1, int height1)
        {
            width = width1;
            height = height1;
        }
    }
}
