using Figures.interfaces;

namespace Figures.Models;

public class Circle : IFigure
{
    public double Radius { get; }
    
    public Circle(double radius)
    {
        Radius = radius;
        
        AssertRadiusIsPositive();
    }
    
    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
    
    private void AssertRadiusIsPositive()
    {
        if (Radius <= 0)
        {
            throw new ArgumentException("Radius must be positive");
        }
    }
}