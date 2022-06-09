using MisPreferencias.Models;

namespace MisPreferencias.Data.Repository
{
    public class PeliculasRepository : IPeliculasRepository
    {
        private readonly MisPreferencias.Models.Context.AppContext _context;

        public PeliculasRepository(MisPreferencias.Models.Context.AppContext context)
        {
            _context = context;
        }
        public List<Pelicula> GetPeliculas()
        {
            List<Pelicula> peliculas = _context.Peliculas.OrderBy(p => p.Puntaje).ToList();
            return peliculas;
        }
    }
}
