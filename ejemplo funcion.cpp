// Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
// Es posible que el codigo generado no sea completamente correcto. Si encuentra
// errores por favor reportelos en el foro (http://pseint.sourceforge.net).

#include<iostream>
using namespace std;

// Para las variables que no se pudo determinar el tipo se utiliza la constante
// SIN_TIPO. El usuario debe reemplazar sus ocurrencias por el tipo adecuado
// (usualmente int,float,string o bool).
#define SIN_TIPO string

// Para leer variables de texto se utiliza el operador << del objeto cin, que
// lee solo una palabra. Para leer una linea completa (es decir, incluyendo los
// espacios en blanco) se debe utilzar getline (ej, reemplazar cin>>x por
// getline(cin,x)), pero obliga a agregar un cin.ignore() si antes del getline
// se leyó otra variable con >>.

// Declaraciones adelantadas de las funciones
int suma(SIN_TIPO valor1, SIN_TIPO valor2, SIN_TIPO valor3);
int escala(SIN_TIPO valor1, SIN_TIPO valor2);

int suma(SIN_TIPO valor1, SIN_TIPO valor2, SIN_TIPO valor3) {
	int sumaralv;
	sumaralv = valor1+valor2+valor3;
	return sumaralv;
}

int escala(SIN_TIPO valor1, SIN_TIPO valor2) {
	int retorno;
	retorno = valor1+valor2;
	return retorno;
}

int main() {
	int a;
	int b;
	int c;
	int d;
	cout << " ingrese dos numero:" << endl;
	cin >> c;
	cin >> a;
	cin >> d;
	b = a+c;
	cout << "El resultado1 es:" << b << endl;
	b = a+c+d;
	cout << "El resultado2 es:" << b << endl;
	b = escala(a,c);
	cout << "su numero (funcion1) es " << b << endl;
	b = suma(a,c,d);
	cout << "su numero (funcion2) es " << b << endl;
	return 0;
}

