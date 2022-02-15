using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace RadGrid2
{
    public partial class RadForm1 : Telerik.WinControls.UI.RadForm
    {
        public RadForm1()
        {
            InitializeComponent();

            this.radGridView1.ReadOnly = true;
            //form1 = new Form1(this);

            GridViewTextBoxColumn gridViewTextBoxColumn1 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn2 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn3 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn4 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn5 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn6 = new GridViewTextBoxColumn();
            GridViewTextBoxColumn gridViewTextBoxColumn7 = new GridViewTextBoxColumn();
            TableViewDefinition tableViewDefinition1 = new TableViewDefinition();

            this.radGridView1.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "TBId";
            gridViewTextBoxColumn2.FieldName = "Nombre";
            gridViewTextBoxColumn2.HeaderText = "Nombre Completo";
            gridViewTextBoxColumn2.MaxLength = 250;
            gridViewTextBoxColumn2.MinWidth = 200;
            gridViewTextBoxColumn2.Name = "TBNombre";
            gridViewTextBoxColumn2.Width = 250;

            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "TBId";
            gridViewTextBoxColumn2.FieldName = "Nombre";
            gridViewTextBoxColumn2.HeaderText = "Nombre Completo";
            gridViewTextBoxColumn2.MaxLength = 250;
            gridViewTextBoxColumn2.MinWidth = 200;
            gridViewTextBoxColumn2.Name = "TBNombre";
            gridViewTextBoxColumn2.Width = 250;

            gridViewTextBoxColumn3.FieldName = "FNacimiento";
            gridViewTextBoxColumn3.FormatString = "{0:yyyy-MM-dd}";
            gridViewTextBoxColumn3.HeaderText = "Fecha de Nacimiento";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.MaxLength = 100;
            gridViewTextBoxColumn3.MinWidth = 100;
            gridViewTextBoxColumn3.Name = "TBFNacimiento";
            gridViewTextBoxColumn3.Width = 100;

            gridViewTextBoxColumn4.FieldName = "HorasDiarias";
            gridViewTextBoxColumn4.FormatString = "{0:0.0}";
            gridViewTextBoxColumn4.HeaderText = "Horas Diarias";
            gridViewTextBoxColumn4.MaxLength = 100;
            gridViewTextBoxColumn4.MinWidth = 100;
            gridViewTextBoxColumn4.Name = "TBHorasDiarias";
            gridViewTextBoxColumn4.Width = 100;

            gridViewTextBoxColumn5.FieldName = "CategoriaId";
            gridViewTextBoxColumn5.HeaderText = "CategoriaId";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.MaxLength = 100;
            gridViewTextBoxColumn5.MinWidth = 100;
            gridViewTextBoxColumn5.Name = "TBCategoriaId";
            gridViewTextBoxColumn5.Width = 100;

            gridViewTextBoxColumn6.FieldName = "Categoria";
            gridViewTextBoxColumn6.HeaderText = "Categoría";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.MaxLength = 100;
            gridViewTextBoxColumn6.MinWidth = 100;
            gridViewTextBoxColumn6.Name = "TBCategoria";
            gridViewTextBoxColumn6.Width = 100;

            //gridViewTextBoxColumn5.FormatString = "CAT";
            gridViewTextBoxColumn7.FieldName = "Estado";
            gridViewTextBoxColumn7.HeaderText = "Estado";
            gridViewTextBoxColumn7.MaxLength = 100;
            gridViewTextBoxColumn7.MinWidth = 100;
            gridViewTextBoxColumn7.Name = "TBEstado";
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn7.Width = 100;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
                gridViewTextBoxColumn1,
                gridViewTextBoxColumn2,
                gridViewTextBoxColumn3,
                gridViewTextBoxColumn4,
                gridViewTextBoxColumn5,
                gridViewTextBoxColumn6,
                gridViewTextBoxColumn7
            });

            myList = new BindingList<Empleado>();
            myList.Add(new Empleado(1, "Steve Jobs", new DateTime(2011, 2, 11), 0.5m, CategoriaTipo.A, true));
            myList.Add(new Empleado(2, "Sofía Vergara", new DateTime(2011, 2, 12), 1.5m, CategoriaTipo.B, false));
            myList.Add(new Empleado(3, "Bill Gates", new DateTime(2011, 2, 13), 2m, CategoriaTipo.C, true));
            myList.Add(new Empleado(4, "Nikola Tesla", new DateTime(2011, 2, 14), 2.5m, CategoriaTipo.A, true));
            myList.Add(new Empleado(5, "Elon Musk", new DateTime(2011, 2, 15), 3m, CategoriaTipo.B, false));
            myList.Add(new Empleado(6, "Gal Gadot", new DateTime(2011, 2, 16), 3m, CategoriaTipo.C, true));
            myList.Add(new Empleado(7, "Dwayne Johnson", new DateTime(2011, 2, 17), 3m, CategoriaTipo.A, false));
            myList.Add(new Empleado(8, "Angelina Jolie", new DateTime(2011, 2, 18), 3m, CategoriaTipo.A, true));
            myList.Add(new Empleado(9, "Emily Blunt", new DateTime(2011, 2, 19), 3m, CategoriaTipo.B, false));
            myList.Add(new Empleado(10, "Ryan Reynolds", new DateTime(2011, 2, 20), 3m, CategoriaTipo.C, true));

            foreach (var emp in myList)
            {
                this.radGridView1.Rows.Add(emp.Id, emp.Nombre, emp.FNacimiento.ToString("yyyy-MM-dd"), emp.HorasDiarias, emp.CategoriaId, emp.GetCategoriaString, emp.Estado);
            }

            radGridView1.Columns["TBId"].VisibleInColumnChooser = false;
            radGridView1.Columns["TBCategoriaId"].VisibleInColumnChooser = false;

            form1 = new Form1(this);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Form1 form1 = new Form1(this);
            nuevo = true;
            form1.TopMost = true;
            form1.SetBounds(200, 200, 400, 300);
            //btnAgregar.Enabled = false;
            form1.MaximizeBox = false;
            form1.MinimizeBox = false;
            //form1.TopLevel = false;
            //form1.FormBorderStyle = FormBorderStyle.FixedDialog;
            form1.Show();
            form1.Activate();
            form1.inicializa();
            form1.checaCambios();
        }

        private BindingList<Empleado> data;
        private BindingList<Empleado> myList;
        //private Form1 form1;
        public Form1 form1;

        private void radGridView1_DoubleClick(object sender, EventArgs e)
        {
            GridViewRowInfo row = radGridView1.CurrentRow;
            nuevo = false;

            form1 = new Form1(this);
            form1.Show();
            form1.SetBounds(200, 200, 400, 300);
            form1.Activate();

            //MessageBox.Show(row.Cells["TBNombre"].Value.ToString());
            //MessageBox.Show(row.Cells["TBNombre"].Value.ToString());
        }
    }
}
