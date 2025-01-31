
[TestClass]
public class CalculatorTests
{
    private CalculatorTests? _calculator;

    [TestInitialize]
    public void Setup()
    {
        // Arrange
        _calculator = new Calculator();
    }

    [TestMethod]
    public void Add_ShouldReturnSum_WhenGivenTwoPositiveNumbers()
    {
        // Act
        var result = _calculator.Add(5, 7);

        // Assert
        Assert.AreEqual(12, result);
    }

    private object Add(int v1, int v2)
    {
        throw new NotImplementedException();
    }

    [TestMethod]
    public void Add_ShouldReturnSum_WhenGivenNegativeAndPositiveNumber()
    {
        // Act
        var result = _calculator.Add(-3, 7);

        // Assert
        Assert.AreEqual(4, result);
    }
}

internal class TestMethodAttribute : Attribute
{
}

internal class Calculator : CalculatorTests
{
}

internal class TestInitializeAttribute : Attribute
{
}

internal class TestClassAttribute : Attribute
{
}