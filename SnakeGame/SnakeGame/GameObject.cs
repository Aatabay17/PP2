using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SnakeGame
{
    public class GameObject
    {
        public  List<Point> body;
       
        public string sign;
        public ConsoleColor color;
        public Point head;
        public GameObject()
        {
        }
        public GameObject(int x,int y,string sign,ConsoleColor color)
        {
            body = new List<Point>
             {
                new Point(x,y)

             };
            this.sign = sign;
            this.color = color;
        }
        public void Draw()
        {
        Console.ForegroundColor = color;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(sign);
            }
        }
        public  bool IsCollisionwithObject(GameObject obj)
        {
            foreach (Point p in obj.body)
            {
                if (body[0].X == p.X && body[0].Y == p.Y)
                {
                    return true;
                }
            }
            return false;
        }
        public bool CollisionSnaketoSnake()
        {
            for (int i = 2; i < body.Count; i++)
            {
                if (body[0].X == body[i].X && body[0].Y == body[i].Y)
                return true;
            }
            return false;
        }
        public void Serialize()
        {
            FileStream fs = new FileStream("gameobjects.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(GameObject));
            xml.Serialize(fs,this);
            fs.Close();
        }
        public void DeSerialize(GameObject obj)
        {
            FileStream fs = new FileStream("gameobjects.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xml = new XmlSerializer(typeof(GameObject));
            obj = xml.Deserialize(fs) as GameObject;
            fs.Close();
        }

    }
}
