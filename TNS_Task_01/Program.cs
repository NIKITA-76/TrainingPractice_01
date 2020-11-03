using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNS_Task_01
{

    class Program
    {
        //Стоимость 1 кристалла
        public const int rate = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите золото: ");
            int gold = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сколько кристаллов вы хотите купить? Курс 1 кр. = {rate} золота");
            int crystals = Convert.ToInt32(Console.ReadLine());

            //Попытка обойтись без if/else
            try
            {
                int res = gold - crystals * rate;
                int[] arr = new int[gold + 1];
                arr[res] = 1;
                Console.WriteLine($"Успешно. У вас {res} золота и {crystals} кристаллов.");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Сделка не удалась - у вас {gold} золота и 0 кристаллов.");
                int ex = Convert.ToInt32(Console.ReadLine());
                Console.ReadKey();
            };
        }
    }


}
