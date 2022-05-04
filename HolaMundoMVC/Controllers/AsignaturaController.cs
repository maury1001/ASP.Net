using HolaMundoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolaMundoMVC.Controllers;

public class AsignaturaController: Controller
{

    public IActionResult Index()
    {
        
        return View(new Asignatura{Nombre="Programación",UniqueId = Guid.NewGuid().ToString()});
    }

    public IActionResult MultiAsignatura()
    {
        var listaAsignaturas = new List<Asignatura>()
        {
            new Asignatura{Nombre="Matemáticas",UniqueId = Guid.NewGuid().ToString()},
            new Asignatura{Nombre="Educación Física",UniqueId = Guid.NewGuid().ToString()},
            new Asignatura{Nombre="Castellano",UniqueId = Guid.NewGuid().ToString()},
            new Asignatura{Nombre="Programación",UniqueId = Guid.NewGuid().ToString()}
        };



        return View("MultiAsignatura",listaAsignaturas);
    }

}
