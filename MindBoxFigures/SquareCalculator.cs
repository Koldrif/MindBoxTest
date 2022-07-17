namespace MindBoxFigures;

public static class SquareCalculator
{
    public static double CalcCircleSquare(double radius)
    {
        if (radius < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        return Math.PI * radius * radius;
    }

    public static double CalcTriangleSquare(double a, double b, double c)
    {
        if (a < 0 || b < 0 || c < 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        if (a + b < 0 || a + c < 0 || b + c < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        double semiPerimeter = (a + b + c) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - a) * (semiPerimeter - b) * (semiPerimeter - c));
    }
}