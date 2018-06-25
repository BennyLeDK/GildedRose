using GildedRose.Console.Interfaces;

namespace GildedRose.Console.BusinessLog
{
    public class BackstagePassesItem : IGildedRoseItem
    {
        public string GetName()
        {
            return "Backstage passes";
        }

        public Item UpdateItem(Item item)
        {

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
            else if (item.SellIn < 6)
            {
                item.Quality = item.Quality + 3;
            }
            else if (item.SellIn < 11)
            {
                item.Quality = item.Quality + 2;
            }
            else
            {
                item.Quality = item.Quality + 1;
            }
            item.SellIn = item.SellIn - 1;
            if (item.SellIn < 0)
                item.Quality = 0;

            return item;
        }
    }
}
