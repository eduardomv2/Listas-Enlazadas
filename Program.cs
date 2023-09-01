using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creamos una instancia de LinkedList<int> llamada miListaEnlazada para almacenar enteros.
        LinkedList<int> miListaEnlazada = new LinkedList<int>();

        // Agregamos elementos a la lista enlazada usando el método AddLast.
        miListaEnlazada.AddLast(1);
        miListaEnlazada.AddLast(2);
        miListaEnlazada.AddLast(3);

        // Mostramos los elementos en la lista enlazada usando un bucle foreach.
        Console.WriteLine("Elementos en la lista enlazada:");
        foreach (int elemento in miListaEnlazada)
        {
            Console.WriteLine(elemento);
        }

        // Eliminamos un elemento de la lista enlazada.
        miListaEnlazada.Remove(1);

        // Mostramos los elementos restantes en la lista enlazada después de la eliminación.
        Console.WriteLine("\nElementos en la lista enlazada después de la eliminación:");
        foreach (int elemento in miListaEnlazada)
        {
            Console.WriteLine(elemento);
            Console.ReadKey();
        }
    }
}
