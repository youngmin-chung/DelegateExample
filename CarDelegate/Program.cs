using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDelegate
{
    public class Car
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }

        private bool carIsDead;

        public Car() { }

        public Car(int CurrentSpeed, int MaxSpeed, string PetName)
        {
            this.CurrentSpeed = CurrentSpeed;
            this.MaxSpeed = MaxSpeed;
            this.PetName = PetName;
        }

        public delegate void CarEngineHandler(string msgForCaller);

        private CarEngineHandler listOfHandlers; //member variable of the delegate

        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers = methodToCall;
        }

        public void Accelerate(int Delta)
        {
            if (carIsDead)
            {
                if (listOfHandlers != null)
                    listOfHandlers("Sorry, this car is dead...");
            }
            else
            {
                CurrentSpeed += Delta;

                if ((MaxSpeed - CurrentSpeed) == 10 && listOfHandlers != null)
                {
                    listOfHandlers("Be carefull, Gone blow!");
                }

                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine("Current Speed is {0}", CurrentSpeed);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car cartype = new Car(10, 100, "BMW");

            cartype.RegisterWithCarEngine(new Car.CarEngineHandler(OnCarEngineevent));

            Console.WriteLine("***** Speeding up *****");
            for (int i = 0; i < 6; i++)
                cartype.Accelerate(20);
            Console.ReadLine();

        }

        private static void OnCarEngineevent(string msgForCaller)
        {
            Console.WriteLine("\n***** Message From Car Object *****");
            Console.WriteLine("=> {0}", msgForCaller);
            Console.WriteLine("***********************************\n");
        }
    }
}
