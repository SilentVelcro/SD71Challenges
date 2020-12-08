using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD71Challenge4
{
    abstract class Car   
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string VechileIdentificationNumber { get; set; }
        public string Color { get; set; }
        public abstract void TankDistance();
        public Car() { }
        public Car(string make, string model, int year, string vechileidentificationNumber, string color)
        {
            Make = make;
            Model = model;
            Year = year;
            VechileIdentificationNumber = vechileidentificationNumber;
            Color = color;
        }

    }
    class Sedan : Car
    {
       public int GasMileageSedan { get; set; }
       public Sedan() { }
        public override void TankDistance()
        {
            Console.WriteLine("Gets great gas mileage.");
        }
        
        public Sedan(int gasmileagesedan, string make, string model, int year, string vechileidentificationNumber, string color)
            : base(make, model, year, vechileidentificationNumber, color)
        {
            GasMileageSedan = gasmileagesedan;
        }

    }
    class Truck : Car
    {
        public double GasMileageTruck { get; set; }
        public override void TankDistance()
        {
            Console.WriteLine("Gets average gas mileage.");
        }
        public Truck() { }
        public Truck(double gasMileageTruck, string make, string model, int year, string vechileidentificationNumber, string color)
            : base(make, model, year, vechileidentificationNumber, color)
        {
            GasMileageTruck = gasMileageTruck;
        }
    } 
}
