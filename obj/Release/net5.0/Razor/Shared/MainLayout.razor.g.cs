#pragma checksum "/home/gaz/blzprj/blzprj-1/blazapp/Shared/MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87a76fff15cd1007bfe93666e99be0712eaa0b20"
// <auto-generated/>
#pragma warning disable 1591
namespace blazapp.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-jmt7j4d9go");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-jmt7j4d9go");
            __builder.OpenComponent<blazapp.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-jmt7j4d9go");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-jmt7j4d9go><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-jmt7j4d9go>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-jmt7j4d9go");
            __builder.AddContent(15, 
#nullable restore
#line 16 "/home/gaz/blzprj/blzprj-1/blazapp/Shared/MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBootstrapCss BootstrapCss { get; set; }
    }
}
#pragma warning restore 1591
