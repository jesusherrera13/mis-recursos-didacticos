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
#line 3 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/Pages/FetchData.razor"
using Telerik.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "/home/jesus/Proyectos/mis-recursos-didacticos/dotnet/blazor_telerik/Telerik/Pages/FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await ForecastService.GetForecastAsync(DateTime.Now);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WeatherForecastService ForecastService { get; set; }
    }
}
#pragma warning restore 1591
