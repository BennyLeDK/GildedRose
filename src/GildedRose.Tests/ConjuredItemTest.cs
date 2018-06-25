using Xunit;

namespace GildedRose.Tests
{
    public class ConjuredItemTest
    {
        [Fact]
        public void TEST_UpdateItems_GIVEN_ConjuredItemQualityIs10SellInIs4_THEN_ItLowerSellInBy1AndLowerQualityBy2()
        {
            var expectedQuality = 8;
            var expectedSellIn = 3;

            var item = new ItemBuilder()
                .WithSellIn(4)
                .WithQuality(10)
                .Build();

            var target = new ConjuredItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedQuality, result.Quality);
            Assert.Equal(expectedSellIn, result.SellIn);
        }

        [Fact]
        public void TEST_UpdateItems_GIVEN_ConjuredItemQualityIs50SellInIs0_THEN_ItLowerSellInBy1AndLowerQualityBy4()
        {
            var expectedQuality = 46;
            var expectedSellIn = -1;

            var item = new ItemBuilder()
                .WithSellIn(0)
                .WithQuality(50)
                .Build();

            var target = new ConjuredItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedQuality, result.Quality);
            Assert.Equal(expectedSellIn, result.SellIn);
        }

        [Fact]
        public void TEST_UpdateItems_GIVEN_ConjuredItemQualityIs0SellInIs0_THEN_ItLowerSellInBy1AndDoNotLowerQuality()
        {
            var expectedQuality = 0;
            var expectedSellIn = -1;

            var item = new ItemBuilder()
                .WithSellIn(0)
                .WithQuality(0)
                .Build();

            var target = new ConjuredItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedQuality, result.Quality);
            Assert.Equal(expectedSellIn, result.SellIn);
        }

        [Fact]
        public void TEST_UpdateItems_GIVEN_ConjuredItemQualityIs3SellInIs0_THEN_ItLowerSellInBy1AndSetsLowerQualityTo0()
        {
            var expectedQuality = 0;
            var expectedSellIn = -1;

            var item = new ItemBuilder()
                .WithSellIn(0)
                .WithQuality(3)
                .Build();

            var target = new ConjuredItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedQuality, result.Quality);
            Assert.Equal(expectedSellIn, result.SellIn);
        }

        [Fact]
        public void TEST_UpdateItems_GIVEN_ConjuredItemQualityIs1SellInIs4_THEN_ItLowerSellInBy1AndSetsLowerQualityTo0()
        {
            var expectedQuality = 0;
            var expectedSellIn = 3;

            var item = new ItemBuilder()
                .WithSellIn(4)
                .WithQuality(1)
                .Build();

            var target = new ConjuredItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedQuality, result.Quality);
            Assert.Equal(expectedSellIn, result.SellIn);
        }

        [Fact]
        public void TEST_GetName_THEN_ItReturnsConjureds()
        {
            var target = new ConjuredItemTestBuilder()
                .Build();

            var result = target.GetName();

            Assert.Equal("Conjured", result);
        }
    }
}
