using System;
using System.Collections.Generic;

namespace lists {
    class Program {
        static void Main (string[] args) {
            List<string> planetList = new List<string> () {
                "Mercury",
                "Mars"
            };
            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");

            List<string> lastPlanets = new List<string> () {
                "Uranus",
                "Neptune"
            };
            planetList.AddRange (lastPlanets);
            planetList.Insert (1, "Venus");
            planetList.Insert (2, "Earth");
            planetList.Add ("Pluto");

            List<string> rockyPlanets = new List<string> () { };
            rockyPlanets = planetList.GetRange (0, 4);
            foreach (string planet in rockyPlanets) {
                Console.WriteLine (planet);
            }
            planetList.Remove ("Pluto");
            foreach (string planet in planetList) {
                Console.WriteLine (planet);
            }
            Dictionary<string, string> probes = new Dictionary<string, string> ();
            probes["Mars"] = "Viking";
            probes["Venus"] = "Venera 7";
            probes["Jupiter"] = "Voyager 2";
            probes["Mercury"] = "Mariner 10";

            foreach (KeyValuePair<string, string> probe in probes) { Console.WriteLine ($"{probe.Value}, {probe.Key}"); }

            foreach (string planet in planetList) // iterate planets
            {
                List<string> matchingProbes = new List<string> ();

                foreach (KeyValuePair<string, string> probe in probes) // iterate probes
                {
                    if (probe.Key.Contains (planet)) {
                        matchingProbes.Add (probe.Value);
                    }
                }
                Console.WriteLine ($"{planet}: { String.Join(",", matchingProbes)}");
            }
        }
    }
}