using labyrinthEditor;

internal class Save {
    public static void SaveFile(Map map) {
        Console.Clear();
        Console.WriteLine(labyrinthEditor.Resources.strings.EnterFileName);
        string fileName = Console.ReadLine() + ".sav";
        if (fileName == ".sav")
        {
            
        }
        Console.WriteLine("Lorem ipsum"); //TODO: Change this to the proper resource string
        string path = Console.ReadLine();
        if (path == "")
        {
            //File.WriteAllBytes(Directory.GetCurrentDirectory() + fileName, map.GetMapData());
        }
    }
}