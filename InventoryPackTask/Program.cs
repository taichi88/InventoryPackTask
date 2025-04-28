



using InventoryPackTask;
using static InventoryPackTask.PackClass;

Package package;
while (true)
    try
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write("Choose Maximum Weight That your package can carry  No more than 30 kg : ");
    int userInputWeight = Convert.ToInt32(Console.ReadLine().Trim());
    Console.Write("Choose Maximum Volume That your package can carry  No more than 30 Capacity : ");
    int userInputVolume = int.TryParse(Console.ReadLine().Trim(), out var volumeInput) ? volumeInput : throw new Exception("Incorrect format, try again!!!");
    Console.Write("Choose Maximum Quantity of Items That your package can carry  No more than 10 Items ");
    int userInputQuantity = int.TryParse(Console.ReadLine().Trim(), out var quantityInput) ? quantityInput : throw new Exception("Incorrect format, try again!!!");


    package = new Package(userInputWeight, userInputVolume, userInputQuantity);
    package.PackInfo();
    break;


}
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }

while (true)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Choose the Item from the list to add to the package \n");
    try
    {
        foreach (var action in Enum.GetValues<InventoryClass.InventoryItems>())
        { 
            Console.WriteLine($"{(int)action}.{action} ");
        }

        Console.ForegroundColor = ConsoleColor.Green;
        
        var inventoryItemName = Enum.Parse<InventoryClass.InventoryItems>(Console.ReadLine().Trim().ToLower());

            if (!Enum.IsDefined(typeof(InventoryClass.InventoryItems), inventoryItemName))
            throw new Exception("Incorrect input, try again!!!");


             package.AddItem(inventoryItemName);


    
        
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

