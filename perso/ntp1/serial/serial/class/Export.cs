using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace serial
{
    internal class Export
    {
        public static void SerializeAll(List<Character> characters, List<Actor> actors)
        {
            string fileName = "C:\\Users\\pu61qgw\\Documents\\GitHub\\321-Prog_distrib\\perso\\ntp1\\serial\\myData.json";
            var data = new
            {
                Characters = characters,
                Actors = actors
            };
            string jsonString = JsonSerializer.Serialize(data, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(fileName, jsonString);
            string fileContent = File.ReadAllText(fileName);
            Console.WriteLine(fileContent);
        }
    }
}
