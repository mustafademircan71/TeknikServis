#pragma checksum "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Views\OurServices\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c57ab6725130e580f3d30e692a152a64b79d8465"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OurServices_Index), @"mvc.1.0.view", @"/Views/OurServices/Index.cshtml")]
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
#line 1 "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Views\_ViewImports.cshtml"
using TeknikServis.MVCUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Views\_ViewImports.cshtml"
using TeknikServis.MVCUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Views\_ViewImports.cshtml"
using TeknikServis.Model.ViewModels.HomePage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Views\OurServices\Index.cshtml"
using TeknikServis.Model.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c57ab6725130e580f3d30e692a152a64b79d8465", @"/Views/OurServices/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbf8938b74d144fa886b0ad94c0c3bba3b0988de", @"/Views/_ViewImports.cshtml")]
    public class Views_OurServices_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Fault>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Views\OurServices\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""cd-full-width"">
        <div class=""container js-tm-page-content tm-section-margin-t-small"" data-page-no=""4"">
            <div class=""tm-contact-page"">
                <div class=""row tm-margin-b"">
                    <div class=""col-xs-12"">
                        <div class=""tm-bg-white tm-textbox-padding"" "">
                            <h2 class=""tm-text-title tm-margin-b-0""  >Hizmetlerimiz</h2>
                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-xs-12"">
                        <div class=""tm-flex tm-contact-container tm-bg-dark-blue"">
                            <div class=""text-xs-left tm-textbox tm-2-col-textbox-2 tm-textbox-padding tm-textbox-padding-contact"">
                                <table class=""table table-bordered table-dark"" style=""width:250px;"">
                                    <thead>
                                        <tr>
                    ");
            WriteLiteral("                        <th scope=\"col\" style=\"color:white;\">Hizmetlerimiz</th>\r\n                                        </tr>\r\n                                    </thead>\r\n");
#nullable restore
#line 31 "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Views\OurServices\Index.cshtml"
                                     foreach (var fault in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tbody>\r\n                                            <tr>\r\n                                                <td style=\"color:white;\">");
#nullable restore
#line 35 "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Views\OurServices\Index.cshtml"
                                                                    Write(fault.FaultName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n                                        </tbody>\r\n");
#nullable restore
#line 38 "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Views\OurServices\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                   
                                </table>
                            </div>

                            <div class=""text-xs-left tm-textbox tm-2-col-textbox-2 tm-textbox-padding tm-textbox-padding-contact"">
                                <!-- contact form -->
                            
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>




    <table class=""table table-bordered table-dark"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">First</th>
                <th scope=""col"">Last</th>
                <th scope=""col"">Handle</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <th scope=""row"">1</th>
                <td>Mark</td>
                <td>Otto</td>

            </tr>
            <tr>
                <th scope=""row"">2</th>
 ");
            WriteLiteral(@"               <td>Jacob</td>
                <td>Thornton</td>

            </tr>
            <tr>
                <th scope=""row"">3</th>
                <td colspan=""2"">Larry the Bird</td>

            </tr>
        </tbody>
    </table>










");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
        <script src=""~/lib/datatables/jquery.dataTables.min.js""></script>
        <script src=""~/lib/datatables-bs4/js/dataTables.bootstrap4.min.js""></script>
        <script src=""~/lib/datatables-responsive/js/dataTables.responsive.min.js""></script>
        <script src=""~/lib/datatables-responsive/js/responsive.bootstrap4.min.js""></script>
        <script src=""~/js/Home.js""></script>
    ");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("styles", async() => {
                WriteLiteral("\r\n        <link rel=\"stylesheet\" href=\"~/lib/datatables-bs4/css/dataTables.bootstrap4.min.css\">\r\n        <link rel=\"stylesheet\" href=\"~/lib/datatables-responsive/css/responsive.bootstrap4.min.css\">\r\n\r\n    ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Fault>> Html { get; private set; }
    }
}
#pragma warning restore 1591
