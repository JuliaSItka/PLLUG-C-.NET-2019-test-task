using System;
using System.Collections.Generic;
using System.Text;
using MySphere;

namespace MyCilinder
{
    class Cylinder:Sphere
    {
        public static double HeightCilinder;

        public static void SizeOfCilinder()
        {
            try
            {
                Console.WriteLine("Яка висота холодильника ---> ");
                HeightCilinder = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Некоректно введенi данi");
                SizeOfCilinder();

            }


        }
    }
}
