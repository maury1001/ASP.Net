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
        var listaAlumnos = new List<Alumno>()
        {
            new Alumno{Nombre="Mauricio",UniqueId = Guid.NewGuid().ToString()},
            new Alumno{Nombre="Sonia",UniqueId = Guid.NewGuid().ToString()},
            new Alumno{Nombre="Cinthia",UniqueId = Guid.NewGuid().ToString()},
            new Alumno{Nombre="Sergio",UniqueId = Guid.NewGuid().ToString()}
        };



        return View("MultiAlumno",listaAlumnos);
    }

}
