#pragma checksum "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\JoinLicense_Assets\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0924211533b7ab6d95dfac74bafcc4bfe0bbf70d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.JoinLicense_Assets.Pages_JoinLicense_Assets_Delete), @"mvc.1.0.razor-page", @"/Pages/JoinLicense_Assets/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/JoinLicense_Assets/Delete.cshtml", typeof(tbkk_AC.Pages.JoinLicense_Assets.Pages_JoinLicense_Assets_Delete), null)]
namespace tbkk_AC.Pages.JoinLicense_Assets
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0924211533b7ab6d95dfac74bafcc4bfe0bbf70d", @"/Pages/JoinLicense_Assets/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_JoinLicense_Assets_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(58, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\JoinLicense_Assets\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(98, 635, true);
            WriteLiteral(@"<div id=""content-wrapper"">
    <div class=""container-fluid"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item active"">Asset Control</li>
            <li class=""breadcrumb-item active"">Managment</li>
            <li class=""breadcrumb-item active"">Join</li>
        </ol>
        <div class=""card border-danger mb-auto"">
            <div class=""card-header"">Delete</div>
            <div class=""card-body text-dark"" style=""text-align:center"">
                <p class=""card-title"">Are you sure you want to delete this?</p>
                <dl class=""dl-horizontal"">
                    <dd>
                        ");
            EndContext();
            BeginContext(734, 65, false);
#line 20 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\JoinLicense_Assets\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Join_License_Asset.JoinLiAsID));

#line default
#line hidden
            EndContext();
            BeginContext(799, 27, true);
            WriteLiteral(" :\n                        ");
            EndContext();
            BeginContext(827, 61, false);
#line 21 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\JoinLicense_Assets\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Join_License_Asset.JoinLiAsID));

#line default
#line hidden
            EndContext();
            BeginContext(888, 76, true);
            WriteLiteral("\n                    </dd>\n                    <dd>\n                        ");
            EndContext();
            BeginContext(965, 61, false);
#line 24 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\JoinLicense_Assets\Delete.cshtml"
                   Write(Html.DisplayNameFor(model => model.Join_License_Asset.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 27, true);
            WriteLiteral(" :\n                        ");
            EndContext();
            BeginContext(1054, 57, false);
#line 25 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\JoinLicense_Assets\Delete.cshtml"
                   Write(Html.DisplayFor(model => model.Join_License_Asset.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1111, 66, true);
            WriteLiteral("\n                    </dd>\n                </dl>\n\n                ");
            EndContext();
            BeginContext(1177, 350, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5ea90f831b44ed9bed72bc4328521fd", async() => {
                BeginContext(1197, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(1218, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0cd9fbfe60284c9fbc99578d80c82f44", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 30 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\JoinLicense_Assets\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Join_License_Asset.Status);

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
                BeginContext(1277, 21, true);
                WriteLiteral("\n                    ");
                EndContext();
                BeginContext(1298, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "89c89117f5c14eb59a260faa5b2c186a", async() => {
                    BeginContext(1320, 64, true);
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
                BeginContext(1388, 132, true);
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
            BeginContext(1527, 53, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.JoinLicense_Assets.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.JoinLicense_Assets.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.JoinLicense_Assets.DeleteModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.JoinLicense_Assets.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
