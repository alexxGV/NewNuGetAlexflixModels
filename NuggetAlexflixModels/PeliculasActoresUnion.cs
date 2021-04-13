using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetAlexflixModels
{
    [Table("PELICULASACTORESUNION")]
    public class PeliculasActoresUnion
    {
        [Key]
        [Column("IdPA")]
        public int IdPA { get; set; }

        [Column("IdPelicula")]
        public int IdPelicula { get; set; }
        
        [Column("IdActor")]
        public int IdActor { get; set; }

        [Column("Actor")]
        public String ActorNombre { get; set; }

    }
}
