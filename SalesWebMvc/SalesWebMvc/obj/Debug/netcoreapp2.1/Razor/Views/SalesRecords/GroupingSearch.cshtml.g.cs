#pragma checksum "C:\Users\lucas\OneDrive\Documentos\Estudos\2.0\ProjetoSistemaWeb\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2464ad2b181d5a402dc81d7f8e62a4c278a66e7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesRecords_GroupingSearch), @"mvc.1.0.view", @"/Views/SalesRecords/GroupingSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalesRecords/GroupingSearch.cshtml", typeof(AspNetCore.Views_SalesRecords_GroupingSearch))]
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
#line 1 "C:\Users\lucas\OneDrive\Documentos\Estudos\2.0\ProjetoSistemaWeb\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "C:\Users\lucas\OneDrive\Documentos\Estudos\2.0\ProjetoSistemaWeb\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2464ad2b181d5a402dc81d7f8e62a4c278a66e7c", @"/Views/SalesRecords/GroupingSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_GroupingSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IGrouping<Department, SalesRecord>>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\lucas\OneDrive\Documentos\Estudos\2.0\ProjetoSistemaWeb\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
  
    ViewData["Title"] = "Grouping Search";
    DateTime minDate = DateTime.Parse(ViewData["minDate"] as string);
    DateTime maxDate = DateTime.Parse(ViewData["maxDate"] as string);



#line default
#line hidden
            BeginContext(257, 7, true);
            WriteLiteral("\r\n<h2> ");
            EndContext();
            BeginContext(265, 17, false);
#line 12 "C:\Users\lucas\OneDrive\Documentos\Estudos\2.0\ProjetoSistemaWeb\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(282, 89, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(371, 660, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2464ad2b181d5a402dc81d7f8e62a4c278a66e7c5317", async() => {
                BeginContext(423, 215, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Min Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 638, "", 665, 1);
#line 20 "C:\Users\lucas\OneDrive\Documentos\Estudos\2.0\ProjetoSistemaWeb\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
WriteAttributeValue("", 645, ViewData["minDate"], 645, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(665, 202, true);
                WriteLiteral(">\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Max Date</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 867, "", 894, 1);
#line 24 "C:\Users\lucas\OneDrive\Documentos\Estudos\2.0\ProjetoSistemaWeb\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
WriteAttributeValue("", 874, ViewData["maxDate"], 874, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(894, 130, true);
                WriteLiteral(">\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1031, 24, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n");
            EndContext();
#line 32 "C:\Users\lucas\OneDrive\Documentos\Estudos\2.0\ProjetoSistemaWeb\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
 foreach (var departmentGroup in Model)
{

#line default
#line hidden
            BeginContext(1099, 123, true);
            WriteLiteral("    <div class=\"panel panel-primary\">\r\n        <div class=\"panel-heading\">\r\n            <h3 class=\"panel-title\">Department ");
            EndContext();
            BeginContext(1223, 24, false);
#line 36 "C:\Users\lucas\OneDrive\Documentos\Estudos\2.0\ProjetoSistemaWeb\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                                          Write(departmentGroup.Key.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1247, 16, true);
            WriteLiteral(", Total sales = ");
            EndContext();
            BeginContext(1264, 63, false);
#line 36 "C:\Users\lucas\OneDrive\Documentos\Estudos\2.0\ProjetoSistemaWeb\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                                                                                   Write(departmentGroup.Key.TotalSales(minDate, maxDate).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 649, true);
            WriteLiteral(@"</h3>
        </div>
        <div class=""panel-body"">
            <table class=""table table-striped table-hover"">
                <thead>
                    <tr class=""success"">
                        <th>
                            Date
                        </th>
                        <th>
                            Amount
                        </th>
                        <th>
                            Seller
                        </th>
                        <th>
                            Status
                        </th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 57 "C:\Users\lucas\OneDrive\Documentos\Estudos\2.0\ProjetoSistemaWeb\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                     foreach (var item in departmentGroup)
                    {

#line default
#line hidden
            BeginContext(2059, 96, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2156, 39, false);
#line 61 "C:\Users\lucas\OneDrive\Documentos\Estudos\2.0\ProjetoSistemaWeb\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2195, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2299, 41, false);
#line 64 "C:\Users\lucas\OneDrive\Documentos\Estudos\2.0\ProjetoSistemaWeb\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2340, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2444, 46, false);
#line 67 "C:\Users\lucas\OneDrive\Documentos\Estudos\2.0\ProjetoSistemaWeb\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2490, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2594, 41, false);
#line 70 "C:\Users\lucas\OneDrive\Documentos\Estudos\2.0\ProjetoSistemaWeb\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2635, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 73 "C:\Users\lucas\OneDrive\Documentos\Estudos\2.0\ProjetoSistemaWeb\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
                    }

#line default
#line hidden
            BeginContext(2726, 76, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 78 "C:\Users\lucas\OneDrive\Documentos\Estudos\2.0\ProjetoSistemaWeb\SalesWebMvc\SalesWebMvc\Views\SalesRecords\GroupingSearch.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IGrouping<Department, SalesRecord>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
