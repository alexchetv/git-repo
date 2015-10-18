using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80,25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0,'*');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '*');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '*');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '*');
            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();

            Snake snake = new Snake(new Point(5,5,'*'),5,Direction.DOWN);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(80,25);
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if (snake.Eat(food))
                {
                    snake.Draw();
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    while (Console.KeyAvailable) key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                
                
            }
            Console.ReadLine();
        }

        
    }
}
