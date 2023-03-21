using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace camsGame2._0
{
    internal class Balls
    {
        public int x, y, xSpeed, ySpeed;
        public int size = 20;

        public Balls(int _x, int _y, int _xSpeed, int _ySpeed)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
        }
        public void Move(int width, int height)
        {
            x += xSpeed;
            y += ySpeed;

         

            if (y > height - size || y < 0)
            {
                ySpeed *= -1;

            }


        }
        public void Collision(Wall w)
        {
            Rectangle ball = new Rectangle(x, y, size, size);
            Rectangle wall = new Rectangle(w.x, w.y, w.width, w.height);
            if (ball.IntersectsWith(wall))
            {
                ySpeed *= -1;
                xSpeed *= -1;
            }

        }
        public bool Collision(player p)
        {
            Rectangle ballRec = new Rectangle(x, y, size, size);
            Rectangle playerRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (ballRec.IntersectsWith(playerRec))
            {
                
                return true;
            }
            return false;
        }
    }
}
