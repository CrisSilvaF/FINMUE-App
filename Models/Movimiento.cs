using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINMUE.Models
{
    public class Movimiento
    {
        [Key]
        public int MovimientoId{ get; set; }

        public string Tipo { get; set; } //el tipo de movimiento, ingreso o gasto/

        public decimal Monto { get; set; }

        public string Concepto { get; set; }

        public Inmueble Inmueble { get; set; }

        public DateTime? FechaDeMovimiento { get; set; }

        public string Status { get; set; }

        public ICollection<Recibo> Recibos { get; set; }

    }
}
//dotnet-aspnet-codegenerator controller -name MovimientoController -m Movimiento -dc DataContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite