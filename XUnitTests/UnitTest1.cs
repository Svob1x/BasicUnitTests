namespace XUnitTests;
using MyMathLibrary;

public class UnitTest1
{
    [Fact]
    public void UnitTestAdd()
    {
        Assert.Equal(4, MyMathLibrary.Class1.Add(2, 2));
    }
    [Fact]
    public void UnitTestSub()
    {
        Assert.Equal(0, MyMathLibrary.Class1.Subtract(2, 2));
    }
    [Fact]
    public void UnitTestMultiply()
    {
        Assert.Equal(4, MyMathLibrary.Class1.Multiply(2, 2));
    }
    [Fact]
    public void UnitTestDevide()
    {
        Assert.Equal(1.0, MyMathLibrary.Class1.Divide(2, 2));
    }
}