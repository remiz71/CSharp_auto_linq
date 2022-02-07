using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_auto_linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание списка авто
            List<Car> carlist = new List<Car>
            {
                new Car("Lada Priora",450000,94),
                new Car("Mini Cooper S", 545000, 187),
                new Car("Lamborgini Countach", 11000000, 560),
                new Car("Tesla Model S", 14000000, 1095),
                new Car("Kia Rio", 460000, 105),
                new Car("Hyundai Solaris", 850000, 99)
            };
            // Вывод на экран списка авто
            carlist.ForEach(delegate (Car car) { Console.WriteLine(car); });
            Console.WriteLine();
            //Выборка авто с ценой более 1М рублей
            var price_result = from car in carlist where car.Cost > 1000000 select car;
            // Вывод на экран выборки
            Console.WriteLine("Автомобили с ценой свыше 1 миллиона рублей: ");
            price_result.ToList().ForEach(car => Console.WriteLine(car));
            //Группировка по мощности
            var under95hp_query = from car in carlist group car by car.HorsePower < 95 into CarsUnder95HP select CarsUnder95HP;
            var c95_135hp_query = from car in carlist group car by (car.HorsePower > 95 && car.HorsePower<130) into Cars95_130HP select Cars95_130HP;
            var upper135hp_query = from car in carlist group car by car.HorsePower>130 into Cars130HP select Cars130HP;
            // не смог реализовать красивый вывод(((
            // Сортировка по цене
            Console.WriteLine();
            var Sort_result = from car in carlist orderby car.Cost select car;
            Console.WriteLine("Авто, отсортированные по цене: ");
            Sort_result.ToList().ForEach(car => Console.WriteLine(car));
            Console.WriteLine();
            // Сортировка по мощности
            Sort_result = from car in carlist orderby car.HorsePower select car;
            Console.WriteLine("Авто, отсортированные по мощности: ");
            Sort_result.ToList().ForEach(car => Console.WriteLine(car));
            Console.WriteLine();

        }
    }
}
