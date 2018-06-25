using Xunit;

namespace GildedRose.Tests
{
    public class NormalItemTest
    {
        [Fact]
        public void TEST_UpdateItems_GIVEN_RegularItemQualityIs20SellInIs50_THEN_ItLowerSellInAndQualityValueBy1()
        {
            var expectedQuality = 19;
            var expectedSellIn = 49;

            var item = new ItemBuilder()
                .WithQuality(20)
                .WithSellIn(50)
                .Build();

            var target = new NormalItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedSellIn, result.SellIn);
            Assert.Equal(expectedQuality, result.Quality);
        }

        [Fact]
        public void TEST_UpdateItems_GIVEN_RegularItemQualityIs20SellInIs0_THEN_ItLowerSellInBy1AndQualityLowerBy2()
        {
            var expectedQuality = 18;
            var expectedSellIn = -1;

            var item = new ItemBuilder()
                .WithQuality(20)
                .WithSellIn(0)
                .Build();

            var target = new NormalItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedSellIn, result.SellIn);
            Assert.Equal(expectedQuality, result.Quality);
        }

        [Fact]
        public void TEST_UpdateItems_GIVEN_RegularItemQualityIs0_THEN_ItDoNotLowerQualityBelow0()
        {
            var expectedQuality = 0;

            var item = new ItemBuilder()
                .WithQuality(0)
                .Build();

            var target = new NormalItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedQuality, result.Quality);
        }

        [Fact]
        public void TEST_UpdateItems_GIVEN_RegularItemQualityIs1SellInIs0_THEN_ItLowerSellInBy1AndSetsQualityTo0()
        {
            var expectedQuality = 0;
            var expectedSellIn = -1;

            var item = new ItemBuilder()
                .WithQuality(1)
                .WithSellIn(0)
                .Build();

            var target = new NormalItemTestBuilder()
                .Build();

            var result = target.UpdateItem(item);

            Assert.Equal(expectedQuality, result.Quality);
        }

        [Fact]
        public void TEST_GetName_THEN_ItReturnsNormal()
        {
            var target = new NormalItemTestBuilder()
                .Build();

            var result = target.GetName();

            Assert.Equal("Normal", result);
        }
    }
}
