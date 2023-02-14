using System;
namespace Animals
{
    public class Animals
    {
        string name;
        string food;
        string location;

        public Animals(string name, string food, string location)
        {
            this.name = name;
            this.food = food;
            this.location = location;
        }

        public virtual void GetVoice()
        {
        }
    }
}