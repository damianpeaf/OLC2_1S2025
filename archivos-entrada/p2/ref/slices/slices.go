package main

import (
	"fmt"
	"slices"
	"strings"
)

func main() {
	puntos := 0

	fmt.Println("=== Archivo de prueba de slices ===")

	// 1. Creación de slices (6 puntos)
	fmt.Println("==== Creación de slices ====")
	puntosCreacion := 0

	fmt.Println("Creación con literales:")
	numeros := []int{1, 2, 3, 4, 5}
	fmt.Println("###Validacion Manual")
	fmt.Println("numeros:", numeros)
	fmt.Println("OK Creación con literales: correcto")
	puntosCreacion = puntosCreacion + 6

	// 2. Acceso de Elementos (6 puntos)
	fmt.Println("\n==== Acceso de Elementos ====")
	puntosAcceso := 0

	fmt.Println("Acceso por índice:")
	primerElemento := numeros[0]
	fmt.Println("Primer elemento:", primerElemento)

	if primerElemento == 1 {
		puntosAcceso = puntosAcceso + 2
		fmt.Println("OK Acceso por índice: correcto")
	} else {
		fmt.Println("X Acceso por índice: incorrecto")
	}

	fmt.Println("\nModificación de elementos:")
	numeros[0] = 10
	fmt.Println("numeros después de modificar:", numeros)

	if numeros[0] == 10 {
		puntosAcceso = puntosAcceso + 4
		fmt.Println("OK Modificación de elementos: correcto")
	} else {
		fmt.Println("X Modificación de elementos: incorrecto")
	}

	// 3. Función slices.Index (1 punto)
	fmt.Println("\n==== Función slices.Index ====")
	puntosIndex := 0

	fmt.Println("Búsqueda de elementos con slices.Index:")
	numeros = []int{10, 20, 30, 40, 50}
	indice1 := slices.Index(numeros, 30)
	indice2 := slices.Index(numeros, 60) // No existe, debería retornar -1
	fmt.Println("Índice de 30:", indice1)
	fmt.Println("Índice de 60:", indice2)

	if indice1 == 2 && indice2 == -1 {
		puntosIndex = puntosIndex + 1
		fmt.Println("OK slices.Index: correcto")
	} else {
		fmt.Println("X slices.Index: incorrecto")
	}

	// 4. Función Strings.Join (1 punto)
	fmt.Println("\n==== Función Strings.Join ====")
	puntosJoin := 0

	fmt.Println("Unión de strings con strings.Join:")
	palabras := []string{"Hola", "mundo", "desde", "Go"}
	frase := strings.Join(palabras, " ")
	fraseConComas := strings.Join(palabras, ", ")
	fmt.Println("Frase con espacios:", frase)
	fmt.Println("Frase con comas:", fraseConComas)

	if frase == "Hola mundo desde Go" && fraseConComas == "Hola, mundo, desde, Go" {
		puntosJoin = puntosJoin + 1
		fmt.Println("OK strings.Join: correcto")
	} else {
		fmt.Println("X strings.Join: incorrecto")
	}

	// 5. Función len (3 puntos)
	fmt.Println("\n==== Función len ====")
	puntosLen := 0

	fmt.Println("Longitud de slices con len:")
	longitud1 := len(numeros)
	longitud2 := len(palabras)
	fmt.Println("Longitud de numeros:", longitud1)
	fmt.Println("Longitud de palabras:", longitud2)

	if longitud1 == 5 && longitud2 == 4 {
		puntosLen = puntosLen + 3
		fmt.Println("OK len: correcto")
	} else {
		fmt.Println("X len: incorrecto")
	}

	// 6. Función append (3 puntos)
	fmt.Println("\n==== Función append ====")
	puntosAppend := 0

	fmt.Println("Agregar elementos con append:")
	numeros = []int{1, 2, 3}
	numeros = append(numeros, 4)
	fmt.Println("numeros después de append(numeros, 4):", numeros)

	if len(numeros) == 4 && numeros[3] == 4 {
		puntosAppend = puntosAppend + 3
		fmt.Println("OK Agregar un elemento: correcto")
	} else {
		fmt.Println("X Agregar un elemento: incorrecto")
	}

	// Resumen de puntos
	puntos = puntosCreacion + puntosAcceso + puntosIndex + puntosJoin +
		puntosLen + puntosAppend

	fmt.Println("\n=== Tabla de Resultados ===")
	fmt.Println("+----------------------------------+--------+-------+")
	fmt.Println("| Característica                   | Puntos | Total |")
	fmt.Println("+----------------------------------+--------+-------+")
	fmt.Println("| Creación de slices               | ", puntosCreacion, "    | 6     |")
	fmt.Println("| Acceso de Elementos              | ", puntosAcceso, "    | 6     |")
	fmt.Println("| Función slices.Index             | ", puntosIndex, "    | 1     |")
	fmt.Println("| Función Strings.Join             | ", puntosJoin, "    | 1     |")
	fmt.Println("| Función len                      | ", puntosLen, "    | 3     |")
	fmt.Println("| Función append                   | ", puntosAppend, "    | 3     |")
	fmt.Println("+----------------------------------+--------+-------+")
	fmt.Println("| TOTAL                            | ", puntos, "   | 20    |")
	fmt.Println("+----------------------------------+--------+-------+")
}
