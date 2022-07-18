using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBoxFigures;

namespace MindBoxMSTest;

[TestClass]
public class MindBoxUTest
{
    [TestMethod]
    public void TestCircleForOutOfRange()
    {
        double testRadius = -10;
        double expected = Math.PI * testRadius * testRadius;
        
        Assert.ThrowsException<System.ArgumentOutOfRangeException>(() => SquareCalculator.CalcCircleSquare(testRadius));
    }
    [TestMethod]
    public void TestCircleResult()
    {
        double testRadius = 10;
        double expected = Math.PI * testRadius * testRadius;
        
        Assert.AreEqual(expected, SquareCalculator.GetSquare(testRadius), 0.001);
    }

    [TestMethod]
    public void TestTriangleForRightSides()
    {
        var expected = true;
        
        Assert.AreEqual(expected, SquareCalculator.IsRightTriangle(new Triangle(3, 4, 5)));
    }

    [TestMethod]
    public void TestTypeofCheck()
    {
        Circle c = new Circle(100);
        var t = new Triangle(3, 4, 5);
        
        Assert.AreEqual(c.GetSquare(), SquareCalculator.GetSquare(c));
        Assert.AreEqual(t.GetSquare(), SquareCalculator.GetSquare(t));
    }
}