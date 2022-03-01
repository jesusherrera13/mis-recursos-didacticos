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
#line 3 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/Pages/Ejercicio1.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/Pages/Ejercicio1.razor"
using Telerik.DataSource;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/Pages/Ejercicio1.razor"
using System.ComponentModel;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ejercicio1")]
    public partial class Ejercicio1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 140 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/Pages/Ejercicio1.razor"
       

    public List<Employee> GridData { get; set; }
    public List<Employee> SourceData { get; set; }
    public List<Employee> Categories { get; set; }
    public Employee employee = new Employee();
    private bool Visible { get; set; } = false;
    TelerikSwitch<bool> TheSwitchRef { get; set; }
    protected List<string> MyList = new List<string>() { "Microsoft", "Google", "Viaro" };
    public Boolean showDialog = false;
    public Boolean showDialogConfirm = false;
    public List<SampleData> lista = new();
    protected string MyStringItem { get; set; }
    public string? DialogTitle;

    public string result;
    string MySelectedItem { get; set; } = "second";
    protected List<string> MyList2 = new List<string>() { "Microsoft", "Google", "Viaro" };

    List<SampleData> days = new List<SampleData>();

    int lastId = 0;

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
        employee = new Employee() { Id = e.Id, Nombre = e.Nombre, TeamName = e.TeamName, Senior = e.Senior };
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
            existing.TeamName = item.TeamName;
            existing.Senior = item.Senior;
            existing.Equipo = item.Equipo;
        }

        LoadData();
    }

    private void OnStateInit(GridStateEventArgs<Employee> args)
    {
        //args.GridState.GroupDescriptors = new List<GroupDescriptor>()
        //{
        //    new GroupDescriptor()
        //    {
        //        Member = nameof(Employee.TeamName)
        //    }
        //};
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        //public int TeamId { get; set; }
        public TeamName TeamName { get; set; }
        public String Equipo { get; set; }
        public Boolean Senior { get; set; }

        public Employee()
        {
            //Available = true;
        }
    }

    public enum TeamName
    {
        [Description("Microsoft")]
        Microsoft = 1,
        [Description("Google")]
        Google = 2,
        [Description("Viaro")]
        Viaro = 3,
    }

    public void LoadData()
    {
        GridData = new List<Employee>(SourceData);
    }

    public void InitSourceData()
    {
        List<Employee> data = new List<Employee>();

        data.Add(new Employee() { Id = 1, Nombre = "Chun-Li", TeamName = TeamName.Microsoft, Senior = true, Equipo = "Microsoft" });
        data.Add(new Employee() { Id = 2, Nombre = "Lio Messi", TeamName = TeamName.Google, Senior = false, Equipo = "Google" });
        data.Add(new Employee() { Id = 2, Nombre = "Steve Jobs", TeamName = TeamName.Viaro, Senior = false, Equipo = "Viaro" });

        SourceData = data;

        foreach (var value in Enum.GetValues(typeof(TeamName)))
        {

            days.Add(new SampleData() { Value = (int)value, Description = ((TeamName)value).ToString() });
        }


        //days = ((TeamName[])Enum.GetValues(typeof(TeamName))).Select(c => new SampleData() { Value = (int)c, Description = c.ToString() }).ToList();
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
            Employee e = new Employee() { Id = 1, Nombre = employee.Nombre, TeamName = employee.TeamName, Senior = employee.Senior, Equipo = employee.Equipo };
            CreateItem(new Employee() { Id = 1, Nombre = employee.Nombre, TeamName = employee.TeamName, Senior = employee.Senior, Equipo = employee.Equipo });
        }
        //data.Add(new Employee() { Id = 1, Nombre = employee.Nombre, TeamId = employee.TeamId, TeamNombre = employee.TeamName });

        ClearFields();
        Visible = false;
        showDialog = false;
    }

    public void ClearFields()
    {
        employee.Id = 0;
        employee.Nombre = "";
        employee.Equipo = "";
        employee.Senior = false;
        DialogTitle = "Agregar nuevo empleado";
    }

    public void Close()
    {
        showDialog = false;
    }

    void OnRowDoubleClickHandler(GridRowClickEventArgs args)
    {
        Employee e = (Employee)args.Item;
        employee = new Employee() { Id = e.Id, Nombre = e.Nombre, TeamName = e.TeamName, Senior = e.Senior, Equipo = e.Equipo };
        DialogTitle = "Editar empleado: " + e.Nombre;
        showDialog = true;
    }

    private void Eliminar()
    {
        Employee e = new Employee() { Id = employee.Id, Nombre = employee.Nombre, TeamName = employee.TeamName, Senior = employee.Senior };

        var existing = SourceData.FirstOrDefault(p => p.Id == e.Id);

        if (existing != null)
        {
            DeleteItem(existing);
            //SourceData.Remove(/*)*/
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

    void MyOnChangeHandler(object theUserInput)
    {
        // the handler receives an object that you may need to cast to the type of the component
        // if you do not provide a Value, you must provide the Type parameter to the component
        result = string.Format("The user selected: {0}", (theUserInput as string));
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

    protected List<string> MyStringList = new List<string>() { "Microsoft", "Google", "Viaro" };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
