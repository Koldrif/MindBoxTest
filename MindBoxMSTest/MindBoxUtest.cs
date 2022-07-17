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
        
        Assert.AreEqual(expected, SquareCalculator.CalcCircleSquare(testRadius), 0.001);
    }
}