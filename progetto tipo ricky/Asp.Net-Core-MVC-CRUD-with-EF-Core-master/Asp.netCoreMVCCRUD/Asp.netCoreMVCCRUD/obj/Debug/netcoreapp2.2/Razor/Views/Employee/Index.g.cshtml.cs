#pragma checksum "C:\Users\Giulio\Desktop\progetto tipo ricky\Asp.Net-Core-MVC-CRUD-with-EF-Core-master\Asp.netCoreMVCCRUD\Asp.netCoreMVCCRUD\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2e5a60141c63e39ec17dcd957c40f8584fd2450"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
#line 1 "C:\Users\Giulio\Desktop\progetto tipo ricky\Asp.Net-Core-MVC-CRUD-with-EF-Core-master\Asp.netCoreMVCCRUD\Asp.netCoreMVCCRUD\Views\_ViewImports.cshtml"
using Asp.netCoreMVCCRUD;

#line default
#line hidden
#line 2 "C:\Users\Giulio\Desktop\progetto tipo ricky\Asp.Net-Core-MVC-CRUD-with-EF-Core-master\Asp.netCoreMVCCRUD\Asp.netCoreMVCCRUD\Views\_ViewImports.cshtml"
using Asp.netCoreMVCCRUD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2e5a60141c63e39ec17dcd957c40f8584fd2450", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19425ece7219a4cf214d9ba04ed397571ef1cc83", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Asp.netCoreMVCCRUD.Models.Employee>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddOrEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger ml-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Are you sure to delete this record?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(55, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Giulio\Desktop\progetto tipo ricky\Asp.Net-Core-MVC-CRUD-with-EF-Core-master\Asp.netCoreMVCCRUD\Asp.netCoreMVCCRUD\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(94, 129, true);
            WriteLiteral("\n<h4>Employee Register</h4>\n<hr />\n\n\n<table class=\"table table-hover\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(224, 44, false);
#line 15 "C:\Users\Giulio\Desktop\progetto tipo ricky\Asp.Net-Core-MVC-CRUD-with-EF-Core-master\Asp.netCoreMVCCRUD\Asp.netCoreMVCCRUD\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(268, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(321, 43, false);
#line 18 "C:\Users\Giulio\Desktop\progetto tipo ricky\Asp.Net-Core-MVC-CRUD-with-EF-Core-master\Asp.netCoreMVCCRUD\Asp.netCoreMVCCRUD\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmpCode));

#line default
#line hidden
            EndContext();
            BeginContext(364, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(417, 44, false);
#line 21 "C:\Users\Giulio\Desktop\progetto tipo ricky\Asp.Net-Core-MVC-CRUD-with-EF-Core-master\Asp.netCoreMVCCRUD\Asp.netCoreMVCCRUD\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
            EndContext();
            BeginContext(461, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(514, 50, false);
#line 24 "C:\Users\Giulio\Desktop\progetto tipo ricky\Asp.Net-Core-MVC-CRUD-with-EF-Core-master\Asp.netCoreMVCCRUD\Asp.netCoreMVCCRUD\Views\Employee\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OfficeLocation));

#line default
#line hidden
            EndContext();
            BeginContext(564, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(616, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2e5a60141c63e39ec17dcd957c40f8584fd24507596", async() => {
                BeginContext(674, 43, true);
                WriteLiteral("<i class=\"far fa-plus-square\"></i> Employee");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(721, 58, true);
            WriteLiteral("\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 32 "C:\Users\Giulio\Desktop\progetto tipo ricky\Asp.Net-Core-MVC-CRUD-with-EF-Core-master\Asp.netCoreMVCCRUD\Asp.netCoreMVCCRUD\Views\Employee\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(810, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(857, 43, false);
#line 35 "C:\Users\Giulio\Desktop\progetto tipo ricky\Asp.Net-Core-MVC-CRUD-with-EF-Core-master\Asp.netCoreMVCCRUD\Asp.netCoreMVCCRUD\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
            EndContext();
            BeginContext(900, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(953, 42, false);
#line 38 "C:\Users\Giulio\Desktop\progetto tipo ricky\Asp.Net-Core-MVC-CRUD-with-EF-Core-master\Asp.netCoreMVCCRUD\Asp.netCoreMVCCRUD\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmpCode));

#line default
#line hidden
            EndContext();
            BeginContext(995, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1048, 43, false);
#line 41 "C:\Users\Giulio\Desktop\progetto tipo ricky\Asp.Net-Core-MVC-CRUD-with-EF-Core-master\Asp.netCoreMVCCRUD\Asp.netCoreMVCCRUD\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1144, 49, false);
#line 44 "C:\Users\Giulio\Desktop\progetto tipo ricky\Asp.Net-Core-MVC-CRUD-with-EF-Core-master\Asp.netCoreMVCCRUD\Asp.netCoreMVCCRUD\Views\Employee\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OfficeLocation));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(1245, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2e5a60141c63e39ec17dcd957c40f8584fd245011468", async() => {
                BeginContext(1303, 34, true);
                WriteLiteral("<i class=\"fa fa-marker fa-lg\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 47 "C:\Users\Giulio\Desktop\progetto tipo ricky\Asp.Net-Core-MVC-CRUD-with-EF-Core-master\Asp.netCoreMVCCRUD\Asp.netCoreMVCCRUD\Views\Employee\Index.cshtml"
                                            WriteLiteral(item.EmployeeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1341, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(1358, 185, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2e5a60141c63e39ec17dcd957c40f8584fd245013929", async() => {
                BeginContext(1502, 37, true);
                WriteLiteral("<i class=\"fa fa-trash-alt fa-lg\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\Giulio\Desktop\progetto tipo ricky\Asp.Net-Core-MVC-CRUD-with-EF-Core-master\Asp.netCoreMVCCRUD\Asp.netCoreMVCCRUD\Views\Employee\Index.cshtml"
                                         WriteLiteral(item.EmployeeId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1543, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 51 "C:\Users\Giulio\Desktop\progetto tipo ricky\Asp.Net-Core-MVC-CRUD-with-EF-Core-master\Asp.netCoreMVCCRUD\Asp.netCoreMVCCRUD\Views\Employee\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1578, 22, true);
            WriteLiteral("    </tbody>\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Asp.netCoreMVCCRUD.Models.Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
