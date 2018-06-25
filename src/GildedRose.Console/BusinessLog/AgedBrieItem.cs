using GildedRose.Console.Interfaces;

namespace GildedRose.Console.BusinessLog
{
    public class AgedBrieItem : IGildedRoseItem
    {
        public string GetName()
        {
            return "Aged Brie";
        }

        public Item UpdateItem(Item item)
        {
            item.SellIn = item.SellIn - 1;
            if (item.Quality < 50)
            {
                if (item.SellIn < 0)
                {
                    item.Quality = item.Quality + 2;
                    if (item.Quality > 50)
                        item.Quality = 50;
                }
                else
                    item.Quality = item.Quality + 1;
            }

            return item;
        }
    }
}
