using System;
using System.Timers;
Console.WriteLine("\nPulsa 1 para añadir un libro a la biblioteca");
Console.WriteLine("Pulsa 2 para coger un libro de la biblioteca");
Console.WriteLine("Pulsa 3 para devolver un libro");
Console.WriteLine("Pulsa 4 para buscar libro");
Console.WriteLine("Pulsa 5 para ver la lista de libros disponibles\n");
int librosbase = 0;
int librosbase2 = 0;

int Menu = Convert.ToInt32(Console.ReadLine());
Libro[,,] Biblioteca = new Libro[100, 1000, 100];
Disponible[,,,] Disponibilidad = new Disponible[100, 100, 100, 100];

while (Menu != 0)
{


    if (Menu == 1)
    {
        Console.WriteLine("¿Cuántos libros desea añadir?");
        int NuevosLibros = Convert.ToInt32(Console.ReadLine());
        librosbase2 = librosbase2 + librosbase;

        for (int i = 0 + librosbase; i < NuevosLibros + librosbase2; i++)
        {

            Console.WriteLine($"Datos del libro {i + 1}:");
            Console.Write("Nombre del libro: ");
            string nombre = Console.ReadLine();
            Console.Write("Autor del libro: ");
            string autor = Console.ReadLine();
            Console.Write("Número ISBN: ");
            int isbn = Convert.ToInt32(Console.ReadLine());
            bool prestado = false;

            // Crear una instancia de Libro y agregarla a la biblioteca
            Biblioteca[i, i, i] = new Libro(nombre, autor, isbn);
            Disponibilidad[i, i, i, i] = new Disponible(nombre, autor, isbn, prestado);
            Console.WriteLine("\nLibro añadido!\n");
            librosbase++;
        }


    }
    if (Menu == 2)
    {
        Console.WriteLine("Introduce el numero ISBN del libro que quieres tomar prestado");
        int ISBN = Convert.ToInt32(Console.ReadLine());
        bool encontrado = false;

        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                for (int k = 0; k < 100; k++)
                {
                    for (int z = 0; z < 100; z++)
                    {

                        if (Disponibilidad[i, j, k, z] != null && Disponibilidad[i, j, k, z].ISBN == ISBN)
                        {
                            encontrado = true;

                            if (Disponibilidad[i, j, k, z].Prestado == true)
                            {
                                Console.WriteLine("El libro" + Disponibilidad[i, j, k, z].Nombre + " está prestado lo sentimos.");
                            }
                            else
                            {
                                Console.WriteLine("Disfuta del libro" + Disponibilidad[i, j, k, z].Nombre + " y no olvide devolverlo");
                            }
                            Disponibilidad[i, j, k, z].Prestado = true;

                            ;
                        }
                    }
                    if (encontrado) ;
                }
                if (encontrado) ;
            }
            if (encontrado) ;
        }

        if (encontrado) { }
        else
        {
            Console.WriteLine("El libro no pertenece a la biblioteca");
        }

    }
    if (Menu == 3)
    {
        Console.WriteLine("Introduce el numero ISBN del libro que quieres devolver");
        int ISBN = Convert.ToInt32(Console.ReadLine());
        bool encontrado = false;

        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                for (int k = 0; k < 100; k++)
                {
                    for (int z = 0; z < 100; z++)
                    {

                        if (Disponibilidad[i, j, k, z] != null && Disponibilidad[i, j, k, z].ISBN == ISBN)
                        {
                            encontrado = true;

                            if (Disponibilidad[i, j, k, z].Prestado == false)
                            {
                                Console.WriteLine("El libro" + Disponibilidad[i, j, k, z].Nombre + " no está prestado, lo sentimos no es posible devolverlo.");
                            }
                            else
                            {
                                Console.WriteLine("El libro" + Disponibilidad[i, j, k, z].Nombre + " ha sido devuelto, muchas gracias.");
                            }
                            Disponibilidad[i, j, k, z].Prestado = false;

                            ;
                        }
                    }
                    if (encontrado) ;
                }
                if (encontrado) ;
            }
            if (encontrado) ;
        }

        if (encontrado) { }
        else
        {
            Console.WriteLine("El libro no pertenece a la biblioteca");
        }
    }


    if (Menu == 4)
    {
        Console.WriteLine("Introduce el Titulo, Autori o Numero ISBN del libro que quieres devolver");
        string input = Console.ReadLine();
        int numero;
        bool encontrado = false;

        if (int.TryParse(input, out numero))
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    for (int k = 0; k < 100; k++)
                    {
                        for (int z = 0; z < 100; z++)
                        {

                            if (Disponibilidad[i, j, k, z] != null && Disponibilidad[i, j, k, z].ISBN == numero)
                            {
                                encontrado = true;
                                Console.WriteLine("\n" + Biblioteca[i, j, k].Nombre);
                                Console.WriteLine(Biblioteca[i, j, k].Autor);
                                Console.WriteLine(Biblioteca[i, j, k].ISBN);

                                ;
                            }
                        }
                        if (encontrado) ;
                    }
                    if (encontrado) ;
                }
                if (encontrado) ;
            }

            if (encontrado) { }
            else
            {
                Console.WriteLine("El libro no pertenece a la biblioteca");
            }
        }
        else
        {
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    for (int k = 0; k < 100; k++)
                    {
                        for (int z = 0; z < 100; z++)
                        {

                            if (Disponibilidad[i, j, k, z] != null && Disponibilidad[i, j, k, z].Nombre == input)
                            {
                                encontrado = true;
                                Console.WriteLine("\n" + Biblioteca[i, j, k].Nombre);
                                Console.WriteLine(Biblioteca[i, j, k].Autor);
                                Console.WriteLine(Biblioteca[i, j, k].ISBN);

                                ;
                            }
                            else if (Disponibilidad[i, j, k, z] != null && Disponibilidad[i, j, k, z].Autor == input)
                            {
                                encontrado = true;
                                Console.WriteLine("\n" + Biblioteca[i, j, k].Nombre);
                                Console.WriteLine(Biblioteca[i, j, k].Autor);
                                Console.WriteLine(Biblioteca[i, j, k].ISBN);

                                ;
                            }

                        }
                        if (encontrado) ;
                    }
                    if (encontrado) ;
                }
                if (encontrado) ;
            }

            if (encontrado) { }
            else
            {
                Console.WriteLine("El libro no pertenece a la biblioteca");
            }
        }
    }
    if (Menu == 5)
    {
        for (int i = 0; i < 100; i++)
        {
            for (int j = 0; j < 100; j++)
            {
                for (int k = 0; k < 100; k++)
                {


                    if (Biblioteca[i, j, k] != null)
                    {
                        Console.WriteLine("\n" + Biblioteca[i, j, k].Nombre);
                        Console.WriteLine(Biblioteca[i, j, k].Autor);
                        Console.WriteLine(Biblioteca[i, j, k].ISBN + "\n");
                    }

                }
            }
        }
    }

    Console.WriteLine("Pulsa 1 para añadir un libro a la biblioteca");
    Console.WriteLine("Pulsa 2 para coger un libro de la biblioteca");
    Console.WriteLine("Pulsa 3 para devolver un libro");
    Console.WriteLine("Pulsa 4 para buscar libro");
    Console.WriteLine("Pulsa 5 para ver la lista de libros disponibles\n");
    Menu = Convert.ToInt32(Console.ReadLine());
}

class Libro
{
    public string Nombre { get; set; }
    public string Autor { get; set; }
    public int ISBN { get; set; }

    public Libro(string nombre, string autor, int isbn)
    {
        Nombre = nombre;
        Autor = autor;
        ISBN = isbn;
    }

}

class Disponible
{
    public string Nombre { get; set; }
    public string Autor { get; set; }
    public int ISBN { get; set; }
    public bool Prestado { get; set; }

    public Disponible(string nombre, string autor, int isbn, bool prestado)
    {
        Nombre = nombre;
        Autor = autor;
        ISBN = isbn;
        Prestado = prestado;
    }
}

