using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labyrinthEditor
{
    public class Map
    {
        private List<List<char>> map = new List<List<char>>();

        public void LoadMap(string filePath) {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            foreach (string line in lines) {
                List<char> child = new List<char>();
                foreach (char c in line) {
                    child.Add(c);
                }
                map.Add(child);
            }
        }
        public void CreateMap(int height, int width)
        {
            List<char> rows = new List<char>();
            for (int i = 0; i < width; i++)
            {
                rows.Add('.');
            }

            for (int i = 0; i < height; i++)
            {
                map.Add(rows);
            }
        }
        
        public void PrintMap() {
            Console.Clear();
            for (int i = 0; i < map.Count(); i++) {
                Console.WriteLine(String.Join("", map[i]));
            }
        }

        public int GetLength()
        {
            return map[0].Count();
        }

        public int GetHeight()
        {
            return map.Count();
        }
    }
}
