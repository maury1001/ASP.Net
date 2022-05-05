using HolaMundoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolaMundoMVC.Controllers;

public class AlumnoController: Controller
{

    public IActionResult Index()
    {
        
        return View(new Alumno{Nombre="Mauricio",UniqueId = Guid.NewGuid().ToString()});
    }

    public IActionResult MultiAlumno()
    {
        var listaAlumnos = GenerarAlumnos();

        return View("MultiAlumno",listaAlumnos);
    }


    private List<Alumno> GenerarAlumnos()
        {
            string[] primerNombre = {"Adrian","Sonia","Sebastian"};
            string[] segundoNombre = {"Mauricio","Beatriz","Nicolas"};
            string[] apellido = {"Allaman","Bagnoud","Rober"};

            var listaAlumnos = from n1 in primerNombre
                               from n2 in segundoNombre
                               from a1 in apellido
                               select new Alumno{Nombre = $"{n1} {n2} {a1}",
                                                 UniqueId = Guid.NewGuid().ToString()};
            return listaAlumnos.OrderBy((al)=>al.UniqueId).ToList();
        }

}
