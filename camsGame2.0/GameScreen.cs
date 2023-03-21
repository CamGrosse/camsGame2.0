using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace camsGame2._0
{
    public partial class GameScreen : UserControl
    {
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush redBrush= new SolidBrush(Color.Red);
        SolidBrush yellowBrush= new SolidBrush(Color.Yellow);
        player hero;
        Boolean leftArrowdown, rightArrowdown, upArrowDown, downArrowDown;
        List<Balls> balls = new List<Balls>();
        List<Balls> balls2= new List<Balls>();
        List<Wall> walls = new List<Wall>();


        public GameScreen()
        {
            InitializeComponent();
            InitializeGame();
        }
        public void InitializeGame()
        {
            hero = new player(150, 210);
            Wall newWall = new Wall(100, 175, 175, 2);
            walls.Add(newWall);

            newWall = new Wall(100, 300, 350, 2);
            walls.Add(newWall);

            newWall = new Wall(100, 175, 2, 125);
            walls.Add(newWall);

            newWall = new Wall(275, 150, 2, 27);
            walls.Add(newWall);

            newWall = new Wall(275, 150, 35, 2);
            walls.Add(newWall);

            newWall = new Wall(310, 150, 2, 27);
            walls.Add(newWall);

            newWall = new Wall(310, 175, 140, 2);
            walls.Add(newWall);

            newWall = new Wall(450, 175, 2,127);
            walls.Add(newWall);

            Balls newBall = new Balls(230, 220,5, 5);
            balls.Add(newBall);
            newBall = new Balls(200,180, 5, 5);
            balls.Add(newBall);
          
            
            newBall = new Balls(230, 159, 5, 0);
            balls.Add(newBall);
            newBall = new Balls(200, 200, 5, 0);
            balls.Add(newBall);


        }
        private void gameEngine_Tick(object sender, EventArgs e)
        {
            foreach (Balls b in balls)
            {
                b.Move( 0,this.Height);
            }
            foreach (Balls b in balls2)
            {
                b.Move(this.Width,0);
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
            foreach(Balls b in balls)
            { hero.Collision(b);
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
                e.Graphics.FillEllipse(yellowBrush, b.x, b.y, b.size, b.size);
            }

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
