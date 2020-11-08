using System;
namespace TNS_Tusk_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] FIO = new string[3][];       // Массив массивов, в котором у Фамилии, Имени и Отчества свои массивы.

            FIO[0] = new string[100];               //Фамилии

            FIO[1] = new string[100];               //Имена

            FIO[2] = new string[100];               //Отчества


            bool End = true;                        // Делаем проверку на выход из общего цикла 
            
            string[] post = new string[100];        // Должность
            
            int i = 0;                              //Количество записей
            
            

            do                                     // Старт цикла While
            {
                Console.Write("Функции отдела кадров: " +

                           "\n  1. Вывод всех кадров " +

                           "\n  2. Добавить кадр" +

                           "\n  3. Удалить кадр" +

                           "\n  4. Поиск кадра по фамилии" +

                           "\n  5. Выход из меню \n \n");

                Console.Write("Выберите нужную вам функцию: ");


                int shoose;

                try { shoose = Convert.ToInt32(Console.ReadLine()); }       //Выбор функии

                catch { shoose = 0; }

                Console.Clear();




                switch (shoose)                                            // Выборка решений
                {
                   
                    case 1:
                        if (i != 0)
                        {
                            Console.Clear();

                            Console.WriteLine("Кадры хронящиеся в Базу Данных: \n");

                            for (int j = 0; j <= i - 1; j++)
                            {
                                Console.WriteLine($"{j}. {FIO[0][j]} {FIO[1][j]} {FIO[2][j]} : {post[j]}"); // Выводим все данные
                            }
                            Console.Write("\n Нажмите любую кнопку что-бы продолжить... ");

                            Console.ReadKey();

                            Console.Clear();


                        }

                        else
                        {
                            Console.Write("Каких-либо записей не найдено" +

                                "\n Нажмите любую кнопку что-бы продолжить... ");

                            Console.ReadKey();

                            Console.Clear();

                        }
                        break;



                    case 2:
                        Console.Write("Введите Фамилию Кадра: ");

                        FIO[0][i] = Console.ReadLine();

                        Console.Write("Введите Имя Кадра: ");

                        FIO[1][i] = Console.ReadLine();

                        Console.Write("Введите Отчество Кадра: ");

                        FIO[2][i] = Console.ReadLine();




                        Console.Write("Введите ниже, какую должность, занимает вводимый вами Кадр: ");      // Запись данных о Кадре

                        post[i] = Console.ReadLine();

                        i++;                                       // Количество записей увеличено на 1

                        Console.Write("Данные записаны успешно" +
                            "\nНажмите на любую кнопку что-бы продолжить...");

                        Console.ReadKey();

                        Console.Clear();

                        break;




                    case 3:

                        Console.Write("Под каким номер будет удалена запись?: ");

                        int choice;                            // Выбор записи

                    again:

                        try { choice = Convert.ToInt32(Console.ReadLine()); }

                        catch { goto again; }


                        bool obnureshenie = false;         // Проверка на повторения еспильзование нужного индекса


                        if (choice <= i && choice > 0)       // Проверка на ошибки, а именно: не введено ли число больше, чем кол-во записей в целом; индекс < 0

                        {
                            for (int j = 0; j <= i; j++)
                            {


                                if (j == choice || obnureshenie)
                                {
                                    if (j != i - 1)         // Предотвращения ошибки заполнения массива несуществующими данными
                                    {

                                        FIO[0][j] = FIO[0][j + 1];

                                        FIO[1][j] = FIO[1][j + 1];

                                        FIO[2][j] = FIO[2][j + 1];

                                        post[j] = post[j + 1];

                                        obnureshenie = true;

                                    }
                                    else
                                    {
                                        FIO[0][j] = "";

                                        FIO[1][j] = "";

                                        FIO[2][j] = "";

                                        post[j] = "";


                                    }
                                }
                            }
                            i--;        // Число записей уменьшено на 1

                            Console.WriteLine("Кадр успешно удален." +

                                "\nНажмите на любую кнопку что-бы продолжить...");

                            Console.ReadKey();

                            Console.Clear();


                        }
                        else
                        {
                            Console.WriteLine("Введен неверный индекс кадра." +

                                "\nНажмите на любую кнопку что-бы продолжить...");
                            Console.ReadKey();

                            Console.Clear();
                        }

                        break;

                    case 4:
                        Console.Write("Введите фамилию Кадра, поиск начнется по введнной вами фамилии: ");

                        

                        bool Sovpadenie = false;          // Найдена ли хотя бы одна фамилия 

                        string SecondName = Console.ReadLine(); // Ввод нужной фамилии

                        for (int j = 0; j <= i; j++)
                        {

                            if (SecondName == FIO[0][j])
                            {
                                Sovpadenie = true;      //Фамилия найдена

                                Console.WriteLine($"{j}. {FIO[0][j]} {FIO[1][j]} {FIO[2][j]} : {post[j]}");

                            }



                        }
                        if (!Sovpadenie)              //Если фамилия НЕ найдена
                        {
                            Console.WriteLine("В базе не было найдено ни одного совпадения.");

                        }
                        Console.WriteLine("\n Нажмите любую кнопку для продолжения!");


                        Console.ReadKey();


                        Console.Clear();


                        break;

                    case 5:

                        End = false;

                        break;

                    default:

                        Console.WriteLine("Такой функции не существует. Нажмите любую кнопку для продолжения!");

                        Console.ReadKey();

                        Console.Clear();

                        break;
                }
            } while (End); // конец цикла
        }
    }
}
