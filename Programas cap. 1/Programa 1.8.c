#include <stdio.h>
#include <math.h>

/*Volumen y area del cilindro*/

void main (void)
{
    float RAD, VOL, ALT, ARE;
    printf("Ingrese el radio y la altura del cilindro>\t");
    scanf("%f %f", &RAD, &ALT);
    /*M_PI es una constante definida en math.h que contiene el calor de PI*/
    VOL = M_PI * pow (RAD, 2) * ALT;
    ARE = 2 * M_PI * RAD * ALT;
    printf("\n El VOlumen es: %6.2f \t El area es: %6.2f", VOL, ARE);
}
