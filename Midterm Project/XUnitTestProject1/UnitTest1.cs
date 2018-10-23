using System;
using Xunit;
using CalculationsLib;

namespace CalculationsLibUnitTests
{
    public class CalculatorTest
    {
        [Fact]
        public void TestAdding2and2()
        {
        //arrange
        double a = 2;
        double b = 2;
        double expected = 4;
        var test = new Calculations();
        //act
        double actual = test.Add(a, b);
        //assert
        Assert.Equal(expected, actual);
        }

    [Fact]
    public void TestAdding3and2()
    {
        //arrange
        double a = 3;
        double b = 2;
        double expected = 5;
        var test = new Calculations();
        //act
        double actual = test.Add(a, b);
        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestSubtracting3and2()
    {
        //arrange
        double a = 3;
        double b = 2;
        double expected = 1;
        var test = new Calculations();
        //act
        double actual = test.Subtract(a, b);
        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestSubtracting9and5()
    {
        //arrange
        double a = 9;
        double b = 5;
        double expected = 4;
        var test = new Calculations();
        //act
        double actual = test.Subtract(a, b);
        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestMultiplying3and2()
    {
        //arrange
        double a = 3;
        double b = 2;
        double expected = 6;
        var test = new Calculations();
        //act
        double actual = test.Multiply(a, b);
        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestMultiplying5and5()
    {
        //arrange
        double a = 5;
        double b = 5;
        double expected = 25;
        var test = new Calculations();
        //act
        double actual = test.Multiply(a, b);
        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestDividing6and2()
    {
        //arrange
        decimal a = 6;
        decimal b = 2;
        decimal expected = 3;
        var test = new Calculations();
        //act
        decimal actual = test.Divide(a, b);
        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestDividing9and9()
    {
        //arrange
        decimal a = 9;
        decimal b = 9;
        decimal expected = 1;
        var test = new Calculations();
        //act
        decimal actual = test.Divide(a, b);
        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestMean()
    {
        //arrange
        double[] arr = { 3, 5, 7, 9, 11 };
        double expected = 7;
        var test = new Calculations();
        //act
        double actual = test.Mean(arr);
        //assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestMedian()
    {
        //arrange
        double[] arr = { 23, 12, 2, 19, 5 };
        double expected = 12;
        var test = new Calculations();
        //act
        double actual = test.Median(arr);
        //assert
        Assert.Equal(expected, actual);
    }
}
}
