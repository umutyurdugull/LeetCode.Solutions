#include <stdio.h>

int addDigits(int num)
{
    while (num >= 10)
    {
        int sum = 0;
        while (num > 0)
        {
            sum = sum + (num % 10);
            num = num / 10;
        }
        num = sum;
        printf("%d",num);
        return num;
}
}
int main(void)
{
addDigits(38);
}