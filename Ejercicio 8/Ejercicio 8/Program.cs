//Ejercicio
Console.Clear();

//Crear un programa que cumpla con los siguientes pasos

//1) Crear una matriz de dos dimensiones de tipo int llamada numeros,
//2) Determinar el tamaño de cada dimansion (fila, columnas) mediante valores
//ingresados por pantalla
//3) Declarar un vector de tipo double llamado promedios
//4) Recorrer la matriz para su carga con elementos de tipo int
//5) Recorrer la matriz para mostrar cada valor de la matriz
//6) Calcular el promedio de cada columna y asignarlo a la posicion correspondiente dentro del vector promedios
//7) Mostrar los promedios recorriendo el vector promedios


//Le pedimos al usuario las dimensiones de la matriz

Console.WriteLine("Ingrese la cantidad de filas de la matriz");
int filas = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de columnas de la matriz");
int columnas = int.Parse(Console.ReadLine());

//Declaramos la matriz
var matriz = new int[filas, columnas];

//Cargamos los elementos en filas y columnas
for (int f = 0; f < filas; f++)
{
    Console.WriteLine();
    Console.WriteLine($"Vamos a ingresar valores de la fila {f +1}:");

    for (int c = 0; c < columnas; c++)
    {
        Console.WriteLine($"Vamos a ingresar valores para la columna {c+1}:");
        int valor = int.Parse(Console.ReadLine());
        matriz[f,c] = valor;
    }

}

//Declaramos el vector de promedio
var promedios = new double[columnas];

//Calculamos los promedios

for (int c = 0; c < columnas; c++)
{
    double suma = 0;
    for (int f = 0; f < filas; f++)
    {
        suma += matriz[f,c];
    }
    promedios[c] = suma / filas; 
}


//Mostramos la matriz 
Console.WriteLine("Los valores de la matriz son: ");
for (int f = 0; f < filas; f++)
{

    for (int c = 0; c < columnas; c++)
    {
        Console.Write($"{matriz[f,c]: 00}");
    }
    Console.WriteLine();
}

//Mostramos los promedios
Console.WriteLine("Los promedios de cada columna son: ");
for (int c = 0; c < columnas; c++)
{
    Console.Write($"{promedios[c]: 00.00} ");
   
}