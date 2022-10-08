using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINMUE.Models
{
    public class Recibo
    {
        [Key]
        public int Id { get; set; }

        public string ValorUnicoRecibo { get; set; } //Concatenacion de IdPiso+"|"+IdLocal+"|"+Id(esta clase)//

        public DateTime FechaEmision { get; set; }

        public decimal Importe { get; set; }

        public string Concepto { get; set; }

        public decimal CargoAgua { get; set; }

        public decimal CargoElectricidad { get; set; }

        public decimal CargoTelefono { get; set; }

        public decimal CargoGas { get; set; }

        public string Status { get; set; }

        public int InmuebleId { get; set; }
    }
}
//dotnet-aspnet-codegenerator controller -name ReciboController -m Recibo -dc DataContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite