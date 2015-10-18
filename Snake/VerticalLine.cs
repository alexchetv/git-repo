using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : ColorFigure
    {

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            for (int y = yUp; y <= yDown; y++)
            {
                pointList.Add(new Point(x, y, sym));
            }
        }
    }
}
