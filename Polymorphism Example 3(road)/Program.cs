using System;

namespace PolymorphismExample3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stabilize the car speed!");
            Console.WriteLine("/*/*/*/*/AlleyStreet/*/*/*/*/*/*");
            
            // Creating an instance of Alleystreet class
            Alleystreet alleystreet = new Alleystreet();
            alleystreet.stabilizeCar();
            alleystreet.stabilizeCarslow();
            // Providing a warning to the driver to slow down and limit the speed to 50 in the alley street:

            Console.WriteLine("/*/*/*/*/Main Road/*/*/*/*/*/");
            
            // Creating an instance of mainRoad class
            mainRoad mainroad = new mainRoad();
            mainroad.stabilizeCar();
            // Modifying the method for the main road since the driver does not need to slow down and can maintain the current speed of 100:

            Console.WriteLine("/*/*/*/*/*/School Road/*/*/*/*/*/");
            
            // Creating an instance of Schoolroad class
            Schoolroad schoolroad = new Schoolroad();
            schoolroad.stabilizeCar();
            schoolroad.stabilizeCarslow();
            /* Driver is on the school road, so we inherit from the Stabilizethecarspeed class to inform the driver to slow down, 
            and then specify that they are on the school road and need to check both left and right. We made modifications to our method. */

        }
    }
}
