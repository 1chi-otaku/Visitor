using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIsitor
{
    public class Client
    {
        public static void ClientCode(List<IComponent> components, IVisitor visitor)
        {
            foreach (var component in components)
            {
                component.Accept(visitor);
                Console.WriteLine();
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IComponent> components = new List<IComponent>
            {
                new House("Tom's lounge"),
                new Bank("PrivatBank"),
                new Factory("Roshen")
            };

            IVisitor visitor1 = new InsuranceVisitor();
            Client.ClientCode(components, visitor1);
        }
    }
}
