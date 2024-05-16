using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganTransplant
{
    internal class Person
    {
        public string Name { get; set; }
        public Kidney[] Kidneys;


        public Person(string name, bool isSick)
        {
            Name = name;
            Kidneys = new Kidney[2];
            if (isSick)
            {
                UnhealthyKidney();
            }
            else
            {
                HealthyKidney();
            }
        }

        public void UnhealthyKidney()
        {
            Kidneys[0] = new Kidney(false);
            Kidneys[1] = new Kidney(false);
        }
        public void HealthyKidney()
        {
            Kidneys[0] = new Kidney(true);
            Kidneys[1] = new Kidney(true);
        }


        public void GiveKidney(Person receiver)
        {
            Console.WriteLine($"{Name} is now donating his kidney to {receiver.Name}");
            receiver.ReceiveKidney(Kidneys[0]);
            Kidneys[0] = null;
            Console.WriteLine($"{Name} now only has 1 functioning Kidney left.");
        }

        public void ReceiveKidney(Kidney donatedKidney)
        {
            Console.WriteLine($"{Name} is now receiving his kidney.");
            Kidneys[0] = donatedKidney;
            Console.WriteLine($"{Name} now has 1 healthy kidney. {Name} will live another day!");
        }
    }
}
