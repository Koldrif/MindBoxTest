using System.Collections;

namespace MindBoxFigures;

public static class SquareCalculator
{
    public static double CalcCircleSquare(double param)
    {
        if (param < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        return Math.PI * param * param;
    }
    
    public static double CalcCircleSquare(Circle param)
    {
        return param.GetSquare();
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

    public static double CalcTriangleSquare(List<double> collection)
    {
        if (collection[0] < 0 || collection[1] < 0 || collection[2] < 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        if (collection[0] + collection[1] < 0 || collection[0] + collection[2] < 0 || collection[1] + collection[2] < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        double semiPerimeter = (collection[0] + collection[1] + collection[2]) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - collection[0]) * (semiPerimeter - collection[1]) * (semiPerimeter - collection[2]));
    }
    
    public static double CalcTriangleSquare(Triangle triangle)
    {
        return triangle.GetSquare();
    }

    public static bool IsRightTriangle(Triangle triangle)
    {
        return triangle.IsRightTriangle();
    }

    public static double GetSquare(AShape figure)
    {
        AShape.Method method = figure.GetRightDelegate(figure);
        return method();
        //return figure.GetSquare();
    }

    public static double GetSquare(double r)
    {
        return CalcCircleSquare(r);
    }
    
};
