namespace GeometryApi
{
    using System;
    using System.Linq;

    public class AdvancedFigureController : FigureController
    {
        public override void ExecuteFigureCreationCommand(string[] splitFigString)
        {
            switch (splitFigString[0])
            {
                case "circle":
                    {
                        Vector3D center = Vector3D.Parse(splitFigString[1]);
                        double radius = double.Parse(splitFigString[2]);
                        this.currentFigure = new Circle(center, radius);
                        break;
                    }
                case "cylinder":
                    {
                        Vector3D bottom = Vector3D.Parse(splitFigString[1]);
                        Vector3D top = Vector3D.Parse(splitFigString[2]);
                        double radius = double.Parse(splitFigString[3]);
                        this.currentFigure = new Cylinder(bottom, top, radius);
                        break;
                    }
            }

            base.ExecuteFigureCreationCommand(splitFigString);
        }

        protected override void ExecuteFigureInstanceCommand(string[] splitCommand)
        {
            switch (splitCommand[0])
            {
                case "area":
                    {
                        IAreaMeasurable areaMeasurable = this.currentFigure as IAreaMeasurable;

                        if (areaMeasurable != null)
                        {
                            Console.WriteLine("{0:0.00}", areaMeasurable.GetArea());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }

                        break;
                    }
                case "volume":
                    {
                        IVolumeMeasurable volumeMeasurable = this.currentFigure as IVolumeMeasurable;

                        if (volumeMeasurable != null)
                        {
                            Console.WriteLine("{0:0.00}", volumeMeasurable.GetVolume());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }

                        break;
                    }
                case "normal":
                    {
                        IFlat currentAsFlat = this.currentFigure as IFlat;

                        if (currentAsFlat != null)
                        {
                            Console.WriteLine("{0:0.00}", currentAsFlat.GetNormal());
                        }
                        else
                        {
                            Console.WriteLine("undefined");
                        }

                        break;
                    }
                default:
                    base.ExecuteFigureInstanceCommand(splitCommand);
                    break;
            }
        }
    }
}