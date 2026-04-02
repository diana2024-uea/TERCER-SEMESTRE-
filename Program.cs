using System;

class NodoArbol
{
    public int dato;
    public NodoArbol izquierda;
    public NodoArbol derecha;

    public NodoArbol(int valor)
    {
        dato = valor;
        izquierda = null;
        derecha = null;
    }
}

class ArbolBusqueda
{
    public NodoArbol raiz;

    public ArbolBusqueda()
    {
        raiz = null;
    }

    public void Agregar(int valor)
    {
        raiz = InsertarNodo(raiz, valor);
    }

    private NodoArbol InsertarNodo(NodoArbol actual, int valor)
    {
        if (actual == null)
        {
            return new NodoArbol(valor);
        }

        if (valor < actual.dato)
        {
            actual.izquierda = InsertarNodo(actual.izquierda, valor);
        }
        else if (valor > actual.dato)
        {
            actual.derecha = InsertarNodo(actual.derecha, valor);
        }

        return actual;
    }

    public void MostrarInOrden(NodoArbol nodo)
    {
        if (nodo != null)
        {
            MostrarInOrden(nodo.izquierda);
            Console.Write(nodo.dato + " ");
            MostrarInOrden(nodo.derecha);
        }
    }

    public void MostrarPreOrden(NodoArbol nodo)
    {
        if (nodo != null)
        {
            Console.Write(nodo.dato + " ");
            MostrarPreOrden(nodo.izquierda);
            MostrarPreOrden(nodo.derecha);
        }
    }

    public void MostrarPostOrden(NodoArbol nodo)
    {
        if (nodo != null)
        {
            MostrarPostOrden(nodo.izquierda);
            MostrarPostOrden(nodo.derecha);
            Console.Write(nodo.dato + " ");
        }
    }
}

class ProgramaPrincipal
{
    static void Main(string[] args)
    {
        // =============================
        // PRIMER ÁRBOL
        // =============================
        ArbolBusqueda arbol1 = new ArbolBusqueda();

        int[] valores1 = { 50, 30, 70, 20, 40, 60, 80 };

        Console.WriteLine("===== ÁRBOL 1 =====\n");
        Console.WriteLine("Insertando datos...\n");

        foreach (int num in valores1)
        {
            arbol1.Agregar(num);
        }

        Console.WriteLine("Recorrido InOrden:");
        arbol1.MostrarInOrden(arbol1.raiz);

        Console.WriteLine("\n\nRecorrido PreOrden:");
        arbol1.MostrarPreOrden(arbol1.raiz);

        Console.WriteLine("\n\nRecorrido PostOrden:");
        arbol1.MostrarPostOrden(arbol1.raiz);

        Console.WriteLine("\n\n---------------------------------\n");


        // =============================
        // SEGUNDO ÁRBOL
        // =============================
        ArbolBusqueda arbol2 = new ArbolBusqueda();

        int[] valores2 = { 15, 10, 20, 8, 12, 17, 25 };

        Console.WriteLine("===== ÁRBOL 2 =====\n");
        Console.WriteLine("Insertando datos...\n");

        foreach (int num in valores2)
        {
            arbol2.Agregar(num);
        }

        Console.WriteLine("Recorrido InOrden:");
        arbol2.MostrarInOrden(arbol2.raiz);

        Console.WriteLine("\n\nRecorrido PreOrden:");
        arbol2.MostrarPreOrden(arbol2.raiz);

        Console.WriteLine("\n\nRecorrido PostOrden:");
        arbol2.MostrarPostOrden(arbol2.raiz);

        Console.WriteLine("\n\nEjecución finalizada. Presione una tecla para salir.");
        Console.ReadKey();
    }
}