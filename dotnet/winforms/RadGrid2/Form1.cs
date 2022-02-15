using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace RadGrid2
{
    public partial class Form1 : Telerik.WinControls.UI.RadForm
    {
        public Form1()
        {
            InitializeComponent();
            cmbCategoria.DataSource = Enum.GetValues(typeof(CategoriaTipo));
        }

        public Form1(RadForm1 callingForm)
        {
            mainForm = callingForm as RadForm1;
            InitializeComponent();
            cmbCategoria.DataSource = Enum.GetValues(typeof(CategoriaTipo));
            txtId.Text = mainForm.lastId.ToString();

            List<Categoria> categorias = new List<Categoria>();

            foreach (CategoriaTipo foo in Enum.GetValues(typeof(CategoriaTipo)))
            {
                categorias.Add(new Categoria() { Value = foo, Name = foo.GetDescription() });
            }

            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Name";
            cmbCategoria.ValueMember = "Value";

            row = mainForm.radGridView1.CurrentRow;

            //MessageBox.Show(mainForm.nuevo.ToString());

            if (mainForm.nuevo)
            {
                Id = "";
                _Nombre = Nombre = "";
                _FNacimiento = FNacimiento = "";
                _HorasDiarias = HorasDiarias = "";
                _Categoria = Categoria = "";
                _Estado = Estado = false;

                txtId.Text = Id;
                txtNombre.Text = _Nombre;
                txtFNacimiento.Text = _FNacimiento;
                txtHorasDiarias.Text = _HorasDiarias;
                cmbCategoria.Text = _Categoria;
                chkEstado.Checked = _Estado;
            }
            else
            {
                _Nombre = Nombre = row.Cells["TBNombre"].Value.ToString();
                _FNacimiento = FNacimiento = row.Cells["TBFNacimiento"].Value.ToString();
                _HorasDiarias = row.Cells["TBHorasDiarias"].Value.ToString();
                _Categoria = row.Cells["TBCategoria"].Value.ToString();
                _Estado = (row.Cells["TBEstado"].Value).ToString() == "True" ? true : false;

                txtId.Text = row.Cells["TBId"].Value.ToString();
                txtNombre.Text = _Nombre;
                txtFNacimiento.Text = _FNacimiento;
                txtHorasDiarias.Text = _HorasDiarias;
                cmbCategoria.Text = _Categoria;
                chkEstado.Checked = _Estado;
            }
        }

        public void inicializa()
        {
            row = mainForm.radGridView1.CurrentRow;

            if (mainForm.nuevo)
            {
                Id = "";
                _Nombre = Nombre = "";

                DateTime fn = DateTime.Parse(txtFNacimiento.Text);

                //FNacimiento = fn.ToString("yyyy-MM-dd");

                _FNacimiento = FNacimiento = fn.ToString("yyyy-MM-dd");
                _HorasDiarias = HorasDiarias = "";
                _Categoria = Categoria = "";
                _Estado = Estado = false;

                txtId.Text = Id;
                txtNombre.Text = _Nombre;
                txtFNacimiento.Text = _FNacimiento;
                txtHorasDiarias.Text = _HorasDiarias;
                cmbCategoria.Text = _Categoria;
                chkEstado.Checked = _Estado;
            }
            else
            {
                _Nombre = Nombre = row.Cells["TBNombre"].Value.ToString();
                _FNacimiento = FNacimiento = row.Cells["TBFNacimiento"].Value.ToString();
                _HorasDiarias = row.Cells["TBHorasDiarias"].Value.ToString();
                _Categoria = row.Cells["TBCategoria"].Value.ToString();
                _Estado = (row.Cells["TBEstado"].Value).ToString() == "True" ? true : false;

                txtId.Text = row.Cells["TBId"].Value.ToString();
                txtNombre.Text = _Nombre;
                txtFNacimiento.Text = _FNacimiento;
                txtHorasDiarias.Text = _HorasDiarias;
                cmbCategoria.Text = _Categoria;
                chkEstado.Checked = _Estado;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult result;
            string Id = txtId.Text;
            Nombre = txtNombre.Text;
            FNacimiento = txtFNacimiento.Text;
            //FNacimiento = DateTime.Parse(txtFNacimiento.Text);
            decimal? HorasDiarias;
            if (txtHorasDiarias.Text.Length > 0) HorasDiarias = Convert.ToDecimal(txtHorasDiarias.Text);
            else HorasDiarias = 0m;
            //CategoriaTipo CategoriaId = cmbCategoria.SelectedItem;
            Categoria categoria = (Categoria) cmbCategoria.SelectedItem;
            CategoriaTipo CategoriaId = categoria.Value;
            Boolean Estado = chkEstado.Checked;

            RadGridView radGridView1 = this.mainForm.radGridView1;
            GridViewDataRowInfo dataRowInfo = new GridViewDataRowInfo(radGridView1.MasterView);
            var insert = true;

            checaCambios();
            guardar();

            this.Close(); // Cerrar formulario
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result;

            if(checaCambios())
            {
                result = MessageBox.Show("¿Desea guardar los cambios?", "Empleado", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    // Closes the parent form.
                    //string texto = Id + "|" + Nombre + "|" + FNacimiento + "|" + HorasDiarias + "|" + CategoriaId + "|" + Estado;


                    //MessageBox.Show(texto);


                    RadGridView radGridView1 = this.mainForm.radGridView1;
                    GridViewDataRowInfo dataRowInfo = new GridViewDataRowInfo(radGridView1.MasterView);
                    var insert = true;

                    for (int r = 0; r < radGridView1.RowCount; r++)
                    {
                        //if (radGridView1.Rows[r].Cells["Nombre"].Value.ToString().ToUpper().Equals(Nombre.ToUpper()))
                        //{
                        //    MessageBox.Show("The employee '" + Nombre + "' already exists");
                        //    insert = false;
                        //    //do something 
                        //}
                    }

                    if (insert)
                    {
                        //radGridView1.Rows.Add(12, Nombre, FNacimiento, HorasDiarias, CategoriaId, GetCategoriaString, Estado);
                        //Empleado emp = new Empleado(12, Nombre, FNacimiento, HorasDiarias, CategoriaId, Estado);
                        //radGridView1.Rows.Add(emp.Id, emp.Nombre, emp.FNacimiento.ToString("yyyy-MM-dd"), emp.HorasDiarias, emp.CategoriaId, emp.GetCategoriaString, emp.Estado);
                        // Ejemplo 2
                        //radGridView1.Rows.Add(11,Nombre,FNacimiento,Horas,Categoria,Estado);
                        //txtNombre.Text = "";
                        //txtNombre.Focus();

                        // Ejmplo 2
                        //dataRowInfo.Cells[0].Value = "Inserted Row";
                        //dataRowInfo.Cells[1].Value = 1156.54;
                        //dataRowInfo.Cells[2].Value = DateTime.Now.AddDays(14);
                        //radGridView1.Rows.Insert(2, dataRowInfo);
                    }

                    guardar();
                }
            }
            
            this.Close(); // Cerrar formulario
        }

        public Boolean checaCambios()
        {
            Boolean cambios = false;
            DateTime fn = DateTime.Parse(txtFNacimiento.Text);

            Id = txtId.Text;
            Nombre = txtNombre.Text;
            FNacimiento = fn.ToString("yyyy-MM-dd");

            HorasDiarias = txtHorasDiarias.Text.Length > 0 ? txtHorasDiarias.Text : "0";
            Categoria categoria = (Categoria) cmbCategoria.SelectedItem;
            //CategoriaTipo CategoriaId = categoria.Value;
            Categoria = categoria.Name;
            Estado = chkEstado.Checked;

            //MessageBox.Show(_Nombre+"|"+Nombre);
            //MessageBox.Show(_FNacimiento + "|" + FNacimiento);
            //MessageBox.Show(mainForm.nuevo.ToString());
            if((Id.Length > 0)|| (Id.Length == 0 && Nombre.Length > 0))
            {
                if ((!_Nombre.Equals(Nombre)) || (!_HorasDiarias.Equals(HorasDiarias)) || (!_Categoria.Equals(Categoria)) || (!_Estado.Equals(Estado))) cambios = true;
            }
            else
            {
                if(Nombre.Length > 0)
                {
                    //if ((!_Nombre.Equals(Nombre)) || (!_HorasDiarias.Equals(HorasDiarias)) || (!_Categoria.Equals(Categoria)) || (!_Estado.Equals(Estado))) cambios = true;
                }
            }

            return cambios;
        }

        private void guardar()
        {
            //MessageBox.Show(Id);
            RadGridView radGridView1 = this.mainForm.radGridView1;

            Categoria categoria = (Categoria) cmbCategoria.SelectedItem;
            CategoriaTipo CategoriaId = categoria.Value;
            //Boolean Estado = chkEstado.Checked;

            var index = 0;
            Boolean accion = true;
            string msg = "";

            for (int r = 0; r < radGridView1.RowCount; r++)
            {
                if (mainForm.nuevo)
                {
                    if (radGridView1.Rows[r].Cells["TBNombre"].Value.ToString().ToUpper().Equals(Nombre.ToUpper()))
                    {
                        //MessageBox.Show("The employee '" + name + "' already exists");
                        accion = false;
                        msg = "El empleado '" + Nombre + "' ya existe.";
                        ////do something 
                    }
                }
                else
                {
                    if (radGridView1.Rows[r].Cells["TBId"].Value.ToString().Equals(Id))
                    {
                        index = r;
                    }
                }
            }

            if (mainForm.nuevo)
            {
                if(accion == true)
                {
                    Empleado emp = new Empleado(mainForm.lastId, Nombre, DateTime.Parse(FNacimiento), Convert.ToDecimal(HorasDiarias), CategoriaId, Estado);
                    radGridView1.Rows.Add(emp.Id, emp.Nombre, emp.FNacimiento.ToString("yyyy-MM-dd"), emp.HorasDiarias, emp.CategoriaId, emp.GetCategoriaString, emp.Estado);
                    mainForm.lastId++;
                }
                else
                {
                    
                }
            }
            else
            {
                for (int r = 0; r < radGridView1.RowCount; r++)
                {
                    if (!radGridView1.Rows[r].Cells["TBId"].Value.ToString().Equals(Id) && radGridView1.Rows[r].Cells["TBNombre"].Value.ToString().Equals(Nombre))
                    {
                        msg = "El empleado '" + Nombre + "' ya existe.";
                        accion = false;
                        //do something 
                    }
                }

                if (accion == true)
                {
                    radGridView1.Rows[index].Cells["TBNombre"].Value = Nombre;
                    radGridView1.Rows[index].Cells["TBFNacimiento"].Value = FNacimiento;
                    radGridView1.Rows[index].Cells["TBHorasDiarias"].Value = HorasDiarias;
                    radGridView1.Rows[index].Cells["TBCategoriaId"].Value = CategoriaId;
                    radGridView1.Rows[index].Cells["TBCategoria"].Value = Categoria;
                    radGridView1.Rows[index].Cells["TBEstado"].Value = Estado;
                }
            }

            if (accion == false)
            {
                MessageBox.Show(msg);
            }
        }

        private RadForm1 mainForm = null;

        private string Id = "";
        private string Nombre;
        private string FNacimiento;
        private string HorasDiarias;
        private string Categoria;
        private Boolean Estado;

        private string _Nombre;
        private string _FNacimiento;
        private string _HorasDiarias;
        private string _Categoria;
        private Boolean _Estado;
        GridViewRowInfo row;

        private void txtHorasDiarias_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
