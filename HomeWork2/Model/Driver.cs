using System;
using System.Linq;


namespace Model
{
    public class Driver
    {
        public int Years;
        public int Experience1;

        public Driver(DateTime licenceDate, string name) //передаем в параметр то, что вводится в консоли
        {
            LicenseDate = licenceDate;
            Name = name;
        }
        // свойства
        public int Experience 
        {
            get
            {
                TimeSpan timeSpan = DateTime.Now - LicenseDate;
                var years = timeSpan.Days/365;
                return years;
            }
          } 
        public string Name { get; }
        public DateTime LicenseDate { get; } // значение licenceDate передается св-ву в конструкторе
        public string Category { get; set; }
        public Car Car { get; private set; }

        // methode:
        public void OwnCar(Car car) // ссылка на объект
        {
             //исключение:
            if (Category.Contains(car.Category)) // определяет, все ли элемены есть в списке
            {
                Car = car; // должно ли быть автоматическое закрепление машины за водителем?
            }
            else
            {
                throw new Exception("Driver has no received category!");
            }
        }
    }
 
}
