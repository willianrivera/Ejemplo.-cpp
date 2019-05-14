/* Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
Es posible que el codigo generado no sea completamente correcto. Si encuentra
errores por favor reportelos en el foro (http://pseint.sourceforge.net). */

#include<stdio.h>
#include<math.h>
#include<stdbool.h>

/* En C no hay variables para guardar cadenas de texto, sino que debe construirse
   un arreglo de caracteres (tipo char). El tamaño del arreglo determina la longitud
   máxima que puede tener la cadena que guarda (tamaño-1, por el caracter de terminación).
   La constante MAX_STRLEN define el tamaño máximo que se utiliza en este programa para
   cualquier cadena. */
#define MAX_STRLEN 256

int main() {
	float valor_a;
	char valor_b[MAX_STRLEN];
	bool valor_c;
	bool valor_d;
	bool valor_e;
	char valor_w[MAX_STRLEN][4];
	int valor_x;
	char valor_y[MAX_STRLEN];
	char valor_z[MAX_STRLEN];
	valor_x = 75;
	valor_y = "84";
	valor_z = "65";
	valor_a = sqrtf(4);
	valor_b = "2019";
	valor_c = true;
	valor_d = false;
	valor_w[0] = "H";
	valor_w[1] = "O";
	valor_w[2] = "L";
	valor_w[3] = "A";
	printf("%f\n",valor_a);
	printf("%s\n",valor_b);
	printf("%i\n",valor_c);
	printf("%i\n",valor_d);
	printf("%i\n",valor_x);
	printf("%s\n",valor_y);
	printf("%s\n",valor_z);
	printf("%s%s%s%s\n",valor_w[0],valor_w[1],valor_w[2],valor_w[3]);
	return 0;
}

