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

        internal bool IsHit(Figure figure)
        {
            foreach (var p in pointList)
            {
                if (figure.IsHit(p)) return true;
            }
            return false;
        }

        private bool IsHit(Point point)
        {
            foreach (var p in pointList)
            {
                if (p.IsHit(point)) return true;
            }
            return false;
        }
    }
}
