#pragma checksum "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b471cf46497e8b17f0950833134465403b2c20b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Pages_Test), @"mvc.1.0.razor-page", @"/Pages/Test.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Test.cshtml", typeof(tbkk_AC.Pages.Pages_Test), null)]
namespace tbkk_AC.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b471cf46497e8b17f0950833134465403b2c20b5", @"/Pages/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Test : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Licenses/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Licenses/Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Assets/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Assets/Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
  
    ViewData["Title"] = "Test";

#line default
#line hidden
            BeginContext(74, 1612, true);
            WriteLiteral(@"
<div id=""content-wrapper"">
    <div class=""container-fluid"">
        <!-- Breadcrumbs-->
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""index.html"">Asset Control</a>
            </li>
            <li class=""breadcrumb-item active"">Managment</li>
            <li class=""breadcrumb-item active"">Expired</li>
        </ol>
        <!-- DataTables Example -->

        <div class=""card mb-3"">
            <div class=""card-header"">
                <div class=""dataTable_length"">
                    <i class=""fas fa-table"">Expired</i>
                </div>
            </div>
            <div class=""card-body"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""3"">
                        <thead>
                            <tr>
                                <th>
                                    ID
                                </th>
                                <th>
");
            WriteLiteral(@"                                    Name
                                </th>
                                <th>
                                    StartDate
                                </th>
                                <th>
                                    ExpireDate
                                </th>
                                <th>
                                    Status
                                </th>
                                <th>Actions</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
#line 49 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                             foreach (var item in Model.License)
                            {
                                if (!item.Status.Equals("Unused"))
                                {
                                    if (item.ExpireDate < DateTime.Now.AddMonths(+1) || item.ExpireDate < DateTime.Now)
                                    {

#line default
#line hidden
            BeginContext(2040, 142, true);
            WriteLiteral("                                        <tr>\n                                            <td>\n                                                ");
            EndContext();
            BeginContext(2183, 44, false);
#line 57 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.LicenseID));

#line default
#line hidden
            EndContext();
            BeginContext(2227, 148, true);
            WriteLiteral("\n                                            </td>\n                                            <td>\n                                                ");
            EndContext();
            BeginContext(2376, 46, false);
#line 60 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(2422, 148, true);
            WriteLiteral("\n                                            </td>\n                                            <td>\n                                                ");
            EndContext();
            BeginContext(2571, 46, false);
#line 63 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.InstallDate));

#line default
#line hidden
            EndContext();
            BeginContext(2617, 148, true);
            WriteLiteral("\n                                            </td>\n                                            <td>\n                                                ");
            EndContext();
            BeginContext(2766, 45, false);
#line 66 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(2811, 101, true);
            WriteLiteral("\n                                            </td>\n\n                                            <td>\n");
            EndContext();
#line 70 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                                 if (item.ExpireDate < DateTime.Now.AddMonths(+1)&&item.ExpireDate > DateTime.Now)
                                                {

#line default
#line hidden
            BeginContext(3093, 221, true);
            WriteLiteral("                                                    <h4>\n                                                        <span class=\"badge badge-warning\">Expiring</span>\n                                                    </h4>\n");
            EndContext();
#line 75 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(3467, 219, true);
            WriteLiteral("                                                    <h4>\n                                                        <span class=\"badge badge-danger\">Expired</span>\n                                                    </h4>\n");
            EndContext();
#line 81 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                                }

#line default
#line hidden
            BeginContext(3736, 161, true);
            WriteLiteral("                                            </td>\n                                            <td width=\"100px\">\n                                                ");
            EndContext();
            BeginContext(3897, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab62ff2ac6964ae79313330bf4a487c7", async() => {
                BeginContext(3958, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 84 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                                                                WriteLiteral(item.LicenseID);

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
            BeginContext(3966, 51, true);
            WriteLiteral(" |\n                                                ");
            EndContext();
            BeginContext(4017, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a731ec2d0e934717843def0d8e885942", async() => {
                BeginContext(4080, 6, true);
                WriteLiteral("Delete");
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
#line 85 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                                                                  WriteLiteral(item.LicenseID);

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
            BeginContext(4090, 97, true);
            WriteLiteral("\n                                            </td>\n                                        </tr>\n");
            EndContext();
#line 88 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                    }
                                }
                            }

#line default
#line hidden
            BeginContext(4289, 28, true);
            WriteLiteral("                            ");
            EndContext();
#line 91 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                             foreach (var item in Model.Asset)
                            {
                                if (!item.Status.Equals("Unused"))
                                {
                                    if (item.ExpireDate < DateTime.Now.AddMonths(+1) || item.ExpireDate < DateTime.Now)
                                    {

#line default
#line hidden
            BeginContext(4641, 142, true);
            WriteLiteral("                                        <tr>\n                                            <td>\n                                                ");
            EndContext();
            BeginContext(4784, 42, false);
#line 99 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.AssetID));

#line default
#line hidden
            EndContext();
            BeginContext(4826, 148, true);
            WriteLiteral("\n                                            </td>\n                                            <td>\n                                                ");
            EndContext();
            BeginContext(4975, 44, false);
#line 102 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.AssetName));

#line default
#line hidden
            EndContext();
            BeginContext(5019, 148, true);
            WriteLiteral("\n                                            </td>\n                                            <td>\n                                                ");
            EndContext();
            BeginContext(5168, 46, false);
#line 105 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.InstallDate));

#line default
#line hidden
            EndContext();
            BeginContext(5214, 148, true);
            WriteLiteral("\n                                            </td>\n                                            <td>\n                                                ");
            EndContext();
            BeginContext(5363, 45, false);
#line 108 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(5408, 100, true);
            WriteLiteral("\n                                            </td>\n                                            <td>\n");
            EndContext();
#line 111 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                                 if (item.ExpireDate < DateTime.Now.AddMonths(+1)&&item.ExpireDate > DateTime.Now)
                                                {

#line default
#line hidden
            BeginContext(5689, 221, true);
            WriteLiteral("                                                    <h4>\n                                                        <span class=\"badge badge-warning\">Expiring</span>\n                                                    </h4>\n");
            EndContext();
#line 116 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
            BeginContext(6063, 219, true);
            WriteLiteral("                                                    <h4>\n                                                        <span class=\"badge badge-danger\">Expired</span>\n                                                    </h4>\n");
            EndContext();
#line 122 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                                }

#line default
#line hidden
            BeginContext(6332, 161, true);
            WriteLiteral("                                            </td>\n                                            <td width=\"100px\">\n                                                ");
            EndContext();
            BeginContext(6493, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b559596f92034e24bcb7e45267ba7826", async() => {
                BeginContext(6550, 4, true);
                WriteLiteral("Edit");
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
#line 125 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
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
            BeginContext(6558, 51, true);
            WriteLiteral(" |\n                                                ");
            EndContext();
            BeginContext(6609, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7623fe91a784eafaf99f10c979e296a", async() => {
                BeginContext(6668, 6, true);
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
#line 126 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
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
            BeginContext(6678, 97, true);
            WriteLiteral("\n                                            </td>\n                                        </tr>\n");
            EndContext();
#line 129 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Test.cshtml"
                                    }
                                }
                            }

#line default
#line hidden
            BeginContext(6877, 130, true);
            WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.TestModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.TestModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.TestModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.TestModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
