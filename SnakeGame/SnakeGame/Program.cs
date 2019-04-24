using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "SNAKE FOR PP2";
            Console.WriteLine("Enter your name:");
            string username = Console.ReadLine();
            UserItems user = new UserItems(username,0);

            Console.CursorVisible = false;
            Game game = new Game(user);
            game.Start();
        }
    }
}
