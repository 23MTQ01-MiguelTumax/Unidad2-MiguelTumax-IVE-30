Algoritmo Unidad2_Actividad2_Leccion7_Inciso2
	Esperar 1 Segundos
	Escribir "¿Quieres saber si tu calificación es deficiente, regular, "
	Escribir "buena, muy buena o excelente?"
	Esperar 2 Segundos
	Escribir "Dime tu calificación: " Sin Saltar
	Definir nota Como Real
	Leer nota
	Esperar 2 Segundos
	Limpiar Pantalla
	
	Escribir "Antes de decirte, ¿Tú qué crees?"
	Escribir "¿Tú nota es deficiente, regular, buena, muy buena o excelente?"
	Esperar 5 Segundos
	Escribir ""
	Escribir "Presiona cualquier tecla para saber tu nota."
	Esperar Tecla
	Limpiar Pantalla
	
	Si (nota < 0 y nota > 10) Entonces
		Escribir "INGRESE UNA NOTA DENTRO DEL RANGO."
	SiNo
		Si (nota >= 0 y nota <3) Entonces
			Escribir "Su nota es deficiente."
		FinSi
		Si (nota >= 3 y nota < 5) Entonces
			Escribir "Su nota es regular."
		FinSi
		Si (nota >= 5 y nota <7) Entonces
			Escribir "Su nota es buena."
		FinSi
		Si (nota >= 7 y nota <9) Entonces
			Escribir "Su nota es muy buena."
		FinSi
		Si (nota >= 9 y nota <= 10) Entonces
			Escribir "Su nota es excelente."
		FinSi
	FinSi
	
FinAlgoritmo
