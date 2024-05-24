using Figures.interfaces;
using Figures.Models;
using FluentAssertions;

namespace Figures.UnitTests;

public class FiguresTests
{
    [Fact]
    public void Circle_GetArea_RadiusIsPositive()
    {
        // Arrange
        IFigure circle = new Circle(5);
        
        // Act
        var result = circle.GetArea();
        
        // Assert
        result.Should().BeApproximately(78.54, 0.01);
    }
    
    [InlineData(-1)]
    [InlineData(0)]
    [Theory]
    public void Circle_Create_RadiusIsInvalid_ThrowsArgumentException(double radius)
    {
        // Arrange
        Action action = () => new Circle(radius);
        
        // Act & Assert
        action.Should().Throw<ArgumentException>();
    }
    
    [Fact]
    public void Triangle_GetArea_SidesAreValid()
    {
        // Arrange
        IFigure triangle = new Triangle(3, 4, 5);
        
        // Act
        var result = triangle.GetArea();
        
        // Assert
        result.Should().BeApproximately(6, 0.01);
    }
    
    [InlineData(-1, 1, 1)]
    [InlineData(1, -1, 1)]
    [InlineData(1, 1, -1)]
    [InlineData(3, 4, 8)]
    [InlineData(8, 4, 3)]
    [InlineData(3, 8, 4)]
    [Theory]
    public void Triangle_Create_SidesAreInvalid_ThrowsArgumentException(double sideA, double sideB, double sideC)
    {
        // Arrange
        Action action = () => new Triangle(sideA, sideB, sideC);
        
        // Act & Assert
        action.Should().Throw<ArgumentException>();
    }
}