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

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                {
                    direction = Direction.LEFT;
                        break;
                }
                case ConsoleKey.RightArrow:
                    {
                        direction = Direction.RIGTH;
                        break;
                    }
                case ConsoleKey.UpArrow:
                    {
                        direction = Direction.UP;
                        break;
                    }
                case ConsoleKey.DownArrow:
                    {
                        direction = Direction.DOWN;
                        break;
                    }
            }   


        }

        public bool Eat(Point food)
        {
            Point newHead = GetNewHead();
            if (newHead.IsHit(food))
            {
                food.sym = newHead.sym;
                pointList.Add(food);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsHitTail()
        {
            Point head = pointList.Last();
            for (int i = 0; i < pointList.Count-2; i++)
            {
                if (pointList[i].IsHit(head)) return true;
            }
            return false;
        }
    }
}
