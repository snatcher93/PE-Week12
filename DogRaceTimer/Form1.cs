using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace DogRaceTimer
{
    public partial class Form1 : Form
    {
        private ArrayList dogs = new ArrayList();

        public Form1()
        {
            InitializeComponent();
            dogs.Add(new Dog(1, dog1));
            dogs.Add(new Dog(2, dog2));
            dogs.Add(new Dog(3, dog3));
            dogs.Add(new Dog(4, dog4));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prepare();
            button1.Enabled = false;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prepare();
        }

        private void prepare()
        {
            foreach (Dog dog in dogs)
            {
                dog.TakeStartingPosition();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Dog dog in dogs)
            {
                if (dog.Run(track.Size.Width))
                {
                    timer1.Stop();
                    button1.Enabled = true;
                    MessageBox.Show(dog.GetTrackName() + " 우승!!!");
                    break;
                }
            }
        }
    }
}
