#pragma checksum "C:\Users\Piotr\Source\Repos\TASKMANAGER\TASKMANAGER.WEB\Views\Construction\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45cf7207708a6094f43136d5735d680c5dda4cf3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Construction_Index), @"mvc.1.0.view", @"/Views/Construction/Index.cshtml")]
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
#line 1 "C:\Users\Piotr\Source\Repos\TASKMANAGER\TASKMANAGER.WEB\Views\_ViewImports.cshtml"
using TASKMANAGER.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Piotr\Source\Repos\TASKMANAGER\TASKMANAGER.WEB\Views\_ViewImports.cshtml"
using TASKMANAGER.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45cf7207708a6094f43136d5735d680c5dda4cf3", @"/Views/Construction/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de35b939f46af3a2606b42fd9b0a5c03cbd6b617", @"/Views/_ViewImports.cshtml")]
    public class Views_Construction_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskManager.Application.ViewModels.Construction.ConstructionListVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Piotr\Source\Repos\TASKMANAGER\TASKMANAGER.WEB\Views\Construction\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Budowy</h1>


<table class=""table"">
    <thead>
        <tr>
            <th>
                Nazwa
            </th>
            <th>
                Adres
            </th>
            <th>
                Liczba Pracowników
            </th>
            <th>
                Data Wyjazdu
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 28 "C:\Users\Piotr\Source\Repos\TASKMANAGER\TASKMANAGER.WEB\Views\Construction\Index.cshtml"
 foreach (var item in Model.Constructions) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\Piotr\Source\Repos\TASKMANAGER\TASKMANAGER.WEB\Views\Construction\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Piotr\Source\Repos\TASKMANAGER\TASKMANAGER.WEB\Views\Construction\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AddressLine1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Piotr\Source\Repos\TASKMANAGER\TASKMANAGER.WEB\Views\Construction\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Employee.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Piotr\Source\Repos\TASKMANAGER\TASKMANAGER.WEB\Views\Construction\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a class=\"btn btn-warning\" style=\"height:40px , \" width:100px\"");
            BeginWriteAttribute("href", " href=\"", 1047, "\"", 1114, 1);
#nullable restore
#line 43 "C:\Users\Piotr\Source\Repos\TASKMANAGER\TASKMANAGER.WEB\Views\Construction\Index.cshtml"
WriteAttributeValue("", 1054, Url.Action("Details", "Construction", new { id = item.Id }), 1054, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edytuj</a>\r\n                <a class=\"btn btn-warning\" style=\"height:40px , \" width:100px\"");
            BeginWriteAttribute("href", " href=\"", 1206, "\"", 1271, 1);
#nullable restore
#line 44 "C:\Users\Piotr\Source\Repos\TASKMANAGER\TASKMANAGER.WEB\Views\Construction\Index.cshtml"
WriteAttributeValue("", 1213, Url.Action("Clone", "Construction", new { id = item.Id }), 1213, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Klonuj</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\Piotr\Source\Repos\TASKMANAGER\TASKMANAGER.WEB\Views\Construction\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskManager.Application.ViewModels.Construction.ConstructionListVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
