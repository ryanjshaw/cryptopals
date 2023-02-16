namespace Shared
{
    public static class Challenge
    {
        public static void Outcome(string name, bool ok)
        {
            if (ok)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(name + ": OK");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(name + ": FAIL");
                Console.ResetColor();
            }
        }
    }
}