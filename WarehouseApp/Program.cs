using System;

class Program
{
    static void Main()
    {
        var manager = new WareHouseManager();

        // Seed with initial data
        manager.SeedData();

        Console.WriteLine("=== Grocery Items ===");
        manager.PrintAllItems(manager.GroceriesRepo);

        Console.WriteLine("\n=== Electronic Items ===");
        manager.PrintAllItems(manager.ElectronicsRepo);

        // Try adding duplicate item (will throw DuplicateItemException)
        try
        {
            manager.SeedData();
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nDuplicate Add Error: " + ex.Message);
        }

        // Try removing non-existent grocery item
        manager.RemoveItemById(manager.GroceriesRepo, 99);

        // Try setting invalid quantity for electronics
        try
        {
            manager.ElectronicsRepo.UpdateQuantity(1, -5);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Quantity Update Error: " + ex.Message);
        }
    }
}
