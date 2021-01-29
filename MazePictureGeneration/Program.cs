using System;

namespace MazePictureGeneration
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new MPG())
                game.Run();
        }
    }
}
