using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetAlexflixModels
{
    public class ComentarioUser
    {
        public Comentario Comentario { get; set; }

        public User Usuario { get; set; }
    }
}
