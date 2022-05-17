using System;
namespace SnoozyZoos.Models
{
    public class ZooAnimal
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Location Location { get; set; }

        public ZooAnimal(string name, string color, int age, Location location)
        {
            Name = name;
            Color = color;
            Age = age;
            Location = location;
        }
    }
}

