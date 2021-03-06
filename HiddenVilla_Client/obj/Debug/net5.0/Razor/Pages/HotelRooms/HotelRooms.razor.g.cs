#pragma checksum "E:\Blazor\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a6ddb668430dde001a4d36836ec2be53c887836"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Client.Pages.HotelRooms
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\Blazor\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Blazor\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Blazor\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Blazor\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Blazor\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Blazor\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Blazor\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Blazor\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Blazor\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Blazor\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Blazor\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Blazor\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Blazor\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client.Model.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Blazor\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Blazor\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client.Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Blazor\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
using Common;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel/rooms")]
    public partial class HotelRooms : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "E:\Blazor\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                 HomeModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnInvalidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "E:\Blazor\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                             SaveBookingInfo

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "class", "bg-light");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "pt-3 pb-2 px-5 mx-1 mx-md-0 bg-secondary");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row px-3 mx-3");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "col-6 col-md-4");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "<label class=\"text-warning\">Check in Date</label>\r\n                    ");
                __Blazor.HiddenVilla_Client.Pages.HotelRooms.HotelRooms.TypeInference.CreateInputDate_0(__builder2, 16, 17, "date", 18, "form-control", 19, 
#nullable restore
#line 16 "E:\Blazor\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                            HomeModel.StartDate

#line default
#line hidden
#nullable disable
                , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HomeModel.StartDate = __value, HomeModel.StartDate)), 21, () => HomeModel.StartDate);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-6 col-md-4");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "<label class=\"text-warning\">Check Out Date</label>\r\n                    ");
                __builder2.OpenElement(28, "input");
                __builder2.AddAttribute(29, "disabled", "disabled");
                __builder2.AddAttribute(30, "readonly", "readonly");
                __builder2.AddAttribute(31, "type", "date");
                __builder2.AddAttribute(32, "class", "form-control");
                __builder2.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "E:\Blazor\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                  HomeModel.EndDate

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HomeModel.EndDate = __value, HomeModel.EndDate, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n            ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", " col-4 col-md-2");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "<label class=\"text-warning\">No. of nights</label>\r\n                    ");
                __builder2.OpenElement(41, "select");
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "E:\Blazor\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                                        HomeModel.NoOfNights

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => HomeModel.NoOfNights = __value, HomeModel.NoOfNights));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(45, "option");
                __builder2.AddAttribute(46, "value", "Select");
                __builder2.AddAttribute(47, "selected");
                __builder2.AddAttribute(48, "disabled", "disabled");
                __builder2.AddContent(49, "(Select No. Of Nights)");
                __builder2.CloseElement();
#nullable restore
#line 30 "E:\Blazor\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                         for (var i = 1; i <= 10; i++)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(50, "option");
                __builder2.AddAttribute(51, "value", 
#nullable restore
#line 32 "E:\Blazor\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                                            i

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 32 "E:\Blazor\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
__builder2.AddContent(52, i);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 33 "E:\Blazor\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n\r\n            ");
                __builder2.AddMarkupContent(54, "<div class=\"col-8 col-md-2\"><div class=\"form-group\" style=\"margin-top: 1.9rem !important;\"><input type=\"submit\" value=\"Update\" class=\"btn btn-success btn-block form-control\"></div></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.AddMarkupContent(56, "<div class=\"mt-4 mx-4 px-0 px-md-5 mx-md-5\"><div class=\"row p-2 my-3 \" style=\"border-radius:20px; border: 1px solid #ffffff\"><div class=\"col-12 col-lg-3 col-md-4\"><div id=\"carouselExampleIndicators\" class=\"carousel slide mb-4 m-md-3 m-0 pt-3 pt-md-0\" data-ride=\"carousel\"><ol class=\"carousel-indicators\"><li data-target=\"#carouselExampleIndicators\" data-slide-to=\"0\" class=\"active\"></li>\r\n                    <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"1\"></li></ol>\r\n                <div class=\"carousel-inner\"><div class=\"carousel-item active\"><img class=\"d-block w-100\" src=\"images/slide1.jpg\" alt=\"First slide\"></div>\r\n                    <div class=\"carousel-item\"><img class=\"d-block w-100\" src=\"images/slide2.jpg\" alt=\"Second slide\"></div></div>\r\n                <a class=\"carousel-control-prev\" href=\"#carouselExampleIndicators\" role=\"button\" data-slide=\"prev\"><span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span>\r\n                    <span class=\"sr-only\">Previous</span></a>\r\n                <a class=\"carousel-control-next\" href=\"#carouselExampleIndicators\" role=\"button\" data-slide=\"next\"><span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span>\r\n                    <span class=\"sr-only\">Next</span></a></div></div>\r\n        <div class=\"col-12 col-lg-9 col-md-8\"><div class=\"row pt-3\"><div class=\"col-12 col-lg-8\"><p class=\"card-title text-warning\" style=\"font-size:xx-large\">##ROOM NAME##</p>\r\n                    <p class=\"card-text\">\r\n                        ##ROOM DETAILS##\r\n                    </p></div>\r\n                <div class=\"col-12 col-lg-4\"><div class=\"row pb-3 pt-2\"><div class=\"col-12 col-lg-11 offset-lg-1\"><a href=\"#\" class=\"btn btn-success btn-block\">Book</a></div></div>\r\n                    <div class=\"row \"><div class=\"col-12 pb-5\"><span class=\"float-right\"><span class=\"float-right\">Max Occupancy : ## adults </span><br>\r\n                                <span class=\"float-right pt-1\">Villa Size : ## sqft</span><br>\r\n                                <h4 class=\"text-warning font-weight-bold pt-4\">USD <span style=\"border-bottom:1px solid #ff6a00\">##</span></h4>\r\n                                <span class=\"float-right\">Cost for  ## nights</span></span></div></div></div></div></div></div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "E:\Blazor\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
       
    private HomeVM HomeModel { get; set; } = new HomeVM();
    private IEnumerable<HotelRoomDTO> Rooms { get; set; } = new List<HotelRoomDTO>();
    protected override async Task OnInitializedAsync()
    {
        try
        {

            if (await localStorage.GetItemAsync<HomeVM>(SD.Local_InitialBooking) != null)
            {
                HomeModel = await localStorage.GetItemAsync<HomeVM>(SD.Local_InitialBooking);
            }
            else
            {
                HomeModel.NoOfNights = 1;
            }
            await LoadRooms();
        }
        catch (Exception e)
        {
            await jsRuntime.ToastrError(e.Message);
        }
    }

    private async Task LoadRooms()
    {
        Rooms = await hotelRoomService.GetHotelRooms(HomeModel.StartDate.ToString("MM/dd/yyyy"), HomeModel.EndDate.ToString("MM/dd/yyyy"));


    }

    private async Task SaveBookingInfo()
        {

        }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomService hotelRoomService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
    }
}
namespace __Blazor.HiddenVilla_Client.Pages.HotelRooms.HotelRooms
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "type", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
