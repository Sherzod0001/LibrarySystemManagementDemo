using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string password = "admin";
        Console.WriteLine("Kutubxona tizimiga xush kelibsiz! Parolni kiriting (parol: admin):");
        string inputPassword = Console.ReadLine();

        if (inputPassword == password)
        {
            ShowMenu();
        }
        else
        {
            Console.WriteLine("Noto'g'ri parol!");
        }
    }

    static void ShowMenu()
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Kitoblar");
            Console.WriteLine("2. O'quvchi");
            Console.WriteLine("3. Ijara");
            Console.WriteLine("4. Chiqish");
            Console.Write("Tanlang: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ManageBooks();
                    break;
                case "2":
                    ManageReaders();
                    break;
                case "3":
                    ManageRentals();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Noto'g'ri tanlov, qayta urinib ko'ring.");
                    break;
            }
        }
    }

    static void ManageBooks()
    {
        Console.WriteLine("\nKitoblar:");
        Console.WriteLine("1. Kitob qo'shish");
        Console.WriteLine("2. Kitob o'chirish");
        Console.WriteLine("3. Kitoblar ro'yxati");
        // Qo'shimcha funksiyalarni shu yerda qo'shing
    }

    static void ManageReaders()
    {
        Console.WriteLine("\nO'quvchi:");
        Console.WriteLine("1. O'quvchi qo'shish");
        Console.WriteLine("2. O'quvchi o'chirish");
        Console.WriteLine("3. O'quvchilar ro'yxati");
        // Qo'shimcha funksiyalarni shu yerda qo'shing
    }

    static void ManageRentals()
    {
        Console.WriteLine("\nIjara:");
        Console.WriteLine("1. Ijaraga berish");
        Console.WriteLine("2. Qaytarib olish");
        Console.WriteLine("3. Ijara ro'yxati");
        // Qo'shimcha funksiyalarni shu yerda qo'shing
    }
}
