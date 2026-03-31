Algoritmo Unidad2_Actividad3_Leccion20_Inciso1
	Escribir "Dame un número del 1 al 7 por favor."
	Escribir "Número: " Sin saltar
	Definir num Como Entero
	Leer num
	
	Limpiar Pantalla
	Esperar 1 Segundos
	Si ((num == 1) o (num == 2) o (num == 3) o (num == 4) o (num ==5)) Entonces
		Escribir "Todavía estás entre semana chaval, sigue trabajando."
	Sino 
		Si ((num == 6) o (num == 7)) Entonces
			Escribir "Ya puedes descansar, es fin de semana."
			Esperar 2 Segundos
			Escribir "No te olvides de ir a Misa los domingos."
		SiNo
			Escribir "Ingresa un número dentro del parámetro."
		FinSi
	FinSi
	
	Esperar 2 Segundos
	Escribir ""
	Escribir "Presiona cualquier tecla para cerrar el programa."
	Esperar Tecla
	Limpiar Pantalla
FinAlgoritmo
