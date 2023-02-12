namespace labyrinthEditor;

public class CursorMovement
{
    MapElements mapelements = new MapElements();
    private int x;
    private int y;
    private bool displayCursorLocation;
    public CursorMovement()
    {
        x = 0;
        y = 0;
    }

    public int GetXCoord()
    {
        return x;
    }

    public int GetYCoord()
    {
        return y;
    }

    public void DisplayCursorLocation()
    {
        int prevX = GetXCoord();
        int prevY = GetYCoord();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.SetCursorPosition(0, Console.WindowHeight - 2);
        for (int i = 0; i < Console.LargestWindowWidth; i++)
        {
            Console.Write(" ");
        }
        Console.SetCursorPosition(0, Console.WindowHeight - 2);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write($"{Resources.strings.Height}: {prevY}, {Resources.strings.Width}: {prevX}, {Resources.strings.Up}: W, {Resources.strings.Left}: A, {Resources.strings.Down}: S, {Resources.strings.Right}: D, {Resources.strings.Save}: L\n ╬: 1, ═: 2, ╦: 3, ╩: 4, ║: 5, ╣: 6, ╠: 7, ╗: 8, ╝: 9, ╚: U, ╔:I");
        Console.SetCursorPosition(prevX, prevY);
        Console.BackgroundColor = ConsoleColor.Black;
    }
    
    public void EnableCursorMovement(Map map)
    {
        bool enabled = true;
        Console.SetCursorPosition(0, 0);
        while (enabled)
        {
            DisplayCursorLocation();
            ConsoleKey key = Console.ReadKey(true).Key;
            DisplayCursorLocation();
            switch (key)
            {
                case ConsoleKey.W:
                    if (y != 0)
                    {
                        y--; 
                    }
                    break;
                case ConsoleKey.A:
                    if (x != 0)
                    {
                        x--;
                    }

                    break;
                case ConsoleKey.S:
                    if (y < map.GetHeight() -1)
                    {
                        y++;
                    }
                    break;
                case ConsoleKey.D:
                    if (x < map.GetLength() -1)
                    {
                        x++;
                    }
                    break;
                case ConsoleKey.Escape:
                    enabled = false;
                    break;
                case ConsoleKey.D1:
                    map.map[y, x] = mapelements.getElement(0);
                    map.PrintMap();
                    break;
                case ConsoleKey.D2:
                    map.map[y, x] = mapelements.getElement(1);
                    map.PrintMap();
                    break;
                case ConsoleKey.D3:
                    map.map[y, x] = mapelements.getElement(2);
                    map.PrintMap();
                    break;
                case ConsoleKey.D4:
                    map.map[y, x] = mapelements.getElement(3);
                    map.PrintMap();
                    break;
                case ConsoleKey.D5:
                    map.map[y, x] = mapelements.getElement(4);
                    map.PrintMap();
                    break;
                case ConsoleKey.D6:
                    map.map[y, x] = mapelements.getElement(5);
                    map.PrintMap();
                    break;
                case ConsoleKey.D7:
                    map.map[y, x] = mapelements.getElement(6);
                    map.PrintMap();
                    break;
                case ConsoleKey.D8:
                    map.map[y, x] = mapelements.getElement(7);
                    map.PrintMap();
                    break;
                case ConsoleKey.D9:
                    map.map[y, x] = mapelements.getElement(8);
                    map.PrintMap();
                    break;
                case ConsoleKey.U:
                    map.map[y, x] = mapelements.getElement(9);
                    map.PrintMap();
                    break;
                case ConsoleKey.I:
                    map.map[y, x] = mapelements.getElement(10);
                    map.PrintMap();
                    break;
                case ConsoleKey.L:
                    Save.SaveFile(map);
                    break;
                default:
                    continue;
            }
            Console.SetCursorPosition(x, y);
        }
    }
}