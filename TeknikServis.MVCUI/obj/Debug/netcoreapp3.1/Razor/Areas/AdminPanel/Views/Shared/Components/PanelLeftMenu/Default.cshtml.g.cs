#pragma checksum "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Areas\AdminPanel\Views\Shared\Components\PanelLeftMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3f58eac15349f2d8d226f222d73e404c37fc9bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Shared_Components_PanelLeftMenu_Default), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Shared/Components/PanelLeftMenu/Default.cshtml")]
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
#line 2 "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Areas\AdminPanel\Views\_ViewImports.cshtml"
using TeknikServis.Model.ViewModels.AdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Areas\AdminPanel\Views\_ViewImports.cshtml"
using TeknikServis.Model.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Areas\AdminPanel\Views\_ViewImports.cshtml"
using TeknikServis.Model.ViewModels.HomePage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Areas\AdminPanel\Views\Shared\Components\PanelLeftMenu\Default.cshtml"
using TeknikServis.Model.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3f58eac15349f2d8d226f222d73e404c37fc9bc", @"/Areas/AdminPanel/Views/Shared/Components/PanelLeftMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60abae713c0fd8dce1928fb958060c070cd1814a", @"/Areas/AdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_AdminPanel_Views_Shared_Components_PanelLeftMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Admin>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<a href=""index3.html"" class=""brand-link"">
    <span class=""brand-text font-weight-light"">Tekno Cep Teknik Servis</span>
</a>

<div class=""sidebar"">
    <div class=""user-panel mt-3 pb-3 mb-3 d-flex"">
       <div class=""info"">
            <a href=""#"" class=""d-block"">");
#nullable restore
#line 11 "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Areas\AdminPanel\Views\Shared\Components\PanelLeftMenu\Default.cshtml"
                                   Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
        </div>
    </div>

    <nav class=""mt-2"">
        <ul class=""nav nav-pills nav-sidebar flex-column"" data-widget=""treeview"" role=""menu"" data-accordion=""false"">
            <li class=""nav-item has-treeview menu-open"">
                <a href=""#"" class=""nav-link active"">
                    <i class=""nav-icon fas fa-tachometer-alt""></i>
                    <p>
                        Yönetici Menü
                        <i class=""right fas fa-angle-left""></i>
                    </p>
                </a>
                <ul class=""nav nav-treeview"">
");
#nullable restore
#line 26 "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Areas\AdminPanel\Views\Shared\Components\PanelLeftMenu\Default.cshtml"
                   if (Model.RoleId == (int)AdminRoles.SuperAdmin)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a href=""/admin-list"" class=""nav-link"">
                                <i class=""fas fa-user nav-icon""></i>
                                <p>Yöneticiler</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""/message-list-admin"" class=""nav-link"">
                                <i class=""fas fa-quote-left nav-icon""  ></i>
                                <p>Mesajlar</p>
                            </a>
                        </li>
");
#nullable restore
#line 40 "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Areas\AdminPanel\Views\Shared\Components\PanelLeftMenu\Default.cshtml"
                       
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Areas\AdminPanel\Views\Shared\Components\PanelLeftMenu\Default.cshtml"
                     if (Model.RoleId == (int)AdminRoles.SuperAdmin || Model.RoleId == (int)AdminRoles.SubAdmin)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <li class=""nav-item"">
                            <a href=""/service-list"" class=""nav-link"">
                                <i class=""fas fa-laptop nav-icon""></i>
                                <p>Teknik Servis</p>
                            </a>
                        </li>
                        <li class=""nav-item"">
                            <a href=""/fault-list"" class=""nav-link"">
                                <i class=""fas fa-cog nav-icon""></i>
                                <p>Arıza</p>
                            </a>
                        </li>
");
#nullable restore
#line 56 "C:\Users\Mustafa\Desktop\TeknikServis\TeknikServis.MVCUI\Areas\AdminPanel\Views\Shared\Components\PanelLeftMenu\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </ul>
            </li>
            <li class=""nav-item"">
                <a href=""/logout"" class=""nav-link"">
                    <i class=""nav-icon fas fa-th""></i>
                    <p>Çıkış</p>
                </a>
            </li>
        </ul>
    </nav>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591
