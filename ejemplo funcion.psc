Funcion sumaralv <- suma ( valor1, valor2, valor3 )
	Definir sumaralv como entero;
	sumaralv= valor1+valor2+valor3;
		
Fin Funcion

Funcion retorno <- escala ( valor1,valor2 )
	Definir retorno Como Entero;
	
	Retorno= valor1 +valor2;
	
	
Fin Funcion

Algoritmo ejemplo_de_funcion
	
	
	Definir a,b,c,d Como Entero;
	
    Escribir " ingrese dos numero:";
	leer c;
	leer a;
	leer d;

	
	
    b= escala (a,c);
	
	imprimir "la funcion"," (", a ,"+",c,") ", "es:", b; 
	
	b= suma(a,c,d);
	
	imprimir "la funcion"," (", a ,"+",c,"+",d,") ", "es:", b; 
FinAlgoritmo

