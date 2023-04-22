using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();   
        Console.Write("what is your first name? ");
        string firstname = Console.ReadLine();

        Console.Write("what is your last name? ");
        String lastname = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}");
    }
}