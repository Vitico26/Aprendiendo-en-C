#include<stdio.h>

int cubo(void);   /*Prototipo de funcion*/
int I;            /*Variable global*/

void main(void)
{
    int CUB;
    for (I = 1; I <= 10; I++)
    {
        CUB = cubo();   /*llamada de la funcion cubo*/
        printf("\nEl cubo de %d es: %d", I, CUB);
    }
}

int cubo(void)  /*Declaracion de la funcion*/
/*La funcion calcula el cubo de la variable global I.*/
{
    return (I*I*I);
}
