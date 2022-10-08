using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FINMUE.Models
{
    public class Inquilino
    {
        [Key]
        public int InquilinoId { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Identificacion { get; set; }

        public string Sexo { get; set; }

        public DateTime FechaDeAlta { get; set; }

        public DateTime FechaDeBaja { get; set; }

        public Inmueble? Inmueble { get; set; }

        public ICollection<Recibo> ListaRecibos { get; set; }
    }
}
//dotnet-aspnet-codegenerator controller -name InquilinoController -m Inquilino -dc DataContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite