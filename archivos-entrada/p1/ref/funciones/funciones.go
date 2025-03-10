package main

import (
	"fmt"
	stdreflect "reflect"
	stdstrconv "strconv"
	"strings"
)

// Reemplazos para las funciones estándar
var strconv = struct {
	Atoi       func(string) int
	ParseFloat func(string) float64
}{
	Atoi: func(s string) int {
		// Verificar si contiene un punto decimal
		if strings.Contains(s, ".") {
			panic("strconv.Atoi: parsing \"" + s + "\": invalid syntax")
		}

		// Usar el Atoi estándar pero manejar el error
		val, err := stdstrconv.Atoi(s)
		if err != nil {
			panic("strconv.Atoi: parsing \"" + s + "\": invalid syntax")
		}
		return val
	},
	ParseFloat: func(s string) float64 {
		val, err := stdstrconv.ParseFloat(s, 64)
		if err != nil {
			panic("strconv.ParseFloat: parsing \"" + s + "\": invalid syntax")
		}
		return val
	},
}

// Reemplazo para reflect.TypeOf
var reflect = struct {
	TypeOf func(interface{}) string
}{
	TypeOf: func(v interface{}) string {
		t := stdreflect.TypeOf(v)
		return t.String()
	},
}

// Función sin parámetros que no retorna nada
func saludar() {
	fmt.Println("¡Hola, mundo!")
}

// Función sin parámetros que retorna un valor
func obtenerNumero() int {
	return 42
}

// Función con parámetros que no retorna nada
func saludarPersona(nombre string) {
	fmt.Println("¡Hola,", nombre+"!")
}

// Función con parámetros que retorna un valor
func sumar(a int, b int) int {
	return a + b
}

// Función recursiva: factorial
func factorial(n int) int {
	if n <= 1 {
		return 1
	}
	return n * factorial(n-1)
}

// Función recursiva: fibonacci
func fibonacci(n int) int {
	if n <= 1 {
		return n
	}
	return fibonacci(n-1) + fibonacci(n-2)
}

// Función recursiva: torres de Hanoi
func hanoi(n int, origen string, auxiliar string, destino string) {
	if n == 1 {
		fmt.Println("Mover disco 1 de", origen, "a", destino)
		return
	}

	hanoi(n-1, origen, destino, auxiliar)
	fmt.Println("Mover disco", n, "de", origen, "a", destino)
	hanoi(n-1, auxiliar, origen, destino)
}

func main() {
	puntos := 0

	fmt.Println("=== Archivo de prueba de funciones ===")

	// 1. Funciones no recursivas sin parámetros (1 punto)
	fmt.Println("==== Funciones no recursivas sin parámetros ====")
	puntosFuncionesSimples := 0

	fmt.Println("Función sin retorno:")
	fmt.Println("###Validacion Manual")
	saludar()

	fmt.Println("\nFunción con retorno:")
	numero := obtenerNumero()
	fmt.Println("El número obtenido es:", numero)

	if numero == 42 {
		puntosFuncionesSimples = puntosFuncionesSimples + 1
		fmt.Println("OK Funciones no recursivas sin parámetros: correcto")
	} else {
		fmt.Println("X Funciones no recursivas sin parámetros: incorrecto")
	}

	// 2. Funciones no recursivas con parámetros (2 puntos)
	fmt.Println("\n==== Funciones no recursivas con parámetros ====")
	puntosFuncionesParametros := 0

	fmt.Println("Función con parámetros sin retorno:")
	fmt.Println("###Validacion Manual")
	saludarPersona("Juan")

	fmt.Println("\nFunción con parámetros y retorno:")
	resultadoSuma := sumar(10, 20)
	fmt.Println("La suma de 10 y 20 es:", resultadoSuma)

	if resultadoSuma == 30 {
		puntosFuncionesParametros = puntosFuncionesParametros + 2
		fmt.Println("OK Función con parámetros y retorno: correcto")
	} else {
		fmt.Println("X Función con parámetros y retorno: incorrecto")
	}

	// 3. Funciones recursivas (6 puntos)
	fmt.Println("\n==== Funciones recursivas ====")
	puntosFuncionesRecursivas := 0

	fmt.Println("Factorial:")
	resultadoFactorial := factorial(5)
	fmt.Println("Factorial de 5:", resultadoFactorial)

	if resultadoFactorial == 120 {
		puntosFuncionesRecursivas = puntosFuncionesRecursivas + 2
		fmt.Println("OK Función factorial: correcto")
	} else {
		fmt.Println("X Función factorial: incorrecto")
	}

	fmt.Println("\nFibonacci:")
	resultadoFibonacci := fibonacci(10)
	fmt.Println("Fibonacci de 10:", resultadoFibonacci)

	if resultadoFibonacci == 55 {
		puntosFuncionesRecursivas = puntosFuncionesRecursivas + 2
		fmt.Println("OK Función fibonacci: correcto")
	} else {
		fmt.Println("X Función fibonacci: incorrecto")
	}

	fmt.Println("\nTorres de Hanoi:")
	fmt.Println("###Validacion Manual")
	hanoi(3, "A", "B", "C")
	puntosFuncionesRecursivas = puntosFuncionesRecursivas + 2

	// 4. strconv.Atoi (1 punto)
	fmt.Println("\n==== strconv.Atoi ====")
	puntosAtoi := 0

	fmt.Println("Conversión de string a int:")
	numeroEntero := strconv.Atoi("123")
	fmt.Println("\"123\" convertido a int:", numeroEntero)

	// Intentar convertir un número decimal (debe fallar)
	// numeroDecimalError := strconv.Atoi("123.45") // ! ERROR: Comentar esta línea para que el programa compile

	// Intentar convertir texto no numérico (debe fallar)
	// numeroTextoError := strconv.Atoi("abc") // ! ERROR: Comentar esta línea para que el programa compile

	if numeroEntero == 123 {
		puntosAtoi = puntosAtoi + 1
		fmt.Println("OK strconv.Atoi: correcto")
	} else {
		fmt.Println("X strconv.Atoi: incorrecto")
	}

	// 5. strconv.ParseFloat (1 punto)
	fmt.Println("\n==== strconv.ParseFloat ====")
	puntosParseFloat := 0

	fmt.Println("Conversión de string a float64:")
	numeroDecimal1 := strconv.ParseFloat("123.45")
	fmt.Println("\"123.45\" convertido a float64:", numeroDecimal1)

	// Convertir un número entero a float (debe funcionar)
	numeroDecimal2 := strconv.ParseFloat("123")
	fmt.Println("\"123\" convertido a float64:", numeroDecimal2)

	// Intentar convertir texto no numérico (debe fallar)
	// numeroTextoErrorFloat := strconv.ParseFloat("abc") // ! ERROR: Comentar esta línea para que el programa compile

	if numeroDecimal1 == 123.45 && numeroDecimal2 == 123.0 {
		puntosParseFloat = puntosParseFloat + 1
		fmt.Println("OK strconv.ParseFloat: correcto")
	} else {
		fmt.Println("X strconv.ParseFloat: incorrecto")
	}

	// 6. reflect.TypeOf (1 punto)
	fmt.Println("\n==== reflect.TypeOf ====")
	puntosTypeOf := 0

	fmt.Println("Obtener tipo de datos:")

	// Tipo int
	entero := 42
	tipoEntero := reflect.TypeOf(entero)
	fmt.Println("Tipo de 42:", tipoEntero)

	// Tipo float64
	decimal := 3.14159
	tipoDecimal := reflect.TypeOf(decimal)
	fmt.Println("Tipo de 3.14159:", tipoDecimal)

	// Tipo string
	texto := "Hola, mundo!"
	tipoTexto := reflect.TypeOf(texto)
	fmt.Println("Tipo de \"Hola, mundo!\":", tipoTexto)

	// Tipo bool
	booleano := true
	tipoBooleano := reflect.TypeOf(booleano)
	fmt.Println("Tipo de true:", tipoBooleano)

	// Tipo slice
	slice := []int{1, 2, 3}
	tipoSlice := reflect.TypeOf(slice)
	fmt.Println("Tipo de []int{1, 2, 3}:", tipoSlice)

	if tipoEntero == "int" && tipoDecimal == "float64" &&
		tipoTexto == "string" && tipoBooleano == "bool" &&
		tipoSlice == "[]int" {
		puntosTypeOf = puntosTypeOf + 1
		fmt.Println("OK reflect.TypeOf: correcto")
	} else {
		fmt.Println("X reflect.TypeOf: incorrecto")
	}

	// Resumen de puntos
	puntos = puntosFuncionesSimples + puntosFuncionesParametros + puntosFuncionesRecursivas +
		puntosAtoi + puntosParseFloat + puntosTypeOf

	fmt.Println("\n=== Errores ===")
	fmt.Println("###Validacion Manual")
	fmt.Println("Errores esperados ?/3")

	fmt.Println("\n=== Tabla de Resultados ===")
	fmt.Println("+----------------------------------+--------+-------+")
	fmt.Println("| Característica                   | Puntos | Total |")
	fmt.Println("+----------------------------------+--------+-------+")
	fmt.Println("| Funciones sin parámetros         | ", puntosFuncionesSimples, "    | 1     |")
	fmt.Println("| Funciones con parámetros         | ", puntosFuncionesParametros, "    | 2     |")
	fmt.Println("| Funciones recursivas             | ", puntosFuncionesRecursivas, "    | 6     |")
	fmt.Println("| strconv.Atoi                     | ", puntosAtoi, "    | 1     |")
	fmt.Println("| strconv.ParseFloat               | ", puntosParseFloat, "    | 1     |")
	fmt.Println("| reflect.TypeOf                   | ", puntosTypeOf, "    | 1     |")
	fmt.Println("+----------------------------------+--------+-------+")
	fmt.Println("| TOTAL                            | ", puntos, "   | 12    |")
	fmt.Println("+----------------------------------+--------+-------+")
}
