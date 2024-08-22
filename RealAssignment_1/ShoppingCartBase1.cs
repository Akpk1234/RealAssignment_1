using System;

public class ShoppingCartBase1
{

    public void AddItem(Item item)
    {
        items.Add(item);
        Console.WriteLine($"{item.Name} added to the cart.");
    }
}