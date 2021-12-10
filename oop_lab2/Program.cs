using System;
using System.Text;
using System.Linq;

namespace oop_lab2
{
    class Program
    {
        static void Main(string[] args) //основной метод который срабатывает при старте программы
        {
            //ТИПЫ, все возможные примитивные типы
            bool bool1 = false;
            System.Boolean bool2 = true;
            Console.WriteLine(bool1 ? "Checked" : "Not checked");
            Console.WriteLine(bool2 ? "Checked" : "Not checked" + "\n");

            byte b1 = 9;  //целые от 0 до 255 
            System.Byte b2;
            Console.WriteLine("b1 = " + b1);
            Console.WriteLine("Enter value b2");
            b2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("b2 = " + b2);

            sbyte b3 = -111;  //целые от -128 до 127 
            System.SByte b4;
            Console.WriteLine("b3 = " + b3);
            Console.WriteLine("Enter value b4");
            b4 = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine("b4 = " + b4);

            char a = 'A';
            System.Char c;
            Console.WriteLine("a = " + a);
            Console.WriteLine("Enter value c");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("c = " + c);

            decimal dencimalnum = 3_000.5m;  // имеет значение от ±1.0*10-28 до ±7.9228*1028
            System.Decimal dencimalnum2;
            Console.WriteLine("dencimalnum = " + dencimalnum);
            Console.WriteLine("Enter value dencimalnum2");
            dencimalnum2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("dencimalnum2 = " + dencimalnum2);

            double doublenum = 3D;  // имеет значение от ±5.0 × 10−324 до ±1.7 × 10308
            System.Double doublenum2;
            Console.WriteLine("doublenum = " + doublenum);
            Console.WriteLine("Enter value doublenum2");
            doublenum2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("doublenum2 = " + doublenum2);

            float floatnum = 1.003f;  // имеет значение от ±1.5 x 10−45 до ±3.4 x 1038
            System.Single floatnum2;
            Console.WriteLine("floatnum = " + floatnum);
            Console.WriteLine("Enter value floatnum2");
            floatnum2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("floatnum2 = " + floatnum2);

            int inta = -112;
            System.Int32 inta2;
            Console.WriteLine("inta = " + inta);
            Console.WriteLine("Enter value inta2");
            inta2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inta2 = " + inta2);

            uint uinta = 112;  //только положительные
            System.UInt32 uinta2;
            Console.WriteLine("uinta = " + uinta);
            Console.WriteLine("Enter value uinta2");
            uinta2 = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("uinta2 = " + uinta2);

            long longa = -11594592;
            System.Int64 longa2;
            Console.WriteLine("longa = " + longa);
            Console.WriteLine("Enter value longa2");
            longa2 = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("longa2 = " + longa2);

            ulong ulonga = 11594592;
            System.UInt64 ulonga2;
            Console.WriteLine("ulonga = " + ulonga);
            Console.WriteLine("Enter value ulonga2");
            ulonga2 = Convert.ToUInt64(Console.ReadLine());
            Console.WriteLine("ulonga2 = " + ulonga2);


            //преобразования базовых типов данных

            //неявные(от беззнакового меньшей разрядности к беззнаковому большей)
            byte q = 4;             // 0000100
            ushort w = q;   // 000000000000100
            Int16 var16 = 134;
            Int32 var32 = var16;
            Int64 var64 = var32;
            //явные(указываем в скобках тип к которому хотим привести)
            int z1 = 4;
            int z2 = 6;
            byte z3 = (byte)(z1 + z2);
            Int64 variable64 = 19942;
            Int32 variable32 = (Int32)variable64;
            Int16 variable16 = (Int16)variable32;



            int price = 39;
            Object obj = price;//упаковка значимых типов(преобразование значимого в object)

            int price2 = (int)obj;//Распаковка значимых типов явно

            //Работа с неявно типизированной переменной
            var varVariable = 2;
            var Vvvvariable = 1;

            //Nullable переменная
            int? nullVariable = null;
            if (nullVariable.HasValue)
                Console.WriteLine("значение nullable переменной: ", nullVariable);
            else
                Console.WriteLine("значение nullable переменной отсутствует");


            //СТРОКИ
            string string1 = "Hellow";
            string string2 = "Bye";
            if (string1 == string2)
            {
                Console.WriteLine("Строки равны");
            }
            else
            {
                Console.WriteLine("Строки не равны");
            }


            //b
            string string3 = "Господи";
            string string4 = "Помоги";
            string string5 = "Сдать сессию";
            string emptyString = "";

            Console.WriteLine(string3 + string5);
            Console.WriteLine(String.Concat(string4, string5)); //объединение

            emptyString = String.Copy(string2);
            Console.Write(emptyString + " ");

            Console.WriteLine(string5.Substring(0, 8));//выделение подстроки 

            string[] words = string3.Split(' ');
            foreach (string s in words)
                Console.Write(s + ".");
            Console.WriteLine();

            Console.WriteLine(string5.Insert(string5.Length, string4)); //вставки подстроки в заданную позицию

            Console.WriteLine(string3.Remove(0, 4));//удаление

            Console.WriteLine($"У студентов БГТУ: {string4}"); //интерполирование строк


            //c
            string string6 = null;
            string string7 = "";
            if (string.IsNullOrEmpty(string6) && string.IsNullOrEmpty(string7)) //проверяет действительно ли строка пустая или null
            {
                Console.WriteLine("Обе строки пусты или нулевые");
            }



            StringBuilder sb = new StringBuilder("Слово");//Предоставляет изменяемую строку символов
            sb.Remove(0, 2); //удаление
            sb.Insert(0, "Сло");
            Console.WriteLine(sb);



            //МАССИВЫ
            int[,] matrix = { { 2, 6, 7, 2 }, { 6, 1, 2, 0 }, { 2, 1, 2, 6 }, { 7, 8, 0, 9 } };
            int rows = matrix.GetUpperBound(0) + 1;
            int cols = matrix.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]}  ");
                }
                Console.WriteLine();
            }


            //b
            string[] stringArray = new string[] { "Я", "не знаю", "как", "допуститься", "к экзамену", "по ООП" };
            foreach (string elOfArr in stringArray)
            {
                Console.Write(elOfArr + " ");
            }
            Console.WriteLine();
            Console.WriteLine("длина массива строк: ", stringArray.Length);
            Int32 numberOfString = Int32.Parse(Console.ReadLine()) - 1;
            String string8 = Console.ReadLine();
            stringArray[numberOfString] = string8;
            Console.Write("Новый массив строк: ");
            foreach (string elOfArr in stringArray)
            {
                Console.Write(elOfArr + " ");
            }
            Console.WriteLine();


            //c
            int[][] A = { new int[2], new int[3], new int[4] };
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A[i].Length; j++)
                {
                    A[i][j] = Int32.Parse(Console.ReadLine());
                }
            }
            foreach (int[] x in A)
            {
                foreach (int b in x)
                    Console.Write(" " + b);
                Console.WriteLine();
            }

            //d, типизированные переменные для хранения массива и строки
            var myArr = new float[6];
            var myStr = "sadasd";




            //КОРТЕЖИ
            (int, string, char, string, ulong) tuple = (12, "gjkd", 'a', "oop", 12319249249219);

            Console.WriteLine("Кортеж целиком: " + tuple);
            Console.WriteLine(tuple.Item1 + " " + tuple.Item3 + " " + tuple.Item4);




            //ЗАДАНИЕ 5
            Tuple<int, int, int, char> MyFunction(int[] myArray, string str9)
            {
                return new Tuple<int, int, int, char>(myArray.Max(), myArray.Min(), myArray.Sum(), str9[0]);
            }

            int[] Array = { 1, 2, 4, 3 };
            string str10 = "qwertyuiop";
            Console.WriteLine(MyFunction(Array, str10));


            //ЗАДАНИЕ 6, переполнение игнорируется при вычислении конкретного выражения

            void uncheckedTest()
            {
                unchecked
                {
                    var left = int.MaxValue + 1;
                    Console.WriteLine(left);
                }
            }



            uncheckedTest();
        }
    }
}
