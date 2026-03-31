Algoritmo Unidad2_Actividad2_Leccion7_Inciso3
	Esperar 1 Segundos
	Escribir "Hola!!, ¿Quires saber en que mes del año estás?"
	Esperar 2 segundos
	Escribir "Dime un número del 1 al 12 y te diré en que mes estás."
	Esperar 3 Segundos
	Escribir "Número: " Sin Saltar
	Definir dato Como Entero
	Leer dato
	Limpiar Pantalla
	Esperar 1 Segundos
	
	Si (dato == 1 o dato == 2 o dato == 3 o dato == 4 o dato == 5 o dato == 6 o dato == 7 o dato == 8 o dato == 9 o dato == 10 o dato == 11 o dato == 12) Entonces
		Escribir "El mes que escogiste es ..."
	FinSi
	
	Esperar 2 Segundos
	Limpiar Pantalla
	Esperar 2 Segundos
	
	Si (dato == 1) Entonces
		Escribir "Enero"
	FinSi
	Si (dato == 2) Entonces
		Escribir "Febrero"
	FinSi
	Si (dato == 3) Entonces
		Escribir "Marzo"
	FinSi
	Si (dato == 4) Entonces
		Escribir "Abril"
	FinSi
	Si (dato == 5) Entonces
		Escribir "Mayo"
	FinSi
	Si (dato == 6) Entonces
		Escribir "Junio"
	FinSi
	Si (dato == 7) Entonces
		Escribir "Julio"
	FinSi
	Si (dato == 8) Entonces
		Escribir "Agosto"
	FinSi
	Si (dato == 9) Entonces
		Escribir "Septiembre"
	FinSi
	Si (dato == 10) Entonces
		Escribir "Octubre"
	FinSi
	Si (dato == 11) Entonces
		Escribir "Noviembre"
	FinSi
	Si (dato == 12) Entonces
		Escribir "Diciembre"
	FinSi
	Si (dato <> 1 y dato <> 2 y dato <> 3 y dato <> 4 y dato <> 5 y dato <> 6 y dato <> 7 y dato <> 8 y dato <> 9 y dato <> 10 y dato <> 11 y dato <> 12) Entonces
		Escribir "Ingresa un número dentro del rango."
	FinSi
FinAlgoritmo
