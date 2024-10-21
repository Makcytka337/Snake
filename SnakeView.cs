using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;

namespace Snake
{
    public class ISnakeView
    {
        public ISnakeModel snakeModel;

        public MediaPlayer mediaPlayer;

        public readonly string path = Directory.GetParent(Application.StartupPath).FullName + @"\audio\";
        public readonly string[] sounds = new[] { "win.mp3", "dead.mp3", "speedup.mp3", "speeddown.mp3", "pause.mp3", "eat.mp3" };

        readonly SolidBrush br = new SolidBrush(System.Drawing.Color.FromArgb(255, 255, 0, 0));

        readonly string keys1 =
            "Пауза/Продолжить\n" + "<Space>\n" +
            "\nПерезапуск\n" + "<R>\n" +
            "\nНазад в меню\n" + "<Esc>\n" +
            "\nУвеличить звук\n" + "<+>\n" +
            "\nУменьшить звук\n" + "<->\n";

        readonly string keys2 =
            "Поворот вправо\n" + "<Arrow Right> или <D>\n" +
            "\nПоворот влево\n" + "<Arrow Left> или <A>\n" +
            "\nУвеличить скорость\n" + "<E>\n" +
            "\nУменьшить скорость\n" + "<Q>";

        readonly Label scetlabel = new Label();
        readonly Label deglabel = new Label();
        readonly Label speedlabel = new Label();
        readonly Label volumelabel = new Label();
        readonly Button infobtn = new Button();

        public ISnakeView(ISnakeModel snakeModel, Label scetlabel, Label keyslabel1, Label keyslabel2,
                                                  Label speedLabel, Label volumeLabel, Label deglabel, Button infobtn) 
        {
            this.snakeModel = snakeModel;
            this.scetlabel = scetlabel;
            this.deglabel = deglabel;
            this.speedlabel = speedLabel;
            this.volumelabel = volumeLabel;
            this.infobtn = infobtn;
            keyslabel1.Text = keys1;
            keyslabel2.Text = keys2;
            mediaPlayer = new MediaPlayer
            {
                Volume = 0.2f
            };
        }

        public void Snake_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            float i = 13;
            float j = 13;
            float step = 1.8f;
            foreach (Dot item in snakeModel.tail.Reverse())
            {                
                br.Color = item.Color;
                g.FillEllipse(br, item.Location.X + step, item.Location.Y + step, j, j);
                if (i < 20.1)
                {
                    j = i;
                    i += 0.2f;
                }
                if (step > 0)
                    step -= 0.02f;
                
            }
            br.Color = snakeModel.head.Color;
            g.FillEllipse(br, snakeModel.head.Location.X, snakeModel.head.Location.Y, j + 5, j + 5);

            br.Color = snakeModel.pie.Color;
            g.FillEllipse(br, snakeModel.pie.Location.X, snakeModel.pie.Location.Y, 20, 20);
        }

        public void Update()
        {
            mediaPlayer.Volume = snakeModel.volume;
            deglabel.Text = "Угол поворота: " + snakeModel.deg.ToString();
            speedlabel.Text = "Скорость: " + snakeModel.speed.ToString();
            scetlabel.Text = "Счет: " + snakeModel.scet.ToString();
            volumelabel.Text = "Громкость: " + (Math.Round(mediaPlayer.Volume * 100)).ToString();
            if (snakeModel.game)
            {
                infobtn.Text = "Игра идет";
                infobtn.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                infobtn.Text = "Пауза";
                infobtn.BackColor = System.Drawing.Color.Red;
            }
        }

        public void PlaySound(int num)
        {
            if (num == -1) return;
            mediaPlayer.Open(new Uri(path + sounds[num]));
            mediaPlayer.Play();
        }

        public DialogResult ShowLose()
        {
            return MessageBox.Show("Вы проиграли, набрав " + snakeModel.scet + " очков.\nПопробовать еще раз?", "Поражение",
                MessageBoxButtons.RetryCancel);
        }

        public DialogResult ShowWin()
        {
            return MessageBox.Show("Вы выиграли, набрав " + snakeModel.scet + " очков.\nПопробовать еще раз?", "Победа",
                MessageBoxButtons.RetryCancel);
        }
    }
}
