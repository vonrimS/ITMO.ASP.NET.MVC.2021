#pragma checksum "C:\Users\Profile\source\repos\ITMO.ASP.NET.MVC.2021\MVC_Lab01\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "198aa0c092764ed5b2d8d13f4d004b25ad5ac459"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"198aa0c092764ed5b2d8d13f4d004b25ad5ac459", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f64fc4566af3ceb425b5564feedab88e6128b822", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Profile\source\repos\ITMO.ASP.NET.MVC.2021\MVC_Lab01\Views\Home\Index.cshtml"
  
    Layout = "~/Views/_BasicLayout.cshtml";
    ViewBag.Title = "Главная";
    //ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    ");
#nullable restore
#line 12 "C:\Users\Profile\source\repos\ITMO.ASP.NET.MVC.2021\MVC_Lab01\Views\Home\Index.cshtml"
Write(ViewBag.Greeting);

#line default
#line hidden
#nullable disable
            WriteLiteral(", спасибо что зашли\r\n<p>\r\n    ");
#nullable restore
#line 14 "C:\Users\Profile\source\repos\ITMO.ASP.NET.MVC.2021\MVC_Lab01\Views\Home\Index.cshtml"
Write(Html.ActionLink("Введите имя", "InputData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n<p>\r\n    ");
#nullable restore
#line 17 "C:\Users\Profile\source\repos\ITMO.ASP.NET.MVC.2021\MVC_Lab01\Views\Home\Index.cshtml"
Write(Html.ActionLink("Посмотрите, кто уже здесь", "OutputData"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n</div>\r\n\r\n\r\n\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
