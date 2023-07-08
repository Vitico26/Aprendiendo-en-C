#include <stdio.h>

struct cliente
{
    char NOMBRE[30];
    int GALONES;
    float DISTANCIA;
    int SEGURO;
    int LLANTAS;
    int ACEITE;
    int MANTENIMIENTO;
    double COMBUSTIBLEPROM;
    int GASTOSVTOTAL;
    int TOTAL;
};

int main()
{
    //Declaracion de variables
    const float PRECIOCOMB = 192.00;
    const int COSTACE = 2500, COSTJG = 32000, COSTMAN = 4000;
    struct cliente c1;

    //double GASTOCOMB;
    int limitejg = 1000, limiteace = 900, limiteman = 1200;
    int P;
    float PROM;
    int CONSMAX = 16;
    int CONSMIN = 8;
    char cad;
    //Pedir datos al cliente
    printf("Cual es su nombre:\t");gets(c1.NOMBRE);
    printf("\nCual es la distacia para llegar a donde el cliente(km):      \t");scanf("%f", &c1.DISTANCIA);
    printf("\nCuantos galones tiene su carro:\t");scanf("%d", &c1.GALONES);
    //Operaciones
                printf("\n\n\tCLIENTE: %s |DISTANCIA|GALONES|COMBUSTIBLE PROMEDIO|GASTOS VARIOS|",c1.NOMBRE);
    for(P = CONSMIN; P <= CONSMAX; P++)
          {
              float GALONESCONVER = P * 3.785;
                PROM = 100 / P;
                c1.COMBUSTIBLEPROM = PROM * PRECIOCOMB;
                //Calcular el gasto a pagar
            //VicGASTOCOMB = c1.COMBUSTIBLEPROM * PRECIOCOMB;
                //Bucle de presicion
                cad = printf("\n\n%d|\t\t        |  %.3f    |  %d |      %.2fl      |     %d    |", P, c1.DISTANCIA, c1.GALONES, c1.COMBUSTIBLEPROM, c1.GASTOSVTOTAL);
            }
            printf("\n");

    if(c1.DISTANCIA >= limiteace)
    {
        //Operacion juego de gomas
    if(c1.DISTANCIA >= limitejg)
    {
        printf("\n\nDebe hacer un cambio al juego de gomas, su costo es: %d", COSTJG);
    }
    //Operacion Aceite
    if(c1.DISTANCIA >= limiteace)
    {
        printf("\n\nDebe hacer un cambio de aceite antes de continuar el viaje, su costo es: %d", COSTACE);
    }

    //Operacion Mantenimiento
    if(c1.DISTANCIA >= limiteman)
    {
        printf("\n\nDebes hacer un mantenimiento al automovil, el costo es de: %d", COSTMAN);
    }

//    c1.GASTOSVTOTAL = limiteace + limitejg + limiteman + GASTOCOMB;
    }

//    c1.GASTOSVTOTAL = GASTOCOMB;

    FILE *ar;
    if((ar = fopen("arc.txt", "w")) != NULL){

        fputs(cad, ar);

    }

    fclose(ar);
}
