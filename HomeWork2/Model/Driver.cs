using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Driver
    {
        public Driver(DateTime licenceDate, string name) //передаем в параметр то, что вводится в консоли
        {
            LicenceDate = licenceDate;
            Name = name;
        }
        // свойства
        public DateTime LicenceDate { get; } // значение licenceDate передается св-ву в конструкторе
        public string Name { get; }
        // лямбда-выраженияе:
        public int Expirience => DateTime.Now.Year - LicenceDate.Year; // это лямбда-выражение
        public string Category { get; set; }
        public Car Car { get; private set; }
        public void OwnCar(Car car) // ссылка на объект
        {
        // catch NullReferenceExp:
            if (Category.Contains(car.Category)) // определяет, все ли элемены есть в списке
            {
                Car = car; // должно ли быть автоматическое закрепление машины за водителем?
            }
            else
            {
                Console.WriteLine("Driver has no needed category");
            }
        }
    }
 
}
