﻿

using System;
using System.Collections.Generic;
using System.Drawing;

namespace Model
{
    public class Car
    {
        public Car(string model, char category) // конструктор
        {
            CarPassport=new CarPassport(this); // создается автоматически
            Category = category;
            Model = model;
        }
        // Свойства:
        public string Model { get; }
        public  Color Color { get; set; } = Color.Blue;
        public string CarNumber { get; private set; } 
        public char Category { get; } 
        public CarPassport  CarPassport { get; } 
        // Метод:
        public void ChangeOwner(Driver newDriver, string newNumber)
        {
            CarPassport.Owner = newDriver; 
            newDriver.OwnCar(this); //не понимаю код/ разобраться!!! у нового драйвера вызыв код. this - вызов кода
            CarNumber = newNumber;
        }
    } 
}