#pragma checksum "C:\Users\StazHsi\source\repos\TASKMANAGER.WEBpt\TASKMANAGER.WEB\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aede9f1e8666abcdaa2ceacd515aae4bc56b7903"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\StazHsi\source\repos\TASKMANAGER.WEBpt\TASKMANAGER.WEB\Views\_ViewImports.cshtml"
using TASKMANAGER.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\StazHsi\source\repos\TASKMANAGER.WEBpt\TASKMANAGER.WEB\Views\_ViewImports.cshtml"
using TASKMANAGER.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aede9f1e8666abcdaa2ceacd515aae4bc56b7903", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de35b939f46af3a2606b42fd9b0a5c03cbd6b617", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskManager.Application.ViewModels.Employee.EmployeeListVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\StazHsi\source\repos\TASKMANAGER.WEBpt\TASKMANAGER.WEB\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<center><h1>Lista Pracowników</h1></center>


<table class=""user_table"">
    <thead>
        <tr>
            <th>
                Imię
            </th>
            <th>
                Nazwisko
            </th>
            <th>
                Stanowisko
            </th>
            <th>
                Akcje
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 28 "C:\Users\StazHsi\source\repos\TASKMANAGER.WEBpt\TASKMANAGER.WEB\Views\Employee\Index.cshtml"
         foreach (var item in Model.Employees)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "C:\Users\StazHsi\source\repos\TASKMANAGER.WEBpt\TASKMANAGER.WEB\Views\Employee\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "C:\Users\StazHsi\source\repos\TASKMANAGER.WEBpt\TASKMANAGER.WEB\Views\Employee\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 38 "C:\Users\StazHsi\source\repos\TASKMANAGER.WEBpt\TASKMANAGER.WEB\Views\Employee\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn btn-warning\" style=\"height:40px , \" width:100px\"");
            BeginWriteAttribute("href", " href=\"", 1020, "\"", 1088, 1);
#nullable restore
#line 41 "C:\Users\StazHsi\source\repos\TASKMANAGER.WEBpt\TASKMANAGER.WEB\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1027, Url.Action("EditEmployee", "Employee", new { id = item.Id }), 1027, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edytuj</a>\r\n                    <a class=\"btn btn-danger\" style=\"height:40px , \" width:100px\"");
            BeginWriteAttribute("href", " href=\"", 1183, "\"", 1253, 1);
#nullable restore
#line 42 "C:\Users\StazHsi\source\repos\TASKMANAGER.WEBpt\TASKMANAGER.WEB\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1190, Url.Action("DeleteEmployee", "Employee", new { id = item.Id }), 1190, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Usuń</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 45 "C:\Users\StazHsi\source\repos\TASKMANAGER.WEBpt\TASKMANAGER.WEB\Views\Employee\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<a class=\"btn btn-danger\" style=\"height:40px , \" width:100px\"");
            BeginWriteAttribute("href", " href=\"", 1403, "\"", 1444, 1);
#nullable restore
#line 48 "C:\Users\StazHsi\source\repos\TASKMANAGER.WEBpt\TASKMANAGER.WEB\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1410, Url.Action("Export", "Employee" ), 1410, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Export</a>\r\n<input type=\"file\" class=\"form-control\"");
            BeginWriteAttribute("href", "href=\"", 1497, "\"", 1537, 1);
#nullable restore
#line 49 "C:\Users\StazHsi\source\repos\TASKMANAGER.WEBpt\TASKMANAGER.WEB\Views\Employee\Index.cshtml"
WriteAttributeValue("", 1503, Url.Action("Export", "Employee" ), 1503, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskManager.Application.ViewModels.Employee.EmployeeListVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
