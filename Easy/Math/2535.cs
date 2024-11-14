public class Solution
{
    public int DifferenceOfSum(int[] nums)
    {
        int elementSum = 0;
        int digitSum = 0;
        foreach (var number in nums)
        {
            elementSum += number;
            int currentNum = number;
            while(currentNum > 0){
                digitSum = digitSum + (currentNum%10);
                currentNum = currentNum / 10;
            }
        }

        return Math.Abs(elementSum - digitSum);
    }
}