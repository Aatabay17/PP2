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
    public class Food : GameObject
    {
        public Food() { }
        public Food(int x, int y, string sign, ConsoleColor color) : base(x, y, sign, color)
        {

        }
        public void Generate()
        {
            Random rand = new Random();
            int x = rand.Next(2,30);
            int y = rand.Next(2,30);

            body[0].X = x;
            body[0].Y = y;
        }
        public void Serialize()
        {
            FileStream fs = new FileStream("food.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(Food));
            xml.Serialize(fs, this);
            fs.Close();
        }
        public void DeSerialize()
        {
            FileStream fs = new FileStream("food.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xml = new XmlSerializer(typeof(Food));
            Game.food = xml.Deserialize(fs) as Food;
            fs.Close();
        }
    }
}
