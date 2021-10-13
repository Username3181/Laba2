using System;
using System.Text;

namespace Laba2
{
    class Program
    {
        private static readonly bool c1;

        [Obsolete]
        static void Main(string[] args)
        {
            bool one = true;
            bool two = false;
            byte thre = 0;
            sbyte four = -128;
            short five = -32768;
            ushort six = 65535;
            int seven = -2147483648;
            uint eight = 4294967295;
            long nine = -9223372036854775808;
            ulong ten = 18446744073709551615;
            float eleven = 5555555555555555555.0f;
            double twelve = 7777777777777777777;
            decimal onethree = 999999999999999999.0m;
            char onefor = 'а';

            dynamic fever = 0;
            string sixtonn = "Hello";
            object oneseven = 3.14;
            object neard = "Омпьютер";

            Console.WriteLine("Типы данных в C#:" + "\n");
            Console.WriteLine("bool " + one);
            Console.WriteLine("bool " + two);
            Console.WriteLine("byte " + thre);
            Console.WriteLine("sbyte " + four);
            Console.WriteLine("short " + five);
            Console.WriteLine("ushort " + six);
            Console.WriteLine("int " + seven);
            Console.WriteLine("uint " + eight);
            Console.WriteLine("long " + nine);
            Console.WriteLine("ulong " + ten);
            Console.WriteLine("float " + eleven);
            Console.WriteLine("double " + twelve);
            Console.WriteLine("decimal " + onethree);
            Console.WriteLine("char " + onefor);
            Console.WriteLine("dynamic " + fever);
            Console.WriteLine("string " + sixtonn);
            Console.WriteLine("object " + oneseven);
            Console.WriteLine("object " + neard);

            Console.WriteLine("Неявное приведение типов в C#:");
            int a = 5;
            float b = a;
            Console.WriteLine(a);

            Console.WriteLine("Явное приведение типов в C#:");
            int c = 2;
            byte d = (byte)c;
            Console.WriteLine(c);
            Console.WriteLine("Упаковка в C#:");
            int a1 = 7;
            object b1 = a1;
            Console.WriteLine(b1);
            Console.WriteLine("Распаковка в C#:");
            int с1 = (int)b1;
            Console.WriteLine(с1);
            Console.WriteLine("Неявно типизированная переменная в C#:");
            var a2 = 5;
            Console.WriteLine("Является типом: " + a2.GetType());
            Console.WriteLine("Пример работы с Nullable в C#:");
            int a5 = 5;
            int? b5 = 7;
            int? result = a5 + b5;
            Console.WriteLine(a5 == b5);
            Console.WriteLine("Другой тип у var в C#:");
            var a32 = 5;
            float a35 = a32;
            Console.WriteLine(a35);
            /////////////////////////////////////////////////////////////////////
            string s1 = "аааааа";
            string s2 = "бббббб";

            int s3 = String.Compare(s1, s2);
            if (s3 < 0)
            {
                Console.WriteLine("Строка s1 перед строкой s2");
            }
            else if (s3 > 0)
            {
                Console.WriteLine("Строка s1 стоит после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }
            string s11 = "Слово";
            string s22 = "Текст";
            string s33 = "Буква";
            Console.WriteLine("Сцепление: " + string.Concat(s11, s22));
            string s44 = string.Copy(s33);
            Console.WriteLine("Копирование: " + s44);
            /////////////////////////////////////////
            string subString = "у";
            int indexOfSubstring = s33.IndexOf(subString);
            Console.WriteLine("Выделение подстроки: " + indexOfSubstring);
            ///////////////////////////////////////////////////
            Console.WriteLine("Вставка подстроки в заданную позицию: " + s11.Insert(4, s22));
            Console.WriteLine("Удаление заданной подстроки: " + s22.Remove(4));
            ///////////////////////////////////////////////////
            string[] s55 = s11.Split(new char[] { 'о' });
            Console.WriteLine("Разделение строки на слова: ");
            foreach (string h in s55) { Console.WriteLine(h); }
            ///////////////////////////////////////////////////
            string nullString = null; // значение null. Строка без значений. Ни на что не ссылается
            var b8 = string.IsNullOrEmpty(nullString); //true
            var b2 = string.IsNullOrEmpty("Строка"); // false
            Console.WriteLine("IsNullOrEmpty");
            Console.WriteLine(b8);
            Console.WriteLine(b2);
            Console.WriteLine("15");
            string whiteString = "\t   \r\n"; //пробелы
            var b3 = string.IsNullOrWhiteSpace(whiteString); //true
            var b4 = string.IsNullOrWhiteSpace("СтрокаБезПробелов"); // false
            Console.WriteLine("IsNullOrWhiteSpace");
            Console.WriteLine(b3);
            Console.WriteLine(b4);
            StringBuilder hh = new StringBuilder("Я еду паркурить");
            hh.Append("!");
            hh.Insert(2, "потом ");
            Console.WriteLine(hh);
            // Замена слов
            hh.Replace("еду", "иду");
            Console.WriteLine(hh);
            // Удаление 3 символов, начиная с 12-го 
            hh.Remove(12, 3);
            Console.WriteLine(hh);
            /////////////////////////////////////////////////////////////////////
            int[,] massiv = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 9, 10 } };

            int rows = massiv.GetUpperBound(0) + 1; // Возвращает индекс последнего элемента в определенной размерности
            int columns = massiv.Length / rows; // Количество элементов в каждой строке

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{massiv[i, j]} \t"); // Интерполяция
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            ////////////////////////////////////////////////////////////////////
            int[] mass = { 1, 2, 3, 4, 5 };
            int y = mass.Length;
            int l = 0;
            while (l < 5)
            {
                Console.WriteLine(mass[l]);
                l++;
            }
            Console.WriteLine();
            int t = 0;
            Console.WriteLine("Всего элементов в массиве: " + y + "\n");
            Console.WriteLine("Введите номер элемента массива: ");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("На какое хотите поменять?");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            while (t < 5)
            {
                if (y1 >= 0 && y1 <= 5 && y1 == mass[t])
                    Console.Write(y2 + "\n");
                else if (y1 >= 0 && y1 <= 5 && y1 == mass[t])
                    t--;
                else
                    Console.WriteLine(mass[t]);
                t++;
            }
            Console.WriteLine();
            ////////////////////////////////////////////////////////
            Console.Write("Введите любые числа 9 раз: ");
            int p = Convert.ToInt32(Console.ReadLine());
            int p1 = Convert.ToInt32(Console.ReadLine());
            int p2 = Convert.ToInt32(Console.ReadLine());
            int p3 = Convert.ToInt32(Console.ReadLine());
            int p4 = Convert.ToInt32(Console.ReadLine());
            int p5 = Convert.ToInt32(Console.ReadLine());
            int p6 = Convert.ToInt32(Console.ReadLine());
            int p7 = Convert.ToInt32(Console.ReadLine());
            int p8 = Convert.ToInt32(Console.ReadLine());
            int[][] mas3 = new int[3][];
            mas3[0] = new int[] { p, p1, };
            mas3[1] = new int[] { p2, p3, p4 };
            mas3[2] = new int[] { p5, p6, p7, p8 };
            for (int n = 0; n < mas3.Length; n++)
            {
                Console.Write("Ряд({0}): ", n);
                for (int k = 0; k < mas3[n].Length; k++)
                {
                    Console.Write("{0} ", mas3[n][k]);
                }
                Console.WriteLine();
            }
            /////////////////////////////////////////////////
            var array = new object[0];
            var str = "";
            /////////////////////////////////////////////////
            (int, int) t1 = (5, 7);
            (string, string) t2 = ("Текст", "Буква");
            (char, char) t3 = ('Т', 'Н');
            (string, string) t4 = ("Слово", "Запятая");
            (ulong, ulong) t5 = (18446744073709551615, 18446744073709551614);
            Console.WriteLine($"Кортеж целиком: {t1}   {t2}   {t3}   {t4}   {t5}");
            Console.WriteLine($"Кортеж выборочно: {t1}   {t3}   {t4} ");
            //////////////////////////////////////////////////
            int a77, b77;
            (a77, b77) = (1, 2); // упаковка кортежей
            (float a, int b) t11 = (1.0f, 42); // упаковка кортежей
            (int c, double d) t22 = (1, 42);
            Console.WriteLine(t11 == t22); // сравнение кортежей
            /////////////////////////////////////////////////////
            string a50 = "Func3";
            int[] b50 = { 1, 2, 3 };
            var p50 = Func3(a50, b50);
            Console.WriteLine($"{p50}");
            
            ////////////////////////////////////////////////////
            Func1();
            Func2();
        }
        static object Func3(string str99, int[] arr)
        {
            int max = arr[0], min = arr[0], sum = 0;
            foreach (int s in arr)
            {
                if (s > max)
                {
                    max = s;
                }
                if (s < min)
                {
                    min = s;
                }
                sum += s;
            }
            var sort = (max, min, sum, str99[0]);
            return sort;
        }
        static void Func1()
        {
            int a99 = checked(123);
            Console.WriteLine(a99);
        }
        static void Func2()
        {
            int a99 = unchecked(123 + 77);
            Console.WriteLine(a99);
        }
    }
}
