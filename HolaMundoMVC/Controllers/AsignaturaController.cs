using HolaMundoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolaMundoMVC.Controllers;

public class AsignaturaController: Controller
{

    public IActionResult Index()
    {
        
        return View(_context.Asignaturas.FirstOrDefault());
    }

    public IActionResult MultiAsignatura()
    {
        return View("MultiAsignatura",_context.Asignaturas);
    }


     private EscuelaContext _context;
    public AsignaturaController(EscuelaContext context)
        {
            _context = context;
        }
}
