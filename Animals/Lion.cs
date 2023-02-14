using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Lion : Animals
    {
        public Lion(string name, string food, string location) : base(name, food, location) { }

        public override void GetVoice()
        {
            Console.WriteLine("ЧЕ, ОПЯТЬ В ЦИРК?");
        }
    }
}