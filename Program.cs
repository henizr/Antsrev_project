using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        string? fieldOutString = default;
        char[,] fieldData = new char[10, 10];
        int[] playerCoords = new int[2] { 5, 5 };

        Console.BackgroundColor = ConsoleColor.DarkMagenta;
        Console.ForegroundColor = ConsoleColor.White;


        void render()
        {
            for (int i = 0; i < 10; i++)
            {
                 
                for (int j = 0; j < 10; j++)
                {
                    if (i == playerCoords[0] && j == playerCoords[1]) fieldOutString += fieldData[i, j] = '%';
                    else fieldOutString += fieldData[i, j] = '^';
                    fieldOutString += ' ';
                }
                fieldOutString += '\n';
                
            }
            Console.WriteLine(fieldOutString);
        }

        


         while (true) {
            if(Console.ReadKey().Key == ConsoleKey.LeftArrow) {
                playerCoords = new int[] { playerCoords[0], playerCoords[1] + 1 };
            }
            if(Console.ReadKey().Key == ConsoleKey.RightArrow) {
                playerCoords = new int[] { playerCoords[0], playerCoords[1] - 1 };
            }

            Console.Clear();
            render();

         }

    }
}