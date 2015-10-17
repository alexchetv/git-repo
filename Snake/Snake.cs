using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;

        public Snake(Point tail, int length, Direction _direction)
        {
            direction = _direction;
            for (int i = 0; i < length; i++)
            {
                pointList.Add(new Point(tail));
                pointList[i].Move(i, direction);
            }
            
        }

        internal void Move()
        {
            Point  tail = pointList.First();
            pointList.Remove(tail);
            Point newHead = GetNewHead();
            pointList.Add(newHead);
            tail.Clear();
            newHead.Draw();
        }

        Point GetNewHead()
        {
            Point newHead = new Point(pointList.Last());
            newHead.Move(1,direction);
            return newHead;

        }
    }
}
