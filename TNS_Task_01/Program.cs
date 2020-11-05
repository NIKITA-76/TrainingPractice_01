using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNS_Task_01
{

    class Program
    {
       
        public const int Dimonds_cost = 100;   //Стоимость 1 кристалла


        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше количество золота: ");
            int Gold = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine($"Сколько кристаллов вы хотите обменять в банке Гоблинов? Сейчас курс 1 кр. = {Dimonds_cost} золота");
            int Dimonds = Convert.ToInt32(Console.ReadLine());

            
            try                             //Это очень плохие костыли, но зато без if
            {
                int calculation = Gold - Dimonds * Dimonds_cost;
                int[] arr = new int[Gold + 1];
                arr[calculation] = 1;
                Console.WriteLine($"Успешно. У вас {calculation} золота и {Dimonds} кристаллов.");

                Console.ReadKey();
            }
            catch (Exception e)            // Ловля ошибок
            {
                Console.WriteLine($"Простите, но у вас очень мало золота, вы нищий и бедный! Убирайтесь!! \n{Gold} золота и 0 кристалл(ов).");

                int fail = Convert.ToInt32(Console.ReadLine());

                Console.ReadKey();
            };
        }
    }


}

