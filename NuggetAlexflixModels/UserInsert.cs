using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetAlexflixModels
{
    public class UserInsert
    {
        public String Nombre { get; set; }

        public String Correo { get; set; }

        public String Username { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public String Password { get; set; }

    }
}
