using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opp_lab3
{
    public partial class car //partial - указывает на то, что другие части класса мб определены в пространстве имен
    {

        public static int id = 0;
        public string label { get; set; } = "none"; //марка, get, set - компилятор автоматически реализует методы и генерирует поля для свойств
        public string model { get; set; } = "none";
        private int year;
        public int Year
        {
            set
            {
                year = value;
            }
            get { return year; }


        }
        public string color { get; set; } = "none";
        public int price { get; set; } = 0;
        public readonly int regNum; //только для чтения
        public int car_age { get; set; } = 0;
        static int carCounter { get; set; } = 0; // статическое поле //классическое св-во //поля класса - это переменные, определенные на уровне класса

        public car() //конструкутор без аргументов
        {
            id++;

            label = "not found";
            model = "not found";
            year = 0;
            color = "not found";
            price = 0;
            regNum = 0000000;

            Console.WriteLine("пожалуйста, введите другую информацию");
        }

        public car(string label, string model, int year,
            string color, int price, int regNum) //закрытый конструктор
        {
            id++;

            this.label = label;
            this.model = model;
            this.year = year;
            this.color = color;
            this.price = price;
            this.regNum = regNum;
            car.addCar();

        }


        static car() //статический конструктор (конструктор типа)
        {
            Console.WriteLine("ПЕРВАЯ машина!");
        }
        public int carAge() //метод подсчета возраста машины
        {
            car_age = 2021 - year;
            Console.WriteLine($"возраст автомобиля {label}: " + car_age);
            return car_age;
        }
        static int addCar() //статический метод
        {
            if (carCounter == 0)
            {
                Console.WriteLine("в гараже есть машины");

            }
            return carCounter++;
        }

        public void about()
        {
            Console.WriteLine($"{id}\n{label}\n{model}\n{year}\n{color}\n{price}\n{regNum}\n\n");

        }

        public override int GetHashCode()
        {
            Console.WriteLine($"\nHASHCODE of car {this.label} is: {label.GetHashCode()}\n-------------------\n");
            return label.GetHashCode();
        }

        public override string ToString()
        {
            return $"{id} - {label} - {model} - {year} - {color} - {price} - {regNum}\n";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            car el = obj as car;
            if (el as car == null)
                return false;

            return el.label == this.label && el.model == this.model;
        }



        public const int wheels = 4; //поле-константа
        public static void Wheels(ref int wheels, out int wheels_out) //ref - значение до вызова, out - значение обяз до завершения
        {
            wheels_out = wheels;
        }


    }
    class Program
    {
        static void Main(string[] args) // статические поля
        {
            car car1 = new car();

            car car2 = new car("bmw", "v3", 2000, "black", 1000, 01234);

            car car3 = new car("volvo", "v56", 2005, "silver", 3400, 67329);
            car car4 = new car();
            car4.label = "reno";
            car4.Year = 2013;
            car car5 = new car("volvo", "v6", 2007, "red", 3790, 65748);



            car[] arrayOfCars = new car[] { car1, car2, car3, car4 };

            Console.WriteLine("введите марку автомобиля: ");
            string enter_label = Console.ReadLine();

            Console.WriteLine("введите год автомобиля: ");
            int enter_year = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < arrayOfCars.Length; i++)
            {
                if (arrayOfCars[i].label == enter_label)
                {

                }
            }

            for (int i = 0; i < arrayOfCars.Length; i++)
            {
                int yearWork = arrayOfCars[i].carAge();
                if (arrayOfCars[i].label == enter_label && yearWork > enter_year)
                {
                    Console.WriteLine(arrayOfCars[i]);
                }
            }

            var car_anon = new { label = "reno", model = "vx23", price = 4500, color = "red", regNum = 20309 };
            Console.WriteLine("авто: " + car_anon);

            Console.ReadKey();
        }

    }
}
