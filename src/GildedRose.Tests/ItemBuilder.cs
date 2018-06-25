using GildedRose.Console;

namespace GildedRose.Tests
{
    public class ItemBuilder
    {
        private string _name;
        private int _quality;
        private int _sellIn;

        public ItemBuilder()
        {
            WithName("TestName");
            WithQuality(52);
            WithSellIn(42);
        }

        public ItemBuilder WithName(string value)
        {
            _name = value;
            return this;
        }

        public ItemBuilder WithQuality(int value)
        {
            _quality = value;
            return this;
        }

        public ItemBuilder WithSellIn(int value)
        {
            _sellIn = value;
            return this;
        }

        public Item Build()
        {
            var item = new Item();
            item.Name = _name;
            item.Quality = _quality;
            item.SellIn = _sellIn;
            return item;
        }
    }
}
