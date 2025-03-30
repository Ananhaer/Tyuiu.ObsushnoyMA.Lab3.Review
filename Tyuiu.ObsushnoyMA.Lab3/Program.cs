using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array;
using Calculate;
using MathFirstExpression;
using MathSecondExpression;
using TabMathFuction;

namespace Tyuiu.ObsushnoyMA.Lab3
{
    internal class Program
    {
        static void Main()
        {
            string[] menuItems = {
            "1. Рассчитать первое математическое выражение",
            "2. Рассчитать второе математическое выражение",
            "3. Протабулировать функцию",
            "4. Калькулятор",
            "5. Обработка одномерного массива"
        };

            int selectedIndex = 0;
            ConsoleKey key;

            do
            {
                Console.Clear();
                Console.WriteLine("Выберите пункт меню и нажмите Enter:\n");

                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == selectedIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"> {menuItems[i]} <");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {menuItems[i]}  ");
                    }
                }

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.UpArrow)
                    selectedIndex = (selectedIndex == 0) ? menuItems.Length - 1 : selectedIndex - 1;
                else if (key == ConsoleKey.DownArrow)
                    selectedIndex = (selectedIndex == menuItems.Length - 1) ? 0 : selectedIndex + 1;

            } while (key != ConsoleKey.Enter && key != ConsoleKey.F10);

            if (key == ConsoleKey.F10)
            {
                Console.WriteLine("\nВыход из программы...");
                return;
            }

            Console.Clear();

            if (selectedIndex == 0)
            {
                OpenFirstExpressionWindow();
            }
            else if (selectedIndex == 1)
            {
                OpenSecondExpressionWindow();
            }
            else if (selectedIndex == 2)
            {
                OpenFunctionTabulationWindow();
            }
            else if (selectedIndex == 3)
            {
                OpenCalculatorWindow();
            }

            else if (selectedIndex == 4)
            {
                OpenArrayWindow();
            }
        }

        static void OpenFirstExpressionWindow()
        {
            Console.Clear();
            Console.WriteLine("Рассчитать первое математическое выражение\n");
            Console.WriteLine("Введите значения:");
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            double c = Convert.ToDouble(Console.ReadLine());

            MathFirstExpressionClass mfec = new MathFirstExpressionClass();

            double res = mfec.CalculateFirstExpression(a, b, c);

            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Ответ на выражение = {res}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
            Main();
        }

        static void OpenSecondExpressionWindow()
        {
            Console.Clear();
            Console.WriteLine("Рассчитать второе математическое выражение\n");
            Console.WriteLine("Введите значения:");

            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            MathSecondExpressionClass msec = new MathSecondExpressionClass();

            double res = msec.CalculateSecondExpression(a, b);
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Ответ на выражение = {res}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
            Main();
        }

        static void OpenFunctionTabulationWindow()
        {
            Console.Clear();
            Console.WriteLine("Табулирование функции");
            Console.WriteLine("Введите значения:");

            Console.Write("Начальное значение = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Конечное значение = ");
            int b = Convert.ToInt32(Console.ReadLine());

            TabMathFuctionClass tabulator = new TabMathFuctionClass();
            string[] result = tabulator.CalculateTabMathFuction(a, b);

            Console.WriteLine("\n|  x   |    F(x)    |");
            Console.WriteLine("|------|------------|");

            for (int i = 0; i < result.Length; i++)
            {
                int xValue = a + i;
                Console.WriteLine("| {0,4} | {1,10} |", xValue, result[i]);
            }

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
            Main();
        }

        static void OpenCalculatorWindow()
        {
            Console.Clear();
            Console.WriteLine("Калькулятор");
            Console.WriteLine("Введите значения:");

            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            CalculateClass calc = new CalculateClass();

            double summ = calc.CalculateSumma(a, b);
            double diff = calc.CalculateDifference(a, b);
            double mult = calc.CalculateMultiplication(a, b);
            double quot = calc.CalculateQuotient(a, b);
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Сумма = {summ}");
            Console.WriteLine($"Разность = {diff}");
            Console.WriteLine($"Происзведение = {mult}");
            Console.WriteLine($"Разность = {quot}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
            Main();
        }

        static void OpenArrayWindow()
        {
            Console.Clear();
            Console.WriteLine("Обработка массива");
            Console.WriteLine("Введите значения:");

            Console.WriteLine("Введите значения массива через запятую: ");
            string input = Console.ReadLine();
            string[] arr_str = input.Split(',');
            int[] arr = arr_str.Select(str => int.Parse(str)).ToArray();


            ArrayClass arr_cl = new ArrayClass();

            int min = arr_cl.CalculateMinimum(arr);
            int max = arr_cl.CalculateMaximum(arr);
            double aver = arr_cl.CalculateAverage(arr);
            double med = arr_cl.CalculateMedian(arr);
            int even = arr_cl.CalculateNumberOfEven(arr);
            int odd = arr_cl.CalculateNumberOfOdd(arr);
            int bytwo = arr_cl.SignsOfDivisibilityByTwo(arr);
            int bythree = arr_cl.SignsOfDivisibilityByThree(arr);
            int byfive = arr_cl.SignsOfDivisibilityByFive(arr);
            int byten = arr_cl.SignsOfDivisibilityByTen(arr);


            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Average = {aver}");
            Console.WriteLine($"Mediana = {med}");
            Console.WriteLine($"Even = {even}");
            Console.WriteLine($"Odd = {odd}");
            Console.WriteLine($"Div by two = {bytwo}");
            Console.WriteLine($"Div by tree = {bythree}");
            Console.WriteLine($"Div by five = {byfive}");
            Console.WriteLine($"Div by ten = {byten}");

            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();
            Main();
        }
    }
}
