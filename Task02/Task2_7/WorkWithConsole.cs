using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2_7
{
    public class WorkWithConsole
    {
        public void SwichFigureType()
        {
            bool isInput = true;

            while (isInput)
            {
                Console.WriteLine("Choose a type of creating figure:" 
                                  + Environment.NewLine + "\t 1: line;" 
                                  + Environment.NewLine + "\t 2: circle;"
                                  + Environment.NewLine + "\t 3: rectangle;" 
                                  + Environment.NewLine + "\t 4: round;"
                                  + Environment.NewLine + "\t 5: ring;" 
                                  + Environment.NewLine + "\t 6: exit from the program.");

                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    switch (result)
                    {
                        case 1:
                        {
                            CreateLine();
                            break;
                        }

                        case 2:
                        {
                            CreateCircle();
                            break;
                        }

                        case 3:
                        {
                            CreateRectangle();
                            break;
                        }

                        case 4:
                        {
                            CreateRound();
                            break;
                        }
                        
                        case 5:
                        {
                            CreateRing();
                            break;
                        }

                        case 6:
                        {
                            isInput = false;
                            break;
                        }
                        
                        default:
                        {
                            Console.WriteLine("Unknown command!");
                            break;
                        }
                    }
                }
            }
        }

        private Point createPoint()
        {
            Console.WriteLine("X coordinate:");
            double xCoordinate = 0;
            if (!double.TryParse(Console.ReadLine(), out var xCoordinateValue))
            {
                throw new ArgumentException("Wrong input data format!");
            }
            else
            {
                xCoordinate = xCoordinateValue;
            }
            
            Console.WriteLine("Y coordinate:");
            double yCoordinate = 0;
            if (!double.TryParse(Console.ReadLine(), out var yCoordinateValue))
            {
                throw new ArgumentException("Wrong input data format!");
            }
            else
            {
                yCoordinate = yCoordinateValue;
            }
            
            return new Point(xCoordinate, yCoordinate);
        }

        private void CreateLine()
        {
            Console.WriteLine("You are creating a line. Input first point coordinate");

            Point firstPoint = createPoint();
            
            Console.WriteLine("Input second point coordinates");

            Point secondPoint = createPoint();
            
            Console.WriteLine((new Line(firstPoint, secondPoint).ToString()));
        }

        private void CreateCircle()
        {
            Console.WriteLine("You are creating a circle. Input coordinate of center");

            Point center = createPoint();
            
            Console.WriteLine("Input radius length");
            double radiusLenth = 0;
            if (!double.TryParse(Console.ReadLine(), out var radiusValue))
            {
                throw new ArgumentException("Wrong input data format!");
            }
            else
            {
                radiusLenth = radiusValue;
            }

            Console.WriteLine((new Circle(center, radiusLenth)).ToString());
        }

        private void CreateRectangle()
        {
            Console.WriteLine("You are creating a rectangle. Input first point coordinate");

            Point firstPoint = createPoint();
            
            Console.WriteLine("Input second point coordinates");

            Point secondPoint = createPoint();
            
            Console.WriteLine("Input third point coordinates");

            Point thirdPoint = createPoint();
            
            Console.WriteLine("Input fourth point coordinates");

            Point fourthPoint = createPoint();
            
            Console.WriteLine((new Rectangle(firstPoint, secondPoint, thirdPoint, fourthPoint)).ToString());
            
        }
        
        private void CreateRound()
        {
            Console.WriteLine("You are creating a round. Input coordinate of center");

            Point center = createPoint();
            
            Console.WriteLine("Input radius length");
            double radiusLenth = 0;
            if (!double.TryParse(Console.ReadLine(), out var radiusValue))
            {
                throw new ArgumentException("Wrong input data format!");
            }
            else
            {
                radiusLenth = radiusValue;
            }

            string colorName = "transparent";
            Console.WriteLine("Choose the color:" 
                              + Environment.NewLine + "\t 1: red;" 
                              + Environment.NewLine + "\t 2: green;"
                              + Environment.NewLine + "\t 3: blue");
            if (int.TryParse(Console.ReadLine(), out int colorNumber))
            {
                switch (colorNumber)
                {
                    case 1:
                    {
                        colorName = "red";
                        break;
                    }

                    case 2:
                    {
                        colorName = "green";
                        break;
                    }

                    case 3:
                    {
                        colorName = "blue";
                        break;
                    }

                    default:
                    {
                        Console.WriteLine("Transparent round.");
                        break;
                    }
                }
            }
            else
            {
                throw new ArgumentException("Wrong input data format!");
            }

            Console.WriteLine((new Round(center, radiusLenth, colorName)).ToString());
        }
        
        private void CreateRing()
        {
            List<double> circleData = new List<double>();
            
            Console.WriteLine("You are creating a ring. Input in line X and Y coordinates of center and radius length of inner and outer rings.");
            string[] inputData = Console.ReadLine().Split(new[] {" ", "\n"}, StringSplitOptions.RemoveEmptyEntries)
                .Select(item => item.Trim())
                .Where(item => !string.IsNullOrEmpty(item)).ToArray();

            if (inputData.Length == 6)
            {
                foreach (var s in inputData)
                {
                    if (!double.TryParse(s, out var value))
                    {
                        throw new ArgumentException("Wrong input data format!");
                    }
                    else
                    {
                        circleData.Add(value);
                    }
                }
            }
            else
            {
                throw new ArgumentException("You have to fill all fields!");
            }

            Console.WriteLine((new Ring(circleData)).ToString());
        }
    }
}