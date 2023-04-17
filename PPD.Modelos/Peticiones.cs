using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPD.Modelos
{

    /*
     * En esta clase, Id es la clave principal que se utilizará para identificar cada petición.
     * FechaInicio y FechaFin son las fechas de inicio y finalización de la petición, respectivamente.
     * DuracionEstimada es la duración estimada de cada tarea en la petición.
     * FranjaHoraria es la franja horaria en la que se realizará cada tarea, y DiasRepetidos es una lista de los días de la semana en los que se repetirá la petición.
    */
    public class Peticiones
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; }


        //En que horario se estima que se realizara la tarea.
        [Display(Name = "Tiempo")]
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        //La duracion que van a tener.
        public TimeSpan DuracionEstimada { get; set; }

        //En que horario se estima realizar la tarea.
        public TimeSpan FranjaHoraria { get; set; }

        //Que dias se van a repetir.
        public List<DayOfWeek> DiasRepetidos { get; set; }

        //Creamos una variable para tomar los datos del tecnico.
        public int EmpleadoId { get; set; }
   
        //Esta llave se va a utilizar para realizar el emparejamiento con Empleados base de datos.
        [ForeignKey("EmpleadosId")]
        public Empleados Empleados { get; set; }


        //Con esto vinculamos de que sucursal es cada peticion.
        public int sucursalID { get; set; }

        [ForeignKey("sucursalID")]

        public Sucursales sucursales { get; set; }
  
    }
}
