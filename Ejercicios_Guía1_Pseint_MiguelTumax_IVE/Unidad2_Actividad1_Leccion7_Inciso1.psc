Algoritmo Unidad2_Actividad1_Leccion7_Inciso1
	Definir nota1, nota2, nota3, nota4, nota5, promedio Como Real
	Escribir "¿APROBASTE O NO APROBASTE?"
	Esperar 2 segundos
	Escribir "Dime tus 5 notas:"
	Esperar 2 Segundos
	Escribir "Nota* -- Las notas no tiene que ser mayor a 10."
	Esperar 2 Segundos
	Escribir "Nota 1: "  Sin Saltar 
	Leer nota1
	Escribir "Nota 2: "  Sin Saltar 
	Leer nota2
	Escribir "Nota 3: "  Sin Saltar 
	Leer nota3
	Escribir "Nota 4: "  Sin Saltar 
	Leer nota4
	Escribir "Nota 5: "  Sin Saltar 
	Leer nota5
	
	Limpiar Pantalla
	Escribir "Procesando datos ."
	Esperar 1 Segundos
	Limpiar Pantalla

	Escribir "Procesando datos .."
	Esperar 1 segundos
	Limpiar Pantalla
	
	Escribir "Procesando datos ..."
	Esperar 1 Segundos
	Limpiar pantalla
	
	Si (nota1 >= 0 y nota1 < 11) y (nota2 >= 0 y nota2 < 11) y (nota3 >= 0 y nota3 < 11) y (nota4 >= 0 y nota4 < 11) y (nota5 >= 0 y nota5 < 11) Entonces
		promedio = (nota1 + nota2 + nota3 + nota4 + nota5)/5
		Si (promedio >= 5) Entonces
			Escribir "FELICIDADES!!!!"
			Escribir "APROBASTE"
		SiNo
			Escribir "SERÁ PARA LA PRÓXIMA"
			Escribir "REPROBASTE"
		FinSi
	SiNo
		Escribir "INGRESE LAS NOTAS EN EL RANGO ESPERADO."
	FinSi
	
FinAlgoritmo
