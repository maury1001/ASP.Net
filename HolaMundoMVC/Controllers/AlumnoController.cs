using HolaMundoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace HolaMundoMVC.Controllers;

public class AlumnoController: Controller
{

    public IActionResult Index()
    {
        
        return View(_context.Alumnos.FirstOrDefault());
    }

    public IActionResult MultiAlumno()
    {
        return View("MultiAlumno",_context.Alumnos);
    }

         private EscuelaContext _context;
         public AlumnoController(EscuelaContext context)
            {
                _context = context;
            }

}
