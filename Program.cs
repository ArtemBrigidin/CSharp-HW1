using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --------------------------------------
            // 1
            // --------------------------------------

            //int a;
            //Console.Write("Введите число >> ");
            //a = Int32.Parse(Console.ReadLine());

            //    if (a % 3 == 0 && a % 5 != 0 && a != 0)
            //    {
            //    Console.WriteLine("Fizz");
            //    }
            //    else if (a % 5 == 0 && a % 3 != 0 && a != 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else if (a % 3 == 0 && a % 5 == 0 && a != 0)
            //    {
            //        Console.WriteLine("Fizz Buzz");
            //    }
            //    else if(a % 3 != 0 && a % 5 != 0 && a != 0 && a > 0 && a < 100)
            //    {
            //        Console.WriteLine(a);
            //    } 
            //    else if (a <= 0 || a > 100) { 
            //        Console.WriteLine("Ваше число \"" + a + "\" не находится в диапазоне 1 - 100");
            //    }

            // --------------------------------------
            // 2
            // --------------------------------------

            //float number, procent;
            //float result;
            //Console.Write("Введите число >> ");
            //number = Int32.Parse(Console.ReadLine());
            //Console.Write("Введите процент >> ");
            //procent = Int32.Parse(Console.ReadLine());
            //result = (number / 100) * procent;
            //Console.WriteLine("Результат = " + result);

            // --------------------------------------
            // 3
            // --------------------------------------

            //int one = Int32.Parse(Console.ReadLine());
            //int two = Int32.Parse(Console.ReadLine());
            //int three = Int32.Parse(Console.ReadLine());
            //int four = Int32.Parse(Console.ReadLine());
            //int result = one * 1000 + two * 100 + three * 10+four;
            //Console.WriteLine("Результат = " + result);

            // --------------------------------------
            // 4
            // --------------------------------------

            //int number = 0;
            //int pos_one = 0, pos_two = 0;
            //Console.Write("Введите 6-ти значное число >> ");
            //number = Int32.Parse(Console.ReadLine());
            //if (number > 999999 || number < 100000)
            //{
            //    Console.WriteLine("Вы ввели не 6-ти значное число. ");
            //}
            //else if (pos_one > 6)
            //    Console.WriteLine("Превышен диапазон");
            //else
            //{
            //    int[] digits = new int[number];
            //    digits[0] = (number / 100000) % 10;
            //    digits[1] = (number / 10000) % 10;
            //    digits[2] = (number / 1000) % 10;
            //    digits[3] = (number / 100) % 10;
            //    digits[4] = (number / 10) % 10;
            //    digits[5] = number % 10;
            //    Console.Write("Введите позицию первого числа которое хотите заменить >> ");
            //    pos_one = Int32.Parse(Console.ReadLine());
            //    Console.Write("Введите позицию второго числа которое хотите заменить >> ");
            //    pos_two = Int32.Parse(Console.ReadLine());
            //    int temp = digits[pos_one - 1];
            //    digits[pos_one - 1] = digits[pos_two - 1];
            //    digits[pos_two - 1] = temp;
            //    int result = digits[0] * 100000 + digits[1] * 10000 + digits[2] * 1000 + digits[3] * 100 + digits[4] * 10 + digits[5];
            //    Console.WriteLine(result);
            //}

            // --------------------------------------
            // 5
            // --------------------------------------

            //int year = 0;
            //int month = 0;
            //int day = 0;

            //Console.WriteLine("Введите год >>");
            //year = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Введите месяц >>");
            //month = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Введите день >>");
            //day = Int32.Parse(Console.ReadLine());

            //DateTime dt = new DateTime(year, month, day);

            //    switch (month)
            //    {
            //        case 12:
            //        case 1:
            //        case 2:
            //            Console.WriteLine("Зима " + dt.ToString("dddd"));
            //            break;
            //        case 3:
            //        case 4:
            //        case 5:
            //            Console.WriteLine("Весна " + dt.ToString("dddd"));
            //            break;
            //        case 6:
            //        case 7:
            //        case 8:
            //            Console.WriteLine("Лето " + dt.ToString("dddd"));
            //            break;
            //        case 9:
            //        case 10:
            //        case 11:
            //            Console.WriteLine("Осень " + dt.ToString("dddd"));
            //            break;
            //    }

            // --------------------------------------
            // 6
            // --------------------------------------

            //int choice = -1;
            //double cel = 0;
            //double fareng = 0;
            //Console.WriteLine("1. Из Цельсия в Фаренгейт");
            //Console.WriteLine("2. Из Фаренгейта в Цельсия");
            //Console.WriteLine("Ваш выбор >>");
            //choice = Int32.Parse(Console.ReadLine());
            //switch (choice) {
            //    case 1:
            //        Console.WriteLine("Введите температуру в цельсиях >>");
            //        cel = Int32.Parse(Console.ReadLine());
            //        fareng = (cel * 1.8) + 32;
            //        Console.WriteLine(fareng);
            //        break;
            //    case 2:
            //        Console.WriteLine("Введите температуру по Фаренгейту >>");
            //        fareng = Int32.Parse(Console.ReadLine());
            //        cel = (fareng - 32) / 1.8;
            //        Console.WriteLine(cel);
            //        break;
            //    case 0:
            //        break;
            //}

            // --------------------------------------
            // 7
            // --------------------------------------

            //int one, two, start = 0, end = 0;
            //Console.WriteLine("Введите первое число >>");
            //one = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Введите второе число >>");
            //two = Int32.Parse(Console.ReadLine());
            //if (one > two) {
            //    end = one;
            //    start = two;
            //}
            //else
            //{
            //    start = one;
            //    end = two;
            //}
            //for (int i = start; i <= end; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
        }
    }
}

