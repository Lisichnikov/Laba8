using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Pig : IAnimals
    {
        public void GetVoice()
        {
            Console.WriteLine("ОТДАЙТЕ МАРИУПОЛЬ");
        }
    }
    class Cow : IAnimals
    {
        public void GetVoice()
        {
            Console.WriteLine("ЧЕЛ ТЫ В МУУУУУУУТЕ");
        }
    }
    class Turtle : IAnimals
    {
        public void GetVoice()
        {
            Console.WriteLine("Я... СКОРОСТЬ");
        }
    }
    class Croco : IAnimals
    {
        public void GetVoice()
        {
            Console.WriteLine("ПОД МНОЙ ВСЕ ТОРЧКИ");
        }
    }
    class Lion : IAnimals
    {
        public void GetVoice()
        {
            Console.WriteLine("ЧЕ, ОПЯТЬ В ЦИРК?");
        }
    }
    class Whale : IAnimals
    {
        public void GetVoice()
        {
            Console.WriteLine("КИТ ТЫ МАМУ МАВ?");
        }
    }
}