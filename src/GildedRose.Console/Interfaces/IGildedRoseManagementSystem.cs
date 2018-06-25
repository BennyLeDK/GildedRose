using System.Collections.Generic;

namespace GildedRose.Console.Interfaces
{
    public interface IGildedRoseManagementSystem
    {
        IList<Item> UpdateQuality(IList<Item> items);
    }
}
