using System;

namespace Web_E_Tickets
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            const string str = "======Лабораторна робота №1======\n" +
                               "=Виконали студенти групи IТ-81: =\n" +
                               "=Cоловов Iван IТ-8121        =\n" +
                               "=Гончаров Олександр IТ-8129  =\n" +
                               "=Кирило Щупiй IТ-8130        =\n" +
                               "=================================\n";
            Console.WriteLine(str);
            CtorTest.Test();
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
