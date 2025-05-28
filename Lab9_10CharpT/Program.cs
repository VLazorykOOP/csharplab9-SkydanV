class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Вибери завдання (1-4):");
            Console.WriteLine("1 - Завдання 1");
            Console.WriteLine("2 - Завдання 2_3");
            Console.WriteLine("4 - Завдання 4");
            Console.Write("Твій вибір: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunTask1();
                    break;
                case "2":
                    RunTask2();
                    break;
                case "4":
                    RunTask4();
                    break;
                default:
                    Console.WriteLine("спробуй ще раз!");
                    break;
            }

            Console.WriteLine("\nНатисни будь-яку клавішу, щоб повернутися в меню...");
            Console.ReadKey();
        }
    }

    static void RunTask1()
    {
        Console.Clear();
        Console.WriteLine("=== Завдання 1 ===");
        var task1 = new Lab9T1();
        task1.Run();
        Console.WriteLine("==================");
    }

    static void RunTask2()
    {
        Console.Clear();
        Console.WriteLine("=== Завдання 2 ===");
        var task2 = new Lab9T2();
        task2.Run();
        Console.WriteLine("==================");
    }

    static void RunTask4()
    {
        Console.Clear();
        Console.WriteLine("=== Завдання 4 ===");
        var task4 = new Lab9T4();
        task4.Run();
        Console.WriteLine("==================");
    }
}
