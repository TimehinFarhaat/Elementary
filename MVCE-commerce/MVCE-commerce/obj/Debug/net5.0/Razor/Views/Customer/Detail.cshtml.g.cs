#pragma checksum "C:\Users\staa99\source\repos\MVCE-commerce\MVCE-commerce\Views\Customer\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77ed05706ccfedcf30047f39e11b46899977881f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Detail), @"mvc.1.0.view", @"/Views/Customer/Detail.cshtml")]
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
#line 1 "C:\Users\staa99\source\repos\MVCE-commerce\MVCE-commerce\Views\_ViewImports.cshtml"
using MVCE_commerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\staa99\source\repos\MVCE-commerce\MVCE-commerce\Views\_ViewImports.cshtml"
using MVCE_commerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77ed05706ccfedcf30047f39e11b46899977881f", @"/Views/Customer/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c439ce295c7d06ad4c8289b331c8bb19f6621ec7", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCE_commerce.DTO.CustomerResponseModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n    <dl>\r\n        <dd>\r\n            Id\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 8 "C:\Users\staa99\source\repos\MVCE-commerce\MVCE-commerce\Views\Customer\Detail.cshtml"
       Write(Model.Data.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            First-Name\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 14 "C:\Users\staa99\source\repos\MVCE-commerce\MVCE-commerce\Views\Customer\Detail.cshtml"
       Write(Model.Data.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            Last-Name\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 20 "C:\Users\staa99\source\repos\MVCE-commerce\MVCE-commerce\Views\Customer\Detail.cshtml"
       Write(Model.Data.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            Email\r\n        </dd>\r\n        <dt>\r\n            ");
#nullable restore
#line 26 "C:\Users\staa99\source\repos\MVCE-commerce\MVCE-commerce\Views\Customer\Detail.cshtml"
       Write(Model.Data.EmailAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n       \r\n    </dl>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCE_commerce.DTO.CustomerResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
