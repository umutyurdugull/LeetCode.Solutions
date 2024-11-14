int climbStairs(int n) {
    if(n<=2){return n;}
    int prev1 = 2, prev2 = 1, a;
    for(int i = 3;i <=n;i++){
        a = prev1 + prev2;
        prev2 = prev1;
        prev1 = a;
    }
    return a;
}