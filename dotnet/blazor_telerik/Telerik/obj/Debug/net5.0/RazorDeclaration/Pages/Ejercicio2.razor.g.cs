// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Telerik.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/_Imports.razor"
using Telerik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/_Imports.razor"
using Telerik.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/Pages/Ejercicio2.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/Pages/Ejercicio2.razor"
using Telerik.DataSource;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/Pages/Ejercicio2.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ejercicio2")]
    public partial class Ejercicio2 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 166 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/Pages/Ejercicio2.razor"
       
    public List<Employee> GridData { get; set; }
    public List<Employee> SourceData { get; set; }
    public List<Employee> Categories { get; set; }
    public Employee employee = new Employee();
    private bool Visible { get; set; } = false;
    TelerikSwitch<bool> TheSwitchRef { get; set; }
    protected List<string> MyList = new List<string>() { "first", "second", "third" };
    public Boolean showDialog = false;
    public Boolean showDialogConfirm = false;
    public List<SampleData> lista = new();
    Telerik.Blazor.Components.TelerikDatePicker<DateTime> theDatePicker;
    public string DialogTitle = "Agregar nuevo empleado";
    private bool isSelected { get; set; }

    public string result;
    string MySelectedItem { get; set; } = "second";
    protected List<string> MyList2 = new List<string>() { "first", "second", "third" };

    List<SampleData> Categorias = new List<SampleData>();

    int lastId = 11;

    public TelerikGrid<Employee> GridRef { get; set; }

    int test = 0;

    Categoria? alta;

    protected override Task OnInitializedAsync()
    {
        InitSourceData();

        LoadData();

        return base.OnInitializedAsync();
    }

    private void CreateHandler(GridCommandEventArgs args)
    {
        CreateItem((Employee)args.Item);

        LoadData();
    }

    private void CreateItem(Employee item)
    {
        Employee e = item;

        e.Id = ++lastId;
        SourceData.Insert(0, e);
        LoadData();
    }

    private void DeleteHandler(GridCommandEventArgs args)
    {
        DeleteItem((Employee)args.Item);

        LoadData();
    }

    private void EditHandler(GridCommandEventArgs args)
    {
        Employee e = (Employee)args.Item;
        employee = new Employee() { Id = e.Id, Nombre = e.Nombre, FNacimiento = e.FNacimiento, CategoriaId = e.CategoriaId, Salario = e.Salario, Estado = e.Estado };
        //Visible = true;
    }

    private void DeleteItem(Employee item)
    {
        SourceData.Remove(item);
    }

    private void UpdateHandler(GridCommandEventArgs args)
    {
        UpdateItem((Employee)args.Item);

        LoadData();
    }

    private void UpdateItem(Employee item)
    {
        var existing = SourceData.FirstOrDefault(p => p.Id == item.Id);

        if (existing != null)
        {

            existing.Nombre = item.Nombre;
            existing.FNacimiento = item.FNacimiento;
            existing.CategoriaId = item.CategoriaId;
            existing.Salario = item.Salario;
            existing.Estado = item.Estado;
        }

        LoadData();
    }

    async Task OnStateInitHandler(GridStateEventArgs<Employee> args)
    {
        var state = new GridState<Employee>
        {
            FilterDescriptors = new List<Telerik.DataSource.IFilterDescriptor>()
            {
                //new Telerik.DataSource.FilterDescriptor() { Member = "Estado", Operator = Telerik.DataSource.FilterOperator.IsEqualTo, Value = isSelected, MemberType = typeof(Boolean) },
            }
        };

        args.GridState = state;
    }

    async void OnStateChangedHandler(GridStateEventArgs<Employee> args)
    {
        Console.WriteLine(args.PropertyName); // get the setting that was just changed (paging, sorting,...)
        test = 1;

        if (args.PropertyName == "FilterDescriptors") // sorting changed for our example
        {
            // ensure certain state based on some condition
            // in this example - ensure that the ID field is always filtered with a certain setting unless the user filters it explicitly
            bool isIdFiltered = false;
            foreach (FilterDescriptor item in args.GridState.FilterDescriptors)
            {
                if (item.Member == "Id")
                {
                    isIdFiltered = true;
                }

                // you could override a user action as well - change settings on the corresponding parameter
                // make sure that the .SetState() method of the grid is always called if you do that
                if (item.Member == "Name")
                {
                    item.Value = "name 1";
                    item.Operator = FilterOperator.Contains;
                }
            }
            if (!isIdFiltered)
            {
                args.GridState.FilterDescriptors.Add(new FilterDescriptor
                {
                    Member = "Id",
                    MemberType = typeof(int),
                    Operator = FilterOperator.IsLessThan,
                    Value = 15
                });
            }
            // needed only if you will be overriding user actions or amending them
            // if you only need to be notified of changes, you should not call this method
            await GridRef.SetState(args.GridState);
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FNacimiento { get; set; }
        public int CategoriaId { get; set; }
        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal? Salario { get; set; }
        public Boolean Estado { get; set; }

        public Employee()
        {
            //Available = true;
        }
    }

    public enum TeamName
    {
        [Description("Alta")]
        Alta = 1,
        [Description("Media")]
        Media = 2,
        [Description("Baja")]
        Baja = 3,
    }

    public enum Categoria
    {
        [Description("Alta")]
        A,
        [Description("Media")]
        B,
        [Description("Baja")]
        C
    }

    public void LoadData()
    {
        GridData = new List<Employee>(SourceData);
        //Filtro();
    }

    public void InitSourceData()
    {
        List<Employee> data = new List<Employee>();

        data.Add(new Employee() { Id = 1, Nombre = "Steve Jobs", FNacimiento = DateTime.Now, CategoriaId = 1, Salario = 1000, Estado = true });
        data.Add(new Employee() { Id = 2, Nombre = "Sofía Vergara", FNacimiento = DateTime.Now, CategoriaId = 2, Salario = 1500, Estado = false });
        data.Add(new Employee() { Id = 3, Nombre = "Bill Gates", FNacimiento = DateTime.Now, CategoriaId = 3, Salario = 2000, Estado = true });
        data.Add(new Employee() { Id = 4, Nombre = "Nikola Tesla", FNacimiento = DateTime.Now, CategoriaId = 3, Salario = 50, Estado = false });
        data.Add(new Employee() { Id = 5, Nombre = "Elon Musk", FNacimiento = DateTime.Now, CategoriaId = 2, Salario = 1800, Estado = true });
        data.Add(new Employee() { Id = 6, Nombre = "Gal Gadot", FNacimiento = DateTime.Now, CategoriaId = 1, Salario = 6000, Estado = true });
        data.Add(new Employee() { Id = 7, Nombre = "Dwayne Johnson", FNacimiento = DateTime.Now, CategoriaId = 1, Salario = 5500, Estado = true });
        data.Add(new Employee() { Id = 8, Nombre = "Angelina Jolie", FNacimiento = DateTime.Now, CategoriaId = 2, Salario = 4000, Estado = true });
        data.Add(new Employee() { Id = 9, Nombre = "Emily Blunt", FNacimiento = DateTime.Now, CategoriaId = 3, Salario = 1300, Estado = false });
        data.Add(new Employee() { Id = 10, Nombre = "Ryan Reynolds", FNacimiento = DateTime.Now, CategoriaId = 3, Salario = 100, Estado = true });

        SourceData = data;

        foreach (var value in Enum.GetValues(typeof(TeamName)))
        {
            Categorias.Add(new SampleData() { Value = (int)value, Description = ((TeamName)value).ToString() });
        }

        isSelected = false;

        Categoria cat = Categoria.A;


        //Categorias = ((TeamName[])Enum.GetValues(typeof(TeamName))).Select(c => new SampleData() { Value = (int)c, Description = c.ToString() }).ToList();
    }

    async Task OnClickHandler()
    {
        //Visible = !Visible;
        showDialog = true;
        ClearFields();
    }

    async Task HandleValidSubmit()
    {
        if (employee.Id > 0)
        {
            UpdateItem(employee);
        }
        else
        {
            Employee e = new Employee() { Id = employee.Id, Nombre = employee.Nombre, FNacimiento = employee.FNacimiento, CategoriaId = employee.CategoriaId, Salario = employee.Salario, Estado = employee.Estado };
            CreateItem(new Employee() { Id = employee.Id, Nombre = employee.Nombre, FNacimiento = employee.FNacimiento, CategoriaId = employee.CategoriaId, Salario = employee.Salario, Estado = employee.Estado });
        }

        ClearFields();
        Visible = false;
        showDialog = false;
    }

    public void ClearFields()
    {
        employee.Id = 0;
        employee.Nombre = null;
        employee.FNacimiento = DateTime.Now;
        employee.CategoriaId = 0;
        employee.Salario = null;
        employee.Estado = false;
        DialogTitle = "Agregar nuevo empleado";
    }

    public void Close()
    {
        showDialog = false;
    }

    void OnRowDoubleClickHandler(GridRowClickEventArgs args)
    {
        Employee e = (Employee)args.Item;
        employee = new Employee() { Id = e.Id, Nombre = e.Nombre, FNacimiento = e.FNacimiento, CategoriaId = e.CategoriaId, Salario = e.Salario, Estado = e.Estado };
        //DialogTitle = "Editar empleado: [" + e.Nombre + "]";
        DialogTitle = "Editar empleado: " + e.Nombre;
        showDialog = true;
    }

    private void Eliminar()
    {
        Employee e = new Employee() { Id = employee.Id, Nombre = employee.Nombre, FNacimiento = employee.FNacimiento, CategoriaId = employee.CategoriaId, Salario = employee.Salario, Estado = employee.Estado };

        var existing = SourceData.FirstOrDefault(p => p.Id == e.Id);

        if (existing != null)
        {
            DeleteItem(existing);
            ClearFields();
        }

        LoadData();
        showDialog = false;
        showDialogConfirm = false;
    }

    void ShowDialogConfirm()
    {
        showDialogConfirm = true;
    }

    void CloseModalDelete()
    {
        showDialogConfirm = false;
    }

    public class SampleData
    {
        public int Value { get; set; }
        public string Description { get; set; }
    }

    public class MyDdlModel
    {
        public int MyValueField { get; set; }
        public string MyTextField { get; set; }
    }

    int selectedValue { get; set; }

    //Define a preselected value when the component initializes
    protected override void OnInitialized()
    {
        selectedValue = 3;
    }

    IEnumerable<MyDdlModel> myDdlData = Enumerable.Range(1, 20).Select(x => new MyDdlModel { MyTextField = "item " + x, MyValueField = x });

    public string Valor(int CategoriaId)
    {
        //TeamName.Alta.Ge
        var existing = Categorias.FirstOrDefault(p => p.Value == CategoriaId);
        return (existing != null ? existing.Description : "");
    }

    public void Filtro()
    {

        //List<Employee> data = SourceData.Where(e => e.Estado == isSelected).ToList();
        List<Employee> data = new();
        if (isSelected) data = SourceData.Where(e => e.Estado == true).ToList();
        else data = SourceData;

        //data = SourceData.Where(e => e.Estado == isSelected).ToList();
        //GridData = new List<Employee>(SourceData);

        //SourceData = new List<Employee>(data);
        GridData = new List<Employee>(data);
        //LoadData();
    }

    async Task ChangeHandler(object value)
    {
        var state = new GridState<Employee> { };
        if (isSelected == true)
        {

            state = new GridState<Employee>
            {
                FilterDescriptors = new List<Telerik.DataSource.IFilterDescriptor>()
                {
                    new Telerik.DataSource.FilterDescriptor() { Member = "Estado", Operator = Telerik.DataSource.FilterOperator.IsEqualTo, Value = isSelected, MemberType = typeof(Boolean) },
                }
            };
        }



        test = 1;
        //isSelected = !isSelected;
        //Filtro();
        //GridState<Employee> desiredState = new GridState<Employee>()
        //{
        //    SortDescriptors = new List<SortDescriptor>()
        //    {
        //        new SortDescriptor { Member = "Id", SortDirection = ListSortDirection.Descending }
        //    }
        //};

        await GridRef.SetState(state);
    }

    async Task RefreshThroughState(object value)
    {
        await GridRef.SetState(GridRef.GetState());
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
