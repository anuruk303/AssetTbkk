#pragma checksum "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ca8191bd723347cbf97916ebdde0c2a539b9003"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.UpdateNetworks.Pages_UpdateNetworks_Details), @"mvc.1.0.razor-page", @"/Pages/UpdateNetworks/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/UpdateNetworks/Details.cshtml", typeof(tbkk_AC.Pages.UpdateNetworks.Pages_UpdateNetworks_Details), null)]
namespace tbkk_AC.Pages.UpdateNetworks
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca8191bd723347cbf97916ebdde0c2a539b9003", @"/Pages/UpdateNetworks/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UpdateNetworks_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Networks/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(6, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 5 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(143, 824, true);
            WriteLiteral(@"<div class=""container"">
    <div class=""row"">
        <div class=""col-md-9"">
            <h2>Network Detail</h2>
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
            BeginContext(968, 68, false);
#line 25 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Update_Network.Network_NetworkID));

#line default
#line hidden
            EndContext();
            BeginContext(1036, 60, true);
            WriteLiteral(" :</td>\n                                                <td>");
            EndContext();
            BeginContext(1097, 64, false);
#line 26 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                               Write(Html.DisplayFor(model => model.Update_Network.Network_NetworkID));

#line default
#line hidden
            EndContext();
            BeginContext(1161, 171, true);
            WriteLiteral("</td>\n                                            </div>\n                                            <div class=\"col\">\n                                                <td>");
            EndContext();
            BeginContext(1333, 62, false);
#line 29 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Update_Network.NetworkName));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 60, true);
            WriteLiteral(" :</td>\n                                                <td>");
            EndContext();
            BeginContext(1456, 58, false);
#line 30 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                               Write(Html.DisplayFor(model => model.Update_Network.NetworkName));

#line default
#line hidden
            EndContext();
            BeginContext(1514, 454, true);
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
            BeginContext(1969, 57, false);
#line 39 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Update_Network.IpAddr));

#line default
#line hidden
            EndContext();
            BeginContext(2026, 60, true);
            WriteLiteral(" :</td>\n                                                <td>");
            EndContext();
            BeginContext(2087, 53, false);
#line 40 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                               Write(Html.DisplayFor(model => model.Update_Network.IpAddr));

#line default
#line hidden
            EndContext();
            BeginContext(2140, 172, true);
            WriteLiteral("</td>\n\n                                            </div>\n                                            <div class=\"col\">\n                                                <td>");
            EndContext();
            BeginContext(2313, 59, false);
#line 44 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Update_Network.Password));

#line default
#line hidden
            EndContext();
            BeginContext(2372, 60, true);
            WriteLiteral(" :</td>\n                                                <td>");
            EndContext();
            BeginContext(2433, 55, false);
#line 45 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                               Write(Html.DisplayFor(model => model.Update_Network.Password));

#line default
#line hidden
            EndContext();
            BeginContext(2488, 454, true);
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
            BeginContext(2943, 57, false);
#line 54 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Update_Network.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3000, 60, true);
            WriteLiteral(" :</td>\n                                                <td>");
            EndContext();
            BeginContext(3061, 53, false);
#line 55 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                               Write(Html.DisplayFor(model => model.Update_Network.Status));

#line default
#line hidden
            EndContext();
            BeginContext(3114, 172, true);
            WriteLiteral("</td>\n\n                                            </div>\n                                            <div class=\"col\">\n                                                <td>");
            EndContext();
            BeginContext(3287, 55, false);
#line 59 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Update_Network.Note));

#line default
#line hidden
            EndContext();
            BeginContext(3342, 277, true);
            WriteLiteral(@" :</td>
                                                <td>
                                                    <div class=""form-group"">
                                                        <textarea class=""form-control"" id=""exampleFormControlTextarea3"" rows=""5"" cols='20'>");
            EndContext();
            BeginContext(3620, 51, false);
#line 62 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                                                                                                                      Write(Html.DisplayFor(model => model.Update_Network.Note));

#line default
#line hidden
            EndContext();
            BeginContext(3671, 1898, true);
            WriteLiteral(@"</textarea>
                                                    </div>
                                                </td>
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
                                                <td></td>
                                            </div>
                                        </div>
                                    </div>
                ");
            WriteLiteral(@"                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
                <div class=""card "" style=""margin-top:0%"">
                    <div class=""card-header"" style=""font-weight:bold;color:darkblue;"">
                        Update
                    </div>
                    <div class=""card-body"">
                        <table class=""table table-user-information"" style=""margin-top:-10%;margin-bottom:-3%"">
                            <tbody>
                                <tr>
                                    <div class=""card-body"">
                                        <div class=""row"">
                                            <div class=""col"">
                                                <td>Employee :</td>
                                                <td>
");
            EndContext();
#line 101 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                                     foreach (var item in Model.Employee)
                                                    {
                                                        if (Model.Update_Network.Employee_EmpID == item.EmployeeID)
                                                        {
                                                            

#line default
#line hidden
            BeginContext(5948, 44, false);
#line 105 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
#line 105 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                                                                                         
                                                        }
                                                    }

#line default
#line hidden
            BeginContext(6105, 219, true);
            WriteLiteral("                                                </td>\n                                            </div>\n                                            <div class=\"col\">\n                                                <td>");
            EndContext();
            BeginContext(6325, 55, false);
#line 111 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Update_Network.Date));

#line default
#line hidden
            EndContext();
            BeginContext(6380, 60, true);
            WriteLiteral(" :</td>\n                                                <td>");
            EndContext();
            BeginContext(6441, 51, false);
#line 112 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                               Write(Html.DisplayFor(model => model.Update_Network.Date));

#line default
#line hidden
            EndContext();
            BeginContext(6492, 1112, true);
            WriteLiteral(@"</td>

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
                                                <td></td>
                                            </div>
                                        </div>
                                    </div>
                                </tr>
                            </tbody>
                        </table>
                    </div>");
            WriteLiteral("\n                </div>\n            </div>\n\n        </div>\n    </div>\n    <div>\n        ");
            EndContext();
            BeginContext(7604, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e568729e9668483db84b90ad17e4f423", async() => {
                BeginContext(7693, 12, true);
                WriteLiteral("Back to List");
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
#line 142 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UpdateNetworks\Details.cshtml"
                                            WriteLiteral(Model.Update_Network.Network_NetworkID);

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
            BeginContext(7709, 19, true);
            WriteLiteral(" \n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.UpdateNetworks.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.UpdateNetworks.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.UpdateNetworks.DetailsModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.UpdateNetworks.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
