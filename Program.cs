using git_github.Models;

// See https://aka.ms/new-console-template for more information

Console.WriteLine("Rama principal - Git Github vs gitlab");
Console.WriteLine("Cambio desde github");

List<Planet> solarSistem = new List<Planet>();

solarSistem.Add(new Planet(){ Id = 1, Name = "Mercury", NumberMoons = 0, InternalPlanet = true});
solarSistem.Add(new Planet(){ Id = 2, Name = "Venus" , InternalPlanet = true});
solarSistem.Add(new Planet(){ Id = 3, Name = "Blue Planet" , NumberMoons = 1, InternalPlanet = true });
solarSistem.Add(new Planet(){ Id = 4, Name = "Mars" , NumberMoons = 2, InternalPlanet = true});

solarSistem.Add(new Planet(){ Id = 5, Name = "Jupiter" , NumberMoons = 79, InternalPlanet = false});
solarSistem.Add(new Planet(){ Id = 5, Name = "Saturn" , NumberMoons = 82, InternalPlanet = false});
solarSistem.Add(new Planet(){ Id = 5, Name = "Uranus" , NumberMoons = 27, InternalPlanet = false});
solarSistem.Add(new Planet(){ Id = 5, Name = "Neptune" , NumberMoons = 14, InternalPlanet = false});

solarSistem.ForEach(planet => {
    Console.WriteLine("Hello, Welcome to {0} planet {1}!", (planet.InternalPlanet ? "internal" : "external")  , planet.Name);
    Console.WriteLine("It have {0} moons!", planet.NumberMoons);
});

Console.WriteLine("Hello, New World!", solarSistem[2].Name);

