using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIsitor
{
    public interface IVisitor
    {
        void VisitHouse(House element);
        void VisitFactory(Factory element);
        void VisitBank(Bank element);
    }
    class InsuranceVisitor : IVisitor
    {
        public void VisitBank(Bank element)
        {
            Console.Write("Visitor visits bank \"" + element.name + "\"" + "!\n");
            Console.WriteLine("The insurance visitor offers the bank to make insurance against thieves!");
        }

        public void VisitFactory(Factory element)
        {
            Console.Write("Visitor visits factory \"" + element.name + "\"" + "!\n");
            Console.WriteLine("The insurance visitor offers fire and flood insurance to the factory!");
        }

        public void VisitHouse(House element)
        {
            Console.Write("Visitor visits house \"" + element.name + "\"" + "!\n");
            Console.WriteLine("The insured visitor offers the house to take out health insurance!");
        }
    }
}
