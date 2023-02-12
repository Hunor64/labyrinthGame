using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labyrinthEditor
{
    public class Map
    {
        public char[,] map;

        public char[] GetMapData()
        {
            char[] mapData = new char[map.Length + map.GetLength(0)];
            int itrCtr = 1;
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int k = 0; k < map.GetLength(1); k++)
                {
                    mapData[i * k] = map[i, k];
                }
                mapData[map.GetLength(0) * itrCtr] = '\n';
                itrCtr++;
            }
            return mapData;
        }

        public void LoadMap(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            map = new char[lines.Count(), lines[0].Count()];
            for (int i = 0; i < lines.Count(); i++) {
                for (int k = 0; k < lines[0].Count(); k++) {
                    map[i, k] = lines[i][k];
                }
            }
        }
        public void CreateMap(int height, int width)
        {
            map = new char[height, width];
            for (int i = 0; i < height; i++) {
                for (int k = 0; k < width; k++) {
                    map[i, k] = '.';
                }
            }
        }
        
        public void PrintMap() {
            Console.Clear();
            for (int i = 0; i < map.GetLength(0); i++) {
                for (int k = 0; k < map.GetLength(1); k++) {
                    Console.Write(map[i, k]);
                }
                Console.WriteLine("");
            }
        }

        public int GetLength()
        {
            return map.GetLength(1);
        }

        public int GetHeight()
        {
            return map.GetLength(0);
        }
    }
}
