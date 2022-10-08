using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINMUE.Models
{
    public class Inmueble
    {
        [Key]
        public int InmuebleId { get; set; }

        public string TipoDeInmueble { get; set; }

        public string Nombre { get; set; }

        public string Domicilio { get; set; }

        public ICollection<Piso>? ListaPisos { get; set; }

        public ICollection<Local>? ListaLocales { get; set; }

        public ICollection<Casa>? ListaCasas { get; set; }

        public decimal Costo { get; set; } //asociado a uno de los conceptos de abajo//

        public string Status { get; set; } //Puede ser rentado, disponible, en venta, vendido//

        public DateTime? FechaActualizacion { get; set; }

        public ICollection<Movimiento>? ListaMovimientos { get; set; }

        public ICollection<Inquilino> ListaInquilinos { get; set; }

    }
}
//dotnet-aspnet-codegenerator controller -name InmuebleController -m Inmueble -dc DataContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite