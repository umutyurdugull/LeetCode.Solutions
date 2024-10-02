#include <stdio.h>
#include <stdbool.h>
#include <math.h>  // sqrt fonksiyonu için gerekli

// isPerfectSquare fonksiyonu
bool isPerfectSquare(int num) {
    double sqrtNum = sqrt(num);  // Sayının karekökünü alıyoruz
    
    // Kareköklü sayının tam sayı olup olmadığını kontrol ediyoruz
    if (sqrtNum == (int)sqrtNum) {
        return true;  // Tam sayı ise true döndür
    }
    
    return false;  // Tam sayı değilse false döndür
}

int main() {
    int num;
    
    // Kullanıcıdan bir sayı alıyoruz
    printf("Bir sayi girin: ");
    scanf("%d", &num);
    
    // isPerfectSquare fonksiyonunu çağırıyoruz ve sonucu kontrol ediyoruz
    if (isPerfectSquare(num)) {
        printf("%d bir tam kare sayıdır veya karekökü bir tam sayıdır.\n", num);
    } else {
        printf("%d tam kare değil ve karekökü tam sayı değil.\n", num);
    }
    
    return 0;
}
