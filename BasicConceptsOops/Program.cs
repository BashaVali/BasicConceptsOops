using BasicConceptsOops.Inheriatance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicConceptsOops
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welecome To Practice Problems");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("****** Basic Concepts Oops ******");

                Console.WriteLine(" Select the option ");

                Console.WriteLine("1.Method Overloading" + "\n" +
                                  "2.Method Overrinding" + "\n" +
                                  "3.Inheritance"+ "\n" +
                                  "4.Exit" + "\n");
                int check = Convert.ToInt32(Console.ReadLine());
                MethodOverLoading method = new MethodOverLoading();
                switch (check)
                {
                    case 1:
                        int sum = method.Add(2, 4, 6);
                        Console.WriteLine("sum of the three "
                                          + "integer value : " + sum);
                        double doubleSum = method.Add(1.0, 2.4, 3.0);
                        Console.WriteLine("sum of the three "
                                          + "double value : " + doubleSum);
                        break;
                    case 2:
                        Animal myAnimal = new Animal();  // Create a Animal object
                        Animal myCat = new Cat();  // Create a Cat object
                        Animal myDog = new Dog();  // Create a Dog object
                        myAnimal.animalSound();
                        myCat.animalSound();
                        myDog.animalSound();
                        break;
                    case 3:
                        // Create a myCar object
                        Car myCar = new Car();

                        // Call the honk() method (From the Vehicle class) on the myCar object
                        myCar.honk();

                        // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
                        Console.WriteLine(myCar.brand + " " + myCar.modelName);
                        break;
                    case 4:
                        flag = false;
                        break;
                }
            }
        }
    }
}
