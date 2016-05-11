using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form

    {
        Tablero t;
        public Form1()
        {
            InitializeComponent();
            t = new Tablero(10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
               
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            t.next();
            t.update();
            this.Invalidate();
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            t.Dibuja(this);
        }
    }
}
