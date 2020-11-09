using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TNS_Task_04
{

    class Progaram
    {
        static void Main(string[] args)
        {   Random Armr_P = new Random();
            double MinusHPBoss = 0; // урон от Игрока - Врагу
            Random HpB = new Random();
            
            Random HpP = new Random();
            Random Armr_B = new Random();
            int Armor_P = Armr_P.Next(5); // случайное число брони Игрока
            int trying = 2;  // Счетчик вызова Атронаха
            double HpBossMain = HpB.Next(200,700);  // Случайное здоровье Эйроха
            double HpPlayer = HpP.Next(225,500); // Случайное здоровье Игрока
            int UltimateDamage = 0; // Если равно 3, срабатывает Атронах
            int Armor_B = Armr_B.Next(3); // случайное число брони Врага
            bool FirstAttack = true; // Обнуление перовй атаки, иначе, при первом ходе будет видно, что босс уже атаковал
            Random bsd = new Random(); // Создание рандома для урона Босса
            int BossDamage = 0;  // // урон от Врага - Игроку
            Random hlp = new Random(); // Создание рандома для прибавления здоровья
            Random kam = new Random(); // Создание рандома для пропуска хода Эйроха от Валуна
            Console.WriteLine("Вы маг отшельник выполняющий разные заказы. Сейчас же вас заказали жители одной из деревнь, да бы избавиться от духа Эйроха, что поедает их скот.\n");
            Console.WriteLine("Вы подошли к пещере где обитает Эйрох, вокруг куча костей. В темноте вы разглядываете злого духа, который готов напасть на вас! \n");
            Console.WriteLine("Победите Эйроха! \n");
            Console.WriteLine("Ваша атака проходит после атаки Духа!!\n");
            Console.WriteLine("Так как Эйрох вам не известен, вы не знаете что за заклинание он накалдует. Вы будете получать урон в диапазоне от 10 до 80 единиц \n");
            Console.WriteLine("Что бы начать, нажмите на любую клавишу...\n");
            Console.ReadKey();
            Console.Clear();
            Console.Clear();
            do
            {



            chooseAgain:
                if (FirstAttack == true)
                {
                    BossDamage = 0;
                    FirstAttack = false;
                }
                
                
                

                
                Console.WriteLine($"Ваше здровье: {HpPlayer}");
                Console.WriteLine($"Здоровье Эйроха: {HpBossMain}\n");
                Console.WriteLine($"Вы нанесли: {MinusHPBoss}  " + $"Вам нанесли: {BossDamage}\n" + $"Ваша броня: {Armor_P}  " + $"Вражеская броня: {Armor_B}  \n");
                Console.Write("Выберите заклинание на этот ход:\n" +
                "1.Огненная стрела 20 урона \n" +
                "2.Струя горячего воздуха(Выбивет Босса из равновесия, если у вас здоровье ниже 200ед., у вас есть возможность залечить раны (+70 Здоровья)).Шанс 50%!.Лечить себя, можно при потереи здоровья ниже 200ед.\n" +
                "3.Летящий валун 70 урона (При попадании с 50% вероятность оглушает босса на 1 ход)\n" +
                "4.Вы можете призвать Атронаха вам в помощь который нанесет 150 урона, но для этого вам нужно 3 раза повторить это заклинание\n" +
                "5.Приказывает Атронаху атаковать врага  \n");

                
                int spell = 0;
                try { spell = Convert.ToInt32(Console.ReadLine()); } // Если Игрок ввел не тот тип данных
                catch
                {
                    Console.WriteLine("Вы ввели не тот тип данных.");
                    Console.ReadKey();
                    Console.Clear();
                    goto chooseAgain;
                }
                Console.Clear();

                int chanseHelp = hlp.Next(0, 2);  // 50% шанс на срабатывание заклинания 
                int stun = kam.Next(0, 2); // 50% шанс на пропуск хода Эйроха
                BossDamage = bsd.Next(10, 80); // Урон Эйроха






                switch (spell) // Выборка 
                {
                    case (1):
                        MinusHPBoss = 20 * (Armor_B * 0.1);
                        HpBossMain -= MinusHPBoss;
                        break;
                    case (2):
                        if (chanseHelp == 1)
                        {
                         Console.WriteLine("Эйрох выбит из равновесия!");
                         BossDamage = 0;
                            if (HpPlayer < 200) // проверка на то, что бы игрок не мог себя лечить, если здоровье больше 200ед.
                            {
                                HpPlayer += 70;
                                MinusHPBoss = 0;
                                Console.WriteLine("Здоровье восстановленно на 70ед.");
                            }
                            else
                            {
                                Console.WriteLine("Но вы не можете восстановить здоровье, так как вы емеете больше 200ед.!");
                            }

                            

                        }

                        break;
                    case (3):
                        if (stun == 1)
                        {   
                            Console.WriteLine("Эйрох оглушен\n");
                            BossDamage = 0;
                        }
                        MinusHPBoss = 70 * (Armor_B * 0.1);
                        HpBossMain -= MinusHPBoss;
                        break;
                    case (4): // при достижении 3 вызывается Атронах 
                        UltimateDamage = UltimateDamage + 1;
    
                        
                        if (UltimateDamage > 3)
                        {
                            Console.WriteLine("Атронах уже призван и вы пропускаете ход!!");
                            MinusHPBoss = 0;
                        }
                        else if (UltimateDamage == 3)
                        {
                            Console.WriteLine("Вы призвали Атронаха, и он тут же нанес Эйроху 90 едениц урона!\n");
                            MinusHPBoss = 90 * (Armor_B * 0.1);
                            HpBossMain -= MinusHPBoss;


                        }
                        else
                        {
                            Console.WriteLine($"Призыв Атронаха будет через {trying} ход(а) ");
                            trying--;
                            MinusHPBoss = 0;
                        }

                        break;
                    case (5):
                        MinusHPBoss = 90 * (Armor_B * 0.1);
                        HpBossMain -= MinusHPBoss;

                        break;
                        
                    default:
                        Console.WriteLine("Вы ничего не скастовали! И Эйрох воспользовался вашей ошибкой!");
                        MinusHPBoss = 0;
                        break;


                }
                
                
                HpPlayer -= Math.Floor(BossDamage * (Armor_P * 0.1));
                




            } while (HpBossMain > 0 && HpPlayer > 0); // окончание битвы при смерти одного из двух 
            if (HpPlayer <= 0 )
            {
                Console.WriteLine("╔══╗╔╗──╔╗╔╗──╔╦═══╦═══╦════╦══╗╔╗──╔╗");
                Console.WriteLine("║╔╗║║║──║║║║──║║╔══╣╔═╗╠═╗╔═╣╔╗║║║──║║");
                Console.WriteLine("║╚╝╚╣╚══╣║║╚╗╔╝║╚══╣╚═╝║─║║─║╚╝╚╣╚══╣║");
                Console.WriteLine("║╔═╗║╔═╗║║║╔╗╔╗║╔══╣╔══╝─║║─║╔═╗║╔═╗║║");
                Console.WriteLine("║╚═╝║╚═╝║║║║╚╝║║╚══╣║────║║─║╚═╝║╚═╝║║");
                Console.WriteLine("╚═══╩═══╩╝╚╝──╚╩═══╩╝────╚╝─╚═══╩═══╩╝");
                Console.WriteLine("\nВы проиграли эту битву");
                Console.WriteLine("\nИ теперь, ваш труп навечно останется в глубинах этой пещеры...");
                Console.ReadKey();

            }
            else if (HpBossMain <= 0)
            {
                Console.WriteLine("Вы победили Великого Эйроха. Деревня может спать спокойно!!");
                Console.ReadKey();

            }
        }

    }
}
  
