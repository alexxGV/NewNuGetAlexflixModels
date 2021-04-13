using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetAlexflixModels
{
    [Table("Actores")]
    public class Actor
    {
        [Key]
        [Column("IdActor")]
        public int IdActor { get; set; }

        [Column("Actor")]
        public String Nombre { get; set; }
    }
}
