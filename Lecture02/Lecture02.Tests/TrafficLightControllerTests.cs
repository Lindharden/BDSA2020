using System;
using Xunit;

namespace Lecture02.Tests
{
    using static TrafficLightColor;

    public class TrafficLightControllerTests
    {
        [Theory]
        [InlineData(Green, true)]
        [InlineData(Yellow, false)]
        [InlineData(Red, false)]
        public void MayIGo_given_color_returns_expected(TrafficLightColor color, bool expected)
        {
            var ctrl = new TrafficLightController();

            var actual = ctrl.MayIGo(color);

            Assert.Equal(actual, expected);
        }

        [Fact]
        public void MayIGo_given_invalid_color_throws()
        {
            var ctrl = new TrafficLightController();

            var actual = Assert.Throws<ArgumentException>(() => ctrl.MayIGo((TrafficLightColor)42));

            Assert.Equal("Invalid color (Parameter 'color')", actual.Message);
        }
    }
}
