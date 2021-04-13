using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetAlexflixModels
{
    public class ComentarioInsert
    {
        public int IdPelicula { get; set; }

        public int IdUsario { get; set; }

        public String ComentarioTexto { get; set; }

        public int Valoracion { get; set; }
    }
}
