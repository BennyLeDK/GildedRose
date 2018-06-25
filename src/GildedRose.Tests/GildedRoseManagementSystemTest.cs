using System.Collections.Generic;
using GildedRose.Console;
using GildedRose.Console.BusinessLog;
using GildedRose.Console.Interfaces;
using Moq;
using Xunit;

namespace GildedRose.Tests
{
    public class GildedRoseManagementSystemTest
    {
        [Fact]
        public void TEST_UpdateQuality_GIVEN_ItemNameMatchAItemType_THEN_ItUpdatesItem()
        {
            var name = "foo";

            var item = new ItemBuilder()
                .WithName(name)
                .Build();

            var itemTypeMock = new Mock<IGildedRoseItem>(MockBehavior.Strict);
            itemTypeMock.Setup(x => x.GetName()).Returns(name).Verifiable();
            itemTypeMock.Setup(x => x.UpdateItem(item)).Returns(item).Verifiable();

            var target = new GildedRoseManagementSystemTestBuilder()
                .WithItemTypes(itemTypeMock.Object)
                .Build();

            target.UpdateQuality(new List<Item> { item });

            itemTypeMock.Verify();
        }

        [Fact]
        public void TEST_UpdateQuality_GIVEN_ItemNameDoNotMatchAItemType_THEN_ItUpdatesItemWithNormalItemType()
        {
            var name = "foo";

            var item = new ItemBuilder()
                .WithName(name)
                .Build();

            var itemTypeMock1 = new Mock<IGildedRoseItem>(MockBehavior.Strict);
            itemTypeMock1.Setup(x => x.GetName()).Returns("bar").Verifiable();
            itemTypeMock1.Setup(x => x.GetType()).Returns(typeof(BackstagePassesItem));

            var itemTypeMock2 = new Mock<IGildedRoseItem>(MockBehavior.Strict);
            itemTypeMock2.Setup(x => x.GetName()).Returns("bar").Verifiable();
            itemTypeMock2.Setup(x => x.GetType()).Returns(typeof(NormalItem));
            itemTypeMock2.Setup(x => x.UpdateItem(item)).Returns(item).Verifiable();

            var target = new GildedRoseManagementSystemTestBuilder()
                .WithItemTypes(itemTypeMock1.Object, itemTypeMock2.Object)
                .Build();

            target.UpdateQuality(new List<Item> { item });

            itemTypeMock1.Verify();
            itemTypeMock2.Verify();
        }
    }
}
