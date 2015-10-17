using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();

            List<Point> pointList = new List<Point>();
            pointList.Add(p2);
            pointList.Add(new Point(1,1,'e'));
            pointList.Add(new Point(1, 2, 'w'));
            pointList.Add(new Point(1, 3, 'q'));
            pointList.Add(p1);

            foreach (var point in pointList)
            {
              point.Draw();  
            }

            HorizontalLine myLine = new HorizontalLine(1, 24, 2,'+');
            myLine.Draw();
            new HorizontalLine(1, 24, 3, '-').Draw();

            Console.ReadLine();
        }

        
    }
}
