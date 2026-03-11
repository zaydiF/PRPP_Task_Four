using System;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Задача 1: Книжная полка ===\n");

            // Создаем объект myBook
            Book myBook = new Book();

            // Устанавливаем значения полей
            myBook.title = "Война и мир";
            myBook.author = "Лев Толстой";
            myBook.year = 1869;

            // Вызываем метод GetInfo() для myBook
            Console.WriteLine("Информация о книге myBook:");
            myBook.GetInfo();

            // Создаем второй объект unknownBook (со значениями по умолчанию)
            Book unknownBook = new Book();

            // Вызываем метод GetInfo() для unknownBook
            Console.WriteLine("\nИнформация о книге unknownBook:");
            unknownBook.GetInfo();

            Console.WriteLine("\n================================\n");
            Console.WriteLine("=== Задача 2: Умный счетчик ===\n");

            // Создаем трех посетителей
            Visitor visitor1 = new Visitor("Анна");
            Visitor visitor2 = new Visitor("Борис");
            Visitor visitor3 = new Visitor("Виктор");

            // Вызываем метод PrintInfo() для каждого посетителя
            Console.WriteLine("Информация о посетителях:");
            visitor1.PrintInfo();
            visitor2.PrintInfo();
            visitor3.PrintInfo();

            // Вызываем статический метод для показа общего количества посетителей
            Visitor.ShowTotalVisitors();

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}