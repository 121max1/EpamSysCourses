using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    class Program
    {
        public static void PrintMenu()
        {
            Console.WriteLine("1.Добавить фигуру \n" +
                              "2.Вывести фигуры \n" +
                              "3.Очистить холст \n" +
                              "4.Вывести меню \n" +
                              "5.Выход");
                              
        }
        static void Main(string[] args)
        {
            List<Figure> figures = new List<Figure>();
            bool isExit = false;
            PrintMenu();
            while(!isExit)
            {
                Console.Write("Введите действие: ");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Выберите тип фигуры:");
                        Console.WriteLine("1.Круг \n" +
                              "2.Кольцо \n" +
                              "3.Прямоугольник \n" +
                              "4.Квадрат\n" +
                              "5.Треугольник \n" +
                              "6.Линия\n");
                        Console.Write("Ваш выбор: ");
                        int choiceFigure = int.Parse(Console.ReadLine());
                        try
                        {
                            switch (choiceFigure)
                            {
                                case 1:

                                    Console.WriteLine("Введите параметры фигуры Круг");
                                    Console.Write("Введите Координаты центра в формате (x;y):");
                                    string inputCircle = Console.ReadLine();
                                    double[] coordCircle = inputCircle.Replace("(", "").Replace(")", "").Split(';').
                                        Select(val => double.Parse(val)).ToArray();

                                    Console.Write("Введите радиус:");
                                    double r = double.Parse(Console.ReadLine());
                                    figures.Add(FigureManager.CreateCircle(coordCircle[0], coordCircle[1], r));
                                    Console.WriteLine("Фигура Круг успешно создана!");



                                    break;
                                case 2:

                                    Console.WriteLine("Введите параметры фигуры Кольцо");
                                    Console.Write("Введите Координаты центра в формате (x;y):");
                                    string inputRing = Console.ReadLine();
                                    double[] coord = inputRing.Replace("(", "").Replace(")", "").Split(';').
                                        Select(val => double.Parse(val)).ToArray();

                                    Console.Write("Введите радиус внутренней окружности:");
                                    double r1 = double.Parse(Console.ReadLine());
                                    Console.Write("Введите радиус внешней окружности:");
                                    double r2 = double.Parse(Console.ReadLine());
                                    figures.Add(FigureManager.CreateRing(coord[0], coord[1], r1, r2));
                                    Console.WriteLine("Фигура Круг успешно создана!");


                                    break;
                                case 3:

                                    Console.WriteLine("Введите параметры фигуры Прямоугольник");
                                    Console.Write("Введите Координаты центра в формате (x1;y1) (x2;y2) (x3;y3) (x4;y4):");
                                    string inputRectangle = Console.ReadLine();
                                    double[][] points = inputRectangle.Split(' ').Select(str => str.Replace("(", "").Replace(")", "").Split(';').
                                            Select(val => double.Parse(val)).ToArray()).ToArray();
                                    figures.Add(FigureManager.CreateRectangle(points[0][0], points[0][1], points[1][0], points[1][1],
                                        points[2][0], points[2][1], points[3][0], points[3][1]));
                                    Console.WriteLine("Фигура Прямоугольник успешно создана!");

                                    break;
                                case 4:
                                    Console.WriteLine("Введите параметры фигуры Квадрат");
                                    Console.Write("Введите Координаты центра в формате (x1;y1) (x2;y2) (x3;y3) (x4;y4):");
                                    string inputSquare = Console.ReadLine();
                                    double[][] pointsSquare = inputSquare.Split(' ').Select(str => str.Replace("(", "").Replace(")", "").Split(';').
                                            Select(val => double.Parse(val)).ToArray()).ToArray();
                                    figures.Add(FigureManager.CreateSquare(pointsSquare[0][0], pointsSquare[0][1], pointsSquare[1][0], pointsSquare[1][1],
                                        pointsSquare[2][0], pointsSquare[2][1], pointsSquare[3][0], pointsSquare[3][1]));
                                    Console.WriteLine("Фигура Квадрат успешно создана!");

                                    break;
                                case 5:
                                    Console.WriteLine("Введите параметры фигуры Треугольник");
                                    Console.Write("Введите Координаты центра в формате (x1;y1) (x2;y2) (x3;y3):");
                                    string inputTriangle = Console.ReadLine();
                                    double[][] pointsTriangle = inputTriangle.Split(' ').Select(str => str.Replace("(", "").Replace(")", "").Split(';').
                                            Select(val => double.Parse(val)).ToArray()).ToArray();
                                    figures.Add(FigureManager.CreateTriangle(pointsTriangle[0][0], pointsTriangle[0][1], pointsTriangle[1][0], pointsTriangle[1][1],
                                        pointsTriangle[2][0], pointsTriangle[2][1]));
                                    Console.WriteLine("Фигура Треугольник успешно создана!");
                                    break;
                                case 6:
                                    Console.WriteLine("Введите параметры фигуры Линия");
                                    Console.Write("Введите Координаты центра в формате (x1;y1) (x2;y2):");
                                    string inputLine = Console.ReadLine();
                                    double[][] pointsLine = inputLine.Split(' ').Select(str => str.Replace("(", "").Replace(")", "").Split(';').
                                            Select(val => double.Parse(val)).ToArray()).ToArray();
                                    figures.Add(FigureManager.CreateLine(pointsLine[0][0], pointsLine[0][1], pointsLine[1][0], pointsLine[1][1]));
                                    Console.WriteLine("Фигура Линия успешно создана!");
                                    break;




                            }
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("Ошибка при создании: {0}",e.Message);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Фигуры на холсте: ");
                        if (figures.Count != 0)
                        {
                            foreach (var fig in figures)
                            {
                                fig.GetInfo();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Нет фигур на холсте!");
                        }
                        break;
                    case 3:
                        figures.Clear();
                        Console.WriteLine("Холст очищен!");
                        break;
                    case 4:
                        PrintMenu();
                        break;
                    case 5:
                        isExit = true;
                        break;


                }
            }
        }
    }
}
