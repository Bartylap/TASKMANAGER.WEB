#pragma checksum "C:\Users\StazHsi\source\repos\TASK\TASKMANAGER.WEB\Views\User\MyErrands.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86a111502eb437e613a6e96230b00ec81ae36775"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_MyErrands), @"mvc.1.0.view", @"/Views/User/MyErrands.cshtml")]
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
#line 1 "C:\Users\StazHsi\source\repos\TASK\TASKMANAGER.WEB\Views\_ViewImports.cshtml"
using TASKMANAGER.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\StazHsi\source\repos\TASK\TASKMANAGER.WEB\Views\_ViewImports.cshtml"
using TASKMANAGER.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a111502eb437e613a6e96230b00ec81ae36775", @"/Views/User/MyErrands.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de35b939f46af3a2606b42fd9b0a5c03cbd6b617", @"/Views/_ViewImports.cshtml")]
    public class Views_User_MyErrands : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TaskManager.Application.ViewModels.Errand.ErrandListVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\StazHsi\source\repos\TASK\TASKMANAGER.WEB\Views\User\MyErrands.cshtml"
  
    ViewData["Title"] = "MyErrands";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>MyErrands</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86a111502eb437e613a6e96230b00ec81ae367753703", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>
                Nazwa
            </th>
            <th>
                Opis
            </th>
            <th>
                Status
            </th>
            <th>
                Akcja
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 30 "C:\Users\StazHsi\source\repos\TASK\TASKMANAGER.WEB\Views\User\MyErrands.cshtml"
         foreach (var item in Model.Errands)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 34 "C:\Users\StazHsi\source\repos\TASK\TASKMANAGER.WEB\Views\User\MyErrands.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\StazHsi\source\repos\TASK\TASKMANAGER.WEB\Views\User\MyErrands.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 40 "C:\Users\StazHsi\source\repos\TASK\TASKMANAGER.WEB\Views\User\MyErrands.cshtml"
                     if (item.StatusId == 1)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"font-weight:700; color:black \"> Nieprzydzielone </p>\r\n");
#nullable restore
#line 43 "C:\Users\StazHsi\source\repos\TASK\TASKMANAGER.WEB\Views\User\MyErrands.cshtml"
                    }
                    else if (item.StatusId == 2)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"font-weight:700; color:darkviolet \"> Przydzielone </p>\r\n");
#nullable restore
#line 47 "C:\Users\StazHsi\source\repos\TASK\TASKMANAGER.WEB\Views\User\MyErrands.cshtml"
                    }
                    else if (item.StatusId == 3)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"font-weight:700; color:darkorange \"> Konsultacja </p>\r\n");
#nullable restore
#line 51 "C:\Users\StazHsi\source\repos\TASK\TASKMANAGER.WEB\Views\User\MyErrands.cshtml"
                    }
                    else if (item.StatusId == 4)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"font-weight:700; color:green \"> Gotowe  </p>\r\n");
#nullable restore
#line 55 "C:\Users\StazHsi\source\repos\TASK\TASKMANAGER.WEB\Views\User\MyErrands.cshtml"
                    }
                    else if (item.StatusId == 5)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p style=\"font-weight:700; color:red \"> Anulowane </p>\r\n");
#nullable restore
#line 59 "C:\Users\StazHsi\source\repos\TASK\TASKMANAGER.WEB\Views\User\MyErrands.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n\r\n                <td>\r\n                    <center>\r\n                        <a class=\"btn btn-warning\" style=\"height:40px , \" width:100px\"");
            BeginWriteAttribute("href", " href=\"", 1904, "\"", 1962, 1);
#nullable restore
#line 64 "C:\Users\StazHsi\source\repos\TASK\TASKMANAGER.WEB\Views\User\MyErrands.cshtml"
WriteAttributeValue("", 1911, Url.Action("Edit", "Errand", new { id = item.Id }), 1911, 51, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edytuj</a>\r\n                    </center>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 68 "C:\Users\StazHsi\source\repos\TASK\TASKMANAGER.WEB\Views\User\MyErrands.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TaskManager.Application.ViewModels.Errand.ErrandListVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
