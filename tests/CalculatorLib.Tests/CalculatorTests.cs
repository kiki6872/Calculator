using CalculatorLib;
using NUnit.Framework;

namespace CalculatorLib.Tests;

[TestFixture]
public class CalculatorTests
{
    private Calculator _calc = null!;

    [SetUp]
    public void Setup() => _calc = new Calculator();

    [Test]
    public void Add_TwoPlusTwo_ReturnsFour() => Assert.That(_calc.Add(2, 2), Is.EqualTo(4));

    [Test]
    public void Subtract_FiveMinusThree_ReturnsTwo() => Assert.That(_calc.Subtract(5, 3), Is.EqualTo(2));

    [Test]
    public void Multiply_ThreeTimesFour_ReturnsTwelve() => Assert.That(_calc.Multiply(3, 4), Is.EqualTo(12));

    [Test]
    public void Divide_TenByTwo_ReturnsFive() => Assert.That(_calc.Divide(10, 2), Is.EqualTo(5.0));

    [Test]
    public void Divide_ByZero_ThrowsDivideByZeroException() =>
        Assert.Throws<DivideByZeroException>(() => _calc.Divide(1, 0));
}

