using System;

namespace GildedRose.Console.Interfaces
{
    public interface IGildedRoseItem
    {
        string GetName();
        Item UpdateItem(Item item);
        Type GetType();
    }
}
