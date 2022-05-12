using Xunit;

namespace ClassLibrary1.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var calculator = new Calculator();
        
        var result = calculator.Add(1, 2);
        
        Assert.Equal(4, result);
    }
}
