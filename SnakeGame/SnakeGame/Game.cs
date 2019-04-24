using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SnakeGame
{
    public class Game
    {
        public List<GameObject> g_objects;
        public bool isAlive;
        public static Snake snake;
        public static Food food;
        public static Wall wall;
        public UserItems user;
        public Game(UserItems user)
        {
            this.user = user;
            g_objects = new List<GameObject>();
            snake = new Snake(20, 20, "(", ConsoleColor.White);
            food = new Food(0, 0, "@", ConsoleColor.Red);
            wall = new Wall("#", ConsoleColor.Green);
            
            wall.LoadLevel();
            while (food.IsCollisionwithObject(snake) || food.IsCollisionwithObject(wall))
            food.Generate();

            g_objects.Add(snake);
            g_objects.Add(food);
            g_objects.Add(wall);

            isAlive = true;
        }
        public void Start()
        {
            Thread th = new Thread(MoveSnake);
            th.Start();
            
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            
            while (isAlive && keyInfo.Key != ConsoleKey.Escape)
            {
                keyInfo = Console.ReadKey();
                snake.ChangeDirection(keyInfo);
                if(keyInfo.Key == ConsoleKey.Backspace)
                {
                    GameResume();
                }
                if(keyInfo.Key == ConsoleKey.Spacebar)
                {
                    GameContinue();
                }
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(35, 20);
            Console.WriteLine("GAME OVER!!");
        }
        public void MoveSnake()
        {
            while (isAlive)
            {
                snake.Move();
                
                if (snake.IsCollisionwithObject(food))
                {
                    user.score++;
                    snake.body.Add(new Point(0, 0));

                    while (food.IsCollisionwithObject(snake) || food.IsCollisionwithObject(wall))
                        food.Generate();
                    if (snake.body.Count % 3 == 0)
                        wall.NextLevel();
                }
                if (snake.IsCollisionwithObject(wall) || snake.CollisionSnaketoSnake())
                {
                    isAlive = false;
                }
                Draw();
                Thread.Sleep(100);
            }
        }
        public void Draw()
        {
            Console.Clear();
            Console.SetWindowSize(80, 40);
            Console.SetBufferSize(80, 40);
            user.PrintInfo();
            foreach (GameObject g in g_objects)
            {
                g.Draw();
            }
        }
        public void GameResume()
        {
            Console.Clear();
              snake.Serialize();
              wall.Serialize();
              food.Serialize();
        }
        public void GameContinue()
        {
            Console.Clear();
            snake.DeSerialize();
            wall.DeSerialize();
            food.DeSerialize();
        }
    }
}
