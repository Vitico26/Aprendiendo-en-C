#include<stdio.h>
/*Programa que calcula el gasto para ir a un cliente, teniendo en cuneta*/

struct cliente
{
   int DISTANCIA;
   float PRECXDIS;
   int GALONES;
   double CONSUMGATOTAL;
   int RESULTOTAL;
   int vidautilg;
   int vidautilace;
};


int main()
{

    struct cliente c1, c2, c3;
    float PRECIOG = 192.00;
    float RESULTADOTT;

    printf("Digite la distancia del cliente 1: \t");
    scanf("%d", &c1.DISTANCIA);

    //Operacion de galones
    printf("\nDigite cuantos galones echo el cliente 1: \t");
    scanf("%d", &c1.GALONES);

    //Operacion consumo max - min
    int GALONESMAX = 16;
    double CONSUMOMAXGA;
    int CONSMAX = 16;
    int CONSMIN = 8;
    if (c1.GALONES <= CONSMAX)
    {
        if(c1.GALONES >= CONSMIN)
           {
                CONSUMOMAXGA = 100 / c1.GALONES;

                c1.CONSUMGATOTAL = CONSUMOMAXGA * c1.DISTANCIA;
                printf("\n\n%.2f", CONSUMOMAXGA);
                printf("\n%.2f", c1.CONSUMGATOTAL);
           }
    }else
    {
        printf("\nSe excedio de su limite o maximo de consumo de gasolina");
        return 0;
    }

    //Operacion juego de gomas
    int limitejg = 1000;
    if(c1.CONSUMGATOTAL >= limitejg)
    {
        printf("\nDebe hacer un cambio al juego de gomas, su costo es: 32,000");
    }else
    {
        c1.vidautilg = limitejg - c1.CONSUMGATOTAL;
        if(c1.vidautilg < limitejg)
        {
             printf("\nAun tiene vida util, le quedan %d km que puede recorrer", c1.vidautilg);
        }
    }

    //Operacion Aceite
    int limiteace = 900;
    if(c1.CONSUMGATOTAL >= limiteace)
    {
        printf("\nDebe hacer un cambio de aceite antes de continuar el viaje");
    }else
    {
        c1.vidautilace = limiteace - c1.CONSUMGATOTAL;
        if("\nPuede continuar el viaje teniendo en cuenta que le queda %d para hacer el cambio de aceite", c1.vidautilace);
    }

    //Operacion Mantenimiento
    int limiteman = 1200;
    if(c1.CONSUMGATOTAL >= limiteman)
    {
        printf("\nDebes hacer un mantenimiento al automovil");
    }

    c1.RESULTOTAL = c1.CONSUMGATOTAL + c1.vidautilg + c1.vidautilace;
    printf("\n%d", c1.RESULTOTAL);

    printf("\n");

    ////////////////////////////////////////////////////////////////// c2

    printf("\nDigite la distancia del cliente 2: \t");
    scanf("%d", &c2.DISTANCIA);

    //Operacion de galones
    printf("\nDigite cuantos galones echo el cliente 2: \t");
    scanf("%d", &c2.GALONES);

    //Operacion consumo max - min

    if (c2.GALONES <= CONSMAX)
    {
        if(c2.GALONES >= CONSMIN)
           {
                CONSUMOMAXGA = 100 / c1.GALONES;

                c2.CONSUMGATOTAL = CONSUMOMAXGA * c2.DISTANCIA;
                printf("\n\n%.2f", CONSUMOMAXGA);
                printf("\n%.2f", c2.CONSUMGATOTAL);
           }
    }else
    {
        printf("\nSe excedio de su limite o maximo de consumo de gasolina");
    }

    //Operacion juego de gomas
    if(c2.CONSUMGATOTAL >= limitejg)
    {
        printf("\nDebe hacer un cambio al juego de gomas, su costo es: 32,000");
    }else
    {
        c2.vidautilg = limitejg - c2.CONSUMGATOTAL;
        if(c2.vidautilg < limitejg)
        {
             printf("\nAun tiene vida util, le quedan %d km que puede recorrer", c2.vidautilg);
        }
    }

    //Operacion Aceite
    if(c2.CONSUMGATOTAL >= limiteace)
    {
        printf("\nDebe hacer un cambio de aceite antes de continuar el viaje");
    }else
    {
        c2.vidautilace = limiteace - c2.CONSUMGATOTAL;
        if("\nPuede continuar el viaje teniendo en cuenta que le queda %d para hacer el cambio de aceite", c2.vidautilace);
    }

    //Operacion Mantenimiento
    if(c2.CONSUMGATOTAL >= limiteman)
    {
        printf("\nDebes hacer un mantenimiento al automovil");
    }
    c2.RESULTOTAL = c2.CONSUMGATOTAL + c2.vidautilg + c2.vidautilace;
    printf("\n%d", c2.RESULTOTAL);

    printf("\n");

    ////////////////////////////////////////////////////////////////////////// c3
    printf("\nDigite la distancia del cliente 3: \t");
    scanf("%d", &c3.DISTANCIA);

    //Operacion de galones
    printf("\nDigite cuantos galones echo el cliente 3: \t");
    scanf("%d", &c3.GALONES);

    //Operacion consumo max - min

    if (c3.GALONES <= CONSMAX)
    {
        if(c3.GALONES >= CONSMIN)
           {
                CONSUMOMAXGA = 100 / c3.GALONES;

                c3.CONSUMGATOTAL = CONSUMOMAXGA * c3.DISTANCIA;
                printf("\n\n%.2f", CONSUMOMAXGA);
                printf("\n%.2f", c3.CONSUMGATOTAL);
           }
    }else
    {
        printf("\nSe excedio de su limite o maximo de consumo de gasolina");
        return 0;
    }

    //Operacion juego de gomas
    if(c3.CONSUMGATOTAL >= limitejg)
    {
        printf("\nDebe hacer un cambio al juego de gomas, su costo es: 32,000");
    }else
    {
        c3.vidautilg = limitejg - c3.CONSUMGATOTAL;
        if(c3.vidautilg < limitejg)
        {
             printf("\nAun tiene vida util, le quedan %d km que puede recorrer", c3.vidautilg);
        }
    }

    //Operacion Aceite
    if(c3.CONSUMGATOTAL >= limiteace)
    {
        printf("\nDebe hacer un cambio de aceite antes de continuar el viaje");
    }else
    {
        c3.vidautilace = limiteace - c2.CONSUMGATOTAL;
        if("\nPuede continuar el viaje teniendo en cuenta que le queda %d para hacer el cambio de aceite", c3.vidautilace);
    }

    //Operacion Mantenimiento
    if(c3.CONSUMGATOTAL >= limiteman)
    {
        printf("\nDebes hacer un mantenimiento al automovil");
    }

    c3.RESULTOTAL = c3.CONSUMGATOTAL + c3.vidautilg + c3.vidautilace;
    printf("%d", c3.RESULTOTAL);



}

  // #define PRECIOG = 192.00;    //Precio constante del precio de la gasolina
  // #define CONSUMOMAX = 16 / 100;  //Consumo maximo litros / kilometros
   //#define CONSUMOMIN = 8 / 100;   //Consumo minimo litros / kilometros
   #define VALORSEGURO = 42000;
   //#define JUEGOMAS = 32000;
   //#define MANTENIMIENTO = 2000;
  // #define ACEITE = 3000;
