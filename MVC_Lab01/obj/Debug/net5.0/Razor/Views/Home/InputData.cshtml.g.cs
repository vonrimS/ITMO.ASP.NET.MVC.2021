#pragma checksum "C:\Users\Profile\source\repos\ITMO.ASP.NET.MVC.2021\MVC_Lab01\Views\Home\InputData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dc12424600adf507f836844b546589ce9eaa4ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_InputData), @"mvc.1.0.view", @"/Views/Home/InputData.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Profile\source\repos\ITMO.ASP.NET.MVC.2021\MVC_Lab01\Views\_ViewImports.cshtml"
using MVC_Lab01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Profile\source\repos\ITMO.ASP.NET.MVC.2021\MVC_Lab01\Views\_ViewImports.cshtml"
using MVC_Lab01.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dc12424600adf507f836844b546589ce9eaa4ad", @"/Views/Home/InputData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f64fc4566af3ceb425b5564feedab88e6128b822", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_InputData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_Lab01.Models.Person>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Profile\source\repos\ITMO.ASP.NET.MVC.2021\MVC_Lab01\Views\Home\InputData.cshtml"
  

    //ViewBag.Title = "Главная";
    ViewData["Title"] = "InputData";
    Layout = "~/Views/_BasicLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n");
#nullable restore
#line 15 "C:\Users\Profile\source\repos\ITMO.ASP.NET.MVC.2021\MVC_Lab01\Views\Home\InputData.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table>\r\n            <tr>\r\n                <td><p>Введите имя:</p></td>\r\n");
            WriteLiteral("                <td>");
#nullable restore
#line 21 "C:\Users\Profile\source\repos\ITMO.ASP.NET.MVC.2021\MVC_Lab01\Views\Home\InputData.cshtml"
               Write(Html.TextBoxFor(x => x.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><p>Введите фамилию:</p></td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Profile\source\repos\ITMO.ASP.NET.MVC.2021\MVC_Lab01\Views\Home\InputData.cshtml"
               Write(Html.TextBoxFor(x => x.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><input type=\"submit\" value=\"Отправить\" /></td>\r\n                <td></td>\r\n            </tr>\r\n        </table>\r\n");
#nullable restore
#line 32 "C:\Users\Profile\source\repos\ITMO.ASP.NET.MVC.2021\MVC_Lab01\Views\Home\InputData.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_Lab01.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591
