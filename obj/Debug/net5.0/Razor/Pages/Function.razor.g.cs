#pragma checksum "C:\Users\seltd\source\repos\blzprj\blazapp\Pages\Function.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec170c34bfec5930c5abf730935942ac91744aea"
// <auto-generated/>
#pragma warning disable 1591
namespace blazapp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\seltd\source\repos\blzprj\blazapp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\seltd\source\repos\blzprj\blazapp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\seltd\source\repos\blzprj\blazapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\seltd\source\repos\blzprj\blazapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\seltd\source\repos\blzprj\blazapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\seltd\source\repos\blzprj\blazapp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\seltd\source\repos\blzprj\blazapp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\seltd\source\repos\blzprj\blazapp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\seltd\source\repos\blzprj\blazapp\_Imports.razor"
using blazapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\seltd\source\repos\blzprj\blazapp\_Imports.razor"
using blazapp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\seltd\source\repos\blzprj\blazapp\_Imports.razor"
using BlazorStrap;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/functions")]
    public partial class Function : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Azure function data</h1>");
#nullable restore
#line 6 "C:\Users\seltd\source\repos\blzprj\blazapp\Pages\Function.razor"
 if(message == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading ...</em></p>");
#nullable restore
#line 9 "C:\Users\seltd\source\repos\blzprj\blazapp\Pages\Function.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "p");
            __builder.AddContent(3, "The message is: ");
            __builder.AddContent(4, 
#nullable restore
#line 12 "C:\Users\seltd\source\repos\blzprj\blazapp\Pages\Function.razor"
                        message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 13 "C:\Users\seltd\source\repos\blzprj\blazapp\Pages\Function.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\seltd\source\repos\blzprj\blazapp\Pages\Function.razor"
       
    string message;

    protected override async Task OnInitializedAsync()
    {
        message = await Http.GetStringAsync("https://gazblazhttp.azurewebsites.net/api/HttpTrigger1?");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
