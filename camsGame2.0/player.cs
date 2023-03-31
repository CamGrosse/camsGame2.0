using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace camsGame2._0
{
    internal class player
    {
        public int x, y;
        public int speed = 10;
        public int xSpeed = 10;
        public int ySpeed = 10;
        public int width = 15;
        public int height = 15;
  


        public player(int _x, int _y)
        {

            x = _x;
            y = _y;

        }

        public void Move(string direction)
        {
            if (direction == "up")
            {
                y -= speed;

            }
            if (direction == "down")
            {
                y += speed;
            }
            if (direction == "left")
            { x -= speed; }
            if (direction == "right")
            {
                x += speed;
            }
        }
        public bool Collision(Wall w)
        {
            Rectangle playerRec = new Rectangle(x, y, width, height);
            Rectangle wallRec=new Rectangle(w.x, w.y, w.width,w.height);
            if (wallRec.IntersectsWith(playerRec))
            {
                x = 150;
                y = 225;
                return true;
            }

            return false;
            
        }
        public bool Collision(winnings i)
        {
            Rectangle playerRec=new Rectangle(x, y, width,height);
            Rectangle WinningRec = new Rectangle(i.x, i.y, i.width, i.height);
           if(playerRec.IntersectsWith(WinningRec))
            {                    return true; }
            return false;
        }
        public bool Collision(Balls b)
        {
            Rectangle playerRec = new Rectangle(x, y, width, height);
            Rectangle ballRec = new Rectangle(b.x, b.y, b.size, b.size);

            if (ballRec.IntersectsWith(playerRec))
            {
                x = 150;
                y = 225;
                return true;
            }
            return false;
        }
    }
}
