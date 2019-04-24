using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SnakeGame
{ 
    [Serializable]
    public class Snake:GameObject
    {
        enum Direction
        {
            NONE,
            RIGHT,
            LEFT,
            UP,
            DOWN
        }
        Direction direction = Direction.NONE;
        public Snake()
        {

        }
        public Snake(int x,int y,string sign,ConsoleColor color) : base(x, y, sign, color)
        {
        }
        public void Move() {
            for(int i = body.Count -1; i>0; i--)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;
            }
            switch (direction)
            {
                case Direction.NONE:
                    return;
                case  Direction.LEFT :
                    body[0].X--;
                    break;
                case Direction.UP:
                    body[0].Y--;
                    break;
                case Direction.RIGHT:
                    body[0].X++;
                    break;
                case Direction.DOWN:
                    body[0].Y++;
                    break;
            }
        }
        public  void ChangeDirection(ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    direction = Direction.LEFT;
                    break;
                case ConsoleKey.UpArrow:
                    direction = Direction.UP;
                    break;
                case ConsoleKey.RightArrow:
                    direction = Direction.RIGHT;
                    break;
                case ConsoleKey.DownArrow:
                    direction = Direction.DOWN;
                    break;
            }
        }
           public void Serialize()
           {
            FileStream fs = new FileStream("snake.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(Snake));
            xml.Serialize(fs, this);
            fs.Close();
           }
        public void DeSerialize()
        {
            FileStream fs = new FileStream("snake.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xml = new XmlSerializer(typeof(Snake));
            Game.snake = xml.Deserialize(fs) as Snake;
            fs.Close();
        }
        
    }
    }
