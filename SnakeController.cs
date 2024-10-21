using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Snake
{
    public class ISnakeController
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern short GetKeyState(int keyCode);
        public const int KEY_PRESSED = 0x8000;
        public static bool IsKeyDown(Keys key)
        {
            return Convert.ToBoolean(GetKeyState((int)key) & KEY_PRESSED);
        }

        public ISnakeModel snakeModel;

        public Timer mainTick;
        public Timer loseTick;

        public ISnakeController(ISnakeModel snakeModel, Timer mainTimer, Timer loseTimer)
        {
            this.snakeModel = snakeModel;
            this.snakeModel.Restart();
            this.snakeModel.gameLoc.Parent.KeyDown += CheckKeyPress;
            mainTick = mainTimer;
            loseTick = loseTimer;
            mainTick.Tick += Main_Tick;
            loseTick.Tick += Lose_Tick;
            if (snakeModel.mouseCtrl)
                loseTick.Tick += MoveMouse_Tick;
            else
                loseTick.Tick += Move_Tick;
        }        

        public void Main_Tick(Object sender, EventArgs e)
        {
            snakeModel.Change();
        }

        public void Lose_Tick(object sender, EventArgs e)
        {
            if (snakeModel.IsLosed())
            { 
                mainTick.Stop();
                loseTick.Stop();
                snakeModel.game = false;
                snakeModel.Lose();
            }
        }

        public void Move_Tick(object sender, EventArgs e)
        {
            if (!snakeModel.game) { return; }
            if (IsKeyDown(Keys.A) || IsKeyDown(Keys.Left))
            {
                snakeModel.deg -= snakeModel.rotation;
            }
            if (IsKeyDown(Keys.D) || IsKeyDown(Keys.Right))
            {
                snakeModel.deg += snakeModel.rotation;
            }
            snakeModel.CalcVelocity();
        }

        public void MoveMouse_Tick(object sender, EventArgs e)
        {
            PointF h = snakeModel.head.Location;
            Point c = snakeModel.curs;

            snakeModel.deg = (float)(Math.Acos((c.X - h.X) / (Math.Sqrt(Math.Pow(c.X - h.X, 2) + Math.Pow(c.Y - h.Y, 2)))) * 180 / Math.PI);
            if (c.Y < h.Y)
                snakeModel.deg = 180 + (180 - snakeModel.deg);

            snakeModel.CalcVelocity();
        }

        public void CheckKeyPress(object sender, KeyEventArgs e)
        {
            int num = 4;
            if (e.KeyData == Keys.Space)
            {
                if (snakeModel.game)
                {
                    snakeModel.game = false;
                    loseTick.Stop();
                    mainTick.Stop();
                }
                else
                {
                    snakeModel.game = true;
                    loseTick.Start();
                    mainTick.Start();
                }
                goto l1;
            }
            if (e.KeyData == Keys.R)
            {
                snakeModel.Restart();
                snakeModel.game = true;
                loseTick.Start();
                mainTick.Start();
                goto l1;
            }
            if (e.KeyData == Keys.Escape)
            {
                snakeModel.game = false;
                loseTick.Stop();
                mainTick.Stop();
                new MainMenu().Show();
                snakeModel.gameLoc.Parent.Dispose();
            }
            if (e.KeyData == Keys.Q)
            {
                if (snakeModel.speed > 5)
                    snakeModel.speed -= 1;
                num = 3;
                goto l1;
            }
            if (e.KeyData == Keys.E)
            {
                if (snakeModel.speed < 20)
                    snakeModel.speed += 1;
                num = 2;
                goto l1;
            }
            if (e.KeyData == Keys.Add)
            {
                if (snakeModel.volume < 1)
                    snakeModel.volume += 0.1f;
                num = 2;
                goto l1;
            }
            if (e.KeyData == Keys.Subtract)
            {
                if (snakeModel.volume > 0)
                    snakeModel.volume -= 0.1f;
                num = 3;
                goto l1;
            }
            num = -1;
            l1:
            snakeModel.UpdateState(num);
        }
    }
}
