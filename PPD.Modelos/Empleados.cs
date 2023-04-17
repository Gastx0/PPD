using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPD.Modelos
{
    public class Empleados
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Mail { get; set; }
        [Required]
        public int celular { get; set; }

        public int? tickets { get; set; }



        //Con esto vinculamos de que sucursal es cada peticion.
        public int sucursalID { get; set; }

        [ForeignKey("sucursalID")]

        public Sucursales sucursales { get; set; }

    }
}
