#pragma checksum "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Models\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "569887ddb5cc9f9d2b9db402c46f9c21752ede40"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Models.Pages_Models_Details), @"mvc.1.0.razor-page", @"/Pages/Models/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Models/Details.cshtml", typeof(tbkk_AC.Pages.Models.Pages_Models_Details), null)]
namespace tbkk_AC.Pages.Models
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"569887ddb5cc9f9d2b9db402c46f9c21752ede40", @"/Pages/Models/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Models_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Models\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(88, 890, true);
            WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-9"">
                <h2>Model Detail</h2>
                <div class="" col-md-12 col-lg-12 "">
                    <div class=""card "" style=""margin-top:1%"">
                        <div class=""card-header"" style=""font-weight:bold;color:darkblue;"">
                            Detail
                        </div>
                        <div class=""card-body"">
                            <table class=""table table-user-information"" style=""margin-top:-21%;margin-bottom:-6%"">
                                <tbody>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td>");
            EndContext();
            BeginContext(979, 49, false);
#line 23 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Models\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Model.ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(1028, 64, true);
            WriteLiteral(" :</td>\n                                                    <td>");
            EndContext();
            BeginContext(1093, 45, false);
#line 24 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Models\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Model.ModelID));

#line default
#line hidden
            EndContext();
            BeginContext(1138, 183, true);
            WriteLiteral("</td>\n                                                </div>\n                                                <div class=\"col\">\n                                                    <td>");
            EndContext();
            BeginContext(1322, 51, false);
#line 27 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Models\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Model.ModelName));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 64, true);
            WriteLiteral(" :</td>\n                                                    <td>");
            EndContext();
            BeginContext(1438, 47, false);
#line 28 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Models\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Model.ModelName));

#line default
#line hidden
            EndContext();
            BeginContext(1485, 490, true);
            WriteLiteral(@"</td>
                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td>");
            EndContext();
            BeginContext(1976, 47, false);
#line 37 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Models\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Model.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(2023, 64, true);
            WriteLiteral(" :</td>\n                                                    <td>");
            EndContext();
            BeginContext(2088, 53, false);
#line 38 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Models\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Model.Brand.BrandName));

#line default
#line hidden
            EndContext();
            BeginContext(2141, 260, true);
            WriteLiteral(@"</td>

                                                </div>
                                                <div class=""col"">
                                                    <div class=""col"">
                                                        <td>");
            EndContext();
            BeginContext(2402, 48, false);
#line 43 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Models\Details.cshtml"
                                                       Write(Html.DisplayNameFor(model => model.Model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2450, 69, true);
            WriteLiteral(" :</td>\r\n                                                        <td>");
            EndContext();
            BeginContext(2520, 44, false);
#line 44 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Models\Details.cshtml"
                                                       Write(Html.DisplayFor(model => model.Model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2564, 557, true);
            WriteLiteral(@"</td>

                                                    </div>

                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td>");
            EndContext();
            BeginContext(3122, 46, false);
#line 56 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Models\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Model.Note));

#line default
#line hidden
            EndContext();
            BeginContext(3168, 292, true);
            WriteLiteral(@" :</td>
                                                    <td>
                                                        <div class=""form-group"">
                                                            <textarea class=""form-control"" id=""exampleFormControlTextarea3"" rows=""5"" cols='20'>");
            EndContext();
            BeginContext(3461, 42, false);
#line 59 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Models\Details.cshtml"
                                                                                                                                          Write(Html.DisplayFor(model => model.Model.Note));

#line default
#line hidden
            EndContext();
            BeginContext(3503, 1644, true);
            WriteLiteral(@"</textarea>
                                                        </div>
                                                    </td>
                                                </div>
                                                <div class=""col"">
                                                    <td></td>
                                                    <td></td>
                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td></td>
                                                    <td></td>

                                                </div>
                              ");
            WriteLiteral(@"                  <div class=""col"">
                                                    <td></td>
                                                    <td></td>
                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div style=""margin-top:2%;margin-left:1.5%"">



            ");
            EndContext();
            BeginContext(5147, 167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2173f9ad8354e9583810f1555919d77", async() => {
                BeginContext(5169, 141, true);
                WriteLiteral("\r\n                <button type=\"button\" class=\"btn btn-outline-secondary\">\r\n                    Back\r\n                </button>\r\n            ");
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
            BeginContext(5314, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(5328, 200, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39c1d514e5a5475ca14551a5057168f3", async() => {
                BeginContext(5385, 139, true);
                WriteLiteral("\r\n                <button type=\"button\" class=\"btn btn-outline-warning\">\r\n                    Edit\r\n                </button>\r\n            ");
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
#line 101 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Models\Details.cshtml"
                                   WriteLiteral(Model.Model.ModelID);

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
            BeginContext(5528, 29, true);
            WriteLiteral("\r\n        </div>\n    </div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.Models.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Models.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Models.DetailsModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.Models.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
