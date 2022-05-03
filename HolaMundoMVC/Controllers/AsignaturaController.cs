using HolaMundoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolaMundoMVC.Controllers;

public class AsignaturaController: Controller
{
    public IActionResult Index()
    {
        var asignatura = new Asignatura();
        asignatura.UniqueId = Guid.NewGuid().ToString();
        asignatura.Nombre = "Programación";
        return View(asignatura);
    }

}
