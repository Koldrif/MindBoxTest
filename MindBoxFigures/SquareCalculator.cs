namespace MindBoxFigures;

public static class SquareCalculator
{
    public static double CalcCircleSquare(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static double CalcTriangleSquare(double a, double b, double c)
    {
        double semiPerimeter = (a + b + c) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
    }
}