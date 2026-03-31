Algoritmo Unidad2_Actividad1_Leccion7_Inciso2
	Definir edad Como Entero
	Definir respuesta Como Cadena
	Esperar 1 Segundos
	Escribir "¿ERES MAYOR DE EDAD O NO?"
	Escribir "Ingresa tu edad: " Sin Saltar
	Leer edad
	
	Limpiar Pantalla
	Esperar 1 Segundos
	Escribir "Antes de que te muestre el resultado"
	Escribir "¿Tú que dices?, eres mayor o no?"
	Leer respuesta
	Limpiar Pantalla
	
	Si (respuesta == 'Si' o respuesta == 'SI' o respuesta == 'sI' o respuesta == 'si' o respuesta == 'No' o respuesta == 'nO' o respuesta == 'NO' o respuesta == 'no') Entonces
		Escribir "Estás en lo correcto!!!"
	FinSi
	Si edad >= 18 Entonces
		Escribir "YA ERES MAYOR DE EDAD, A TRABAJAR."
	SiNo
		Escribir "ERES MENOR TODAVÍA, APROVECHA TU EDAD ANTES DE QUE SEA DEMASIADO TARDE."
	FinSi
	
FinAlgoritmo
