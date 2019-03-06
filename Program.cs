using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>(){"Mercury", "Mars"};

            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            planetList.Add("Pluto");
            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");
            planetList.Remove("Pluto");

            List<string> newPlanetList = new List<string>(){"Neptune", "Uranus"};
            planetList.AddRange(newPlanetList);
            foreach( string planet in planetList ) {
            Console.WriteLine(planet);
            }
            List<string> rockyPlanetst = planetList.GetRange(0, 4);
            rockyPlanetst.ForEach(rocky => Console.WriteLine(rocky));
        }
    }
}
