using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetAlexflixModels
{
    [Table("USUARIOSPELICULAS")]
    public class UsuariosPeliculas
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IdUP")]
        public int IdUp { get; set; }

        [Column("IdUsuario")]
        public int IdUsuario { get; set; }

        [Column("IdPelicula")]
        public int IdPelicula { get; set; }
    }
}
