Algoritmo Unidad2_Actividad1_Leccion21_Inciso1
	Esperar 1 Segundos
	Escribir "Días de la semana."
	Esperar 2 Segundos
	Escribir "Como dato curioso, ya estamos en semana santa."
	Esperar 2 Segundos
	Escribir "Dame un número del 1 al 7 y te diré que día es."
	Esperar 2 Segundos
	Escribir "Número: " Sin Saltar
	Definir num Como Entero
	Leer num
	
	Limpiar Pantalla
	Esperar 1 Segundos
	
	Si (num == 1) Entonces
		Escribir "Es lunes."
		Esperar 1 segundos
		Escribir "Hoy es un buen día para ir a procesiones."
	Sino 
		Si (num == 2) Entonces
			Escribir "Es martes."
			Esperar 1 Segundos
			Escribir "Continua reflexionando sobre la Pasión de Cristo."
		Sino 
			Si (num == 3) Entonces
				Escribir "Es miércoles."
				Esperar 1 Segundos
				Escribir "Hoy es el fin de la Cuaresma, ve a hacer el baile de Judas."
			Sino 
				Si (num == 4) Entonces
					Escribir "Es jueves."
					Esperar 1 Segundos
					Escribir "Hoy nuestro Señor tuvo su última cena."
				Sino 
					Si (num == 5) Entonces
						Escribir "Es viernes."
						Esperar 1 Segundos
						Escribir "En este día Jesús fue juzgado, lastimado, crucificado y posteriormente, murió."
					Sino 
						Si (num == 6) Entonces
							Escribir "Es sábado."
							Esperar 1 Segundos
							Escribir "Pero Jesús dijo que al tercer día el resucitaría."
						Sino 
							Si (num == 7) Entonces
								Escribir "Es domingo."
								Esperar 1 Segundos
								Escribir "Hoy Cristo resucitó y venció a la muerte."
							Sino
								Escribir "Ingrese un número dentro del parámetro."
							FinSi
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
	FinSi
	
	
FinAlgoritmo
