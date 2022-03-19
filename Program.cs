using System;

internal class Program
{
    static void Main(string[] args)
    {
        string name;
        string zodiac;
        string age;
        string work;

        Console.WriteLine("Как Вас зовут?");
        name = Console.ReadLine();
        Console.WriteLine("Ваш знак зодиака?");
        zodiac = Console.ReadLine();
        Console.WriteLine("Сколько Вам лет?");
        age = Console.ReadLine();
        Console.WriteLine("Где вы работаете?");
        work = Console.ReadLine();

        Console.WriteLine("Вас зовут " + name + "," + "Вам " + age + " вы " + "," + zodiac + " и работаете на "+work);
    }
}
