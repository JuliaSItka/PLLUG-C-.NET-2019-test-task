using System;
using MyDoor;
using MyRoudDoor;
using MyCilinder;
using MyParallelepiped;
using MySphere;


namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            double frig, door;
            while (true)
            {
                try
                {
                    Console.WriteLine("Привiт. Розкажи нам про свiй холодильник");
                    Console.WriteLine("1. Мiй холодильник прямокутний");
                    Console.WriteLine("2. Мiй холодильник чомусь круглий");
                    Console.WriteLine("3. Вiн як бочечка ");
                    frig = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Ок, супер. Тепер скажи якi ж y тебе дверi ");
                    Console.WriteLine("1. Та звичайнi дверi - прямкутнi");
                    Console.WriteLine("2. Ексклюзивнi вiд iталiйського дизайнера - кругленькi ;)");
                    door = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Некоректно введенi данi");
                    Console.ReadLine();
                    return;

                }

                if (door == 1)
                {
                    Door.SizeOfDoor();

                    if (frig == 1)
                    {
                        Parallelepiped.SizeOfFrige();
                        Door.FitParallepipedIntoDoor();
                    }

                    if (frig == 2)
                    {
                        Sphere.SizeOfSphere();
                        Door.FitSphereIntoDoor();
                    }

                    if (frig == 3)
                    {
                        MyCilinder.Cylinder.SizeOfSphere();
                        MyCilinder.Cylinder.SizeOfCilinder();
                        Door.FitCilinderIntoDoor();
                    }

                }

                if (door == 2)
                {
                    RoundDoor.SizeOfRoundDoor();

                    if (frig == 1)
                    {
                        Parallelepiped.SizeOfFrige();
                        RoundDoor.FitParallepipedIntoRoundDoor();
                    }

                    if (frig == 2)
                    {
                        Sphere.SizeOfSphere();
                        RoundDoor.FitSphereIntRoundDoor();
                    }

                    if (frig == 3)
                    {
                        MyCilinder.Cylinder.SizeOfSphere();
                        MyCilinder.Cylinder.SizeOfCilinder();
                        RoundDoor.FitCilinderIntoRoundDoor();

                    }
                }

                Console.ReadLine();

            }

        }
    }
}