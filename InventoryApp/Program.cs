using System;

class Program
{
    static void Main()
    {
        string filePath = "inventory.json";

        // First session
        var app = new InventoryApp(filePath);
        app.SeedSampleData();
        app.SaveData();

        // Simulate clearing memory (new session)
        Console.WriteLine("\n--- Starting New Session ---\n");

        var newApp = new InventoryApp(filePath);
        newApp.LoadData();
        newApp.PrintAllItems();
    }
}
