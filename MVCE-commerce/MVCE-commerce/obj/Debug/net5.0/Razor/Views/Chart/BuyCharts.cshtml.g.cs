#pragma checksum "C:\Users\staa99\source\repos\MVCE-commerce\MVCE-commerce\Views\Chart\BuyCharts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "002cf388b5f3ddd8fdb3bd9ad848a02460cf634f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chart_BuyCharts), @"mvc.1.0.view", @"/Views/Chart/BuyCharts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"002cf388b5f3ddd8fdb3bd9ad848a02460cf634f", @"/Views/Chart/BuyCharts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c439ce295c7d06ad4c8289b331c8bb19f6621ec7", @"/Views/_ViewImports.cshtml")]
    public class Views_Chart_BuyCharts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVCE_commerce.DTO.Response>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\staa99\source\repos\MVCE-commerce\MVCE-commerce\Views\Chart\BuyCharts.cshtml"
     if (@Model.Status == false)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n\r\n            ");
#nullable restore
#line 7 "C:\Users\staa99\source\repos\MVCE-commerce\MVCE-commerce\Views\Chart\BuyCharts.cshtml"
       Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 9 "C:\Users\staa99\source\repos\MVCE-commerce\MVCE-commerce\Views\Chart\BuyCharts.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div>
    
            <table class=""table"">
                <thead>
                <tr>
                    <th>
                        Product
                    </th>
                    <th>
                        Quantity
                    </th>
                    <th>
                        Price
                    </th>
                </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 29 "C:\Users\staa99\source\repos\MVCE-commerce\MVCE-commerce\Views\Chart\BuyCharts.cshtml"
                 foreach (var t in @Model.Data)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th>\r\n                            ");
#nullable restore
#line 33 "C:\Users\staa99\source\repos\MVCE-commerce\MVCE-commerce\Views\Chart\BuyCharts.cshtml"
                       Write(t.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 36 "C:\Users\staa99\source\repos\MVCE-commerce\MVCE-commerce\Views\Chart\BuyCharts.cshtml"
                       Write(t.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                        <th>\r\n                            ");
#nullable restore
#line 39 "C:\Users\staa99\source\repos\MVCE-commerce\MVCE-commerce\Views\Chart\BuyCharts.cshtml"
                       Write(t.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </th>\r\n                    </tr>\r\n");
#nullable restore
#line 42 "C:\Users\staa99\source\repos\MVCE-commerce\MVCE-commerce\Views\Chart\BuyCharts.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n");
#nullable restore
#line 46 "C:\Users\staa99\source\repos\MVCE-commerce\MVCE-commerce\Views\Chart\BuyCharts.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVCE_commerce.DTO.Response> Html { get; private set; }
    }
}
#pragma warning restore 1591