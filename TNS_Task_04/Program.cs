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
        {
            Random HpB = new Random();
            Random HpP = new Random();

            int HpBoss = HpB.Next(200,700);  // Случайное здоровье Эйроха
            int HpPlayer = HpP.Next(225,500); // Случайное здоровье Игрока
            int UltimateDamage = 0; // Если равно 3, срабатывает Атронах
            bool Attack = false;
            Random bsd = new Random(); // Создание рандома для урона Босса
            Random hlp = new Random(); // Создание рандома для прибавления здоровья
            Random kam = new Random(); // Создание рандома для пропуска хода Эйроха от Валуна
            Console.WriteLine("Вы маг отшельник выполняющий разные заказы. Сейчас же вас заказали жители одной из деревнь, да бы избавиться от духа Эйроха, что поедает их скот.\n");
            Console.WriteLine("Вы подошли к пещере где обитает Эйрох, вокруг куча костей. В темноте вы разглядываете злого духа, который готов напасть на вас! \n");
            Console.WriteLine("Победите Эйроха! \n");
            Console.WriteLine("Ваша атака проходит после атаки Духа!!\n");
            Console.WriteLine("Так как Эйрох вам не известен, вы не знаете что за заклинание он накалдует. Вы будете получать урон в диапазоне от 10 до 80 единиц \n");
            do
            {


                
            chooseAgain:
                Console.WriteLine($"Ваше здровье: {HpPlayer}");
                Console.WriteLine($"Здоровье Эйроха: {HpBoss}\n");
                Console.Write("Выберите заклинание на этот ход:\n" +
                "1.Огненная стрела (20 урона) \n" +
                "2.Струя горячего воздуха(Выбивет Босса из равновесия, если вас атаковали, у вас есть время залечить раны (+70 Здоровья)).Шанс 50%!.Лечить себя, можно при потереи здоровья ниже 200\n" +
                "3.Летящий валун 80 (При попадании с 50% вероятность оглушает босса на 1 ход)\n" +
                "4.Вы можете призвать Атронаха вам в помощь который нанесет 150 урона, но для этого вам нужно 3 раза повторить это заклинание\n" +
                "5.Приказывает Атронаху атаковать врага  \n");

                
                int spell = 0;
                try { spell = Convert.ToInt32(Console.ReadLine()); } // Если Игрок ввел не тот тип данных
                catch
                {
                    Console.WriteLine("Вы ввели не тот тип данных.");
                    goto chooseAgain;
                }
                Console.Clear();

                int BossDamage = bsd.Next(10, 80); // Получение случайного числа (Урона Эйроха)
                int chanseHelp = hlp.Next(0, 2);  // 50% шанс на срабатывание заклинания 
                int stun = kam.Next(0, 2); // 50% шанс на пропуск хода Эйроха
                

                switch (spell) // Выборка 
                {
                    case (1):
                        HpBoss -= 20;
                        break;
                    case (2):
                        if (chanseHelp == 1 && Attack == true)
                        {
                         Console.WriteLine("Эйрох выбит из равновесия!");
                         BossDamage = 0;
                            if (HpPlayer < 200) // проверка на то, что бы у игрока не было больше здоровья чем положен, и если оно выше положенного, сбрасывает до 200
                            {
                                HpPlayer += 70;
                            }
                            

                        }

                        break;
                    case (3):
                        if (stun == 1)
                        {   
                            Console.WriteLine("Эйрох оглушен\n");
                            BossDamage = 0;
                        }
                        HpBoss -= 80;
                        break;
                    case (4): // при достижении 3 вызывается Атронах 
                        UltimateDamage = UltimateDamage + 1;
    
                        
                        if (UltimateDamage > 3)
                        {
                            Console.WriteLine("Атронах уже призван и вы пропускаете ход!!");

                        }
                        if (UltimateDamage == 3)
                        {
                            Console.WriteLine("Вы призвали Атронаха, и он тут же нанес Эйроху 90 едениц урона!\n");
                            HpBoss -= 90;
                            

                        }
                        break;
                    case (5):
                        HpBoss -= 90;

                        break;
                        
                    default:
                        Console.WriteLine("Вы ничего не скастовали! И Эйрох воспользовался вашей ошибкой!");
                        break;


                }
                
                HpPlayer -= BossDamage;
                Attack = true;




            } while (HpBoss > 0 && HpPlayer > 0); // окончание битвы при смерти одного из двух 
            if (HpPlayer <= 0 )
            {
                Console.WriteLine("Вы погибли... И босс победил");
                Console.ReadKey();

            }
            else if (HpBoss <= 0)
            {
                Console.WriteLine("Вы победили Великого Эйроха. Деревня может спать спокойно!!");
                Console.ReadKey();

            }
        }

    }
}
  
