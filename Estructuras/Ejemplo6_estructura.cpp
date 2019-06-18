#include <cstdlib>
#include <iostream>
#include <string.h>
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
	Cliente cliente3;
	Cliente listadoClientes[100];
	cliente3=cliente2=cliente1;

	cout<<"Los valores del cliente0 son:"<<cliente0.nombre<<","<<cliente0.numUnidades<<","<<cliente0.precio<<","<<cliente0.estado<<endl;
	cout<<"Los valores del cliente1 son:"<<cliente1.nombre<<","<<cliente1.numUnidades<<","<<cliente1.precio<<","<<cliente1.estado<<endl;
	cout<<"Los valores del cliente2 son:"<<cliente2.nombre<<","<<cliente2.numUnidades<<","<<cliente2.precio<<","<<cliente2.estado<<endl;

	strcpy(cliente3.nombre,"Antonio Banderas");
	cliente3.numUnidades=9;
	cliente3.precio=5.13;
	cliente3.estado='P';
	
	cout<<"Los valores del cliente3 son:"<<cliente3.nombre<<","<<cliente3.numUnidades<<","<<cliente3.precio<<","<<cliente3.estado<<endl;

    Cliente *cliente4;
    cliente4 = (Cliente*)malloc(sizeof(Cliente));
    strcpy(cliente4->nombre ,"Luis Velez"); 
    cliente4->numUnidades = 10;
    cliente4->precio = 14.56;
    cliente4->estado='P';
    cout << "Los datos del cliente4 son: " << cliente4->nombre << ", " << cliente4->numUnidades << ", " << cliente4->precio << ", " << cliente4->estado << endl;
    free(cliente4);

   Cliente *cliente5 = new Cliente;
    strcpy(cliente5->nombre ,"Miriam Nicolalde"); 
    cliente5->numUnidades = 30;
    cliente5->precio = 8.40;
    cliente5->estado='M';
    cout << "Los datos del cliente5 son: " << cliente5->nombre << ", " << cliente5->numUnidades << ", " << cliente5->precio << ", " << cliente5->estado << endl;
    delete cliente5;

system("PAUSE");
return 0;
}

