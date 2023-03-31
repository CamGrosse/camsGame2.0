using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace camsGame2._0
{
    public partial class GameScreen : UserControl
    {
        int fails = 0;

        SoundPlayer twitch = new SoundPlayer(Properties.Resources.ricochet);

        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush greeenBrush = new SolidBrush(Color.Green);

        player hero;
        winnings win;

        Boolean leftArrowdown, rightArrowdown, upArrowDown, downArrowDown;
        List<Balls> balls = new List<Balls>();

        List<Wall> walls = new List<Wall>();

        public GameScreen()
        {
            InitializeComponent();
            InitializeGame();
        }
        public void InitializeGame()
        {
            hero = new player(150, 225);

            win = new winnings(450, 175, 2, 127);
            //bottom wall
            Wall newWall = new Wall(100, 300, 350, 2);
            walls.Add(newWall);
            //left wall
            newWall = new Wall(100, 175, 2, 125);
            walls.Add(newWall);
            //top wall
            newWall = new Wall(100, 175, 350, 2);
            walls.Add(newWall);


            Balls newBall = new Balls(230, 220, 5, 5);
            balls.Add(newBall);
            newBall = new Balls(200, 180, 5, 5);
            balls.Add(newBall);


            newBall = new Balls(250, 200, 0, 5);
            balls.Add(newBall);
            newBall = new Balls(250, 250, 0, 1);
            balls.Add(newBall);
            newBall = new Balls(300, 250, -5, -5);
            balls.Add(newBall);
            newBall = new Balls(250, 250, -5, -5);
            balls.Add(newBall);

        }
        public void GameOverWin()
        {
            Form1.ChangeScreen(this, new winningScreem());
        }
        private void gameEngine_Tick(object sender, EventArgs e)
        {
            failsLabal.Text = $"Fails: {fails}";
            foreach (Balls b in balls)
            {
                b.Move(0, this.Height);
            }


            if (upArrowDown && hero.y > 0)
            {
                hero.Move("up");

            }
            else if (downArrowDown && hero.y < this.Height - hero.height)
            {
                hero.Move("down");
            }


            if (leftArrowdown && hero.x > 0)
            { hero.Move("left"); }
            else if (rightArrowdown && hero.x < this.Width - hero.width)
            {
                hero.Move("right");
            }



            foreach (Balls b in balls)
            {
                foreach (Wall walls in walls)
                {
                    b.Collision(walls);

                }
            }
            foreach (Balls b in balls)
            {
                if (hero.Collision(b))
                {
                    twitch.Play();
                    fails++;
                }
            }
            foreach (Wall w in walls)
            {
                if (hero.Collision(w))
                {
                    fails++;
                }

            }
            if (hero.Collision(win))
            {
                gameEngine.Enabled = false;
                GameOverWin();
            }
            Refresh();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Wall w in walls)
            {
                e.Graphics.FillRectangle(blackBrush, w.x, w.y, w.width, w.height);
            }
            foreach (Balls b in balls)
            {
                e.Graphics.FillEllipse(blackBrush, b.x, b.y, b.size, b.size);
            }


            e.Graphics.FillRectangle(greeenBrush, win.x, win.y, win.width, win.height);

            e.Graphics.FillRectangle(redBrush, hero.x, hero.y, hero.width, hero.height);

        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowdown = true;
                    break;
                case Keys.Right:
                    rightArrowdown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
            }

        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {

                case Keys.Left:
                    leftArrowdown = false;
                    break;
                case Keys.Right:
                    rightArrowdown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
            }
        }
    }
}
