#include<stdio.h>
#include<stdlib.h>

int main ()
{
    float sul;
    printf("\n Ingrese su sueldo:");
    scanf("%f", &sul);

    if(sul > 100000.000)
    {
        printf("El impuesto a pagar es: %f",sul * 0.25);
    }else
    {
        if(sul > 0.0)
        {
            if(sul > 50000)
            {
                printf("El impuesto a pagar el sueldo es: %f", sul * 0.1);
            }else if (sul > 25000)
            {
                printf("El impuesto a pagar es: %f", sul * 0.05);
            }else
            {
                printf("El impuesto a pagar es: %f", sul * 0.2);
            }


        }else{
                printf("Su sueldo es menor que 0, usted no trabaja");
            }
    }

}
