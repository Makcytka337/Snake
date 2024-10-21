using System.Windows.Forms;

namespace Snake
{
    public class NewGame
    {

        public ISnakeModel snakeModel;
        public ISnakeController snakeController;
        public ISnakeView snakeView;
        
        public NewGame(Panel gamePanel, Label scetLabel, Label keysLabel1, Label keysLabel2,
                                        Label degLabel, Label speedLabel, Label volumeLabel,
                                        Button infobtn, Timer mainTimer, Timer loseTimer, Label l1, bool mouseCtrl)
        {
            snakeModel = new ISnakeModel(gamePanel, l1, mouseCtrl);
            snakeView = new ISnakeView(snakeModel, scetLabel, keysLabel1, keysLabel2, speedLabel, volumeLabel, degLabel, infobtn);
            snakeModel.snakeView = snakeView;
            snakeController = new ISnakeController(snakeModel, mainTimer, loseTimer);
            snakeModel.SetNewGame(snakeController, snakeView);
        }

        public void Reset()
        {
        }

        
    }
}
