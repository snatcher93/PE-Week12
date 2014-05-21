using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Point location = dog.Location;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    location.X -= 2;
                    break;
                case Keys.Right:
                    location.X += 2;
                    break;
                case Keys.Up:
                    location.Y -= 2;
                    break;
                case Keys.Down:
                    location.Y += 2;
                    break;
            }

            dog.Location = location;
        }
    }
}
