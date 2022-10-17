using git_github.Models;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Rama principal - Git Github vs gitlab");

List<Planet> solarSistem = new List<Planet>();

solarSistem.Add(new Planet(){ Id = 1, Name = "Mercury", NumberMoons = 0 });
solarSistem.Add(new Planet(){ Id = 2, Name = "Venus" });
solarSistem.Add(new Planet(){ Id = 3, Name = "Blue Planet" });

solarSistem.Add(new Planet(){ Id = 4, Name = "Mars" });

solarSistem.ForEach(planet => {
    Console.WriteLine("Hello, Welcome to {0}!", planet.Name);
    Console.WriteLine("It have {0} moons!", planet.NumberMoons);
});

Console.WriteLine("Hello, New World!", solarSistem[2].Name);

