public class Solution {
    public bool CheckPerfectNumber(int num)
    {
        int total = 0;
        for (int i = 1; i <num; i++)
        {
            if (num % i == 0)
            {
                total = total + i;
            }
            
        }

        return total == num;
    }
}