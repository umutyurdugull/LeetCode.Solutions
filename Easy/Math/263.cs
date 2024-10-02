public class Solution {
    public bool IsUgly(int n) {
        if (n <= 0) return false; 
        int[] divisors = { 2, 3, 5 };
        
        foreach(int divisor in divisors){
            while (n % divisor == 0) {
                n /= divisor;
            }
        }
        
        return n == 1;
    }
}
