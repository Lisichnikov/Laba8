using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Cow : Animals
    {
        public Cow(string name, string food, string location) : base(name, food, location) { }

        public override void GetVoice()
        {
            Console.WriteLine("ЧЕЛ ТЫ В МУУУУУУУТЕ");
        }
    }
}