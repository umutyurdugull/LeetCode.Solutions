public class Solution
{
    public int Reverse(int x)
    {
        string y = Math.Abs(x).ToString();

        char[] chars = y.ToCharArray();
        Array.Reverse(chars);

        int reversed = int.Parse(new string(chars));

        return x < 0 ? -reversed : reversed;


    }
}
