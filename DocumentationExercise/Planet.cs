using System;
using System.Collections.Generic;
using System.Text;

namespace DocumentationExercise
{
    public class Planet
    {
        public string Name { get; private set; }

        public double Radius { get; private set; }

        public double Volume { get; private set; }

        public double Mass { get; private set; }

        public double Gravity { get; private set; }

        public Planet(string name, double radius, double volume, double mass, double gravity)
        {
            Name = name;
            Radius = radius;
            Volume = volume;
            Mass = mass;
            Gravity = gravity;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
