using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace PlanetsAndSpaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Planets and Spaceships!");
            Console.WriteLine("The planets in our solor system are...");

            List<string> planetList = new List<string>() { "Mercury", "Mars" };


            planetList.Add("Jupiter");
            planetList.Add("Saturn");


            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune" };


            planetList.AddRange(lastTwoPlanets);


            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");


            planetList.Add("Pluto");


            foreach (string planet in planetList)
            {
                Console.WriteLine(planet);
            }





            Console.WriteLine(new string('-', 100));
            Console.WriteLine("Now let's slice out only the rocky planets.");


            var rockyPlanets = planetList.GetRange(0, 4);

            foreach (string rockyPlanet in rockyPlanets)
            {
                Console.WriteLine(rockyPlanet);
            }




            Console.WriteLine(new string('-', 100));
            Console.WriteLine("No dwarf planets allowed!");

            planetList.Remove("Pluto");


            foreach (string realPlanet in planetList)
            {
                Console.WriteLine(realPlanet);
            }


            Console.WriteLine(new string('-', 100));
            


            /*
            1. Create a dictionary that will hold the name of a spacecraft that we have launched, and a list of names of the planets that it has visited.
            Remember that List is a Type just like native types(such as string, int, &bool) and your custom types(such as Movie, Dog, and Food). 
            These types can be passed to anything, like a dictionary.
            */

            //Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune

            // these are the lists that will be passed into value part of a definition
            var mercuryOrbiters = new List<string> { "Messenger", "BepiColombo" };
            var venusOrbiters = new List<string> { "Venera 9", "Pioneer Venus Orbiter", "Magellan" };
            var earthOrbiters = new List<string> { "Juno", "Rosetta", "Stardust"};
            var marsOrbiters = new List<string> { "Mariner 9", "Mars 2", "Viking Orbiter 1"};
            var jupiterOrbiters = new List<string> { "Galieo Orbiter", "Juno", "Voyager 2" };
            var saturnOrbiters = new List<string> { "Voyager 1", "Voyager 2", "Pioneer 11"};
            var uranusOrbiters = new List<string> { "Voyager 2" };
            var neptuneOrbiters = new List<string> { "Voyager 2" };


            // create new dictionary
            var orbiters = new Dictionary<string, List<string>>();


            // combine the string and list and add to the dictionary
            orbiters.Add("Mercury", mercuryOrbiters);
            orbiters.Add("Venus", venusOrbiters);
            orbiters.Add("Earth", earthOrbiters);
            orbiters.Add("Mars", marsOrbiters);
            orbiters.Add("Jupiter", jupiterOrbiters);
            orbiters.Add("Saturn", saturnOrbiters);
            orbiters.Add("Uranus", uranusOrbiters);
            orbiters.Add("Neptune", neptuneOrbiters);



            /*
            2.Iterate over your list of planets from above, and inside that loop,
            iterate over the dictionary.Write to the console, for each planet,
            which satellites have visited which planet.
            */

            
            Console.WriteLine("Here's a short list of satellites that have visited each planet.");
            Console.WriteLine("\b");




            foreach (var key in orbiters.Keys)
            {
                Console.WriteLine(key);
                foreach (var value in orbiters[key])
                {
                    Console.WriteLine(value);
                }
                Console.WriteLine("\b");

            }



            Console.ReadLine();
        }
    }
}
