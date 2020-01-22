using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vectedit
{
    public partial class Form1 : Form
    {
        private Graphics g;
        
        public Form1()
        {
            
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Pen p = new Pen(Color.Black, 10);
            g.DrawEllipse(p, 0, 0, panel1.Width, panel1.Height);
            g.Clear(Color.Transparent);
        }
    }
}
