using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__2
{
    public class Car
    {
        private static int _idCounter = 0;
        public int Id { get; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public CarType Type { get; set; }

        public Car(string brand,string model,CarType type)
        {
            Id = ++_idCounter;
            Brand = brand;
            Model = model;
            Type = type;
        }
        public override string ToString()
        {
           return $"Id: {Id}, Brand: {Brand}, Model: {Model}, CarType: {Type}";
        }
    }
}
