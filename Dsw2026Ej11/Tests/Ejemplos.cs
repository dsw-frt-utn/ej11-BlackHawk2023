namespace Dsw2026Ej11.Tests;
using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using System.Runtime.CompilerServices;

internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos

    private static Alumno _alumno1 = new(1, "Juan Godoy", 20);
    private static Alumno _alumno2 = new(2, "María Llano", 22);
    private static Alumno _alumno3 = new(3, "Pedro Valenzuela", 21);

    public static void EjemploList()
    {
        CasoList casoList = new CasoList();
        casoList.AgregarAlumno(_alumno1);
        casoList.AgregarAlumno(_alumno2);
        casoList.AgregarAlumno(_alumno3);

        casoList.MostrarAlumnos();

        Console.WriteLine("\nVerificamos si el alumno Pedro Valenzuela existe en la lista:");
        casoList.MostrarAlumno("Pedro Valenzuela");

        Console.WriteLine("\nVerificamos si el alumno Jose Suarez existe en la lista:");
        casoList.MostrarAlumno("Jose Suarez");
        
        Console.WriteLine("\nEliminamos el alumno María Llano y listamos nuevamente:");
        casoList.EliminarAlumno(_alumno2);
        casoList.MostrarAlumnos();

        Console.WriteLine("\nEliminamos el primer elemento de la lista y listamos nuevamente:");
        casoList.EliminarAlumno(0);
        casoList.MostrarAlumnos();
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDictionary = new CasoDictionary();
        casoDictionary.AgregarAlumno(22601, _alumno1);
        casoDictionary.AgregarAlumno(33602, _alumno2);
        casoDictionary.AgregarAlumno(44603, _alumno3);

        casoDictionary.MostrarAlumnos();

        Console.WriteLine("\nVerificamos si el alumno con legajo 44603 existe en el diccionario:");
        casoDictionary.MostrarAlumno(44603);

        Console.WriteLine("\nVerificamos si el alumno con legajo 99999 existe en el diccionario:");
        casoDictionary.MostrarAlumno(99999);

        Console.WriteLine("\nEliminamos el alumno con legajo 33602 y listamos nuevamente:");
        casoDictionary.EliminarAlumno(33602);
        casoDictionary.MostrarAlumnos();
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq casoLinq = new CasoLinq();

        Console.WriteLine("\nPrimer elemento de la lista: {0}", casoLinq.GetPrimero());

        Console.WriteLine("\nUltimo elemento de la lista: {0}", casoLinq.GetUltimo());

        Console.WriteLine("\nTotal de precios: ${0:C}", casoLinq.GetTotalPrecios());

        Console.WriteLine("\nPromedio de precios: ${0:C}", casoLinq.GetPromedioPrecios());

        Console.WriteLine("\nLista de elementos por ID en orden ascendente:");
        foreach (var libro in casoLinq.GetListById())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nMayor precio: ${0:C}", casoLinq.GetMayorPrecio());

        Console.WriteLine("\nMenor precio: ${0:C}", casoLinq.GetMenorPrecio());

        Console.WriteLine("\nMayores que el promedio:");
        foreach (var libro in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine("\nLibros ordenados por titulo en orden descendente:");
        foreach (var libro in casoLinq.GetLibrosPorTituloDes())
        {
            Console.WriteLine(libro);
        }
    }
}
