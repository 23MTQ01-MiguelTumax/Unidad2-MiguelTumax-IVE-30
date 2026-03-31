Algoritmo Unidad2_Actividad2_Leccion21_Inciso2
	Escribir "BUZÓN DE VOZ DE MICROSOFT"
	Esperar 2 Segundos
	Escribir "Hola, mi nombre es Miguel Tumax, CEO de Microsoft."
	Escribir "Por el momento no estoy disponible, pero mi equipo de servicio al cliente te ayudará."
	Esperar 3 Segundos
	Escribir "Presiona cualquier tecla para redirigirte a ellos."
	Esperar Tecla
	
	Limpiar Pantalla
	Escribir "Transfiriendo llamada ."
	Esperar 2 Segundos
	Limpiar Pantalla
	Escribir "Transfiriendo llamada .."
	Esperar 2 Segundos
	Limpiar Pantalla
	Escribir "Transfiriendo llamada ..."
	Esperar 2 Segundos
	Limpiar Pantalla
	
	Escribir "Te has comunicado con servicio al cliente de Microsoft."
	Esperar 2 Segundos
	Escribir "Presiona 1 si quieres comunicarte con ventas."
	Esperar 2 Segundos
	Escribir "Presiona 2 si quieres comunicarte con recepción."
	Esperar 2 Segundos
	Escribir "Presiona 3 si quieres comunicarte con dirección."
	Esperar 2 Segundos
	Escribir "Presiona 4 si quieres comunicarte con compras."
	Esperar 2 Segundos
	Escribir "¿Con cuál departamento deseas comunicarte?"
	Esperar 1 Segundos
	Definir num Como Entero
	Leer num
	
	Limpiar Pantalla
	Escribir "Transfiriendo llamada ."
	Esperar 2 Segundos
	Limpiar Pantalla
	Escribir "Transfiriendo llamada .."
	Esperar 2 Segundos
	Limpiar Pantalla
	Escribir "Transfiriendo llamada ..."
	Esperar 2 Segundos
	Limpiar Pantalla
	
	Si (num == 1) Entonces
		Escribir "Bienvenido, usted se ha comunicado con ventas."
		Esperar 2 Segundos
		Escribir "Soy Xavier Borrayo y mi correo es: gatunavi@gmail.com"
		Esperar 2 Segundos
		Escribir "¿Cuál es su duda?"
	Sino 
		Si (num == 2) Entonces
			Escribir "Bienvenido, usted se ha comunicado con recepción."
			Esperar 2 Segundos
			Escribir "Soy Anggelo Rosales y mi correo es: arosalesdb23@gmail.com"
			Esperar 2 Segundos
			Escribir "¿En qué puedo ayudarle?"
		Sino 
			Si (num == 3) Entonces
				Escribir "Bienvenido, usted se ha comunicado con dirección."
				Esperar 2 Segundos
				Escribir "Soy Kendrick Santos y mi correo es: kasantshnz@gmail.com"
				Esperar 2 Segundos
				Escribir "¿En qué puedo ayudarte estimado?"
			Sino 
				Si (num == 4) Entonces
					Escribir "Bienvenido, usted se ha comunicado con compras."
					Esperar 2 Segundos
					Escribir "Soy Diego Hernández, mejor conocido como Presi, mi correo es: dieguishernandez.@gmail.com"
					Esperar 2 Segundos
					Escribir "¿Como puedo ayudarte?"
				SiNo
					Escribir "DIGITE UN NÚMERO DENTRO DEL RANGO."
				FinSi
			FinSi
		FinSi
	FinSi
	
FinAlgoritmo
