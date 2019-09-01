using NUnit.Framework;
using WarmupChallenges.Solutions.SockMerchant;

namespace WarmupChallenges.Tests.SockMerchant
{
    [TestFixture]
    public class SockMerchant_Should
    {
        [Test]
        public void ReturnZero_WhenNoSockPairsArePassed()
        {
            // Arrange
            var numberOfSocks = 5;
            var colorsOfSocks = new int[5] { 10, 20, 30, 40, 50 };

            // Act
            var actual = Startup.NumberOfSockPairs(colorsOfSocks, numberOfSocks);

            // Assert
            Assert.AreEqual(0, actual);
        }

        [Test]
        public void ReturnTwo_WhenFiveSocksOfOneColorArePassed()
        {
            // Arrange
            var numberOfSocks = 10;
            var colorsOfSocks = new int[10] { 10, 10, 20, 30, 40, 10, 50, 10, 10, 15 };

            // Act
            var actual = Startup.NumberOfSockPairs(colorsOfSocks, numberOfSocks);

            // Assert
            Assert.AreEqual(2, actual);
        }

        [Test]
        public void ReturnThree_WhenSixSocksOfOneColorArePassed()
        {
            // Arrange
            var numberOfSocks = 10;
            var colorsOfSocks = new int[10] { 10, 10, 20, 30, 40, 10, 50, 10, 10, 10 };

            // Act
            var actual = Startup.NumberOfSockPairs(colorsOfSocks, numberOfSocks);

            // Assert
            Assert.AreEqual(3, actual);
        }

        [Test]
        public void ReturnFour_WhenSixSocksOfOneColorAndTwoOfAnotherColorArePassed()
        {
            // Arrange
            var numberOfSocks = 10;
            var colorsOfSocks = new int[10] { 10, 10, 20, 10, 20, 10, 50, 10, 10, 20 };

            // Act
            var actual = Startup.NumberOfSockPairs(colorsOfSocks, numberOfSocks);

            // Assert
            Assert.AreEqual(4, actual);
        }
    }
}
