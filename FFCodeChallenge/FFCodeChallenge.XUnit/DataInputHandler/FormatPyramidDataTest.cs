using Xunit;
using AutoFixture;
using FFCodeChallenge.DataInputHandler;

namespace FFCodeChallenge.XUnit.DataInputHandler
{
    public class FormatPyramidDataTest
    {
        [Fact]
        public void checkThatAllElementsLinesAreInArray()
        {
            //Arrange
            int[][] Triangle = new int[4][];
            Triangle[0] = new int[1] { 2 };
            Triangle[1] = new int[2] { 3, 5 };
            Triangle[2] = new int[3] { 4, 3, 6 };
            Triangle[3] = new int[4] { 1, 2, 3, 4 };

            Fixture fixture = new Fixture();

            var sut = fixture.Create<FormatPyramidData>();
            //Act
            var result = sut.GetFormattedData("C:/Users/micpe/source/repos/FFCodeChallenge/FFCodeChallenge.XUnit/test.txt");
            
            //Assert
            Assert.Equal(4, result.Length);
            Assert.Equal(Triangle, result);
        }
    }
}
