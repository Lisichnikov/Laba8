using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Whale : Animals
    {
        public Whale(string name, string food, string location) : base(name, food, location) { }

        public override void GetVoice()
        {
            Console.WriteLine("КИТ ТЫ МАМУ МАВ?");
        }
    }
}