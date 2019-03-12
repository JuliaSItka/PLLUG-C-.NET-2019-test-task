using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int frig, door;
            int high, weigh, r_frige, d_h, d_w, r_door, weigh2;
            Console.WriteLine("Привiт. Розкажи нам про свiй холодильник");
            Console.WriteLine("1. Мiй холодильник прямокутний");
            Console.WriteLine("2. Мiй холодильник чомусь круглий");
             frig = int.Parse(Console.ReadLine());
            Console.WriteLine("Ок, супер. Тепер скажи якi ж y тебе дверi ");
            Console.WriteLine("1.Та звичайнi дверi - прямкутнi");
            Console.WriteLine("2.Ексклюзивнi вiд iталiйського дизайнера - кругленькi ;)");
             door = int.Parse(Console.ReadLine());

            if (frig == 1)
            {
                Console.Write("Яка висота у твого малиша-холодильника? ---> ");
                high = int.Parse(Console.ReadLine());
                Console.Write("А яка ширина лицьової сторони? ---> ");
                weigh = int.Parse(Console.ReadLine());
                Console.Write("А яка ширина збоку? ---> ");
                weigh2 = int.Parse(Console.ReadLine());

                if (door == 1)  //якщо двері та  холодильник прямокутні
                {
                    Console.Write("Висота дверей ---> ");
                    d_h = int.Parse(Console.ReadLine());
                    Console.Write("А  ширина? ---> ");
                    d_w = int.Parse(Console.ReadLine());

                    if (door == 1 && frig == 1)
                    {
                        if ((d_h > high && d_w > weigh) || (d_h > high && d_w > weigh2)) 
                            Console.WriteLine("Все супер! Переносiть свiй холодильник у стоячому положеннi");

                        else if ( (d_w > weigh2 && d_h >weigh) || (d_h > weigh2 && d_w > weigh) )
                            Console.WriteLine("Переносiть холодильник лежачим на бочку");
                        else Console.WriteLine("Ваш холодильник занадто товстий  або зависокий :( ");
                    }
                }
                if (door == 2)
                {
                     Console.Write("Який радiус дверей? ---> ");
                     r_door = int.Parse(Console.ReadLine());
                    int d = r_door * 2;
                    if ((d > weigh && d > high )|| (d>weigh2 && d>high))
                    
                        Console.WriteLine("Трiшки дивно, але виносiть");
                    
                   else  Console.WriteLine("На жаль, не получиться винести ");

                }
            }
            if (frig == 2)
            {
                Console.Write("Який радiус холодильника? ---> ");
                r_frige = int.Parse(Console.ReadLine());
                int d = r_frige * 2;
                if (door == 1)
                {
                    Console.Write("Висота дверей ---> ");
                    d_h = int.Parse(Console.ReadLine());
                    Console.Write("А  ширина? ---> ");
                    d_w = int.Parse(Console.ReadLine());
                    if (d_h > d && d_w > d)
                        Console.WriteLine("Трiшки дивно, але виносiть");

                    else Console.WriteLine("На жаль, не получиться винести ");
                }

                if (door == 2) {
                    Console.Write("Який радiус дверей? ---> ");
                    r_door = int.Parse(Console.ReadLine());
                    if (r_door > r_frige) Console.WriteLine("Викочуйте! :)");
                    else Console.WriteLine( " Нiчого не вийде :( ");
                }
            }

            Console.ReadLine();

        }

    }
}
