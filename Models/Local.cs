using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINMUE.Models
{
    public class Local
    {
        [Key]
        public int LocalId { get; set; }

        public string NumeroDeLocal { get; set; }

        public int MetrosCuadrados { get; set; }

        public string Tipo { get; set; }

        public int InmuebleId { get; set; }
    }
}
//dotnet-aspnet-codegenerator controller -name LocalController -m Local -dc DataContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite