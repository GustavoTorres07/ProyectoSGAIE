using Microsoft.AspNetCore.Mvc;
using ProyectoSGAIE.Models;

namespace ProyectoSGAIE.Controllers
{
    public class AlumnoController : Controller
    {
        private readonly dbinstitutoContext _dbinstitutocontext;


        public AlumnoController(dbinstitutoContext dbinstitutoContext)
        {

            _dbinstitutocontext = dbinstitutoContext;


        }


        public IActionResult Index()
        {
            var lst = _dbinstitutocontext.Alumnos;

            return View(lst.ToList());


        }
    }
}
