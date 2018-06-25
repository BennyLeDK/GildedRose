using GildedRose.Console.Interfaces;

namespace GildedRose.Console.BusinessLog
{
    public class LegendaryItem : IGildedRoseItem
    {
        public string GetName()
        {
            return "Sulfuras";
        }

        public Item UpdateItem(Item item)
        {
            return item;
        }
    }
}
