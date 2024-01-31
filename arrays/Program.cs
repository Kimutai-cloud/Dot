int startingInventory = 100;
int[] inventory = new int[100];


for (int i = 0; i < inventory.Length; i++)
{
    inventory[i] = startingInventory;
}

int bin = 0;

foreach (int item in inventory)
{
    bin++;
    Console.WriteLine($"Bin {bin} = {item} Inventory: Running total {item * bin}");
}
Console.WriteLine($"We have {inventory.Sum()} items in inventory.");
