using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPD.Modelos
{
    public class Administrador
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Mail { get; set; }

        [Required]
        public int Celular { get; set; }

        [Required]
        public string Usuario { get; set; }

        [Required]
         public string Clave { get; set; }

    }
}
