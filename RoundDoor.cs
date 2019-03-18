using System;
using System.Collections.Generic;
using System.Text;
using MyParallelepiped;
using MySphere;
using MyCilinder;

namespace MyRoudDoor
{


    class RoundDoor
    {
        public static double DiameterDoor;


        public static void SizeOfRoundDoor()
        {
            try
            {
                Console.Write("Який радiус дверей? ---> ");
                DiameterDoor = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Некоректно введенi данi");
                SizeOfRoundDoor();
               
            }

        }

        public static void FitParallepipedIntoRoundDoor()
        {
            if ((DiameterDoor > Parallelepiped.WidthFrig && DiameterDoor > Parallelepiped.HeightFrig) ||
                       (DiameterDoor > Parallelepiped.SideWidthFrig && DiameterDoor > Parallelepiped.HeightFrig))
            {
                Console.WriteLine("Трiшки дивно, але виносiть");
            }

            else
            {
                Console.WriteLine("На жаль, не получиться винести ");
            }
        }

        public static void FitSphereIntRoundDoor()
        {
            if (DiameterDoor > Sphere.DiameterFrige)
            {
                Console.WriteLine("Викочуйте! :)");
            }
            else
            {
                Console.WriteLine(" Нiчого не вийде :( ");
            }
        }

        public static void FitCilinderIntoRoundDoor()
        {
            if (DiameterDoor > MyCilinder.Cylinder.DiameterFrige || DiameterDoor > MyCilinder.Cylinder.HeightCilinder)
            {
                Console.WriteLine("Холодильник помiщається");
            }
            else
            {
                Console.WriteLine("Холодильник не помiщається");
            }

        }
    }
}

