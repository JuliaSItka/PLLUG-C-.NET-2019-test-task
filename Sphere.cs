using System;
using System.Collections.Generic;
using System.Text;

namespace MySphere
{
  
    class Sphere
    {
        public static double DiameterFrige;

        public static void SizeOfSphere()
        {
            try
            {
                Console.Write("Який радiус холодильника? ---> ");
                DiameterFrige = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Некоректно введенi данi");
                SizeOfSphere();
            }
        }

    }
}
