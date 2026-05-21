namespace Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<Alumno> _alumnos;

    public CasoList()
    {
        _alumnos = new List<Alumno>();
    }

    public void AgregarAlumno(Alumno alumno)
    {
        if (alumno != null) _alumnos.Add(alumno);
    }

    public List<Alumno> GetAlumnos()
    {
        return _alumnos;
    }

    public Alumno? BuscarAlumno(string nombre)
    {
        foreach (var alumno in _alumnos)
        {
            if (alumno.Nombre.Equals(nombre)) return alumno;
        }
        return null;
    }

    public void EliminarAlumno(Alumno alumno)
    {
        _alumnos.Remove(alumno);
    }

    public void EliminarAlumno(int posicion)
    {
        if (posicion < _alumnos.Count && posicion >= 0) _alumnos.RemoveAt(posicion);
    }

    public void MostrarAlumnos()
    {
        Console.WriteLine("\nListado de alumnos:");
        foreach (var alumno in _alumnos)
        {
            Console.WriteLine(alumno);
        }
    }

    public void MostrarAlumno(string nombre)
    {
        var alumno = BuscarAlumno(nombre);
        if (alumno != null)
        {
            Console.WriteLine(alumno);
        }
        else
        {
            Console.WriteLine("No existe");
        }
    }
}
