using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using serial;
class Program
{
    static void Main(string[] args)
    {
        List<Character> Characters = new List<Character>();
        List<Actor> Actors = new List<Actor>();

        string filePath = "C:\\Users\\pu61qgw\\Downloads\\lucas-character.json";
        string json;

        Characters.Add(new Character
        {
            Id = 0,
            FirstName = "Philippe-Supercalifragilisticexpialidocious",
            LastName = "Thunderpants",
            Description = "A wildly eccentric character with a love for penguins.",
            actorFk = 0
        });

        Characters.Add(new Character
        {
            Id = 1,
            FirstName = "Philippe-Smelly",
            LastName = "Pants",
            Description = "An adventurer with a mysterious odor that follows him everywhere.",
            actorFk = 1
        });

        Characters.Add(new Character
        {
            Id = 2,
            FirstName = "Philippe-Sparkly",
            LastName = "Funk",
            Description = "A disco dancer who never stops glowing under black lights.",
            actorFk = 2
        });

        Actors.Add(new Actor
        {
            Id = 0,
            FirstName = "Philippe-Crazy",
            LastName = "McFunky",
            BirthDate = new DateTime(1982, 10, 15),
            Country = "France",
            IsAlive = true
        });

        Actors.Add(new Actor
        {
            Id = 1,
            FirstName = "Philippe-Bouncy",
            LastName = "Jellybean",
            BirthDate = new DateTime(1990, 5, 22),
            Country = "Belgium",
            IsAlive = true
        });

        Actors.Add(new Actor
        {
            Id = 2,
            FirstName = "Philippe-Funky",
            LastName = "Cheese",
            BirthDate = new DateTime(1975, 7, 9),
            Country = "Canada",
            IsAlive = true
        });

        Export.SerializeAll(Characters, Actors);

        /*        //json=characteristics.Serialize();
                Character desChar = Character.Deserialize(filePath);
                Console.WriteLine($"Character: {desChar.FirstName} {desChar.LastName}");
                //Console.WriteLine($"Played by: {characteristics.PlayedBy.FirstName} {characteristics.PlayedBy.LastName}");
                Console.ReadLine();*/

    }
}
