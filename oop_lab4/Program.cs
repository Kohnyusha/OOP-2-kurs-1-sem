
                              
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lab4
{
    public class MyList<T> : List<T>
    {
        public class Owner
        {
            public int id { get; set; } //автоматические свойства
            public string name { get; set; }
            public string uni { get; set; }

            public Owner(int id, string name, string uni)
            {
                this.id = id;
                this.name = name;
                this.uni = uni;
            }
        }
        public class Data
        {
            public string data { get; set; }

            public Data(string data)
            {
                this.data = data;
            }
        }

        public static bool operator true(MyList<T> a) //перегрузка булевых операторов true и false
        {
            if (a.Capacity != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator false(MyList<T> a)
        {
            if (a.Capacity == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static MyList<T> operator +(MyList<T> a, MyList<T> b) //объединение списков
        {
            MyList<T> result = new MyList<T>();
            foreach (T item in a) result.Add(item);
            foreach (T item in b) result.Add(item);
            return result; //перегруженные операции обязаны возвращать значения
        }

        public static MyList<T> operator --(MyList<T> a) //удаляем элемент из начала
        {
            a.RemoveAt(0);
            return a;
        }


        public static bool operator ==(MyList<T> a, MyList<T> b) //проверка на равенство
        {
            return a.Equals(b);

        }
        public static bool operator !=(MyList<T> a, MyList<T> b) //проверка на неравенство
        {
            return !a.Equals(b);
        }


    }
    public static class StatisticOperation
    {
        static int count = 0;
        public static void Sum(MyList<string> a, MyList<string> b)
        {

            foreach (var item in a + b)
                Console.WriteLine(item);

            return;
        }

        public static void MinMax(MyList<int> a)
        {
            a.Sort();
            Console.WriteLine(a[a.Count - 1] - a[0]);
            return;
        }

        public static void Amount(MyList<string> a)
        {
            Console.WriteLine(a.Count);
            return;
        }
        public static void getLast(this string a) //Выделение последнего числа, содержащегося в строке
        {

            int indx = a.Length - 1;
            Console.WriteLine(a[indx].ToString());
            return;
        }
        public static void deleteElem(this MyList<string> a, int n) //Удаление заданного элемента из списка
        {

            if (n < a.Count)
            {
                a.RemoveAt(n);
            }
            else { Console.WriteLine("попробуйте другой индекс"); }
            foreach (var item in a)
                Console.WriteLine(item);
            return;

        }

    }
    class Program
    {



        static void Main(string[] args)
        {
            MyList<string> animal_1 = new MyList<string> { "1", "2" };

            MyList<string> animal_2 = new MyList<string> { "23234", "6", "677" };




            MyList<dynamic>.Owner own = new MyList<dynamic>.Owner(01, "Александра Кохнюк", "БГТУ");
            Console.WriteLine($"{own.id} - {own.name} - {own.uni} ");

            MyList<string>.Data date = new MyList<string>.Data("29/11/2021");
            Console.WriteLine($"{date.data} ");

            MyList<int> nums = new MyList<int> { 2, 456, 355, 2 };
            StatisticOperation.MinMax(nums);
            Console.WriteLine();

            StatisticOperation.Amount(animal_2);
            Console.WriteLine();

            String str = "HELLO";
            Console.WriteLine(str);
            str.getLast();
            Console.WriteLine();

            animal_2.deleteElem(2);

            foreach (var item in animal_2)
                Console.WriteLine(item);
            Console.WriteLine();


            StatisticOperation.Sum(animal_1, animal_2);
            Console.WriteLine();

            foreach (var item in animal_1 + animal_2)
                Console.WriteLine(item);
            Console.WriteLine();

            foreach (var item in --animal_2)
                Console.WriteLine(item);
            Console.WriteLine();

            if (animal_1 == animal_2)
            { Console.WriteLine("они равны"); }
            else { Console.WriteLine("они не равны"); }

            if (animal_1)
            {
                Console.WriteLine("в списке есть элементы");
            }
            else { Console.WriteLine("в списке нет элементов"); }



            Console.ReadKey();
        }


    }
}