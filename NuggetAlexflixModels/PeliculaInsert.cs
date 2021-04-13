using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetAlexflixModels
{
    public class PeliculaInsert
    {
        public String Titulo { get; set; }

        public int IdGenero { get; set; }

        public String Sinopsis{ get; set; }

        public int Valoracion { get; set; }

        public int Duracion { get; set; }

        public String Imagen { get; set; }

        public String Video { get; set; }


    }
}
