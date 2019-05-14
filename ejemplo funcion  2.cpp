#include <stdlib.h>
#include<iostream>
using namespace std;
#define SIN_TIPO string

int suma(int valor1, int valor2, int valor3);
int escala(int valor1, int valor2);

int suma( int  valor1, int valor2, int valor3) {
	int sumaralv;
	sumaralv = valor1+valor2+valor3;
	return sumaralv;
}

int escala(int valor1, int valor2) {
	int retorno;
	retorno = valor1+valor2;
	return retorno;
}

int main() {
    system ("color BD");
	int a;
	int b;
	int c;
	int d;
	cout << " ingrese tres numero:" << endl;
	cin >> c;
	cin >> a;
	cin >> d;
	b = a+c;
	b = escala(a,c);
	cout << "la funcion" << " (" << a << "+" << c << ") " << "es:" << b << endl;
	b = suma(a,c,d);
	cout << "la funcion" << " (" << a << "+" << c << "+" << d << ") " << "es:" << b << endl;
	return 0;
}

