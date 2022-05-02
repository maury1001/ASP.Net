using HolaMundoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolaMundoMVC.Controllers;

public class EscuelaController: Controller
{
    public IActionResult Index()
    {
        var escuela = new Escuela();
        escuela.AñoFundacion = 2005;
        escuela.EscuelaID = Guid.NewGuid().ToString();
        escuela.Nombre = "UNTDF";
        return View(escuela);
    }

}
