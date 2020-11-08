using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNS_Tusk_07
{
    class Program
    {
        public static void Shuffle<T>(T[] arr)
        {
            Random rand = new Random();

            for (int i = arr.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);

                T tmp = arr[j];
                arr[j] = arr[i];
                arr[i] = tmp;
            }
            
        }
        private static void Main(string[] args)
        {  
            Again:
            try
                { 
                 Console.WriteLine("Сколько случайных числе будет в массиве?");
                 int N = Convert.ToInt32(Console.ReadLine());
                 int[] mas = new int[N];
                 Random r = new Random();
                    for (int i = 0; i < mas.Length; i++)
                    {
                       mas[i] = r.Next(-100, 101);
                     }
                    Console.Write("Ваши числа до изменения:  ");
                    Console.WriteLine(string.Join(" ", mas));
                    Shuffle(mas);
                    Console.Write("Ваши числа после изменения: ");
                    Console.WriteLine(string.Join(" ", mas));
                    Console.ReadKey();


                }
            
            catch (Exception e)  
                {
                Console.WriteLine("Вы ввели не тот тип данных!" +
                    "\nПопробуйте еще раз (Программа принимает лишь тип данных в ввиде INT)\n");
                
                goto Again;
                }
           
        }  

    }
}
