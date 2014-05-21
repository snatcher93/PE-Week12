using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            ScoreDialog dialog = new ScoreDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Student student = dialog.student;
                listbox1.Items.Add(student.GetName() + "\t" + student.GetSubject() + "\t" + student.GetScore());
            }
        }
    }
}
