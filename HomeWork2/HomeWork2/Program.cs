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

            var driver1 = new Driver(new DateTime(2007, 1, 11), "Voldemar");
            driver1.Category = "BC";
            try
            {
                car1.ChangeOwner(driver1, "o777oo");
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }
           
            driver1.Category = driver1.Category.Insert(2, "D");
            try
            {
                car1.ChangeOwner(driver1, "o777oo"); 
            }
            catch (CategoryOfDriverException)
            {
                
                Console.WriteLine("Driver has no needed category to rule this car.");
            }
            
            Console.WriteLine("Car number: "+ driver1.Car.CarNumber);
            Console.WriteLine("Owner's name: " + car1.CarPassport.Owner.Name);
            Console.WriteLine("Driver has experience of {0} years", driver1.Experience);

            Console.ReadKey();
        }
    }
}
