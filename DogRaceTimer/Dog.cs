using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DogRaceTimer
{
    class Dog
    {
        private const int STARTING_POSITION = 12;

        private int trackName;
        private PictureBox pictureBox;
        private Random random;

        public Dog(int track, PictureBox pictureBox)
        {
            this.trackName = track;
            this.pictureBox = pictureBox;
            this.random = new Random(track);
            MoveToStartingPosition();
        }

        public string GetTrackName()
        {
            return trackName + "번";
        }

        public void MoveToStartingPosition()
        {
            Point location = pictureBox.Location;
            location.X = STARTING_POSITION;
            pictureBox.Location = location;
        }

        public bool Run(int TrackLength)
        {
            Move();
            return GetCurrentPosition() >= TrackLength;
        }

        private void Move()
        {
            Point location = pictureBox.Location;
            location.X += random.Next(1, 30);
            pictureBox.Location = location;
        }

        private int GetCurrentPosition()
        {
            return pictureBox.Location.X + pictureBox.Size.Width;
        }
    }
}
