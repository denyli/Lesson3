using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    // Ученик - Андрей Марачковский        
    class Program
    {
        #region Task 01
        public struct Complex
        {
            /// <summary>
            /// Действительная часть комплексного числа
            /// </summary>
            public double re;

            /// <summary>
            /// Мнимая часть комплексного числа
            /// </summary>
            public double im;

            public Complex Plus(Complex x)
            {
                Complex y;               
                y.re = re + x.re;
                y.im = im + x.im;
                return y;
            }

            public Complex Minus(Complex x)
            {
                Complex y;
                y.re = re - x.re;
                y.im = im - x.im;
                return y;
            }

            public Complex Umnojenie(Complex x)
            {
                Complex y;
                double res1;
                double res2;
                double resI1;
                double resI2;

                res1 = re * x.re; // комплексная часть
                res2 = -1 * (im * x.im); // i * i = -1
                resI1 = re * x.im; // с буквой
                resI2 = im * x.re; // с буквой 

                y.re = res1 + res2;
                y.im = resI1 + resI2;
                return y;
            }

            public override string ToString()
            {
                string res = ""; 
                string ims = "";
                if (re != 0)
                {
                    res = Convert.ToString(re);
                } 
                if (im != 0)
                {
                    ims = Convert.ToString(im) + "i";
                }
                return $"{res}" + (im > 0 ? "+" : "") + $"{ims}";
            }
        }

        static void Task01()
        {
            Complex comp1;
            Complex comp2;
            Complex result;
            float x1;
            float x2;

            Console.WriteLine("Сложение комплексных чисел!");
            Console.WriteLine("Введите первое комплексное число!");
            Console.Write("Введите действительную часть комплексного числа: ");
            string strFirst1 = Console.ReadLine();
            Console.Write("Введите мнимую часть комплексного числа: ");
            string strFirst2 = Console.ReadLine();

            x1 = Convert.ToSingle(strFirst1);
            x2 = Convert.ToSingle(strFirst2);

            comp1.re = x1;
            comp1.im = x2;

            Console.WriteLine($"Первое комплексное число: {comp1}");

            Console.WriteLine("Введите второе комплексное число!");
            Console.Write("Введите действительную часть комплексного числа: ");
            string strSecond1 = Console.ReadLine();
            Console.Write("Введите мнимую часть комплексного числа: ");
            string strSecond2 = Console.ReadLine();

            x1 = Convert.ToSingle(strSecond1);
            x2 = Convert.ToSingle(strSecond2);

            comp2.re = x1;
            comp2.im = x2;

            Console.WriteLine($"Второе комплексное число: {comp2}");

            result = comp1.Plus(comp2);
            Console.WriteLine($"Результат сложения: {result}");

            result = comp1.Minus(comp2);
            Console.WriteLine($"Результат вычитания: {result}");

            result = comp1.Umnojenie(comp2);
            Console.WriteLine($"Результат умножения: {result}");

            Console.ReadKey();
        }
        #endregion

        #region Task 02
        static void Task02()
        {
            int sum = 0;
            int a;
            do
            {
                Console.Write("Введите целое число: ");
                if (int.TryParse(Console.ReadLine(), out a))
                {
                    if (a % 2 != 0 && a > 0)
                    {
                        sum += a;
                    }
                }
                else
                {
                    throw new Exception("Неверный формат числа!");
                }
            }
            while (a != 0);
            Console.WriteLine($"Cумма всех нечетных положительных чисел: {sum}");

            Console.ReadKey();
        }
        #endregion
         
        #region Task 03
        class Drobi
        {
            public int a;
            public int b; // знаменотель дроби
            public Drobi()
            {

            }
            public Drobi Umnojenie(Drobi x)
            {
                Drobi res = new Drobi();
                res.a = a * x.a;
                res.b = b * x.b;
                return res;
            }
            public Drobi Delenie(Drobi x)
            {
                Drobi res = new Drobi();
                res.a = a * x.b;
                res.b = b * x.b;
                return res;
            }
            public Drobi Plus(Drobi x)
            {
                Drobi res = new Drobi();
                if (b == x.b)
                {
                    res.a = a + x.a;
                    res.b = x.b;
                }
                return res;
            }
            public Drobi Minus(Drobi x)
            {
                Drobi res = new Drobi();
                if (b == x.b)
                {
                    res.a = a - x.a;
                    res.b = x.b;
                }
                return res;
            }
            public override string ToString()
            {
                return $"({a}" + "/" + $"{b})";
            }

        }

        static void Task03()
        {
            Drobi drob1 = new Drobi();
            Drobi drob2 = new Drobi();
            Drobi res = new Drobi();
            Console.WriteLine("Задайте первую дробь!");
            Console.Write("Введите числитель первой дроби: ");
            if (!int.TryParse(Console.ReadLine(), out int x1)) throw new Exception("Неверный формат числителя дроби!");
            Console.Write("Введите знаменатель первой дроби: ");
            if (!int.TryParse(Console.ReadLine(), out int x2)) throw new Exception("Неверный формат знаменателя дроби!");

            Console.WriteLine("Задайте вторую дробь!");
            Console.Write("Введите числитель второй дроби: ");
            if (!int.TryParse(Console.ReadLine(), out int y1)) throw new Exception("Неверный формат числителя дроби!");
            Console.Write("Введите знаменатель второй дроби: ");
            if (!int.TryParse(Console.ReadLine(), out int y2)) throw new Exception("Неверный формат знаменателя дроби!");

            drob1.a = x1;
            drob1.b = x2;

            drob2.a = y1;
            drob2.b = y2;

            Console.WriteLine("Результаты!!!");
            res = drob1.Umnojenie(drob2);
            Console.WriteLine($"Результат умножения: {res}");
            res = drob1.Delenie(drob2);
            Console.WriteLine($"Результат деления: {res}");

            Console.Write("Введите числитель первой дроби: ");
            if (!int.TryParse(Console.ReadLine(), out int a1)) throw new Exception("Неверный формат числителя дроби!");
            Console.Write("Введите числитель второй дроби: ");
            if (!int.TryParse(Console.ReadLine(), out int b1)) throw new Exception("Неверный формат числителя дроби!");
            Console.Write("Введите общий числитель для обеих дробей: ");
            if (!int.TryParse(Console.ReadLine(), out int c1)) throw new Exception("Неверный формат числителя дроби!");

            drob1.a = a1;
            drob1.b = c1;

            drob2.a = b1;
            drob2.b = c1;

            res = drob1.Plus(drob2);
            Console.WriteLine($"Результат сложения: {res}");
            res = drob1.Minus(drob2);
            Console.WriteLine($"Результат вычитания: {res}");

            Console.ReadKey();
        }
        #endregion

        static void Main(string[] args)
        {
            bool isExit = false;
            do
            {
                int number;
                Console.Clear();
                Console.Write("Введите номер задания (1-3), либо число 0 для выхода: ");
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    number = 0;
                }
                switch (number)
                {
                    case 0:
                        isExit = true;
                        break;
                    case 1:
                        Console.Clear();
                        Task01();
                        break;
                    case 2:
                        Console.Clear();
                        Task02();
                        break;
                    case 3:
                        Console.Clear();
                        Task03();
                        break;
                }
            }
            while (!isExit);
        }
    }
}