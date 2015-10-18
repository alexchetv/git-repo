using System;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        public Point()
        {
            
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void Move(int step, Direction d)
        {
            if (d == Direction.LEFT) x -= step;
            if (d == Direction.RIGTH) x += step;
            if (d == Direction.UP) y -= step;
            if (d == Direction.DOWN) y += step;
        }

        public bool IsHit(Point point)
        {
            return x == point.x && y == point.y;
        }
    }
}
