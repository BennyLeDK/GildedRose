using Xunit;

namespace GildedRose.Tests
{
    public class AgedBrieItemTest
    {
        [Fact]
        public void TEST_UpdateItems_GIVEN_AgedBrieItemQualityIs0_THEN_ItIncreasesInQualityBy1()
        {
            var expectedQuality = 1;
            var expectedSellIn = 5;

            var item = new ItemBuilder()
                .WithQuality(0)
                .WithSellIn(6)
                .Build();

            var target = new AgedBrieItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedQuality, result.Quality);
            Assert.Equal(expectedSellIn, result.SellIn);

        }

        [Fact]
        public void TEST_UpdateItems_GIVEN_AgedBrieItemQualityIs50_THEN_ItDoNotIncreseQualityHigherThen50()
        {
            var expectedQuality = 50;
            var expectedSellIn = -1;

            var item = new ItemBuilder()
                .WithQuality(50)
                .WithSellIn(0)
                .Build();

            var target = new AgedBrieItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedQuality, result.Quality);
            Assert.Equal(expectedSellIn, result.SellIn);
        }


        [Fact]
        public void TEST_UpdateItems_GIVEN_AgedBrieItemQualityIs20SellInIs0_THEN_ItIncreasesInQualityBy2AndLowerSellInby1()
        {
            var expectedQuality = 22;
            var expectedSellIn = -1;

            var item = new ItemBuilder()
                .WithSellIn(0)
                .WithQuality(20)
                .Build();

            var target = new AgedBrieItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedQuality, result.Quality);
            Assert.Equal(expectedSellIn, result.SellIn);
        }

        [Fact]
        public void TEST_UpdateItems_GIVEN_AgedBrieItemQualityIs49SellInIs0_THEN_ItIncreasesInQualityBy1AndLowerSellInby1()
        {
            var expectedQuality = 50;
            var expectedSellIn = -1;

            var item = new ItemBuilder()
                .WithSellIn(0)
                .WithQuality(49)
                .Build();

            var target = new AgedBrieItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedQuality, result.Quality);
            Assert.Equal(expectedSellIn, result.SellIn);
        }

        [Fact]
        public void TEST_GetName_THEN_ItReturnsAgedBrie()
        {
            var target = new AgedBrieItemTestBuilder()
                .Build();

            var result = target.GetName();

            Assert.Equal("Aged Brie", result);
        }
    }
}