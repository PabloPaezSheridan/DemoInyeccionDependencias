using MisPreferencias.Models;

namespace MisPreferencias.Data.Repository
{
    public interface IPeliculasRepository
    {
        List<Pelicula> GetPeliculas();
    }
}
