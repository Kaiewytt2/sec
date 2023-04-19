using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Приветствую вас в этом замечательном приложении!");
        Console.WriteLine("Пожалуйста, жмакните на любую цифру:");

        while (true)
        {
            Console.WriteLine("\n1. Сюда нельзя нажимать. Произойдет непоправимое!");
            Console.WriteLine("2. Если введёте цифру 2, то ничего не произойдет");
            Console.WriteLine("3. Вы точно хотите ввести это число?");
            Console.WriteLine("4. Если введёте 4, то увидите анекдот");
            Console.WriteLine("0. Ливнуть");

            int option;
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Вы что, ввели сюда буквы? Серьезно?");
            }

            switch (option)
            {
                case 0:
                    Console.WriteLine("Уже уходите? :( Ну хорошо, надеюсь еще встретимся, удачи!");
                    return;
                case 1:
                    Function1();
                    break;
                case 2:
                    Function2();
                    break;
                case 3:
                    Function3();
                    break;
                case 4:
                    Function4();
                    break;
                default:
                    Console.WriteLine("Такой цифры здесь нет! Чтож вы не туда жмакаете то...");
                    break;
            }
        }
    }

    static void Function1()
    {
        Console.WriteLine("Да ладно, все норм, я шучу");
    }

    static void Function2()
    {
        Console.WriteLine("Ничего не произошло...");
    }

    static void Function3()
    {
        Console.WriteLine("Пусть будет по вашему, так уж и быть");
    }

    static void Function4()
    {
        Console.WriteLine(" Штирлиц ел картошку в мундире. \n Война давно кончилась и он не боялся его испачкать." );
    }
}