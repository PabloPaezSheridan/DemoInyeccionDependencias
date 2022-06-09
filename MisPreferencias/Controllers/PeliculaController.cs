using Microsoft.AspNetCore.Mvc;
using MisPreferencias.Data.Repository;
using MisPreferencias.Models;

namespace MisPreferencias.Controllers
{
    public class PeliculaController : Controller
    {

        private readonly PeliculasRepository _peliculasRepositoryService;

        public PeliculaController(PeliculasRepository peliculasRepositoryService)
        {
            _peliculasRepositoryService = peliculasRepositoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public ActionResult ListadoPeliculas()
        {
            List<Pelicula> peliculas = _peliculasRepositoryService.GetPeliculas();
            return View("ListadoPeliculas", peliculas);
        }
    }
}
