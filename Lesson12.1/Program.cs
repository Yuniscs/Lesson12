using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12._1
{
    /*2.IVehicle interface yaradın.Tərkibində iki metod olsun. Drive və Refuel: Drive metodu 
     * void metoddu input parametri yoxdur. Refuel metodu geriye bool qaytaracaq və int tipinde 
     * amount parametr qəbul edəcək.Daha sonra Car class yaradın hansi ki tərkibində Fuel(yanacaq) 
     * int tipində property olacaq və constructorda mashinin bashlangic benzin parametrin qebul edir və
     * Fuel propertysin ona bərabər edəcək. Drive ve Refuel metodlarini da implement edir.Drive metodu
     * eger Fuel 0 dan boyukduse console mesaj cixaracaq-Car is driving Refuel metodu ise Fuel -i artiracag 
     * ve true qaytaracaq Test etmək ucun Car obyektini yaradin 0 yanacaq ilə.Və Refuel metodunu cagirib yanacagi 
     * artirin daha sonra ise Drive metodunu cagirin.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            int a =car.Refuel(0);
            car.Drive();
        }
        interface IVehicle
        {
            public void Drive();
            public bool Refuel(int amount);
        }
        class Car:IVehicle
        {
            public int Fuel;
            public Car()
            {
                int Fuel = 0;
            }

            void IVehicle.Drive()
            {
               if(Fuel > 0)
                {
                    Console.WriteLine("Car is driving");
                }
            }

            bool IVehicle.Refuel(int amount)
            {
                Fuel++;
                return true;
                
            }
        }
    }
}
