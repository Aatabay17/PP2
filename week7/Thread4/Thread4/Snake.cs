using System;
namespace Thread4
{
    public class Snake
    {
        public int x, y;
        enum Direction
        {
            UP,
            DOWN,
            LEFT,
            RIGHT
        }
        Direction direction;

        public Snake(int x, int y)
        {
            this.x = x;
            this.y = y;
            direction = Direction.UP;
        }

        public void Move()
        {
            if (y==5)
                direction = Direction.RIGHT;
            if (x==30)
                direction = Direction.DOWN;
            if (y==30)
                direction = Direction.LEFT;
            if (x==5)
                direction = Direction.UP;
        }

        public void Draw()
        {
            if (direction == Direction.UP)
                y--;
            if (direction == Direction.DOWN)
                
                y++;
            if (direction == Direction.LEFT)
                
                x--;
            if (direction == Direction.RIGHT)
                x++;
                
            /* квадрат if (direction == Direction.UP)
                 y--;
             if (direction == Direction.DOWN)
                 y++;
             if (direction == Direction.LEFT)
                 x--;
             if (direction == Direction.RIGHT)
                 x++;*/
            Console.Clear();
            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write("*");

        }
    }
}