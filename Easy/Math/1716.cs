public class Solution
{
    public int TotalMoney(int n)
    {
        int totalMoney = 0;

        for (int i = 0; i < n; i++)
        {
            totalMoney += (i / 7) + (i % 7) + 1;
        }

        return totalMoney;
    }
}