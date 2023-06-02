#include <stdio.h>
#include <stdlib.h>



int main()
{
    /*
    programa que calcula un descuento del 18% si viene superada una compra
    de 1500 pesos.
    */



    float PRE = 0.0;
    float PRE_FINAL = 0.0;



    printf("\nIngresar precio a calcular: ");
    scanf("%f",&PRE);



    if(PRE > 1500)
    {
        PRE_FINAL = PRE * 1.18;
        printf("El nuevo precio es: %7.2f",PRE_FINAL);
    }else if(PRE <= 1500 && PRE > 0)
    {
        PRE_FINAL = (1 - 0.11)* PRE;
        printf("El nuevo precio es: %7.2f",PRE_FINAL);
    }else
    {
        printf("El precio no puede ser menor igual a cero");
    }
