using System;
namespace SnoozyZoos.Models
{
    public class ZooAnimal
    {
        public string Name { get; private set; }
        public string Color { get; private set; }
        public Location Location { get; private set; }

        public ZooAnimal(string name, string color, Location location)
        {
            Name = name;
            Color = color;
            Location = location;
        }
    }
}

