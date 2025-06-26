namespace SumTwoSolution;

public class SumTwoSolution
{
    public int[] TwoSum(int[] nums, int target)
    {

        Dictionary<int, int> seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int currentNumber = nums[i];

            int differnece = target - currentNumber;

            if (seen.ContainsKey(differnece))
            {
                int firstLocation = seen[differnece];
                int secondLocation = i;
                return new int[] { firstLocation, secondLocation };
            }
            else
            {
                if (!seen.ContainsKey(currentNumber))
                {
                    seen.Add(currentNumber, i);
                }
            }

        }

        return new int[] { };

    }
}
