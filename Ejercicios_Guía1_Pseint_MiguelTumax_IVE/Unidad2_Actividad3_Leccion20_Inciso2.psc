Algoritmo Unidad2_Actividad3_Leccion20_Inciso2
	Escribir "Vamos a ver si aprobaste la clase de progra con Crupi."
	Esperar 2 Segundos
	Escribir "Solo déjame decirte que no todos aprueban con Crupi."
	Esperar 2 Segundos
	Escribir "Rango de la nota --> 0 a 100"
	Escribir "Ingresa tu nota final: " Sin Saltar
	Definir nota Como Entero
	Leer nota
	
	Limpiar Pantalla
	Esperar 1 Segundos
	
	Si (nota >= 70 y nota <= 100) Entonces
		Escribir "Felicidades!!!"
		Esperar 2 Segundos
		Escribir "Muy pocos consiguen pasar con Crupi."
	Sino
		Si (nota >= 0 y nota <= 69) Entonces
			Escribir "Será para la próxima unidad."
			Esperar 2 Segundos
			Escribir "Te dije que no todos aprobaban con Crupi."
		Sino 
			Escribir "Ingresa una nota dentro del parámetro."
		FinSi
	FinSi
FinAlgoritmo
