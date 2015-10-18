using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*HorizontalLine upLine = new HorizontalLine(0, 78, 0, '*');
HorizontalLine downLine = new HorizontalLine(0, 78, 24, '*');
VerticalLine leftLine = new VerticalLine(0, 24, 0, '*');
VerticalLine rightLine = new VerticalLine(0, 24, 78, '*');
*/
namespace Snake
{
    class Walls
    {
        protected List<Figure> wallList = new List<Figure>();

        public Walls(int mapWidth, int mapHeight,char sym)
        {
            wallList.Add(new HorizontalLine(0, mapWidth - 2, 0, sym));
            wallList.Add(new HorizontalLine(0, mapWidth - 2, mapHeight - 1, sym));
            wallList.Add(new VerticalLine(0, mapHeight - 1, 0, sym));
            wallList.Add(new VerticalLine(0, mapHeight - 1, mapWidth - 2, sym));
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.Draw();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure)) return true;
            }
            return false;
        }
    }
}
