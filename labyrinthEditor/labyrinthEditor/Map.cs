using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labyrinthEditor
{
    internal class Map
    {
        private List<List<Object>> map = new List<List<Object>>();

        public void LoadMap(string filePath) {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            foreach (string line in lines) {
                List<Object> child = new List<Object>();
                foreach (char c in line) {
                    child.Add(c);
                }
                map.Add(child);
            }
        }
        public void PrintMap() {
            Console.Clear();
            for (int i = 0; i < map.Count(); i++) {
                Console.WriteLine(String.Join("", map[i]));
            }
        }
    }
}
