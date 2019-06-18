#include <cstdlib>
#include <iostream>
using namespace std;
struct Cliente
{
char nombre[20];
int numUnidades;
float precio;
char estado;
} cliente0= {"Willian Rivera",15,12.45,'M'};




int main()
{
	
	Cliente cliente1={"David Aguirre",20,15.3,'A'};
	Cliente cliente2={"Pablo Turushina",19,10.3,'M'};
	Cliente cliente3,cliente4;
	Cliente listadoClientes[100];
	cliente4=cliente3=cliente2=cliente1;
	
	cout<<"sizeof(char) ="<<sizeof(char)<<endl;
	cout<<"sizeof(int) ="<<sizeof(int)<<endl;
	cout<<"sizeof(float) ="<<sizeof(float)<<endl;
	cout<<"sizeof(Cliente) ="<<sizeof(Cliente)<<endl;

system("PAUSE");
return 0;
}

