public class Solution
{
    public void ReverseString(char[] s)
    {
        Array.Reverse(s);
    }
}



//2. Cozum - Algoritmayı kendimiz kuralım.
/*
 * Adım 1 = charın uzunlugunu al. 
 * Adım 2 = 0. char n'e esit olsun
 * Adım 3 = k. char n-k+1'e esit olsun
 */


public void ReverVoid(char[] s)
{
    int n = s.Length;
    int k = 0;
    int j = n - 1 ;
    while (k < j) 
    {
        char temp = s[k]; 
        s[k] = s[j]; 
        s[j] = temp; 

        k++; 
        j--; 
    }
}