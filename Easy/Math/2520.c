#include <stdio.h>
int countDigits(int num)
{
    int originalNum = num;
    int x;
    int count = 0;
    while (num != 0)
    {
        x = num % 10;
        if (x != 0 && originalNum % x == 0)
        {
            count++;
        }
        num /= 10;
    }
    return count;
}
int main()
{
}