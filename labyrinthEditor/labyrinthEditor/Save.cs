using labyrinthEditor;
using System.Text;

internal class Save {
    public static void SaveFile(Map map) {
        if (map.chamberExists == false)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(labyrinthEditor.Resources.strings.Error_NoChamber);
            Console.WriteLine(labyrinthEditor.Resources.strings.PressEnterToContinue);
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            map.PrintMap();

        } else
        {
            Console.Clear();
            Console.WriteLine(labyrinthEditor.Resources.strings.EnterFileName);
            string fileName = Console.ReadLine() + ".sav";
            if (fileName == ".sav")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(labyrinthEditor.Resources.strings.Error_InvalidFileName);
                Console.WriteLine(labyrinthEditor.Resources.strings.PressEnterToContinue);
                Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                SaveFile(map);

            }
            Console.WriteLine(labyrinthEditor.Resources.strings.EnterPathOrUseDefaultPath); 
            string path = Console.ReadLine();
            if (path == "")
            {
                File.WriteAllText(fileName, map.GetMapDataAsString());
            }
            else
            {
                File.WriteAllText(path + fileName, map.GetMapDataAsString());
            }
            map.PrintMap();
        }

    }
}