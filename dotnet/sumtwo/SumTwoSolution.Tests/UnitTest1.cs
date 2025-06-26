namespace SumTwoSolution.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        SumTwoSolution s = new SumTwoSolution();
        int[] nums = new int[] { 2, 7, 11, 15 };
        int target = 9;
        int[] output = new int[] { 0, 1 };
        Assert.Equal(output, s.TwoSum(nums, target));
    }

    [Fact]
    public void Test2()
    {
        SumTwoSolution s = new SumTwoSolution();
        int[] nums = new int[] { 3, 2, 4 };
        int target = 6;
        int[] output = new int[] { 1, 2 };
        Assert.Equal(output, s.TwoSum(nums, target));
    }

    [Fact]
    public void Test3()
    {
        SumTwoSolution s = new SumTwoSolution();
        int[] nums = new int[] { 3, 3 };
        int target = 6;
        int[] output = new int[] { 0, 1 };
        Assert.Equal(output, s.TwoSum(nums, target));
    }

}
