Algoritmo Unidad2_Actividad2_Leccion7_Inciso1
	Escribir "=====BUZÓN DE VOZ COCA COLA====="
	Esperar 2 segundos
	Escribir "Usted se ha comunicado con el buzón de voz de Coca Cola."
	Esperar 2 segundos
	Escribir "Marque 1 si desea comunicarse con productos."
	Esperar 2 segundos
	Escribir "Marque 2 si desea comunicarse con ventas."
	Esperar 2 segundos
	Escribir "Marque 3 si desea comunicarse con mantenimiento."
	Esperar 2 segundos
	Escribir "Marque 4 si desea trabajar para nosotros."
	Esperar 2 segundos
	Escribir "¿Con qué departamento desea comunicarse?: "
	Definir respuesta Como Entero
	Leer respuesta
	Esperar 1 segundos
	Limpiar Pantalla
	
	Esperar 1 Segundos
	Escribir "Transfiriéndolo a la llamada ."
	Esperar 1 Segundos
	Limpiar Pantalla
	Escribir "Transfiriéndolo a la llamada .."
	Esperar 1 Segundos
	Limpiar Pantalla
	Escribir "Transfiriéndolo a la llamada ..."
	Esperar 1 Segundos
	Limpiar Pantalla
	Escribir "Transfiriéndolo a la llamada ."
	Esperar 1 Segundos
	Limpiar Pantalla
	Escribir "Transfiriéndolo a la llamada .."
	Esperar 1 Segundos
	Limpiar Pantalla
	Escribir "Transfiriéndolo a la llamada ..."
	Esperar 1 Segundos
	Limpiar Pantalla
	
	Si (respuesta <> 1 y respuesta <> 2 y respuesta <> 3 y respuesta <> 4) Entonces
		Escribir "INGRESE UN NÚMERO DENTRO DEL RANGO."
	SiNo
		Si (respuesta == 1) Entonces
			Escribir "Usted se ha comunicado con productos, ¿Cuál es su duda?"
		FinSi
		Si (respuesta == 2) Entonces
			Escribir "Usted se ha comunicado con ventas, ¿Cuál es su duda?"
		FinSi
		Si (respuesta == 3) Entonces
			Escribir "Usted se ha comunicado con mantenimiento, ¿Cuál es su duda?"
		FinSi
		Si (respuesta == 4) Entonces
			Escribir "Usted se ha comunicado para trabajar con nostros, ¿Cuál es su duda?"
		FinSi
	FinSi
FinAlgoritmo
