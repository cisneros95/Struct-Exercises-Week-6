using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Exercises_Week_6
{

    struct CarProperties
    {

        public string name;
        public string eyeColor;
        public int age;
    
    
    }






    class Program
    {

        struct Car     //What properties makes the car

        {
            public string Brand;  // These are the properties

            public string Model;

            public int Year;

            public float Price;
                
        }

        struct Employee

        {
            public string Firstname;
            public string Lastname;
            public float HourlyWage;
            public bool completedTraining;


        }

        static void Main(string[] args)
        {

            //Variable
            Car car1;
            Car car2;
            Car car3;

            Console.Write("what's the brand? ");
            car1.Brand = Console.ReadLine();

            Console.Write("what is the model? ");
            car1.Model = Console.ReadLine();

            Console.Write("what's the year? ");
            car1.Year = int.Parse(Console.ReadLine() );

            Console.Write("What's the price? ");
            car1.Price = float.Parse(Console.ReadLine());







            Employee employee1;

            employee1.Firstname = "Nicholas";
            employee1.Lastname = "Dingle";
            employee1.HourlyWage = 35.7f;
            employee1.completedTraining = true;

        }
                   
    }
}
