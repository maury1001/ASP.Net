using HolaMundoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolaMundoMVC.Controllers;

public class EscuelaController: Controller
{
    public IActionResult Index()
    {
        var escuela = new Escuela();
        escuela.AñoDeCreacion = 2005;
        escuela.UniqueId = Guid.NewGuid().ToString();
        escuela.Nombre = "UNTDF";
        escuela.Direccion = "Av. Siempre viva";
        escuela.Ciudad = "Ushuaia";
        escuela.Pais = "Argentina";
        escuela.TipoEscuela = TiposEscuela.Secundaria;
        return View(escuela);
    }

}
