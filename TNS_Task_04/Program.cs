using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNS_Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int boss = 100;
            int player = 100;
            int choose_player = 0;

            Dictionary<int, string> 
            spell = new Dictionary<int, string>(5);
            spell.Add(0, "1.Fire");
            spell.Add(1, "2.Water");
            spell.Add(2, "3.Earth");
            spell.Add(3, "4.Air");
            spell.Add(4, "5.Light");

            Console.WriteLine("Перед вами Босс Эйрох, атакуйте его заклинаниями на выбор: ");
            for ( int i = 0;  i< 5;  i++  )
            {
                Console.WriteLine(spell[i]);

            }
            Choose:
            choose_player = Convert.ToInt32(Console.ReadLine());
            
            if (choose_player == 1)
            {
                Console.WriteLine("Ты отнял Эйроху 25 hp! ");
                boss -= 25;
                if (boss > 0 )
                    {
                    goto Choose;
                    }

            }
            else if (choose_player == 2)
            {

                Console.WriteLine("Ты отнял Эйроху 35 hp! ");
                boss -= 35;
                if (boss > 0)
                {
                    goto Choose;
                }
            }
            else if (choose_player == 3)
            {
                Console.WriteLine("Ты отнял Эйроху 60 hp! ");
                boss -= 60;
                if (boss > 0)
                {
                    goto Choose;
                }

            }
            else if (choose_player == 4)
            {
                Console.WriteLine("Ты отнял Эйроху 80 hp! ");
                boss -= 80;
                if (boss > 0)
                {
                    goto Choose;
                }

            }
            else if (choose_player == 5)
            {
                Console.WriteLine("Ты отнял Эйроху 120 hp!!!!!! ");
                boss -= 120;

            }

            else if (boss < 0)
            {
                goto Finish;
            }
            else
            {
                Console.WriteLine("Вы ввели не то заклинание!");
                goto Choose;
            }


        Finish:
            Console.WriteLine("Поздравляю! Ты сверг Великого Эйроха!");
            Console.ReadKey();





        }
    }
}
