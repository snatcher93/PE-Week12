using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DogRace
{
    class Dog
    {
        private const int STARTING_POSITION = 12;

        private int Track;
        private PictureBox MyPictureBox;
        private Random random;

        public Dog(int Track, PictureBox MyPictureBox)
        {
            this.Track = Track;
            this.MyPictureBox = MyPictureBox;
            this.random = new Random(Track);
            TakeStartingPosition();
        }

        public string GetTrackName()
        {
            return Track + "번";
        }

        public void TakeStartingPosition()
        {
            Point location = MyPictureBox.Location;
            location.X = STARTING_POSITION;
            MyPictureBox.Location = location;
        }

        public bool Run(int TrackLength)
        {
            Point location = MyPictureBox.Location;

            location.X += random.Next(1, 30);
            MyPictureBox.Location = location;

            Size size = MyPictureBox.Size;

            if (location.X + size.Width >= TrackLength)
            {
                return true;
            }

            return false;
        }
    }
}
