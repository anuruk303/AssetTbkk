#pragma checksum "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Brands\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99224f06022b9fea5be4270f6bed56d60da7a2a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Brands.Pages_Brands_Details), @"mvc.1.0.razor-page", @"/Pages/Brands/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Brands/Details.cshtml", typeof(tbkk_AC.Pages.Brands.Pages_Brands_Details), null)]
namespace tbkk_AC.Pages.Brands
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99224f06022b9fea5be4270f6bed56d60da7a2a6", @"/Pages/Brands/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Brands_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("220px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Brands\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(88, 890, true);
            WriteLiteral(@"    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-9"">
                <h2>Brand Detail</h2>
                <div class="" col-md-12 col-lg-12 "">
                    <div class=""card "" style=""margin-top:1%"">
                        <div class=""card-header"" style=""font-weight:bold;color:darkblue;"">
                            Detail
                        </div>
                        <div class=""card-body"">
                            <table class=""table table-user-information"" style=""margin-top:-16%;margin-bottom:-6%"">
                                <tbody>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td>");
            EndContext();
            BeginContext(979, 49, false);
#line 23 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Brands\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Brand.BrandID));

#line default
#line hidden
            EndContext();
            BeginContext(1028, 64, true);
            WriteLiteral(" :</td>\n                                                    <td>");
            EndContext();
            BeginContext(1093, 45, false);
#line 24 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Brands\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Brand.BrandID));

#line default
#line hidden
            EndContext();
            BeginContext(1138, 183, true);
            WriteLiteral("</td>\n                                                </div>\n                                                <div class=\"col\">\n                                                    <td>");
            EndContext();
            BeginContext(1322, 51, false);
#line 27 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Brands\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Brand.BrandName));

#line default
#line hidden
            EndContext();
            BeginContext(1373, 64, true);
            WriteLiteral(" :</td>\n                                                    <td>");
            EndContext();
            BeginContext(1438, 47, false);
#line 28 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Brands\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Brand.BrandName));

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
            BeginContext(1976, 48, false);
#line 37 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Brands\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Brand.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2024, 64, true);
            WriteLiteral(" :</td>\n                                                    <td>");
            EndContext();
            BeginContext(2089, 44, false);
#line 38 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Brands\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Brand.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2133, 1591, true);
            WriteLiteral(@"</td>

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
                                                <div class=""col"">
                                                    <td></td>
                                    ");
            WriteLiteral(@"                <td></td>
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
            <div class=""col-md-3"">
                <h2></h2>
                <div class=""col-md-3 col-lg-3 "" align=""center"" style=""margin-top:15%"">
                    ");
            EndContext();
            BeginContext(3724, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2bd832672e894d27a03e4a1588d4ecca", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3734, "~/uploads/", 3734, 10, true);
#line 72 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Brands\Details.cshtml"
AddHtmlAttributeValue("", 3744, Html.DisplayFor(model => model.Brand.Image), 3744, 44, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(3821, 84, true);
            WriteLiteral("\n                </div>\n            </div>\n        </div>\n        <div>\n            ");
            EndContext();
            BeginContext(3905, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d2a1073dd9f44bca6dc24c5ea24372c", async() => {
                BeginContext(3962, 4, true);
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
#line 77 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Brands\Details.cshtml"
                                   WriteLiteral(Model.Brand.BrandID);

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
            BeginContext(3970, 15, true);
            WriteLiteral(" |\n            ");
            EndContext();
            BeginContext(3985, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b580d78b3ad4137ade353371de75b25", async() => {
                BeginContext(4007, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4023, 16, true);
            WriteLiteral("\n        </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.Brands.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Brands.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Brands.DetailsModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.Brands.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
