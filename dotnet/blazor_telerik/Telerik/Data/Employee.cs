using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Telerik.Data
{
    public class Employee
    {
        [Editable(false)]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FNacimiento { get; set; }
        public Categoria CategoriaId { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? Salario { get; set; }
        public Boolean Estado { get; set; }

    }
}
