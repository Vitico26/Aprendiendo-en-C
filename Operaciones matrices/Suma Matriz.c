#include <stdio.h>

void sumarMatrices(int matriz1[][3], int matriz2[][3], int resultado[][3]) {  //Se declaran las funciones y el tamaño de cada matriz
    for (int i = 0; i < 3; i++) {                                               //Se abre un bucle para asignar la posicion de cada valor
        for (int j = 0; j < 3; j++) {
            resultado[i][j] = matriz1[i][j] + matriz2[i][j];                      //Se declara la variable resultado con el valor de la operacion de la matriz
        }
    }
}

void imprimirMatriz(int matriz[][3]) {                                      //Se declara la funcion imprimir para presentar la matriz en la consola
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            printf("%d ", matriz[i][j]);
        }
        printf("\n");
    }
}

int main() {
    int matriz1[3][3], matriz2[3][3], resultado[3][3];                         //Se declaran 3 matrices que se usaran en el programa

    printf("Ingrese los elementos de la primera matriz:\n");                    //Usamos un printf para enviar un mensaje al usuario de isnertar los datos de la primera matriz
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            scanf("%d", &matriz1[i][j]);                                        //Se guardan los datos de tipo entero en cada arreglo de la matriz 1
    }
    }
    printf("Ingrese los elementos de la segunda matriz:\n");                     //Usamos un printf para enviar un mensaje al usuario de isnertar los datos de la primera matriz
    for (int i = 0; i < 3; i++) {
        for (int j = 0; j < 3; j++) {
            scanf("%d", &matriz2[i][j]);                                        //Se guardan los datos de tipo entero en cada arreglo de la matriz 2
        }
    }

    sumarMatrices(matriz1, matriz2, resultado);                                 //Se le hace un llamdo a la funcion suma y mencionando las matrices 1, 2 y la resultante

    printf("La suma de las matrices es:\n");                                    //Se imprime un mensaje al usuario y se imprime el valor resultado de la suma de la matriz
    imprimirMatriz(resultado);

    return 0;
}
