using Figures.interfaces;

namespace Figures.Models;

public class Triangle : IFigure
{
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }
    
    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        
        AssertSidesArePositive();
        AssertSidesAreValid();
    }
    
    public double GetArea()
    {
        var p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }
    
    public bool IsRight()
    {
        var sides = new[] { SideA, SideB, SideC };
        Array.Sort(sides);
        return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 0.001;
    }
    
    private void AssertSidesArePositive()
    {
        if (SideA <= 0 || SideB <= 0 || SideC <= 0)
        {
            throw new ArgumentException("Sides must be positive");
        }
    }
    
    private void AssertSidesAreValid()
    {
        if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
        {
            throw new ArgumentException("Invalid sides");
        }
    }
}