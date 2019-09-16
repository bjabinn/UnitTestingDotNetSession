using System;
using Xunit;

namespace XUnitTestProject2
{
    public class DateTimeExtensionsTests
    {
        [Fact]
        public void RoundToNearestHour_Round_Down_Same_Day()
        {
            var dateTime = new DateTime(2018, 06, 01, 08, 05, 27);

            var result = dateTime.RoundToNearestHour();

            Assert.Equal(2018, result.Year);
            Assert.Equal(06, result.Month);
            Assert.Equal(01, result.Day);
            Assert.Equal(08, result.Hour);
            Assert.Equal(00, result.Minute);
            Assert.Equal(00, result.Second);
        }

        [Fact]
        public void RoundToNearestHour_Round_Up_Same_Day()
        {
            var dateTime = new DateTime(2018, 06, 01, 17, 43, 59);

            var result = dateTime.RoundToNearestHour();

            Assert.Equal(2018, result.Year);
            Assert.Equal(06, result.Month);
            Assert.Equal(01, result.Day);
            Assert.Equal(18, result.Hour);
            Assert.Equal(00, result.Minute);
            Assert.Equal(00, result.Second);
        }

        [Fact]
        public void RoundToNearestHour_Round_Up_Next_Day()
        {
            var dateTime = new DateTime(2018, 06, 01, 23, 57, 42);

            var result = dateTime.RoundToNearestHour();

            Assert.Equal(2018, result.Year);
            Assert.Equal(06, result.Month);
            Assert.Equal(02, result.Day);
            Assert.Equal(00, result.Hour);
            Assert.Equal(00, result.Minute);
            Assert.Equal(00, result.Second);
        }
    }
}
