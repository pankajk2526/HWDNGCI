#pragma checksum "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b0b8d8763bdc3b711a1476ef42eb57bed3105e3"
// <auto-generated/>
#pragma warning disable 1591
namespace HWDnGCI.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\_Imports.razor"
using HWDnGCI.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\_Imports.razor"
using HWDnGCI.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex flex-column w-100");
            __builder.AddAttribute(2, "style", 
#nullable restore
#line 3 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\Shared\MainLayout.razor"
                                              PageOpacity

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "slide-up-fade-in bg-white");
            __builder.AddMarkupContent(6, "\r\n<img src=\"https://i.imgur.com/0r5J1cV.png\" class=\"float-left ml-5 icon-6\">\r\n");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\Shared\MainLayout.razor"
               ToggleSidebar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "src", "https://i.imgur.com/ohUdyBk.png");
            __builder.AddAttribute(10, "class", "float-right mr-5 mt-3 icon-4");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.OpenComponent<HWDnGCI.Client.Shared.SearchBar>(13);
            __builder.CloseComponent();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenComponent<HWDnGCI.Client.Shared.HWLabel>(15);
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenComponent<HWDnGCI.Client.Shared.Breadcrumbs>(17);
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.AddContent(19, 
#nullable restore
#line 13 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\Shared\MainLayout.razor"
 Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenComponent<HWDnGCI.Client.Shared.About>(21);
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n");
            __builder.OpenComponent<HWDnGCI.Client.Shared.Credit>(23);
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "sidenav" + " " + (
#nullable restore
#line 19 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\Shared\MainLayout.razor"
                     SidebarAnimation

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "style", 
#nullable restore
#line 19 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\Shared\MainLayout.razor"
                                               VisValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(29, "\r\n  ");
            __builder.OpenElement(30, "img");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\Shared\MainLayout.razor"
                 ToggleSidebar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "src", "https://i.imgur.com/ohUdyBk.png");
            __builder.AddAttribute(33, "class", "ml-3 mb-3 icon-4");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n  ");
            __builder.OpenElement(35, "a");
            __builder.AddAttribute(36, "href", "/");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\Shared\MainLayout.razor"
                        ToggleSidebar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Home");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n  ");
            __builder.OpenElement(40, "a");
            __builder.AddAttribute(41, "href", "/contribute");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\Shared\MainLayout.razor"
                                  ToggleSidebar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(43, "Contribute Resources");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n  ");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "href", "");
            __builder.AddAttribute(47, "onmouseout", "window.scrollTo(0,document.body.scrollHeight);");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\Shared\MainLayout.razor"
                                                                                   ToggleSidebar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(49, "About Us");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n  ");
            __builder.OpenElement(51, "a");
            __builder.AddAttribute(52, "href", "/donate");
            __builder.AddAttribute(53, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\Shared\MainLayout.razor"
                              ToggleSidebar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(54, "Donate Money");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\h383590\OneDrive - Honeywell\HWDnGCI\HWDnGCI\HWDnGCI\Client\Shared\MainLayout.razor"
       
  private string VisValue = "visibility: hidden;";
  private string SidebarAnimation = "";
  private string PageOpacity = "";
      private void ToggleSidebar()
      {
          if (VisValue.Equals("visibility: hidden;"))
          {
              PageOpacity = "opacity: 0.3; transition: .5s ease;";
              VisValue = "visibility: visible;";
              SidebarAnimation = "slide-left-fade-in";
          }
          else
          {
              PageOpacity = "opacity: 1; transition: .5s ease;";
              VisValue = "visibility: hidden;";
              SidebarAnimation = "";
          }
      }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
