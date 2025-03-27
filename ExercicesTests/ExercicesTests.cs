
using exercices;
using FluentAssertions;

namespace ExercicesTests;

public class ExercicesTests
{
     
    [Theory]
    [InlineData(3, 1.21, 0, 3.63)]
    [InlineData(3, 1.21, 5, 3.81)]
    [InlineData(3, 1.21, 20, 4.36)]
    public void TestPrixSansRemise(int nbre, decimal pU, int taxe , decimal expected)
    {
       // Arrange
       var ex = new Exercices();
         // Act
        string result  = ex.AffichePrix(nbre, pU,taxe);

        // Assert
        result.Should().Be($"{nbre} articles à {pU} et taxe à {taxe} % - {expected}");

        
    }

    [Theory]
    [InlineData(5, 345, 10, 1840.58)]
    [InlineData(5, 1299, 10, 6787.28)]
    public void TestPrixAvecRemise(int nbre, decimal pU, int taxe , decimal expected)
    {
       // Arrange
       var ex = new Exercices();
         // Act
        string result  = ex.AffichePrix(nbre, pU,taxe);

        // Assert
        result.Should().Be($"{nbre} articles à {pU} et taxe à {taxe} % - {expected}");

        
    }


}
