using System;

namespace LibraryApp
{
    public class Visitor
    {
        // Поле для хранения имени посетителя
        public string name;

        // Статическое поле для подсчета общего количества посетителей
        public static int totalVisitors = 0;

        // Конструктор по умолчанию
        public Visitor()
        {
            totalVisitors++;
        }

        // Конструктор с параметром для удобства
        public Visitor(string name)
        {
            this.name = name;
            totalVisitors++;
        }

        // Метод для вывода информации о конкретном посетителе
        public void PrintInfo()
        {
            Console.WriteLine($"Посетитель: {name}");
        }

        // Статический метод для вывода общего количества посетителей
        public static void ShowTotalVisitors()
        {
            Console.WriteLine($"\nВсего посетителей создано: {totalVisitors}");
        }
    }
}