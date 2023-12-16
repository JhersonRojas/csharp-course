int counter = 0;

// Ejecuta un codigo hasta que la condicional se cumpla para detenerse
while (counter < 10)
{
    Console.WriteLine($"Hello World! The counter is {counter}");
    counter++;
}

// Ejecuta el codigo una primera vez y asimila lo logica de un While corriente 
int doCounter = 0;

do
{
    Console.WriteLine($"Hello World! The doCounter is {doCounter}");
    doCounter++;
} while (doCounter < 10);

// Reitera un codigo pero no de forma infinita, sino, hasta la sentencia agregada
// Este funciona bajo una la logica numerica
for (int forCounter = 0; forCounter < 10; forCounter++)
{
    Console.WriteLine($"Hello World! The forCounter is {forCounter}");
}

// O de caracteres
for (char charCounter = 'a'; charCounter < 'k'; charCounter++)
{
    Console.WriteLine($"The charCounter is {charCounter}");
}

// Tambien es posible iterar listas o Array para conocer su contenido
var names = new List<string> { "Juan", "Ana", "Felipe" };

foreach (var name in names)
{
    Console.WriteLine($"Hello {name}!");
}

// Cierto tipo de variables tienen metodos especiales para recorrerlas
// o modificarlas, ejemplos con la lista.

var index = names.IndexOf("Felipe");
if (index != -1)
{
    Console.WriteLine($"The name {names[index]} is at index {index}");
}
else
{
    Console.WriteLine($"When an item is not found, IndexOf returns Not Found");
}

// Tambien aplica el metodo Sort() para ordenar Listas/Arrays de forma ascendente
names.Sort();
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

// Ejemplo de ejecución de codigo, con fibonacci
var fibonacciNumbers = new List<int> { 1, 1 };

while (fibonacciNumbers.Count < 20)
{
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);
}
foreach (var item in fibonacciNumbers)
{
    Console.WriteLine(item);
}
