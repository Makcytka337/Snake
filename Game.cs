using System;
using System.Windows.Forms;


namespace Snake
{
    public partial class Game : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;      
                return handleParam;
            }
        }

        public bool mouseCtrl = false;

        public Game(bool m)
        {
            mouseCtrl = m;
            InitializeComponent();
        }

        private void Game_Load(object sender, EventArgs e)
        {
            label1.Visible = mouseCtrl;
            new NewGame(gamepanel, scetLabel, keysLabel1, keysLabel2, degLabel, speedLabel, volumeLabel, infoBtn, game_timer, isLose, label1, mouseCtrl);
        }

        private void Game_Deactivate(object sender, EventArgs e)
        {
        }
    }
}