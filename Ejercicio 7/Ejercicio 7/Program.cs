
Console.Clear();
//1) Pida 10 números al usuario.
int[] numeros = new int[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Ingrese el número {i+1}: ");
    numeros[i] = int .Parse(Console.ReadLine());

}
//2) Obtener la suma de todos los números ingresados.
//Acumulador
int suma = 0;
for (int i = 0; i < 10; i++)
{
    suma = suma + numeros[i];
}

//3) Obtener cual es el mayor de todos los números.
int mayor = numeros[0];
//empiezo a comparar desde 1 ya que al 0 ya lo declare como mayor
for (int i = 0; i < 10; i++)
{
    if (numeros[i] > mayor)
    {
        mayor = numeros[i];
    }
}
//4) Obtener cual es el menor de todos los números.
int menor = numeros[0];

for (int i = 0; i < 10; i++)
{
    if (numeros[i] < menor)
    {
        menor = numeros[i];
    }
}

//5) Obtener el promedio de todos los números.
//pongo la d para representar double
double promedio = suma / 10d;


//6) Mostrar todos los números ingresados por pantalla.
Console.WriteLine("Los números ingresados son: ");
for (int i = 0; i < 10; i++)
{
    Console.Write(numeros[i] +" ");
   
}
Console.WriteLine();
//7) Mostrar los valores calculados en los puntos 2, 3, 4 y 5
Console.WriteLine("La suma es:" + suma);
Console.WriteLine("El mayor es:" + mayor);
Console.WriteLine("La menor es:" + menor);
Console.WriteLine("El promedio es:" + promedio);
