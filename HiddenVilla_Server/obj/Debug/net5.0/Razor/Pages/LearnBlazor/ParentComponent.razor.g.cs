#pragma checksum "E:\Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83385a072c8b3e5f78a34f0f032e97f5b150c7cd"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Blazor\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Helper;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/parentcomponent")]
    public partial class ParentComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-danger\">Parent Child Component</h1>\r\n");
            __builder.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent.ChildComponent>(1);
            __builder.AddAttribute(2, "OnClickBtnMethod", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "E:\Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor"
                                  ShowMessage

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Title", "This title is passed as a parameter from Parent Component");
            __builder.AddAttribute(4, "MessageForGrandChild", "This is a message from Grand Parent");
            __builder.AddAttribute(5, "DangerChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(6, "Danger Content from Render Fragment!");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent.AnotherChildComponent>(8);
            __builder.AddAttribute(9, "placeholder", "Placeholder default");
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(11, "p");
            __builder.OpenElement(12, "b");
#nullable restore
#line 11 "E:\Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor"
__builder.AddContent(13, MessageText);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "E:\Blazor\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor"
       
    //public Dictionary<string, object> InputAttributesFromParent { get; set; } = new Dictionary<string, object>()
    //{
    //    {"required", "required" },
    //    {"placeholder", "Enter the room name from parent" },
    //    {"maxlength", 5 }
    //};
    private string MessageText = "";

    private void ShowMessage(MouseEventArgs e)
    {
        MessageText = "Blazing text from Parent";
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
