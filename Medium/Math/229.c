#include <stdio.h>
int *majorityElement(int *nums, int numsSize, int *returnSize)
{
    int sayac = 0;
    int sayi;
    int x = (sizeof(nums) / sizeof(nums[0])) / 3;
    for (int i = 1; i <= x; i++)
    {
        if (nums[i]== nums[i+1])
        {
            sayac+=1;
            sayi = nums[i];
        }
        
    }
}
int main()
{
    return 0;
}