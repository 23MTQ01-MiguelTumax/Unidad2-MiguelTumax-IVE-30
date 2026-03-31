Algoritmo Unidad2_Actividad2_Leccion20_Inciso1
	Limpiar Pantalla
	Escribir "Cargando página ."
	Esperar 2 segundos
	Limpiar Pantalla
	Escribir "Cargando página .."
	Esperar 2 segundos
	Limpiar Pantalla
	Escribir "Cargando página ..."
	Esperar 2 segundos
	Limpiar Pantalla
	
	
	Limpiar Pantalla
	Esperar 1 Segundos
	
	Escribir "AGENCIA CENTRAL DE INTELIGENCIA DE GUATEMALA"
	Esperar 2 Segundos
	Escribir "Inicio de sesión"
	Esperar 2 Segundos
	Escribir "Escriba la contraseña para ingresar a los archivos clasificados."
	Esperar 2 Segundos
	Escribir "Contraseña: "
	Definir dato Como Cadena
	Leer dato
	
	Limpiar Pantalla
	Esperar 2 Segundos
	
	Si (dato == "Password123") Entonces
		Escribir "Sesión iniciada correctamente."
		Esperar 2 Segundos
		Escribir "¿Qué archivos desea consultar?"
	SiNo
		Escribir "Ingreso prohibido."
		Esperar 2 Segundos
		Escribir "¿Qué intentas hacer?"
	FinSi
	
FinAlgoritmo
