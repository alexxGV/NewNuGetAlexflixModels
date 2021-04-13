using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetAlexflixModels
{
    [Table("Peliculas")]
    public class Pelicula
    {
        [Key]
        [Column("IdPelicula")]
        public int IdPelicula { get; set; }

        [Column("Titulo")]
        public String Titulo { get; set; }

        [Column("IdGenero")]
        public int IdGenero { get; set; }

        [Column("Sinopsis")]
        public String Sinopsis{ get; set; }

        [Column("Valoracion")]
        public int Valoracion { get; set; }

        [Column("Duracion")]
        public int Duracion { get; set; }

        [Column("Imagen")]
        public String Imagen { get; set; }

        [Column("Trailer")]
        public String Video { get; set; }


    }
}
