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
            dogs.Add(new Dog(1, dog1Ctrl));
            dogs.Add(new Dog(2, dog2Ctrl));
            dogs.Add(new Dog(3, dog3Ctrl));
            dogs.Add(new Dog(4, dog4Ctrl));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisableButtons();
            GetReady();
            StrtTimer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetReady();
        }

        private void GetReady()
        {
            foreach (Dog dog in dogs)
            {
                dog.MoveToStartingPosition();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Dog dog in dogs)
            {
                if (dog.Run(trackCtrl.Size.Width))
                {
                    StopTimer();
                    MessageBox.Show(dog.GetTrackName() + " 우승!!!");
                    EnasbleButtons();
                    return;
                }
            }
        }

        private void DisableButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
        }

        private void EnasbleButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void StrtTimer()
        {
            timer1.Start();
        }

        private void StopTimer()
        {
            timer1.Stop();
        }
    }
}
