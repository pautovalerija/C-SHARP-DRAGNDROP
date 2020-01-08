using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drag_n_Drop_Pautova
{
    public partial class Form1 : Form
    {
        Rectangle Rectangle = new Rectangle(10, 10, 200, 100);
        Rectangle Circle = new Rectangle(220, 10, 150, 150);
        Rectangle Square = new Rectangle(380, 10, 150, 150);
        bool c = false;
        bool r = false;
        bool s = false;
        int RectangleX = 0;
        int CircleX = 0;
        int SquareX = 0;
        int RectangleY = 0;
        int CircleY = 0;
        int SquareY = 0;
        int X, Y, dX, dY;
        int LastClicked = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
       

    }
}
