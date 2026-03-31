Algoritmo Unidad2_Actividad3_Leccion7_Inciso1
	Escribir "ESTACIONES DEL AÑO -- VERSIÓN EE.UU"
	Esperar 2 Segundos
	Escribir "En EE.UU hay 4 estaciones, ¿en cuál deseas estar?"
	Esperar 2 segundos
	Escribir "Deseas estar en ..."
	Esperar 2 Segundos
	Escribir "¿Primavera? "
	Esperar 2 Segundos
	Escribir "O quizas en ..."
	Esperar 2 Segundos
	Escribir "¿Verano?"
	Esperar 2 Segundos
	Escribir "¿Que tal Otoño? ..."
	Esperar 2 Segundos
	Escribir "¿O será Invierno?"
	Esperar 2 Segundos
	Escribir "Vamos a ver"
	Esperar 2 Segundos
	
	Escribir "Ingresa el día (máximo 28):"
	Definir dias, mes Como Entero
	Leer dias
	Escribir "Ingresa el mes (máximo 12):"
	Leer mes
	Limpiar Pantalla
	
	Esperar 1 Segundos
	
	Si ((dias <= 0 o dias >= 29) o (mes <= 0 o mes >= 13)) Entonces
		Escribir "Ingresa los datos dentro del parámetro por favor."
	FinSi
	
	//ESTACIÓN PRIMAVERA
	
	Si (mes == 3 y (dias >= 21 y dias <= 28)) Entonces
		Escribir "Elegiste la opción de ..."
		Esperar 2 Segundos
		Escribir "Primavera"
	FinSi
	Si ((mes >= 4 y mes <= 5) y (dias >= 1 y dias <= 28)) Entonces
		Escribir "Elegiste la opción de ..."
		Esperar 2 Segundos
		Escribir "Primavera"
	FinSi
	Si (mes == 6 y (dias >= 1 y dias <= 20)) Entonces
		Escribir "Elegiste la opción de ..."
		Esperar 2 Segundos
		Escribir "Primavera"
	FinSi
	
	//ESTACIÓN VERANO
	Si (mes == 6 y (dias >= 21 y dias <= 28)) Entonces
		Escribir "Elegiste la opción de ..."
		Esperar 2 Segundos
		Escribir "Verano"
	FinSi
	Si ((mes >= 7 y mes <= 8) y (dias >= 1 y dias <= 28)) Entonces
		Escribir "Elegiste la opción de ..."
		Esperar 2 Segundos
		Escribir "Verano"
	FinSi
	Si (mes == 9 y (dias >= 1 y dias <= 21)) Entonces
		Escribir "Elegiste la opción de ..."
		Esperar 2 Segundos
		Escribir "Verano"
	FinSi
	
	//ESTACIÓN OTOÑO
	Si (mes == 9 y (dias >= 22 y dias <= 28)) Entonces
		Escribir "Elegiste la opción de ..."
		Esperar 2 Segundos
		Escribir "Otoño"
	FinSi
	Si ((mes >= 10 y mes <= 11) y (dias >= 1 y dias <= 28)) Entonces
		Escribir "Elegiste la opción de ..."
		Esperar 2 Segundos
		Escribir "Otoño"
	FinSi
	Si (mes == 12 y (dias >= 1 y dias <= 20)) Entonces
		Escribir "Elegiste la opción de ..."
		Esperar 2 Segundos
		Escribir "Otoño"
	FinSi
	
	//ESTACIÓN INVIERNO
	Si (mes == 12 y (dias >= 21 y dias <= 28)) Entonces
		Escribir "Elegiste la opción de ..."
		Esperar 2 Segundos
		Escribir "Invierno"
	FinSi
	Si ((mes >= 1 y mes <= 2) y (dias >= 1 y dias <= 28)) Entonces
		Escribir "Elegiste la opción de ..."
		Esperar 2 Segundos
		Escribir "Invierno"
	FinSi
	Si (mes == 3 y (dias >= 1 y dias <= 20)) Entonces
		Escribir "Elegiste la opción de ..."
		Esperar 2 Segundos
		Escribir "Invierno"
	FinSi
	
FinAlgoritmo
