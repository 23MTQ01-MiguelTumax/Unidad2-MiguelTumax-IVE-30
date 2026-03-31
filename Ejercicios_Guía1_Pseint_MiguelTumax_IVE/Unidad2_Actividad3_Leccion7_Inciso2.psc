Algoritmo Unidad2_Actividad3_Leccion7_Inciso2
	Esperar 1 Segundos
	Escribir "TIPOS DE TRIÁNGULO"
	Esperar 1.5 Segundos
	Escribir "Dime los tres ángulos de tu triángulo y te diré que tipo es."
	Esperar 3 segundos
	Definir ang1, ang2, ang3 Como Real
	Escribir "Ángulo 1: " Sin Saltar
	Leer ang1
	Escribir "Ángulo 2: " Sin Saltar
	Leer ang2
	Escribir "Ángulo 3: " Sin Saltar
	Leer ang3
	
	Escribir ""
	
	Si ((ang1 + ang2 + ang3) <> 180) Entonces
		Escribir "Eso no es un triángulo."
	SiNo 
		Si ((ang1 == ang2) y (ang1 == ang3) y (ang2 == ang3)) Entonces
			Escribir "Es un triángulo equilátero."
		Sino 
			Si ((ang1 == ang2) o (ang1 == ang3) o (ang2 == ang3)) Entonces
				Escribir "Es un triángulo isóceles."
			Sino 
				Escribir "Es un triángulo escaleno."
			FinSi
		FinSi
	FinSi
	
FinAlgoritmo
