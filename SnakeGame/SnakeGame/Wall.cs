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
    public class Wall :GameObject
    {
        enum GameLevel
        {
            FIRST,
            SECOND,
            THIRD
        }
        GameLevel gameLevel = GameLevel.FIRST;
        public Wall() { }
        public Wall(string sign,ConsoleColor color) : base(0,0,sign,color)
        {
            body = new List<Point>();
        }
        public void LoadLevel()
        {
            body = new List<Point>();
            string fileName = "level1.txt";
            if(gameLevel == GameLevel.SECOND)
            {
                fileName = "level2.txt";
            }
            if (gameLevel == GameLevel.THIRD)
            {
                fileName = "level3.txt";
            }
            StreamReader sr = new StreamReader(fileName);


            string[] rows = sr.ReadToEnd().Split('\n');
            
            for (int i = 0; i < rows.Length; i++)
            { 
                for (int j = 0; j < rows[i].Length; j++)
                {
                    if (rows[i][j] == '#')

                        body.Add(new Point(j, i));
                }
            }
            sr.Close();
        }
        public void NextLevel()
        {
            if (gameLevel == GameLevel.FIRST)
                gameLevel = GameLevel.SECOND;
            else if (gameLevel == GameLevel.SECOND)
                gameLevel = GameLevel.THIRD;
            LoadLevel();
        }
        public void Serialize()
        {
            FileStream fs = new FileStream("wall.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(Wall));
            xml.Serialize(fs, this);
            fs.Close();
        }
        public void DeSerialize()
        {
            FileStream fs = new FileStream("wall.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xml = new XmlSerializer(typeof(Wall));
            Game.wall = xml.Deserialize(fs) as Wall;
            fs.Close();
        }
    } 
}

