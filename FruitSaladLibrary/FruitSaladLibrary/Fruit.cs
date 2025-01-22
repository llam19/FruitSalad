using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitSaladLibrary
{
    public abstract class Fruit
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public double Weight { get; set; }
        public bool IsOrganic { get; set; }

        public Fruit(string name, string color, double weight, bool isOrganic)
        {
            Name = name;
            Color = color;
            Weight = weight;
            IsOrganic = isOrganic;
        }
        //abstract method to enforce implementation in derived classes
        public abstract string Describe();

        public override string ToString()
        {
            string organicLabel = IsOrganic ? "Organic" : "Non-Organic";
            return $"{Name} ({Color}, {Weight}g, {organicLabel})";
        }
    }
}
