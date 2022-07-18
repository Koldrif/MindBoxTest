using System.Collections.Generic;
using System.Reflection;

namespace MindBoxFigures;

public abstract class AShape
{
    public delegate double Method();
    public List<double> parameters = new List<double>();
    public AShape(){}
    public Method GetRightDelegate(AShape shape)
    {
        Type parentShapeType = typeof(AShape);
        IEnumerable<Type> childTypes = Assembly.GetAssembly(parentShapeType).GetTypes()
            .Where(type => type.IsSubclassOf(parentShapeType));
        dynamic proxyShape = new Circle(4);
        foreach (var child in childTypes)
        {
            
            if (shape.GetType() == child)
            {
                var childInstance = Convert.ChangeType(proxyShape, child);
                Method currentDelegate = () => childInstance.GetSquare();
                return currentDelegate;
            }
        }

        throw new NotImplementedException();


    }
    public abstract double GetSquare();
}