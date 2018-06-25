using Xunit;

namespace GildedRose.Tests
{
    public class BackstagePassesItemTest
    {
        [Fact]
        public void TEST_UpdateItems_GIVEN_BackstagePassesItemQualityIs30SellInIs12_THEN_ItIncreasesQualityBy1SellInLowerBy1()
        {
            var expectedQuality = 31;
            var expectedSellIn = 11;

            var item = new ItemBuilder()
                .WithSellIn(12)
                .WithQuality(30)
                .Build();

            var target = new BackstagePassesItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedQuality, result.Quality);
            Assert.Equal(expectedSellIn, result.SellIn);
        }

        [Fact]
        public void TEST_UpdateItems_GIVEN_BackstagePassesItemQualityIs30SellInIs8_THEN_ItIncreasesQualityBy2SellInLowerBy1()
        {
            var expectedQuality = 32;
            var expectedSellIn = 7;

            var item = new ItemBuilder()
                .WithSellIn(8)
                .WithQuality(30)
                .Build();

            var target = new BackstagePassesItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedQuality, result.Quality);
            Assert.Equal(expectedSellIn, result.SellIn);
        }

        [Fact]
        public void TEST_UpdateItems_GIVEN_BackstagePassesItemQualityIs30SellInIs4_THEN_ItIncreasesQualityBy3SellInLowerBy1()
        {
            var expectedQuality = 33;
            var expectedSellIn = 3;

            var item = new ItemBuilder()
                .WithSellIn(4)
                .WithQuality(30)
                .Build();

            var target = new BackstagePassesItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedQuality, result.Quality);
            Assert.Equal(expectedSellIn, result.SellIn);
        }

        [Fact]
        public void TEST_UpdateItems_GIVEN_BackstagePassesItemQualityIs30SellInIs0_THEN_ItSetsQualityTo0SellInLowerBy1()
        {
            var expectedQuality = 0;
            var expectedSellIn = -2;

            var item = new ItemBuilder()
                .WithSellIn(-1)
                .WithQuality(30)
                .Build();

            var target = new BackstagePassesItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedQuality, result.Quality);
            Assert.Equal(expectedSellIn, result.SellIn);
        }

        [Fact]
        public void TEST_GetName_THEN_ItReturnsBackstagepasses()
        {
            var target = new BackstagePassesItemTestBuilder()
                .Build();

            var result = target.GetName();

            Assert.Equal("Backstage passes", result);
        }
    }
}
