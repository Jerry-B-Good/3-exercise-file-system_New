using System;
using System.IO;
using System.Linq;
using System.Text.Json;
// Define the JSON file structure
using Concept;


class Program
{
    static void Main()
    {
        // Graphical data JSON file string
        string structDat = "Software_Dev.json";

        if (!File.Exists(structDat))
        {
            Console.WriteLine("Error: Software_Dev.json file not found.");
            return;
        }

        // Read the JSON string
        string rawStruct = File.ReadAllText(structDat);

        // Parse the JSON string into c# objects
        DevFile cohortData = JsonSerializer.Deserialize<DevFile>(rawStruct);

        DevNode[] nodeArray = cohortData.Nodes.ToArray();

        // Iterate over that array
        foreach (var node in cohortData.Nodes)
        {
            // Display the contents of those objects
            Console.WriteLine($"Node detail ({node.Type}): {node.Text}");
        }
    }
}