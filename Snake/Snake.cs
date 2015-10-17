using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        public Snake(Point tail, int length, Direction direction)
        {
            for (int i = 0; i < length; i++)
            {
                pointList.Add(new Point(tail));
                pointList[i].Move(i, direction);
            }
            
        }
    }
}
