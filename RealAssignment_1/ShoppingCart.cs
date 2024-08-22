using System;
using System.Collections.Generic;

public class ShoppingCart : ShoppingCartBase1
{
    private List<Item> items;

    public ShoppingCart()
    {
        items = new List<Item>();
    }

    public ShoppingCart(List<Item> items)
    {
        this.items = items;
    }

    public void RemoveItem(string itemName)
    {
        var item = items.Find(i => i.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));
        if (item != null)
        {
            items.Remove(item);
            Console.WriteLine($"{itemName} removed from the cart.");
        }
        else
        {
            Console.WriteLine($"{itemName} not found in the cart.");
        }
    }

    public void ViewCart()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("Your cart is empty.");
        }
        else
        {
            Console.WriteLine("Your shopping cart:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item}");
            }
            Console.WriteLine($"Total price: ${TotalPrice():F2}");
        }
    }

    public decimal TotalPrice()
    {
        decimal total = 0;
        foreach (var item in items)
        {
            total += item.Price;
        }
        return total;
    }

    public override bool Equals(object obj)
    {
        return obj is ShoppingCart cart &&
               EqualityComparer<List<Item>>.Default.Equals(items, cart.items);
    }

    public override int GetHashCode()
    {
        return -452805401 + EqualityComparer<List<Item>>.Default.GetHashCode(items);
    }
}
