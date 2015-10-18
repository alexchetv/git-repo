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

            Walls walls = new Walls(80, 25,'+');
            walls.Draw();

            Snake snake = new Snake(new Point(5,5,'*'),5,Direction.RIGTH);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(80,25);
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail()) break;
 
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
