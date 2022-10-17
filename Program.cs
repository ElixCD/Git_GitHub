using git_github.Models;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Rama Moons - Curso Git y Github");

List<Planet> solarSistem = new List<Planet>();

solarSistem.Add(new Planet(){ Id = 1, Name = "Mercury", NumberMoons = 0 });
solarSistem.Add(new Planet(){ Id = 2, Name = "Venus" });
solarSistem.Add(new Planet(){ Id = 3, Name = "Blue Planet" });

solarSistem.Add(new Planet(){ Id = 4, Name = "Mars" });

solarSistem.ForEach(planet => {
    Console.WriteLine("Hello, {0}!", planet.Name);
    Console.WriteLine("The {0} have {1} moons!", planet.Name, planet.NumberMoons);
});

Console.WriteLine("Hello, New World!", solarSistem[2].Name);

