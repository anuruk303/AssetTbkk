#pragma checksum "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Employees\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ef8628c1d3a41b39f3d570bd48d17a6b9a4fd75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Employees.Pages_Employees_Delete), @"mvc.1.0.razor-page", @"/Pages/Employees/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Employees/Delete.cshtml", typeof(tbkk_AC.Pages.Employees.Pages_Employees_Delete), null)]
namespace tbkk_AC.Pages.Employees
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\_ViewImports.cshtml"
using tbkk_AC;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ef8628c1d3a41b39f3d570bd48d17a6b9a4fd75", @"/Pages/Employees/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Employees_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Employees\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(89, 640, true);
            WriteLiteral(@"
<div id=""content-wrapper"">
    <div class=""container-fluid"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item active"">Asset Control</li>
            <li class=""breadcrumb-item active"">Managment</li>
            <li class=""breadcrumb-item active"">Employee</li>
        </ol>
        <div class=""card border-danger mb-auto"">
            <div class=""card-header"">Delete</div>
            <div class=""card-body text-dark"" style=""text-align:center"">
                <p class=""card-title"">Are you sure you want to delete this?</p>
                <dl class=""dl-horizontal"">
                    <dd>
                        ");
            EndContext();
            BeginContext(730, 55, false);
#line 21 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Employees\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Employee.EmployeeID));

#line default
#line hidden
            EndContext();
            BeginContext(785, 27, true);
            WriteLiteral(" :\n                        ");
            EndContext();
            BeginContext(813, 51, false);
#line 22 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Employees\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Employee.EmployeeID));

#line default
#line hidden
            EndContext();
            BeginContext(864, 76, true);
            WriteLiteral("\n                    </dd>\n                    <dd>\n                        ");
            EndContext();
            BeginContext(941, 51, false);
#line 25 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Employees\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Employee.Status));

#line default
#line hidden
            EndContext();
            BeginContext(992, 27, true);
            WriteLiteral(" :\n                        ");
            EndContext();
            BeginContext(1020, 47, false);
#line 26 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Employees\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Employee.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 66, true);
            WriteLiteral("\n                    </dd>\n                </dl>\n\n                ");
            EndContext();
            BeginContext(1133, 344, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7508143bd9f747f78a7ebe7dff47e9a0", async() => {
                BeginContext(1153, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(1174, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dc9f6e2f8d54478b80692df5ba6a1e6a", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 31 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Employees\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Employee.EmployeeID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1227, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(1248, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bec5ad2904241e286270d99c141262e", async() => {
                    BeginContext(1270, 64, true);
                    WriteLiteral("<button type=\"button\" class=\"btn btn-link\">Back to List</button>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1338, 132, true);
                WriteLiteral("\n                    <input style=\"margin-left:10px\" type=\"submit\" value=\"Delete\" class=\"btn btn-outline-danger\" />\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1477, 52, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.Employees.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Employees.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Employees.DeleteModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.Employees.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
