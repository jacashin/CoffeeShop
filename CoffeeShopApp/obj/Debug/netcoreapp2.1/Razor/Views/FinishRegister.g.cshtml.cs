#pragma checksum "C:\Users\YL\source\repos\CoffeeShopApp\CoffeeShopApp\Views\FinishRegister.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3be918193942df8f4c8fa34224d4a670ca63be5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FinishRegister), @"mvc.1.0.view", @"/Views/FinishRegister.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FinishRegister.cshtml", typeof(AspNetCore.Views_FinishRegister))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3be918193942df8f4c8fa34224d4a670ca63be5b", @"/Views/FinishRegister.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33479ae7daa2bc01bea2466d33dcc7c588e95329", @"/Views/_ViewImports.cshtml")]
    public class Views_FinishRegister : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registration>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\YL\source\repos\CoffeeShopApp\CoffeeShopApp\Views\FinishRegister.cshtml"
  
    ViewData["Title"] = "FinishRegister";

#line default
#line hidden
            BeginContext(71, 15, true);
            WriteLiteral("\r\n<h2>Welcome  ");
            EndContext();
            BeginContext(87, 20, false);
#line 6 "C:\Users\YL\source\repos\CoffeeShopApp\CoffeeShopApp\Views\FinishRegister.cshtml"
        Write(ViewData["UserInfo"]);

#line default
#line hidden
            EndContext();
            BeginContext(107, 9, true);
            WriteLiteral("</h2>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registration> Html { get; private set; }
    }
}
#pragma warning restore 1591