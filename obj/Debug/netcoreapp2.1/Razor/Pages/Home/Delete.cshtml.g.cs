#pragma checksum "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ccbb87b3da8b91d53d601264afe049067ce618d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Home.Pages_Home_Delete), @"mvc.1.0.razor-page", @"/Pages/Home/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Home/Delete.cshtml", typeof(tbkk_AC.Pages.Home.Pages_Home_Delete), null)]
namespace tbkk_AC.Pages.Home
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccbb87b3da8b91d53d601264afe049067ce618d8", @"/Pages/Home/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Home_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(33, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(119, 157, true);
            WriteLiteral("\n<h2>Delete</h2>\n\n<h3>Are you sure you want to delete this?</h3>\n<div>\n    <h4>Asset</h4>\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n            ");
            EndContext();
            BeginContext(277, 51, false);
#line 17 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.AssetName));

#line default
#line hidden
            EndContext();
            BeginContext(328, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(369, 47, false);
#line 20 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.AssetName));

#line default
#line hidden
            EndContext();
            BeginContext(416, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(457, 54, false);
#line 23 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.SerailNumber));

#line default
#line hidden
            EndContext();
            BeginContext(511, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(552, 50, false);
#line 26 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.SerailNumber));

#line default
#line hidden
            EndContext();
            BeginContext(602, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(643, 49, false);
#line 29 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.MACAddr));

#line default
#line hidden
            EndContext();
            BeginContext(692, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(733, 45, false);
#line 32 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.MACAddr));

#line default
#line hidden
            EndContext();
            BeginContext(778, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(819, 53, false);
#line 35 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.InstallDate));

#line default
#line hidden
            EndContext();
            BeginContext(872, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(913, 49, false);
#line 38 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.InstallDate));

#line default
#line hidden
            EndContext();
            BeginContext(962, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1003, 54, false);
#line 41 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1057, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1098, 50, false);
#line 44 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(1148, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1189, 52, false);
#line 47 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1241, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1282, 48, false);
#line 50 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(1330, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1371, 50, false);
#line 53 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(1421, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1462, 46, false);
#line 56 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(1508, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1549, 47, false);
#line 59 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1637, 43, false);
#line 62 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1680, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1721, 50, false);
#line 65 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Warranty));

#line default
#line hidden
            EndContext();
            BeginContext(1771, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1812, 46, false);
#line 68 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Warranty));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(1899, 46, false);
#line 71 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Note));

#line default
#line hidden
            EndContext();
            BeginContext(1945, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(1986, 42, false);
#line 74 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Note));

#line default
#line hidden
            EndContext();
            BeginContext(2028, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2069, 48, false);
#line 77 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2117, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2158, 44, false);
#line 80 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2202, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2243, 47, false);
#line 83 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Image));

#line default
#line hidden
            EndContext();
            BeginContext(2290, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2331, 43, false);
#line 86 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Image));

#line default
#line hidden
            EndContext();
            BeginContext(2374, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2415, 59, false);
#line 89 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(2474, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2515, 55, false);
#line 92 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(2570, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2611, 61, false);
#line 95 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Location_LocationID));

#line default
#line hidden
            EndContext();
            BeginContext(2672, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2713, 57, false);
#line 98 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Location_LocationID));

#line default
#line hidden
            EndContext();
            BeginContext(2770, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(2811, 65, false);
#line 101 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(2876, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(2917, 61, false);
#line 104 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(2978, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(3019, 61, false);
#line 107 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Supplier_SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(3080, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(3121, 57, false);
#line 110 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Supplier_SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(3178, 40, true);
            WriteLiteral("\n        </dd>\n        <dt>\n            ");
            EndContext();
            BeginContext(3219, 55, false);
#line 113 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Asset.Model_ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(3274, 40, true);
            WriteLiteral("\n        </dt>\n        <dd>\n            ");
            EndContext();
            BeginContext(3315, 51, false);
#line 116 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Asset.Model_ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(3366, 34, true);
            WriteLiteral("\n        </dd>\n    </dl>\n    \n    ");
            EndContext();
            BeginContext(3400, 208, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c842575aae9480198cc117b72beec60", async() => {
                BeginContext(3420, 9, true);
                WriteLiteral("\n        ");
                EndContext();
                BeginContext(3429, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "509bdc754013433fbf2c4ec519d4b67d", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 121 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Asset.AssetID);

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
                BeginContext(3476, 82, true);
                WriteLiteral("\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\n        ");
                EndContext();
                BeginContext(3558, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58868d5e50924e62ac2cc6dcdd13e7b4", async() => {
                    BeginContext(3580, 12, true);
                    WriteLiteral("Back to List");
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
                BeginContext(3596, 5, true);
                WriteLiteral("\n    ");
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
            BeginContext(3608, 8, true);
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.DeleteModel>)PageContext?.ViewData;
        public tbkk_AC.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
