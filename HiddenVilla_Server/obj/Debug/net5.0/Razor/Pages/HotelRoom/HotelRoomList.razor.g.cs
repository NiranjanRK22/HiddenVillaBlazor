#pragma checksum "E:\Blazor\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "786956c32f478f4b62baccf3e84527434f293fd5"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.HotelRoom
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
#nullable restore
#line 2 "E:\Blazor\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Blazor\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room")]
    public partial class HotelRoomList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-4");
            __builder.AddMarkupContent(2, "<div class=\"col-8\"><h4 class=\"card-title text-info\">Hotel Rooms</h4></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-3 offset-1");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "href", "hotel-room/create");
            __builder.AddAttribute(7, "class", "btn-info form-control");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(9, "Add New Room");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row mt-4");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-12");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(17, "<thead><tr><th>Name</th>\r\n                    <th>Occupancy</th>\r\n                    <th>Rate</th>\r\n                    <th>Sq ft.</th>\r\n                    <th>Action</th></tr></thead>\r\n            ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 28 "E:\Blazor\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
                 if(HotelRooms.Any())
            {
                    foreach(var room in HotelRooms)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
#nullable restore
#line 33 "E:\Blazor\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(21, room.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 34 "E:\Blazor\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(24, room.Occupancy);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "td");
#nullable restore
#line 35 "E:\Blazor\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(27, room.RegularRate.ToString("c"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "td");
#nullable restore
#line 36 "E:\Blazor\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
__builder.AddContent(30, room.SqFt);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(33);
            __builder.AddAttribute(34, "href", 
#nullable restore
#line 38 "E:\Blazor\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
                                             $"hotel-room/edit/{room.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(35, "class", "btn btn-primary");
            __builder.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(37, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "E:\Blazor\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
                }
            }
                 else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "<tr><td colspan=\"5\">No records found</td></tr>");
#nullable restore
#line 48 "E:\Blazor\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 54 "E:\Blazor\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomList.razor"
       
    private IEnumerable<HotelRoomDTO> HotelRooms { get; set; } = new List<HotelRoomDTO>();

    protected override async Task OnInitializedAsync()
    {
        HotelRooms = await HotelRoomRepository.GetAllHotelRooms();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomRepository HotelRoomRepository { get; set; }
    }
}
#pragma warning restore 1591