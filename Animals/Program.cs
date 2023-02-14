using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
    static void Main(string[] args)
    {
        Animals.Cow cow = new Animals.Cow("Корова", "Травушка", "Россиюшка");
        Animals.Pig pig = new Animals.Pig("Свинья", "БУКВАЛЬНО ВСЕ", "Украина");
        Animals.Turtle turtle = new Animals.Turtle("Черепаха", "рыб", "Бразилия");
        Animals.Croco crocodile = new Animals.Croco("Крокодил", "всех", "Нигерия");
        Animals.Lion lion = new Animals.Lion("Лев", "че дадут", "Цирк");
        Animals.Whale whale = new Animals.Whale("Кит", "планктон", "Лужа");

        Console.WriteLine("-------------------");
        Console.WriteLine("Привет друг, это крутейшая программа для того чтобы узнать как звучит то или иное животное, попробуй, введи тип животного: ");
        Console.WriteLine("Парнокопытные");
        Console.WriteLine("Пресмыкающиеся");
        Console.WriteLine("Млекопитающие");
        Console.WriteLine("-------------------");
        string answer = Console.ReadLine().ToLower();

        switch (answer)
        {
            case "парнокопытные":
                Console.WriteLine("-------------------");
                Console.WriteLine("Выберете животного из нашего обширного списка:");
                Console.WriteLine("Свинья");
                Console.WriteLine("Корова");
                Console.WriteLine("-------------------");
                string animal = Console.ReadLine().ToLower();
                switch (animal)
                {
                    case "свинья":
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Свинья говорит: ");
                        pig.GetVoice();
                        Console.WriteLine("-------------------");
                        break;

                    case "корова":
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Корова говорит: ");
                        cow.GetVoice();
                        Console.WriteLine("-------------------");
                        break;
                }
                break;
            case "пресмыкающиеся":
                Console.WriteLine("-------------------");
                Console.WriteLine("Выберете животного из нашего обширного списка:");
                Console.WriteLine("Черепаха");
                Console.WriteLine("Крокодил");
                Console.WriteLine("-------------------");
                string animal1 = Console.ReadLine().ToLower();
                switch (animal1)
                {
                    case "черепаха":
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Черепаха говорит: ");
                        turtle.GetVoice();
                        Console.WriteLine("-------------------");
                        break;

                    case "крокодил":
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Крокодил говорит: ");
                        crocodile.GetVoice();
                        Console.WriteLine("-------------------");
                        break;
                }
                break;
            case "млекопитающие":
                Console.WriteLine("-------------------");
                Console.WriteLine("Выберете животного из нашего обширного списка:");
                Console.WriteLine("Лев");
                Console.WriteLine("Кит");
                Console.WriteLine("-------------------");
                string animal2 = Console.ReadLine().ToLower();
                switch (animal2)
                {
                    case "лев":
                        Console.WriteLine("-------------------");
                        Console.WriteLine("лев говорит: ");
                        lion.GetVoice();
                        Console.WriteLine("-------------------");
                        break;

                    case "кит":
                        Console.WriteLine("-------------------");
                        Console.WriteLine("Кит говорит: ");
                        whale.GetVoice();
                        Console.WriteLine("-------------------");
                        break;
                }
                break;
        }

    }
}
