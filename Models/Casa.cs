using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINMUE.Models
{
    public class Casa
    {
        [Key]
        public int CasaId { get; set; }

        public string NumeroDeCasa { get; set; }

        public int MetrosCuadrados { get; set; }

        public int InmuebleId { get; set; }
    }
}
//dotnet-aspnet-codegenerator controller -name CasaController -m Casa -dc DataContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite