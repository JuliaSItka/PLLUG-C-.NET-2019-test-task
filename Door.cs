using System;
using System.Collections.Generic;
using System.Text;
using MyParallelepiped;
using MySphere;

namespace MyDoor
{
   public class Door
    {
        public static double HeightDoor;
        public static double WidthDoor;

       
        public static void SizeOfDoor()
        {
            Height();
            Width();
        }


        private static void Height()
        {
            try
            {
                Console.Write("Висота дверей ---> ");
                HeightDoor = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Некоректно введенi данi");
                Height();
            }
        }


        private static void Width()
        {
            try
            {
                Console.Write("А  ширина? ---> ");
                WidthDoor = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Некоректно введенi данi");
                Width();

            }
        }

        public static void FitParallepipedIntoDoor() /// перевірка чи поміститься звичайний холодильник у прямокутні двері
        {
            if ((HeightDoor > Parallelepiped.HeightFrig && WidthDoor > Parallelepiped.WidthFrig) ||
                           (HeightDoor > Parallelepiped.HeightFrig && WidthDoor > Parallelepiped.SideWidthFrig))
            {
                Console.WriteLine("Все супер! Переносiть свiй холодильник у стоячому положеннi");
            }

            else if ((WidthDoor > Parallelepiped.SideWidthFrig && HeightDoor > Parallelepiped.WidthFrig) ||
                     (HeightDoor > Parallelepiped.SideWidthFrig && WidthDoor > Parallelepiped.WidthFrig))
            {
                Console.WriteLine("Переносiть холодильник лежачим на бочку");
            }
            else
            {
                Console.WriteLine("Ваш холодильник занадто товстий  або зависокий :( ");
            }
        }


        public static void FitSphereIntoDoor() /// перевірка чи поміститься сфера у прямокутні двері
        {
            if (HeightDoor > Sphere.DiameterFrige && WidthDoor > Sphere.DiameterFrige)
            {
                Console.WriteLine("Трiшки дивно, але виносiть");

            }

            else
            {
                Console.WriteLine("На жаль, не получиться винести ");
            }
        }


        public static void FitCilinderIntoDoor()
        {
            if ((HeightDoor > Sphere.DiameterFrige && WidthDoor > Sphere.DiameterFrige) ||
                    (HeightDoor > MyCilinder.Cylinder.HeightCilinder) ||
                    (WidthDoor > MyCilinder.Cylinder.HeightCilinder))
            {
                Console.WriteLine("Холодильник помiщається");
            }
            else
            {
                Console.WriteLine("Холодильник не помiщається ");
            }
        }    



    }
}
