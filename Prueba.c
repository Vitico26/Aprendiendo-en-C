#include <stdio.h>

int main() {
    FILE *archivo;
    archivo = fopen("impresion.txt", "w"); // Abre el archivo en modo escritura

    if (archivo == NULL) {
        printf("No se pudo abrir el archivo.\n");
        return 1;
    }

    fprintf(archivo, "�Hola, mundo!\n");
    fprintf(archivo, "Esta es una impresi�n guardada en un archivo de texto.\n");

    fclose(archivo); // Cierra el archivo

    printf("Impresi�n guardada en el archivo 'impresion.txt'.\n");

    return 0;
}
