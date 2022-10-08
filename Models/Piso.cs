using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINMUE.Models
{
    public class Piso
    {
        [Key]
        public int PisoId { get; set; }

        public int NumeroDePiso { get; set; }

        public int MetrosCuadrados { get; set; }

        public int InmuebleId { get; set; }
    }
}
//dotnet-aspnet-codegenerator controller -name PisoController -m Piso -dc DataContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite