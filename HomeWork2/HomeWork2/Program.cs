using System;
using System.ComponentModel;
using System.Drawing;
using Model;

namespace HomeWork2
{
     class Program
    {
        private static void Main(string[] args)
        {
            Car car1 = new Car("Lada Sedan", 'D');
            car1.Color=Color.FromArgb(35, 3, 43);
            try
            {
                Console.WriteLine("Driver's name is"+ car1.CarPassport.Owner.Name);
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Impossible to show driver's name. " +
                                        "It hasn't been specified yet"); }
            Driver driver1 = new Driver(new DateTime(2006, 12, 04), "Voldemar");
                driver1.Category = "BC";
            car1.ChangeOwner(driver1, "o777oo");
            driver1.Category = driver1.Category.Insert(2,"D"); 
            driver1.OwnCar(car1);
            Console.WriteLine(driver1.Car.CarNumber);
            Console.WriteLine(car1.CarPassport.Owner.Name);
            
            Console.ReadKey();
        }
    }
}
