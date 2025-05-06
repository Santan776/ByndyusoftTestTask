namespace ByndyusoftTestTask.Tests;

[TestFixture]
public class ArrayUtilsTests
{
    [Test]
    public void SumOfTwoSmallest_NormalArray_ReturnsCorrectSum()
    {
        int[] numbers = { 4, 0, 3, 19, 492, -10, 1 };
        
        var result = ArrayUtils.SumOfTwoSmallest(numbers);
        
        Assert.That(result, Is.EqualTo(-10)); // -10 + 0 = -10
    }

    [Test]
    public void SumOfTwoSmallest_DuplicateValues_ReturnsCorrectSum()
    {
        int[] numbers = { 5, 5, 10, 5, 20 };
        
        var result = ArrayUtils.SumOfTwoSmallest(numbers);
        
        Assert.That(result, Is.EqualTo(10)); // 5 + 5 = 10
    }

    [Test]
    public void SumOfTwoSmallest_TwoElementsOnly_ReturnsCorrectSum()
    {
        int[] numbers = { 7, 3 };
        
        var result = ArrayUtils.SumOfTwoSmallest(numbers);
        
        Assert.That(result, Is.EqualTo(10)); // 3 + 7 = 10
    }

    [Test]
    public void SumOfTwoSmallest_SingleElement_ThrowsArgumentException()
    {
        int[] numbers = { 5 };
        
        Assert.Throws<ArgumentException>(() => ArrayUtils.SumOfTwoSmallest(numbers));
    }

    [Test]
    public void SumOfTwoSmallest_NullArray_ThrowsArgumentException()
    {
        int[] numbers = null;
        
        Assert.Throws<ArgumentException>(() => ArrayUtils.SumOfTwoSmallest(numbers));
    }
}