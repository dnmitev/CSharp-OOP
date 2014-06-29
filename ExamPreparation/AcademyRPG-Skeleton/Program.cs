namespace AcademyRPG
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static Engine GetEngineInstance()
        {
            return new AdvancedEngine();
        }

        private static void Main(string[] args)
        {
            Engine engine = GetEngineInstance();

            string command = Console.ReadLine();
            while (command != "end")
            {
                engine.ExecuteCommand(command);
                command = Console.ReadLine();
            }
        }
    }
}