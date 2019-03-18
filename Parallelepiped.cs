using System;
using System.Collections.Generic;
using System.Text;

namespace MyParallelepiped
{
    class Parallelepiped
    {

        public static double WidthFrig;
        public static double SideWidthFrig;      
        public static double HeightFrig;


        public static void SizeOfFrige()
        {

            Height();
            Width();
            SideWidth();
        }

        private static void Height()
        {
            try
            {
                Console.Write("Яка висота у твого малиша-холодильника? ---> ");
                HeightFrig = Convert.ToDouble(Console.ReadLine());
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

                Console.Write("А яка ширина лицьової сторони? ---> ");
                WidthFrig = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Некоректно введенi данi");
                Width();
            }
        }

        private static void SideWidth()
        {

            try
            {
                Console.Write("А яка ширина збоку? ---> ");
                SideWidthFrig = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Некоректно введенi данi");
                SideWidth();
            }
        }
        
    }
}