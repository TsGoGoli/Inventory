
using Inventary.Inventories;
using InventoryManagement;


var pack = new Pack(10, 20, 15); // Max 10 items, 20 weight, 15 volume

while (true)
{
    Console.Clear();
    Console.WriteLine("Pack Inventory Management");
    Console.WriteLine("=========================");
    Console.WriteLine($"Current Items: {pack.CurrentItemCount}/{pack.MaxItems}");
    Console.WriteLine($"Current Weight: {pack.CurrentWeight}/{pack.MaxWeight}");
    Console.WriteLine($"Current Volume: {pack.CurrentVolume}/{pack.MaxVolume}");
    Console.WriteLine();
    Console.WriteLine("1. Add Arrow");
    Console.WriteLine("2. Add Bow");
    Console.WriteLine("3. Add Rope");
    Console.WriteLine("4. Add Water");
    Console.WriteLine("5. Add Food Ration");
    Console.WriteLine("6. Add Sword");
    Console.WriteLine("0. Exit");
    Console.Write("Choose an option: ");
    var choice = Console.ReadLine();

    if (choice == "0")
        break;

    InventoryItem item = choice switch
    {
        "1" => new Arrow(),
        "2" => new Bow(),
        "3" => new Rope(),
        "4" => new Water(),
        "5" => new FoodRation(),
        "6" => new Sword(),
        _ => null
    };

    if (item == null)
    {
        Console.WriteLine("Invalid choice. Press Enter to try again.");
        Console.ReadLine();
        continue;
    }

    if (pack.Add(item))
    {
        Console.WriteLine("Item added successfully!");
    }
    else
    {
        Console.WriteLine("Failed to add item. Pack limits exceeded.");
    }
    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();
}

