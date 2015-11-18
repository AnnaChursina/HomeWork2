

namespace Model
{
    public class CarPassport
    {
        public Driver Owner { get; set; }
        public Car Car { get; }
        public CarPassport(Car car) //конструктор / не создавать лишних переменных для конструктора
        {
            Car = car; // ссылка на объект car1;
        }
    }
}
