public class Solution {
    public int CountPrimes(int n) {
        if (n <= 2) return 0; // No primes less than 2
        
        boolean[] isPrime = new boolean[n]; // Create a boolean array to mark prime numbers
        for (int i = 2; i < n; i++) {
            isPrime[i] = true; // Assume all numbers are prime initially
        }

        for (int i = 2; i * i < n; i++) { // Check for factors only up to the square root of n
            if (isPrime[i]) { // If i is a prime
                for (int j = i * i; j < n; j += i) { // Mark all multiples of i as non-prime
                    isPrime[j] = false;
                }
            }
        }

        int count = 0;
        for (int i = 2; i < n; i++) {
            if (isPrime[i]) {
                count++; // Count all primes
            }
        }

        return count; // Return the count of prime numbers
    }
}