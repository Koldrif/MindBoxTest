namespace MindBoxFigures;

public class Circle : AShape
{
    public Circle(double radius)
    {
        parameters.Add(radius);
    }
    public override double GetSquare()
    {
        return parameters[0] * parameters[0] * Math.PI;
    }
}