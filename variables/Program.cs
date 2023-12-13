﻿
// Espacio de trabajo asignado
namespace Variables
{
    class MainClass
    {
        // Metodo Principal de la clase, se ejecuta primero que todo en la clase del momento
        static void Main(string[] args)
        {
            /* Generico */

            // Se usa para declarar variables cuando el tipo de datos se infiere automáticamente por el compilador en función del valor asignado.
            var myVarInt = 10; // Aquí, el compilador infiere que 'numero' es del tipo int
            var myVarString = "Hello world with Var!"; // Aquí, 'texto' es inferido como string

            Console.WriteLine(myVarInt);
            Console.WriteLine(myVarString);

            /* Booleanos */

            // Almacena valores booleanos, es decir, true o false.
            // Generalmente ocupa 1 byte, aunque el tamaño exacto puede variar según la implementación del compilador.
            bool myTrue = true;
            bool myFalse = false;

            Console.WriteLine(myTrue);
            Console.WriteLine(myFalse);

            /* Cadenas */

            // Ocupa 2 bytes y puede representar caracteres en el rango de U+0000 a U+ffff.
            char myChar = 'A';

            // La longitud de una cadena puede variar dependiendo de la memoria disponible, no tiene un límite fijo predefinido.
            string myString = "Hello world with String!";

            // Declaración de una variable sin inicializarla
            string myStringVoid;
            myStringVoid = "new Hello World!"; // Asignando un valor a la variable

            Console.WriteLine(myChar);
            Console.WriteLine(myString);
            Console.WriteLine(myStringVoid);

            /* Números */

            // Representa números enteros.
            // Su tamaño es de 4 bytes y puede almacenar valores en el rango de -2,147,483,648 a 2,147,483,647
            int myInt = 1000; // 100...

            // Un número entero más grande que int.
            // Su tamaño es de 8 bytes y puede almacenar valores en el rango de -9,223,372,036,854,775,808 a 9,223,372,036,854,775,807.
            long myLong = 1000000000; // 10000000000...

            // Representa números de punto flotante de precisión simple. 
            // Ocupa 4 bytes y puede almacenar valores en el rango de ±1.5 x 10^-45 a ±3.4 x 10^38 con una precisión de 7 dígitos decimales
            float myFloat = 1.11111F; // 1.111111...F

            // Almacena números de punto flotante de doble precisión. 
            // Utiliza 8 bytes y puede almacenar valores en el rango de ±5.0 x 10^-324 a ±1.7 x 10^308 con una precisión de 15-16 dígitos decimales.
            double myDouble = 1.11111111111111111F; // 1.111111111111...F

            Console.WriteLine(myInt);
            Console.WriteLine(myLong);
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
        }
    }
}
