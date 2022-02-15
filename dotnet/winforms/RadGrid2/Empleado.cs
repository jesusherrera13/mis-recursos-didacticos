using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RadGrid2
{
    public class Empleado
    {
        //public Empleado(int Id, string Nombre, DateTime FNacimiento, int Horas)
        public Empleado(int Id, string Nombre, DateTime FNacimiento, decimal HorasDiarias, CategoriaTipo CategoriaId, Boolean Estado)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.FNacimiento = FNacimiento;
            this.HorasDiarias = HorasDiarias;
            this.CategoriaId = CategoriaId;
            this.Estado = Estado;
        }
        //the next attribute prevents the EmployeeId column from showing
        //[Browsable(false)]
        //public Categoria Type { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FNacimiento { get; set; }
        public decimal HorasDiarias { get; set; }
        public CategoriaTipo CategoriaId { get; set; }
        public Boolean Estado { get; set; }
        public String GetCategoriaString { get { return $"{EnumHelper.GetDescription(CategoriaId)}"; } }
    }
}
