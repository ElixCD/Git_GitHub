using git_github.Models;

// See https://aka.ms/new-console-template for more information

List<Planet> solarSistem = new List<Planet>();

solarSistem.Add(new Planet(){ Id = 1, Name = "Mercury" });
solarSistem.Add(new Planet(){ Id = 2, Name = "Venus" });
solarSistem.Add(new Planet(){ Id = 3, Name = "Earth" });


solarSistem.ForEach(planet => 
    Console.WriteLine("Hello, {0}!", planet.Name)
);

Console.WriteLine("Hello, New World!", solarSistem[2].Name);


