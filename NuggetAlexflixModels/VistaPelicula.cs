using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetAlexflixModels
{
    //[Table("VISTAPELICULA")]
    public class VistaPelicula
    {
        public Pelicula Pelicula { get; set; }

        public String Genero { get; set; }

        public List<Actor> Actores { get; set; }

        public List<ComentarioUser> ComentariosUsers { get; set; }
    }
}
