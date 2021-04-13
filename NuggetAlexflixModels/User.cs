using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NuGetAlexflixModels
{
    [Table("Users")]
    public class User
    {
        [Key]
        [Column("IdUser")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdUsuario { get; set; }

        [Column("Nombre")]
        public String Nombre { get; set; }

        [Column("Correo")]
        public String Correo { get; set; }

        [Column("username")]
        public String Username { get; set; }

        [Column("FechaNacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Column("salt")]
        public String Salt { get; set; }
        
        [Column("Password")]
        public byte[] Password { get; set; }

        [Column("Rol")]
        public String Rol { get; set; }

    }
}
