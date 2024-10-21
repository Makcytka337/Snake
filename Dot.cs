using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snake
{
    public class Dot
    {
        readonly Random r = new Random();

        public PointF Location { get; set; }

        public PointF OldLocation { get; set; }

        public Color Color { get; set; }
        
        public void NewLocation(Panel pole)
        {
            Location = new PointF(r.Next(4, pole.Width - 50), r.Next(4, pole.Height - 50));
            Color = Color.FromArgb(255, r.Next(255), r.Next(255), r.Next(255));
        }

        public Dot(PointF p, Color c)
        {
            Color = c;
            Location = p;
        }
    }
}
