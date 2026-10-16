bool HasItem(int[] inventory, int itemID)
{
    foreach(int item in inventory)
    {
        if(item == itemID)
        {
            return true;
        }

    }
    return false;
}

int[] myInventory ={101, 102, 105, 201};
int searchItem = 105;
bool itemFound = HasItem(myInventory, searchItem);
Console.WriteLine($"Searching for Item ID: {searchItem}");
Console.WriteLine($"Is Item in Inventory? {itemFound}");
