#pragma checksum "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ff5fbdda7dbf0d68821b8cafaec3be6b8515d3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Home.Pages_Home_Index), @"mvc.1.0.razor-page", @"/Pages/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Home/Index.cshtml", typeof(tbkk_AC.Pages.Home.Pages_Home_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ff5fbdda7dbf0d68821b8cafaec3be6b8515d3c", @"/Pages/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Home_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(117, 25, true);
            WriteLiteral("\n<h2>Index</h2>\n\n<p>\n    ");
            EndContext();
            BeginContext(142, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03f53c070d1b4494baaee852cefc08a5", async() => {
                BeginContext(163, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(177, 86, true);
            WriteLiteral("\n</p>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(264, 54, false);
#line 18 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].AssetName));

#line default
#line hidden
            EndContext();
            BeginContext(318, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(371, 57, false);
#line 21 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].SerailNumber));

#line default
#line hidden
            EndContext();
            BeginContext(428, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(481, 52, false);
#line 24 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].MACAddr));

#line default
#line hidden
            EndContext();
            BeginContext(533, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(586, 56, false);
#line 27 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].InstallDate));

#line default
#line hidden
            EndContext();
            BeginContext(642, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(695, 57, false);
#line 30 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(752, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(805, 55, false);
#line 33 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(860, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(913, 53, false);
#line 36 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(966, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1019, 50, false);
#line 39 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(1069, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1122, 53, false);
#line 42 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Warranty));

#line default
#line hidden
            EndContext();
            BeginContext(1175, 65, true);
            WriteLiteral("\n            </th>\n            \n            <th>\n                ");
            EndContext();
            BeginContext(1241, 49, false);
#line 46 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Note));

#line default
#line hidden
            EndContext();
            BeginContext(1290, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1343, 51, false);
#line 49 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Status));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1447, 50, false);
#line 52 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Image));

#line default
#line hidden
            EndContext();
            BeginContext(1497, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1550, 62, false);
#line 55 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(1612, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1665, 64, false);
#line 58 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Location_LocationID));

#line default
#line hidden
            EndContext();
            BeginContext(1729, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1782, 68, false);
#line 61 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(1850, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(1903, 64, false);
#line 64 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Supplier_SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(1967, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(2020, 58, false);
#line 67 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Asset[0].Model_ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(2078, 80, true);
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 73 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
 foreach (var item in Model.Asset) {

#line default
#line hidden
            BeginContext(2195, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(2242, 44, false);
#line 76 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AssetName));

#line default
#line hidden
            EndContext();
            BeginContext(2286, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2339, 47, false);
#line 79 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.SerailNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2386, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2439, 42, false);
#line 82 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MACAddr));

#line default
#line hidden
            EndContext();
            BeginContext(2481, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2534, 46, false);
#line 85 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.InstallDate));

#line default
#line hidden
            EndContext();
            BeginContext(2580, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2633, 47, false);
#line 88 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(2680, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2733, 45, false);
#line 91 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(2778, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2831, 43, false);
#line 94 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(2874, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(2927, 40, false);
#line 97 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(2967, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3020, 43, false);
#line 100 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Warranty));

#line default
#line hidden
            EndContext();
            BeginContext(3063, 65, true);
            WriteLiteral("\n            </td>\n            \n            <td>\n                ");
            EndContext();
            BeginContext(3129, 39, false);
#line 104 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Note));

#line default
#line hidden
            EndContext();
            BeginContext(3168, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3221, 41, false);
#line 107 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3262, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3315, 40, false);
#line 110 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Image));

#line default
#line hidden
            EndContext();
            BeginContext(3355, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3408, 52, false);
#line 113 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Company_CompanyID));

#line default
#line hidden
            EndContext();
            BeginContext(3460, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3513, 54, false);
#line 116 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Location_LocationID));

#line default
#line hidden
            EndContext();
            BeginContext(3567, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3620, 58, false);
#line 119 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Department_DepartmentID));

#line default
#line hidden
            EndContext();
            BeginContext(3678, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3731, 54, false);
#line 122 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Supplier_SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(3785, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3838, 48, false);
#line 125 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Model_ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(3886, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(3938, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e648dedd11b24a2fbc7238a6a4966e1a", async() => {
                BeginContext(3988, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 128 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
                                       WriteLiteral(item.AssetID);

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
            BeginContext(3996, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(4015, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2eb52031a8f54109ac764af5f8b6d7b3", async() => {
                BeginContext(4068, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 129 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
                                          WriteLiteral(item.AssetID);

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
            BeginContext(4079, 19, true);
            WriteLiteral(" |\n                ");
            EndContext();
            BeginContext(4098, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c88d905224f45d79e96cefeed27c6fa", async() => {
                BeginContext(4150, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 130 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
                                         WriteLiteral(item.AssetID);

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
            BeginContext(4160, 33, true);
            WriteLiteral("\n            </td>\n        </tr>\n");
            EndContext();
#line 133 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Home\Index.cshtml"
}

#line default
#line hidden
            BeginContext(4195, 22, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.IndexModel>)PageContext?.ViewData;
        public tbkk_AC.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
