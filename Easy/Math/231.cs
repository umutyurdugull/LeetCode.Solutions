public class Solution {
    public bool IsPowerOfTwo(int n) {
        int power = 0;
        /*
        1. Adım - Döngü içerisinde power atamasını yap         
        */
        for (int i = 0; i < Math.Pow(2,31); i++)
        {
            if(n == Math.Pow(n,i)){
                return true;
            }
            else{
                i = i + 1;
                
            }
        }
    }
}