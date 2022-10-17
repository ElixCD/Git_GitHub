using git_github.Models;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Rama principal");

List<Planet> solarSistem = new List<Planet>();

solarSistem.Add(new Planet(){ Id = 1, Name = "Mercury" });
solarSistem.Add(new Planet(){ Id = 2, Name = "Venus" });
solarSistem.Add(new Planet(){ Id = 3, Name = "Blue Planet" });

solarSistem.Add(new Planet(){ Id = 4, Name = "Mars" });

solarSistem.ForEach(planet => 
    Console.WriteLine("Hello, {0}!", planet.Name)
);

Console.WriteLine("Hello, New World!", solarSistem[2].Name);

