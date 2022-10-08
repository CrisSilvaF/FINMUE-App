using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FINMUE.Models;

    public class DataContext : DbContext
    {
        public DataContext (DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<FINMUE.Models.Casa> Casa { get; set; } = default!;

        public DbSet<FINMUE.Models.Inmueble> Inmueble { get; set; }

        public DbSet<FINMUE.Models.Inquilino> Inquilino { get; set; }

        public DbSet<FINMUE.Models.Local> Local { get; set; }

        public DbSet<FINMUE.Models.Movimiento> Movimiento { get; set; }

        public DbSet<FINMUE.Models.Piso> Piso { get; set; }

        public DbSet<FINMUE.Models.Recibo> Recibo { get; set; }
    }
