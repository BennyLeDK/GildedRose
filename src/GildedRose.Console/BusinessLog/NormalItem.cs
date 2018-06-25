using System;
using GildedRose.Console.Interfaces;

namespace GildedRose.Console.BusinessLog
{
    public class NormalItem : IGildedRoseItem
    {
        public string GetName()
        {
            return "Normal";
        }

        public Item UpdateItem(Item item)
        {
            item.SellIn = item.SellIn - 1;
            if (item.Quality > 0)
            {
                if (item.SellIn < 0)
                {
                    item.Quality = item.Quality - 2;
                    if (item.Quality < 0)
                        item.Quality = 0;
                }
                else
                    item.Quality = item.Quality - 1;
            }

            return item;
        }
    }
}
