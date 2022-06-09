using System.ComponentModel.DataAnnotations;

namespace MisPreferencias.Models
{
    public class Pelicula
    {
        [Key]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Puntaje { get; set; }
    }
}
