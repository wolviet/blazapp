// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace blazapp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/gaz/blzprj/blzprj-1/blazapp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/gaz/blzprj/blzprj-1/blazapp/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/gaz/blzprj/blzprj-1/blazapp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/gaz/blzprj/blzprj-1/blazapp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/gaz/blzprj/blzprj-1/blazapp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/gaz/blzprj/blzprj-1/blazapp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/gaz/blzprj/blzprj-1/blazapp/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/gaz/blzprj/blzprj-1/blazapp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/gaz/blzprj/blzprj-1/blazapp/_Imports.razor"
using blazapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/gaz/blzprj/blzprj-1/blazapp/_Imports.razor"
using blazapp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/home/gaz/blzprj/blzprj-1/blazapp/_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/entry")]
    public partial class Entry : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "/home/gaz/blzprj/blzprj-1/blazapp/Pages/Entry.razor"
    
    private enum EmployeeType{ Employee, Contractor, Intern};
    private EmployeeType TypeOfEmployee{ get; set;} = EmployeeType.Employee;

    private string Name{get; set;} ="Gaz";
    private bool IsManager{ get; set;} =true;
    private static int Age {get; set;} = 52;
    public DateTime Birthday{get; set;} = DateTime.Today.AddYears(-Age);

    public decimal Salary {get; set;} = (decimal) 50000;
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
