namespace labyrinthEditor;

public class CursorMovement
{
    private int x;
    private int y;
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
    
    public void EnableCursorMovement(Map map)
    {
        bool enabled = true;
        Console.SetCursorPosition(0, 0);
        while (enabled)
        {
            ConsoleKey key = Console.ReadKey(true).Key;
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