namespace MindBoxFigures;

public class Triangle : AShape
{
    public Triangle(double a, double b, double c)
    {
        parameters.Add(a);
        parameters.Add(b);
        parameters.Add(c);
    }
    public override double GetSquare()
    {
        return CalcTriangleSquare();
    }
    public double CalcTriangleSquare()
    {
        if (parameters[0] < 0 || parameters[1] < 0 || parameters[2] < 0)
        {
            throw new ArgumentOutOfRangeException();
        }

        if (parameters[0] + parameters[1] < 0 || parameters[0] + parameters[2] < 0 || parameters[1] + parameters[2] < 0)
        {
            throw new ArgumentOutOfRangeException();
        }
        double semiPerimeter = (parameters[0] + parameters[1] + parameters[2]) / 2;
        return Math.Sqrt(semiPerimeter * (semiPerimeter - parameters[0]) * (semiPerimeter - parameters[1]) * (semiPerimeter - parameters[2]));
    }

    public bool IsRightTriangle()
    {
        var maxSide = parameters.Max();
        var maxIndex = parameters.FindIndex((a) => a == maxSide);
        double tmp = default;
        for (int i = 0; i < parameters.Count; i++)
        {
            if (i == maxIndex) continue;
            tmp += parameters[i] * parameters[i];
        }

        return Math.Abs(tmp - maxSide * maxSide) < 1e-9;
    }
}