using System.Collections.Generic;

namespace MindBoxFigures;

public abstract class AShape
{
    public List<double> parameters = new List<double>();
    public abstract double GetSquare();
}