using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPD.Modelos
{
    public class Sucursales
    {
        [Key]
        public int ID { get; set; }

        public string Nombre { get; set; }

        public TimeSpan tiempo { get; set; }

        public int adminID { get; set; }

        [ForeignKey("adminID")]

        public Administrador administrador { get; set; }

    }
}
