using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class ColorFigure : Figure
    {
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Draw();
            Console.ResetColor();
        }
    }
}
