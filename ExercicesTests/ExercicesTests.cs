using exercices;using Xunit;

namespace ExercicesTests
{
    public class ExercicesTests
    {
        [Fact]
        public void Fermat_ShouldReturnFalse_ForNumbersLessThan2()
        {
            // Arrange
            var exercices = new Exercices();

            // Act & Assert
            Assert.False(exercices.Fermat(0)); // 0 is not prime
            Assert.False(exercices.Fermat(1)); // 1 is not prime
            Assert.False(exercices.Fermat(-5)); // Negative numbers are not prime
        }

        [Fact]
        public void Fermat_ShouldReturnTrue_ForSmallPrimes()
        {
            // Arrange
            var exercices = new Exercices();

            // Act & Assert
            Assert.True(exercices.Fermat(2)); // 2 is prime
            Assert.True(exercices.Fermat(3)); // 3 is prime
            Assert.True(exercices.Fermat(5)); // 5 is prime
            Assert.True(exercices.Fermat(7)); // 7 is prime
        }

        [Fact]
        public void Fermat_ShouldReturnFalse_ForSmallComposites()
        {
            // Arrange
            var exercices = new Exercices();

            // Act & Assert
            Assert.False(exercices.Fermat(4)); // 4 is composite
            Assert.False(exercices.Fermat(6)); // 6 is composite
            Assert.False(exercices.Fermat(8)); // 8 is composite
            Assert.False(exercices.Fermat(9)); // 9 is composite
        }

        [Fact]
        public void Fermat_ShouldReturnTrue_ForLargerPrimes()
        {
            // Arrange
            var exercices = new Exercices();

            // Act & Assert
            Assert.True(exercices.Fermat(11)); // 11 is prime
            Assert.True(exercices.Fermat(13)); // 13 is prime
            Assert.True(exercices.Fermat(17)); // 17 is prime
            Assert.True(exercices.Fermat(19)); // 19 is prime
            Assert.True(exercices.Fermat(23)); // 23 is prime
        }

        [Fact]
        public void Fermat_ShouldReturnFalse_ForLargerComposites()
        {
            // Arrange
            var exercices = new Exercices();

            // Act & Assert
            Assert.False(exercices.Fermat(15)); // 15 is composite
            Assert.False(exercices.Fermat(21)); // 21 is composite
            Assert.False(exercices.Fermat(25)); // 25 is composite
            Assert.False(exercices.Fermat(27)); // 27 is composite
        }

        [Fact]
        public void Fermat_ShouldHandleCarmichaelNumbers()
        {
            // Arrange
            var exercices = new Exercices();

            // Act & Assert
            Assert.False(exercices.Fermat(561)); // 561 is a Carmichael number (composite)
            Assert.False(exercices.Fermat(1105)); // 1105 is a Carmichael number (composite)
            Assert.False(exercices.Fermat(1729)); // 1729 is a Carmichael number (composite)
        }

        [Fact]
        public void Fermat_ShouldHandleEdgeCases()
        {
            // Arrange
            var exercices = new Exercices();

            // Act & Assert
            Assert.False(exercices.Fermat(int.MinValue)); // Large negative number
            Assert.True(exercices.Fermat(int.MaxValue)); // int.MaxValue is not prime
        }
  
        [Fact]
        public void BasicImproved_ShouldReturnFalse_ForNumberLessThanOrEqualTo1()
        {
            // Arrange
            var exercices = new Exercices();

            // Act & Assert
            Assert.False(exercices.BasicImproved(0)); // 0 is not prime
            Assert.False(exercices.BasicImproved(1)); // 1 is not prime
        }

        [Fact]
        public void BasicImproved_ShouldReturnTrue_ForSmallPrimes()
        {
            // Arrange
            var exercices = new Exercices();

            // Act & Assert
            Assert.True(exercices.BasicImproved(2)); // 2 is prime
            Assert.True(exercices.BasicImproved(3)); // 3 is prime
            Assert.True(exercices.BasicImproved(5)); // 5 is prime
            Assert.True(exercices.BasicImproved(7)); // 7 is prime
        }

        [Fact]
        public void BasicImproved_ShouldReturnFalse_ForSmallComposites()
        {
            // Arrange
            var exercices = new Exercices();

            // Act & Assert
            Assert.False(exercices.BasicImproved(4)); // 4 is composite
            Assert.False(exercices.BasicImproved(6)); // 6 is composite
            Assert.False(exercices.BasicImproved(8)); // 8 is composite
            Assert.False(exercices.BasicImproved(9)); // 9 is composite
        }

        [Fact]
        public void BasicImproved_ShouldReturnTrue_ForLargerPrimes()
        {
            // Arrange
            var exercices = new Exercices();

            // Act & Assert
            Assert.True(exercices.BasicImproved(11)); // 11 is prime
            Assert.True(exercices.BasicImproved(13)); // 13 is prime
            Assert.True(exercices.BasicImproved(17)); // 17 is prime
            Assert.True(exercices.BasicImproved(19)); // 19 is prime
            Assert.True(exercices.BasicImproved(23)); // 23 is prime
        }

        [Fact]
        public void BasicImproved_ShouldReturnFalse_ForLargerComposites()
        {
            // Arrange
            var exercices = new Exercices();

            // Act & Assert
            Assert.False(exercices.BasicImproved(15)); // 15 is composite
            Assert.False(exercices.BasicImproved(21)); // 21 is composite
            Assert.False(exercices.BasicImproved(25)); // 25 is composite
            Assert.False(exercices.BasicImproved(27)); // 27 is composite
        }

        [Fact]
        public void BasicImproved_ShouldHandleEdgeCases()
        {
            // Arrange
            var exercices = new Exercices();

            // Act & Assert
            Assert.False(exercices.BasicImproved(-1)); // Negative numbers are not prime
            Assert.False(exercices.BasicImproved(int.MinValue)); // Large negative number
            Assert.True(exercices.BasicImproved(int.MaxValue)); // int.MaxValue is not prime
        }
    }
}
