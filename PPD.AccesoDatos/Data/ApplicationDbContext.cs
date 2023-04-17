using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PPD.Modelos;

namespace Tutorial1.AccesoDatos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Los modelos van por jerarquia y tenemos a Administrador Como Tabla Mayor.
        public DbSet<Administrador> Administrador { get; set; }

        public DbSet<Sucursales> Sucursales { get; set; }

        public DbSet<Empleados> Empleados { get; set; }
        
        public DbSet<Peticiones> Peticiones { get; set; }  

    }
}
