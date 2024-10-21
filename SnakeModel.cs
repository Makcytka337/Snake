using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Snake
{
    public class ISnakeModel
    {     
        public ISnakeView snakeView;

        public Panel gameLoc;
        public bool mouseCtrl = false;

        public readonly Random random = new Random();

        public float speed = 5;
        public int rotation = 3;

        public Label debugl;

        public int startdot = 6;
        public bool game = false;
        public int scet;
        public int num;
        public float deg;
        public float volume = 0.2f;

        public double degrad;
        public double deltaX;
        public double deltaY;

        public Dot[] tail = new Dot[1];
        public Dot head = new Dot(new Point(50, 50), System.Drawing.Color.Blue);
        public Dot pie = new Dot(new Point(0, 0), System.Drawing.Color.Lime);

        public Point curs = new Point(500, 500);

        public System.Drawing.Color dotColor = System.Drawing.Color.FromArgb(255, 255, 0, 0);


        public ISnakeModel(Panel p, Label l, bool m)
        {
            gameLoc = p;
            debugl = l;
            mouseCtrl = m;
            //typeof(Panel).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(gameLoc, true, null);
        }

        public void SetNewGame(ISnakeController snakeController, ISnakeView snakeView)
        {
            gameLoc.KeyDown += snakeController.CheckKeyPress;
            gameLoc.Paint += snakeView.Snake_Paint;
            if (mouseCtrl)
                gameLoc.MouseMove += CursorPos;
            Restart();
            snakeView.Update();
        }        

        public void CursorPos(object sender, MouseEventArgs e)
        {
            curs = e.Location;
        }

        public void AddTail(int kolv)
        {
            num += kolv;
            Array.Resize(ref tail, num);
            for (int i = tail.Length - kolv; i < tail.Length; i++)
            {
                tail[i] = new Dot(tail[i - 1].OldLocation, dotColor);
                tail[i].OldLocation = tail[i].Location;
                dotColor = System.Drawing.Color.FromArgb(255, random.Next(255), random.Next(255), random.Next(255));
            }
            head.Color = pie.Color;
            pie.NewLocation(gameLoc);
        }

        public void Change()
        {
            head.OldLocation = new PointF(head.Location.X + 2, head.Location.Y + 2);

            for (int i = 0; i < tail.Length; i++)
            {
                tail[i].OldLocation = tail[i].Location;
            }

            head.Location = new PointF(head.Location.X + (float)deltaX, head.Location.Y + (float)deltaY);

            if ((head.Location.X > pie.Location.X - 20 && head.Location.X < pie.Location.X + 15) &&
                (head.Location.Y > pie.Location.Y - 20 && head.Location.Y < pie.Location.Y + 15))
            {
                UpdateState(5);
                scet++;
                AddTail(2);
                if (scet > 100)
                    if (snakeView.ShowWin() == DialogResult.Retry)
                    {
                        Restart();
                        game = false;
                        UpdateState(4);
                    }
                    else
                    {
                        Application.Exit();
                    }
            }

            tail[0].Location = head.OldLocation;

            for (int i = 1; i < tail.Length; i++)
            {
                tail[i].Location = tail[i - 1].OldLocation;
            }

            UpdateState(-1);
        }

        public bool IsLosed()
        {
            for (int i = 4; i < tail.Length; i++)
                if ((head.Location.X > tail[i].Location.X - 17 && head.Location.X < tail[i].Location.X + 14) &&
                    (head.Location.Y > tail[i].Location.Y - 17 && head.Location.Y < tail[i].Location.Y + 14))
                {
                    return true;
                }
            if ((head.Location.X > gameLoc.Width - 30 || head.Location.X < 4) ||
                (head.Location.Y > gameLoc.Height - 30 || head.Location.Y < 4))
            {
                return true;
            }
            if (mouseCtrl)
                return MouseLose();
            return false;
        }

        public bool MouseLose()
        {
            if (head.Location.X > curs.X - 18 && head.Location.X < curs.X + 15 &&
                head.Location.Y > curs.Y - 18 && head.Location.Y < curs.Y + 15)
            {
                return true;
            }
            return false;
        }

        public void Restart()
        {
            game = false;
            speed = 5;
            scet = 0;
            num = startdot - 1;
            deg = 0;
            CalcVelocity();

            Array.Resize(ref tail, startdot);
            head.Location = new Point(200, 50);
            head.OldLocation = head.Location;

            for (int i = 0; i < tail.Length; i++)
            {
                tail[i] = new Dot(new PointF(head.OldLocation.X - (i * speed), head.OldLocation.Y + (speed / 2)), dotColor);
                dotColor = Color.FromArgb(255, random.Next(255), random.Next(255), random.Next(255));
            }

            pie.NewLocation(gameLoc);
            UpdateState(-1);
        } 

        public void CalcVelocity()
        {
            if (deg < -360 || deg > 360)
            {
                deg = 0;
            }
            degrad = deg * Math.PI / 180;
            deltaX = Math.Round(speed * Math.Cos(degrad), 2);
            deltaY = Math.Round(speed * Math.Sin(degrad), 2);
        }        

        public void UpdateState(int code)
        {
            snakeView.Update();
            gameLoc.Invalidate();
            snakeView.PlaySound(code);
        }

        public void Lose()
        {
            snakeView.PlaySound(1);
            if (snakeView.ShowLose() == DialogResult.Retry)
            {
                Restart();
            }
            else
            {
                gameLoc.Parent.Hide();
                new MainMenu().Show();
            }
        }
    }
}