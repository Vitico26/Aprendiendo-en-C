#include <stdio.h>
#include <stdlib.h>



int main()
{
    float x = 0.0;
    float b = 0.0;



    printf("Calculo de raiz cuadrada\n");
    printf("\nIntroduce el numero: ");
    scanf("%f",&x);
    b = x;



    while(!(b == (x/b)))
    {
        b = 0.5 * ((x/b) + b);
    }
    printf("Raiz cuadrada de %f es: %f",x,b);
    return 0;
}
