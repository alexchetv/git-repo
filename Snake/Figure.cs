using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        protected List<Point> pointList = new List<Point>();

        public virtual void Draw()
        {
            foreach (var point in pointList)
            {
                point.Draw();
            }
        }
    }
}
