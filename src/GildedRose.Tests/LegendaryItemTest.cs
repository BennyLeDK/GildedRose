using Xunit;

namespace GildedRose.Tests
{
    public class LegendaryItemTest
    {
        [Fact]
        public void TEST_UpdateItems_GIVEN_LegendaryItemQualityIs40AndSellInIs0_THEN_ItDoNotLowerOrEncreaseForQualityAndSellIn()
        {
            var expectedQuality = 40;
            var expectedSellIn = 0;

            var item = new ItemBuilder()
                .WithQuality(40)
                .WithSellIn(0)
                .Build();

            var target = new LegendaryItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedQuality, result.Quality);
            Assert.Equal(expectedSellIn, result.SellIn);
        }

        [Fact]
        public void TEST_GetName_THEN_ItReturnsConjureds()
        {
            var target = new LegendaryItemTestBuilder()
                .Build();

            var result = target.GetName();

            Assert.Equal("Sulfuras", result);
        }
    }
}
