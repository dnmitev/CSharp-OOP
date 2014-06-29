namespace GeometryApi
{
    using System;
    using System.Linq;

    public class Program
    {
        private static FigureController GetFigureController()
        {
            return new AdvancedFigureController();
        }

        private static void Main(string[] args)
        {
            var figController = GetFigureController();

            int figCreationsCount = int.Parse(Console.ReadLine());
            int endCommandsCount = 0;

            while (endCommandsCount < figCreationsCount)
            {
                figController.ExecuteCommand(Console.ReadLine());
                if (figController.EndCommandExecuted)
                {
                    endCommandsCount++;
                }
            }
        }
    }
}