public class Solution
{
    public bool IsFascinating(int n)
    {
        string num1 = Convert.ToString(n * 2);
        string num2 = Convert.ToString(n * 3);
        string num3 = Convert.ToString(n);
        string total = string.Concat(num1, num2, num3);

        if (total.Contains('0'))
        {
            return false;
        }

        char[] chars = total.ToCharArray();
        
        //Bubble sort'u kendim yazdim
        for (int i = 0; i < chars.Length - 1; i++)
        {
            for (int j = 0; j < chars.Length - i - 1; j++)
            {
                if (chars[j] > chars[j + 1])
                {
                    char temp = chars[j];
                    chars[j] = chars[j + 1];
                    chars[j + 1] = temp;
                }
            }
        }

        string sorted = new string(chars);

        return sorted == "123456789";
    }
}