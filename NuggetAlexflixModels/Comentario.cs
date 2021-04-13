using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetAlexflixModels
{
    [Table("Comentarios")]
    public class Comentario
    {
        [Key]
        [Column("IdComentario")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdComentario { get; set; }

        [Column("IdPelicula")]
        public int IdPelicula { get; set; }

        [Column("IdUsuario")]
        public int IdUsario { get; set; }

        [Column("Comentario")]
        public String ComentarioTexto { get; set; }

        [Column("Valoracion")]
        public int Valoracion { get; set; }
    }
}
