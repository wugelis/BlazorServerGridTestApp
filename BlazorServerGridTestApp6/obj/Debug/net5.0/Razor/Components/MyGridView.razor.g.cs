#pragma checksum "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\Components\MyGridView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "331936b74bbf6fb828877ac7507f6a5f906c3377"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerGridTestApp6.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\_Imports.razor"
using BlazorServerGridTestApp6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\_Imports.razor"
using BlazorServerGridTestApp6.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\Components\MyGridView.razor"
using BlazorServerGridTestApp6.Data;

#line default
#line hidden
#nullable disable
    public partial class MyGridView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "border", "1");
            __builder.AddAttribute(2, "class", "table table-primary");
            __builder.OpenElement(3, "tr");
            __builder.AddContent(4, 
#nullable restore
#line 5 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\Components\MyGridView.razor"
         ChildContent

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 7 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\Components\MyGridView.razor"
     if (employees == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p>No Data</p>");
#nullable restore
#line 10 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\Components\MyGridView.razor"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\Components\MyGridView.razor"
         foreach (Employee data in employees)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
            __builder.AddContent(8, 
#nullable restore
#line 16 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\Components\MyGridView.razor"
                     data.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "td");
            __builder.AddContent(11, 
#nullable restore
#line 17 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\Components\MyGridView.razor"
                     data.ChtName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 18 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\Components\MyGridView.razor"
                     data.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\Components\MyGridView.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\Visual Studio 2017 Demo\BlazorServerGridTestApp6\BlazorServerGridTestApp6\Components\MyGridView.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
