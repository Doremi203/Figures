using Figures.Models;
using FluentAssertions;

namespace Figures.UnitTests;

public class TriangleTests
{
    [InlineData(3, 4, 5)]
    [InlineData(10, 6, 8)]
    [Theory]
    public void IsRight_TriangleIsRight_ReturnsTrue(double sideA, double sideB, double sideC)
    {
        // Arrange
        var triangle = new Triangle(sideA, sideB, sideC);
        
        // Act
        var result = triangle.IsRight();
        
        // Assert
        result.Should().BeTrue();
    }
    
    [InlineData(3, 4, 6)]
    [InlineData(10, 6, 7)]
    [Theory]
    public void IsRight_TriangleIsNotRight_ReturnsFalse(double sideA, double sideB, double sideC)
    {
        // Arrange
        var triangle = new Triangle(sideA, sideB, sideC);
        
        // Act
        var result = triangle.IsRight();
        
        // Assert
        result.Should().BeFalse();
    }
}