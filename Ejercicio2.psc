

Algoritmo Ejercicio2
	Definir num1,num2,opc Como Real
	Definir msj Como Caracter
	Escribir Sin Saltar "Digite dos valores numericos:"
	leer num1
	leer num2 
	
	//menu de las operaciones
	Escribir "**************************"
	Escribir "MENU PRINCIPAL"
	Escribir "1-suma"
	Escribir "2-Resta"
	Escribir "3-Multiplicacion"
	Escribir "4-Division"
	Escribir "5-Salir"
	Escribir Sin Saltar "Digite el nuevo segun su operacion"
	leer opc
	
	
	
	Segun opc Hacer
		1:
		msj="el resultado de la suma es":
		
		result=num1+num2:
		2:	
		msj="el resultado de la resta es":
		result=num1-num2:
			
		3:
		msj="el resultado de la Multiplicacion es":
			
		result=num1*num2:
		4:	
		msj="el resultado de la Divison es":
		result=num1/num2:
			
		5:
		msj="Salindo del sistema":
			
		

		De Otro Modo:
			msj="Seleccione una opcion valida!!"
	Fin Segun
	
FinAlgoritmo
