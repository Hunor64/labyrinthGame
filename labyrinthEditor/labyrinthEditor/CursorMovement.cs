namespace labyrinthEditor;

public class CursorMovement
{
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
        Console.SetCursorPosition(0, Console.LargestWindowHeight - 2);
        for (int i = 0; i < Console.LargestWindowWidth; i++)
        {
            Console.Write(" ");
        }
        Console.SetCursorPosition(0, Console.LargestWindowHeight - 2);
        Console.BackgroundColor = ConsoleColor.Red;
        Console.Write($"{Resources.strings.Height}: {prevY}, {Resources.strings.Width}: {prevX}, UP: W, LEFT: A, DOWN: S, RIGHT:D");
        Console.SetCursorPosition(prevX, prevY);
    }
    
    public void EnableCursorMovement(Map map)
    {
        bool enabled = true;
        Console.SetCursorPosition(0, 0);
        while (enabled)
        {
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
                default:
                    continue;
            }
            Console.SetCursorPosition(x, y);
        }
    }
}