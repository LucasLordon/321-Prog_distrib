// Character.cs
using System;
using System.IO;
using System.Text.Json;

namespace serial
{
    internal class Character
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public int actorFk { get; set; }

        public string Serialize()
        {
            string fileName = "C:\\Users\\pu61qgw\\Documents\\GitHub\\321-Prog_distrib\\perso\\ntp1\\serial\\myJsonCharacter.json";
            string jsonString = JsonSerializer.Serialize(this); 
            File.WriteAllText(fileName, jsonString); 
            string fileContent = File.ReadAllText(fileName);
            Console.WriteLine(fileContent);
            return fileContent;
        }

        public static Character Deserialize(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);

            Character newCharacter = JsonSerializer.Deserialize<Character>(jsonString);

            return newCharacter;
        }

    }
}
