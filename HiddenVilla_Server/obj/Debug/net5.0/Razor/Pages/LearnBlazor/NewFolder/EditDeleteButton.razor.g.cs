#pragma checksum "C:\Users\Niranjan\Dev\Blazor\HiddenVilla_Server\Pages\LearnBlazor\NewFolder\EditDeleteButton.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e546cc098393fd6ff2c219226cd97f63233d3633"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor.NewFolder
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Niranjan\Dev\Blazor\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Niranjan\Dev\Blazor\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Niranjan\Dev\Blazor\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Niranjan\Dev\Blazor\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Niranjan\Dev\Blazor\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Niranjan\Dev\Blazor\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Niranjan\Dev\Blazor\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Niranjan\Dev\Blazor\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Niranjan\Dev\Blazor\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Niranjan\Dev\Blazor\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Niranjan\Dev\Blazor\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.NewFolder;

#line default
#line hidden
#nullable disable
    public partial class EditDeleteButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\Niranjan\Dev\Blazor\HiddenVilla_Server\Pages\LearnBlazor\NewFolder\EditDeleteButton.razor"
 if (IsAdmin)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<button class=\"btn btn-danger\">Delete</button>\r\n    ");
            __builder.AddMarkupContent(1, "<button class=\"btn btn-success\">Edit</button>");
#nullable restore
#line 5 "C:\Users\Niranjan\Dev\Blazor\HiddenVilla_Server\Pages\LearnBlazor\NewFolder\EditDeleteButton.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Niranjan\Dev\Blazor\HiddenVilla_Server\Pages\LearnBlazor\NewFolder\EditDeleteButton.razor"
       
    [Parameter]
    public bool IsAdmin { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
