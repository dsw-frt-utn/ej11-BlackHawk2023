namespace Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> _alumnos;

    public CasoDictionary()
    {
        _alumnos = new Dictionary<int, Alumno>();
    }

    public void AgregarAlumno(int legajo, Alumno alumno)
    {
        if (alumno != null && legajo != 0 && !_alumnos.ContainsKey(legajo)) _alumnos.Add(legajo, alumno);
    }

    public Alumno? BuscarAlumno(int legajo)
    {
        foreach (var alumno in _alumnos)
        {
            if (alumno.Key == legajo) return alumno.Value;
        }
        return null;
    }

    public Dictionary<int, Alumno> GetAlumnos()
    {
        return _alumnos;
    }

    public void EliminarAlumno(int legajo)
    {
        if (legajo != 0 && _alumnos.ContainsKey(legajo)) _alumnos.Remove(legajo);
    }

    public void MostrarAlumnos()
    {
        Console.WriteLine("\nListado de alumnos:");
        foreach (var alumno in _alumnos)
        {
            Console.WriteLine($"Legajo: {alumno.Key}, Alumno: {alumno.Value}");
        }
    }

    public void MostrarAlumno(int legajo)
    {
        if (_alumnos.ContainsKey(legajo))
        {
            var alumno = _alumnos[legajo];
            Console.WriteLine($"Legajo: {legajo}, Alumno: {alumno}");
        }
        else
        {
            Console.WriteLine("No existe");
        }
    }
}