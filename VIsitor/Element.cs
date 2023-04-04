using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIsitor
{
    public interface IComponent
    {
        void Accept(IVisitor visitor);
    }
    public class House : IComponent
    {
        public string name { get; set; }
        public House(string name) { 
            this.name = name;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitHouse(this);
        }       
    }
    public class Factory : IComponent
    {
        public string name { get; set; }
        public Factory(string name)
        {
            this.name = name;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitFactory(this);
        }
    }
    public class Bank : IComponent
    {
        public string name { get; set; }
        public Bank(string name)
        {
            this.name = name;
        }
        public void Accept(IVisitor visitor)
        {
            visitor.VisitBank(this);
        }
    }

}
