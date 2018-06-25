using GildedRose.Console;
using GildedRose.Console.BusinessLog;
using GildedRose.Console.Interfaces;
using Moq;

namespace GildedRose.Tests
{
    public class GildedRoseManagementSystemTestBuilder
    {
        private IGildedRoseItem[] _itemTypes;

        public GildedRoseManagementSystemTestBuilder()
        {
            WithItemTypes(DefaultQualityEngineMock().Object);
        }
        public static Mock<IGildedRoseItem> DefaultQualityEngineMock()//TODO - might be obsolete
        {
            var item = new ItemBuilder()
                .Build();

            var mock = new Mock<IGildedRoseItem>(MockBehavior.Strict);
            mock.Setup(x => x.UpdateItem(It.IsAny<Item>())).Returns(item);
            return mock;
        }

        public GildedRoseManagementSystemTestBuilder WithItemTypes(params IGildedRoseItem[] value)
        {
            _itemTypes = value;
            return this;
        }

        public GildedRoseManagementSystem Build()
        {
            var gildedRoseManagementSystem = new GildedRoseManagementSystem(_itemTypes);
            return gildedRoseManagementSystem;
        }
    }
}
