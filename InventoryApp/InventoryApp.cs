using System;

public class InventoryApp
{
    private InventoryLogger<InventoryItem> _logger;

    public InventoryApp(string filePath)
    {
        _logger = new InventoryLogger<InventoryItem>(filePath);
    }

    public void SeedSampleData()
    {
        _logger.Add(new InventoryItem(1, "Laptop", 10, DateTime.Now));
        _logger.Add(new InventoryItem(2, "Smartphone", 25, DateTime.Now));
        _logger.Add(new InventoryItem(3, "Headphones", 50, DateTime.Now));
        _logger.Add(new InventoryItem(4, "Keyboard", 15, DateTime.Now));
        _logger.Add(new InventoryItem(5, "Mouse", 20, DateTime.Now));
    }

    public void SaveData()
    {
        _logger.SaveToFile();
    }

    public void LoadData()
    {
        _logger.LoadFromFile();
    }

    public void PrintAllItems()
    {
        var items = _logger.GetAll();
        Console.WriteLine("\n=== Inventory Items ===");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Id} - {item.Name}, Quantity: {item.Quantity}, Date Added: {item.DateAdded}");
        }
    }
}
