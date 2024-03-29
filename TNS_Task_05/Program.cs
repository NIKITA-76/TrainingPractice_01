using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            
            int[,] maze = new int[,]     //Паттерн лабиринта
            {
{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
{1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,2,1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
{1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,0,0,0,1,0,1,1,1,1,0,1,1,1,2,1,1,1,1,1,1},
{1,0,1,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,1,1,0,1,1,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
{1,0,0,0,1,0,1,1,1,1,1,1,1,0,1,0,1,0,0,0,0,0,1,0,1,0,0,1,1,1,1,1,1,1,1,1,1,1,1},
{1,0,1,0,1,0,1,0,0,0,0,0,1,0,1,0,1,0,1,0,1,1,1,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,1},
{1,0,1,0,1,0,1,1,0,1,1,1,1,0,1,0,1,0,1,0,0,0,0,0,1,0,0,1,0,1,1,1,1,1,1,1,1,0,1},
{1,0,1,0,1,0,1,1,0,1,1,1,1,0,1,0,1,1,1,1,1,1,1,1,1,0,0,1,0,1,0,0,0,0,0,0,1,0,1},
{1,0,1,0,1,0,0,0,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,1,0,0,0,1,0,1},
{1,0,1,0,1,1,1,1,1,1,1,1,1,0,1,0,1,0,1,1,1,1,0,1,0,0,0,1,0,1,0,0,1,1,0,0,1,2,1},
{1,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,1,0,1,0,0,1,0,1,0,1,1,1,0,1,1,0,0,1,0,0,1,0,1},
{1,0,1,1,1,1,1,1,1,1,1,1,1,1,1,0,1,0,1,0,0,1,0,1,0,1,0,0,0,0,1,0,0,1,0,0,1,0,1},
{1,0,0,0,0,2,0,0,0,0,0,0,0,0,1,0,1,0,1,0,0,1,0,1,0,1,0,0,1,0,1,0,0,1,0,0,1,0,1},
{1,0,1,1,1,1,1,1,1,1,0,1,0,1,1,0,1,0,1,0,0,1,0,1,0,1,0,0,1,0,1,1,0,1,1,0,1,0,1},
{1,0,1,0,0,0,0,1,0,1,0,1,0,1,1,0,1,0,1,0,0,1,0,1,1,1,0,0,1,0,1,1,0,0,1,0,1,0,1},
{1,0,1,0,1,1,0,1,0,0,0,1,0,1,1,0,0,0,0,0,0,1,0,0,0,0,0,1,1,0,1,1,0,0,1,0,1,0,1},
{1,0,1,0,1,1,0,1,0,1,0,1,0,1,1,1,1,1,0,1,0,1,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,3},
{1,0,0,0,1,1,0,1,0,1,0,1,0,1,1,0,1,0,0,1,0,0,0,0,0,0,0,0,1,0,1,1,0,0,1,0,1,1,1},
{1,0,1,0,1,1,0,0,0,2,0,0,0,0,0,0,0,0,1,1,0,0,0,0,1,0,1,0,1,0,1,1,0,0,1,0,0,0,1},
{1,0,1,0,1,1,0,1,1,1,1,1,1,1,1,0,1,0,1,1,0,1,1,1,1,0,1,0,1,0,1,1,1,1,1,1,1,0,1},
{1,0,1,2,1,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,1,0,1,0,1,0,0,0,0,0,0,0,0,0,1},
{1,0,1,0,1,1,0,1,0,1,1,1,0,1,1,1,1,1,1,1,1,0,0,0,1,0,1,0,0,0,1,1,1,1,0,0,1,0,1},
{1,0,1,0,1,1,0,1,0,1,1,1,0,1,1,0,0,0,1,1,1,1,1,1,1,0,1,0,1,0,0,1,0,1,0,0,1,0,1},
{1,0,1,0,0,0,0,1,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,1,0,0,1,0,1,0,0,1,0,1},
{1,0,1,1,1,1,1,1,0,1,1,1,1,1,1,1,1,1,0,0,1,1,1,1,1,1,1,0,1,1,1,1,0,1,1,1,1,0,1},
{1,0,0,0,0,0,1,0,0,0,0,2,1,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1},
{1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1}



            };
            
            int x = 1, y = 1; //Х и У - координаты Игрока
            int i = 0;
            int j = 0;
            Console.WriteLine("Вам исполнилось 18, а по законам племени Варваров (где вы сейчас и живете) - при достижении совершенолетия, юноша обязан пройти испытание духа" +
                "\nЛабиринт является одним из этих испытаний" +
                "\n" +
                "\nОт отца, вы получаете совет, что в лабиринте могу обитать опасные существа..." +
                "\n" +
                "\nВ кромешной темноте, вам нужно найти выход!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\nВ любой момент времени, вы можете сдаться, нажав на клавишу Esc");
            Console.WriteLine("\nНажмите на любую клавишу что-бы начать...");
            Console.ReadKey();
        Again:
            x = 1;
            y = 1;
            try 
            {
                


                while (true)  //Прорисовка Лабиринта путем бесконечно цикла
                {
                    Console.Clear(); 
                    
                    
                    for ( i = 0; i < maze.GetLength(0); i++)
                    {
                        for ( j = 0; j < maze.GetLength(1); j++)
                        {
                            if (maze[i, j] == 0) Console.Write(",");
                            if (maze[i, j] == 1) Console.Write("▒");
                            if (maze[i, j] == 2) Console.Write("@");
                            if (maze[i, j] == 3) Console.Write("№");
                        }

                        Console.WriteLine();
                    }
                    Console.WriteLine("\n @ - Опасные существа");
                    Console.Write("\n № - Выход");


                    Console.CursorLeft = x;
                    Console.CursorTop = y;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("V");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.BackgroundColor = ConsoleColor.Black;

                    

                    ConsoleKeyInfo ki = Console.ReadKey(); // Обработка управления с клавиатуры
                    if (ki.Key == ConsoleKey.Escape)
                    {
                        Console.Clear();
                        Console.WriteLine("Вы не прошли Первое Испытание Варваров" +
                            "\nПозор ВАМ до конца дней!!");
                        Console.ReadKey();
                        break;

                        
                        
                    
                    }                        

                    if (ki.Key == ConsoleKey.LeftArrow && maze[y, x - 1] == 0) x--;

                    if (ki.Key == ConsoleKey.RightArrow && maze[y, x + 1] == 0) x++;

                    if (ki.Key == ConsoleKey.UpArrow && maze[y - 1, x] == 0) y--;

                    if (ki.Key == ConsoleKey.DownArrow && maze[y + 1, x] == 0) y++;

                    if (ki.Key == ConsoleKey.LeftArrow && maze[y, x - 1] == 2) goto Dead;

                    if (ki.Key == ConsoleKey.RightArrow && maze[y, x + 1] == 2) goto Dead; ;

                    if (ki.Key == ConsoleKey.UpArrow && maze[y - 1, x] == 2) goto Dead; ;

                    if (ki.Key == ConsoleKey.DownArrow && maze[y + 1, x] == 2) goto Dead; ;





                }

            }
            catch (System.IndexOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine("Поздравляю! Вы прошли испытание Варваров!!!");
                Console.ReadKey();
                Environment.Exit(0);
            }
        Dead:
            Console.Clear();
            Console.WriteLine("В темноте вы понимаете, что наткнулись на нечто");
            Console.ReadKey();
            Console.WriteLine("\nПодходя ближе, вы понимаете, что это 'нечто' враждебно к вам");
            Console.WriteLine("                      ####                                ####                               ");
            Console.WriteLine("                       ####                             ####                                   ");
            Console.WriteLine("                         ####                         ####                                     ");
            Console.WriteLine("                           ####                     ####                                       ");
            Console.WriteLine("                       ##########################################                                                            ");
            Console.WriteLine("                      ####                                    ####                                       ");
            Console.WriteLine("                     ####          @@                @@        ####                             ");
            Console.WriteLine("                    ####           @@                @@         ####                            ");
            Console.WriteLine("                   ####                                          ####                          ");
            Console.WriteLine("                   ####             $$$$$$$$$$$$$$$$             ####                             ");
            Console.WriteLine("                     ####          $$$$            $$$$        ####                               ");
            Console.WriteLine("                      ####            $$$$$$$$$$$$$$$$        ####                                 ");
            Console.WriteLine("                       ####                                  ####                                 ");
            Console.WriteLine("                        ########################################                                                             ");
            Console.WriteLine("                               ######################                                                        ");
            Console.WriteLine("                                  ################                                                     ");
            Console.WriteLine("                                                                                       ");
            Console.WriteLine("\nСпустя мгновение, существо пробивает вам грудь");
            Console.ReadKey();
            Console.WriteLine("\nЛежа в своей крови, последнии мысли в вашей голове - это мысле о доме и Матери...");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear(); 
            Console.WriteLine("\nВы мертвы. Нажмите на любую клавишу что-бы начать сначала...");
            Console.ReadKey();
            
            goto Again;

            
            
            





        }
    }
}
