public class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        int maxCandies = 0;
        foreach(int candy in candies)
        {
            if(candy > maxCandies)
            {
                maxCandies = candy;
            }
        }

        List<bool> result = new List<bool>();
        foreach(int candy in candies)
        {
            if(candy + extraCandies >= maxCandies)
            {
                result.Add(true);
            }
            else
            {
                result.Add(false);
            }
        }
        return result;
    }
}