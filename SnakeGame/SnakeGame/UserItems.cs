using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SnakeGame
{
    public class UserItems
    {
        public string name;
        public  int score;
        public UserItems(string name,int score)
        {
            this.name = name;
            this.score = score;
        }
        public  void PrintInfo()
        {
            Console.SetCursorPosition(0, 34);
            Console.Write("Your name : {0}", name);
            Console.SetCursorPosition(0,33);
            Console.Write("Your score : {0}", score);
        }
        public void Serialize(UserItems user)
        {
            FileStream fs = new FileStream("user.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(UserItems));
            xml.Serialize(fs, user);
            fs.Close();
        }
        public void DeSerialize(UserItems user)
        {
            FileStream fs = new FileStream("user.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xml = new XmlSerializer(typeof(UserItems));
            user = xml.Deserialize(fs) as UserItems;
            fs.Close();
        }
    }
}
