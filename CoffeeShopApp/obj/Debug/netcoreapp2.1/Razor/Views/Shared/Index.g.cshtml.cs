#pragma checksum "C:\Users\YL\source\repos\CoffeeShopApp\CoffeeShopApp\Views\Shared\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4732b68923071c3b6b9dade045c176d0c8f47c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Index), @"mvc.1.0.view", @"/Views/Shared/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Index.cshtml", typeof(AspNetCore.Views_Shared_Index))]
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
#line 1 "C:\Users\YL\source\repos\CoffeeShopApp\CoffeeShopApp\Views\_ViewImports.cshtml"
using CoffeeShopApp;

#line default
#line hidden
#line 2 "C:\Users\YL\source\repos\CoffeeShopApp\CoffeeShopApp\Views\_ViewImports.cshtml"
using CoffeeShopApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4732b68923071c3b6b9dade045c176d0c8f47c4", @"/Views/Shared/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33479ae7daa2bc01bea2466d33dcc7c588e95329", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\YL\source\repos\CoffeeShopApp\CoffeeShopApp\Views\Shared\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 162, true);
            WriteLiteral("\r\n<h2>Welcome to the Grand Circus Coffee Shop!</h2>\r\n\r\n<p></p>\r\n<p></p>\r\n<h4>Please register or sign in:</h4>\r\n\r\n<div>\r\n    <p>To register click below:</p>\r\n     ");
            EndContext();
            BeginContext(206, 90, false);
#line 14 "C:\Users\YL\source\repos\CoffeeShopApp\CoffeeShopApp\Views\Shared\Index.cshtml"
Write(Html.ActionLink("Register", "RegisterView" , new { @class = "btn btn-default btn-large" }));

#line default
#line hidden
            EndContext();
            BeginContext(296, 44, true);
            WriteLiteral("\r\n\r\n    <p>To sign in click below:</p>\r\n    ");
            EndContext();
            BeginContext(341, 80, false);
#line 17 "C:\Users\YL\source\repos\CoffeeShopApp\CoffeeShopApp\Views\Shared\Index.cshtml"
Write(Html.ActionLink("Sign in", "null", new { @class = "btn btn-default btn-large" }));

#line default
#line hidden
            EndContext();
            BeginContext(421, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
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
