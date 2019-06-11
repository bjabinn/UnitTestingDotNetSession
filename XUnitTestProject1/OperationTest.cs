using Xunit;
using xUnitSession;

namespace XUnitTestProject1
{
    public class OperationTest
    {
        private IOperation _operation;

        public OperationTest()
        {
            _operation = new Operation();
        }


        [Fact]
        public void Add_2plus2equal4_True()
        {
            //Arrange

            //Act

            //Assert
            Assert.Equal(4, _operation.Add(2, 2));
        }



        [Fact]
        public void Add_2plus2equal5_False()
        {
            //Arrange

            //Act

            //Assert
            Assert.NotEqual(5, _operation.Add(2, 2));
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]        
        public void IsOdd_3_5and7AreOdd_True(int value)
        {
            Assert.True(_operation.IsOdd(value));
        }
      
    }
}
