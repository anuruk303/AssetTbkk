#pragma checksum "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b9fd84da19649ccf709dc8e0c6d54faf54d5b02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.UdateLicense.Pages_UdateLicense_Details), @"mvc.1.0.razor-page", @"/Pages/UdateLicense/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/UdateLicense/Details.cshtml", typeof(tbkk_AC.Pages.UdateLicense.Pages_UdateLicense_Details), null)]
namespace tbkk_AC.Pages.UdateLicense
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b9fd84da19649ccf709dc8e0c6d54faf54d5b02", @"/Pages/UdateLicense/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UdateLicense_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "../Licenses/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(140, 875, true);
            WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-9"">
                <h2>License Detail</h2>
                <div class="" col-md-12 col-lg-12 "">
                    <div class=""card "" style=""margin-top:1%"">
                        <div class=""card-header"" style=""font-weight:bold;color:darkblue;"">
                            Detail
                        </div>
                        <div class=""card-body"">
                            <table class=""table table-user-information"" style=""margin-top:-24%"">
                                <tbody>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td>");
            EndContext();
            BeginContext(1016, 62, false);
#line 25 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(1078, 65, true);
            WriteLiteral(" :</td>\n                                                    <td> ");
            EndContext();
            BeginContext(1144, 58, false);
#line 26 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                    Write(Html.DisplayFor(model => model.Update_License.LicenseName));

#line default
#line hidden
            EndContext();
            BeginContext(1202, 183, true);
            WriteLiteral("</td>\n                                                </div>\n                                                <div class=\"col\">\n                                                    <td>");
            EndContext();
            BeginContext(1386, 64, false);
#line 29 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.SoftewareName));

#line default
#line hidden
            EndContext();
            BeginContext(1450, 64, true);
            WriteLiteral(" :</td>\n                                                    <td>");
            EndContext();
            BeginContext(1515, 60, false);
#line 30 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Update_License.SoftewareName));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 490, true);
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
            BeginContext(2066, 62, false);
#line 39 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.Attachfiles));

#line default
#line hidden
            EndContext();
            BeginContext(2128, 65, true);
            WriteLiteral(" :</td>\n                                                    <td> ");
            EndContext();
            BeginContext(2194, 58, false);
#line 40 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                    Write(Html.DisplayFor(model => model.Update_License.Attachfiles));

#line default
#line hidden
            EndContext();
            BeginContext(2252, 183, true);
            WriteLiteral("</td>\n                                                </div>\n                                                <div class=\"col\">\n                                                    <td>");
            EndContext();
            BeginContext(2436, 59, false);
#line 43 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(2495, 64, true);
            WriteLiteral(" :</td>\n                                                    <td>");
            EndContext();
            BeginContext(2560, 55, false);
#line 44 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Update_License.PONumber));

#line default
#line hidden
            EndContext();
            BeginContext(2615, 491, true);
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
            BeginContext(3107, 68, false);
#line 54 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.License_LicenseID));

#line default
#line hidden
            EndContext();
            BeginContext(3175, 64, true);
            WriteLiteral(" :</td>\n                                                    <td>");
            EndContext();
            BeginContext(3240, 64, false);
#line 55 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Update_License.License_LicenseID));

#line default
#line hidden
            EndContext();
            BeginContext(3304, 2164, true);
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
            WriteLiteral(@"               <td></td>
                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>

                    <div class=""card "" style=""margin-top:-4%"">
                        <div class=""card-header"" style=""font-weight:bold;color:darkblue;"">
                            Model
                        </div>
                        <div class=""card-body"">
                            <table class=""table table-user-information"" style=""margin-top:-16%;margin-bottom:2%"">
                                <tbody>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
             ");
            WriteLiteral("                                       <td>Supplier :</td>\n                                                    <td>\n");
            EndContext();
#line 97 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                         foreach (var item in Model.Supplier)
                                                        {
                                                            if (Model.Update_License.Supplier_SupplierID == item.SupplierID)
                                                            {
                                                                

#line default
#line hidden
            BeginContext(5872, 47, false);
#line 101 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.SupplierName));

#line default
#line hidden
            EndContext();
#line 101 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                                                                                
                                                            }
                                                        }

#line default
#line hidden
            BeginContext(6040, 307, true);
            WriteLiteral(@"                                                    </td>
                                                </div>
                                                <div class=""col"">
                                                    <td>Company :</td>
                                                    <td>
");
            EndContext();
#line 109 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                         foreach (var item in Model.Company)
                                                        {
                                                            if (Model.Update_License.Company_CompanyID == item.CompanyID)
                                                            {
                                                                

#line default
#line hidden
            BeginContext(6747, 46, false);
#line 113 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
            EndContext();
#line 113 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                                                                               
                                                            }
                                                        }

#line default
#line hidden
            BeginContext(6914, 617, true);
            WriteLiteral(@"                                                    </td>
                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
                                                    <td>Department :</td>
                                                    <td>
");
            EndContext();
#line 127 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                         foreach (var item in Model.Department)
                                                        {
                                                            if (Model.Update_License.Department_DepartmentID == item.DepartmentID)
                                                            {
                                                                

#line default
#line hidden
            BeginContext(7943, 49, false);
#line 131 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.DepartmentName));

#line default
#line hidden
            EndContext();
#line 131 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                                                                                  
                                                            }
                                                        }

#line default
#line hidden
            BeginContext(8113, 2143, true);
            WriteLiteral(@"                                                    </td>
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
                                               ");
            WriteLiteral(@"     <td></td>
                                                    <td></td>
                                                </div>
                                            </div>
                                        </div>
                                    </tr>
                                </tbody>
                            </table>
                        </div>
                    </div>

                    <div class=""card "" style=""margin-top:-4%"">
                        <div class=""card-header"" style=""font-weight:bold;color:darkblue;"">
                            Date
                        </div>
                        <div class=""card-body"">
                            <table class=""table table-user-information"" style=""margin-top:-16%;margin-bottom:-3%"">
                                <tbody>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                           ");
            WriteLiteral("                     <div class=\"col\">\n                                                    <td>");
            EndContext();
            BeginContext(10257, 62, false);
#line 174 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.InstallDate));

#line default
#line hidden
            EndContext();
            BeginContext(10319, 64, true);
            WriteLiteral(" :</td>\n                                                    <td>");
            EndContext();
            BeginContext(10384, 58, false);
#line 175 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Update_License.InstallDate));

#line default
#line hidden
            EndContext();
            BeginContext(10442, 184, true);
            WriteLiteral("</td>\n\n                                                </div>\n                                                <div class=\"col\">\n                                                    <td>");
            EndContext();
            BeginContext(10627, 63, false);
#line 179 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(10690, 64, true);
            WriteLiteral(" :</td>\n                                                    <td>");
            EndContext();
            BeginContext(10755, 59, false);
#line 180 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Update_License.PurchaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(10814, 491, true);
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
            BeginContext(11306, 61, false);
#line 190 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(11367, 64, true);
            WriteLiteral(" :</td>\n                                                    <td>");
            EndContext();
            BeginContext(11432, 57, false);
#line 191 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Update_License.ExpireDate));

#line default
#line hidden
            EndContext();
            BeginContext(11489, 2091, true);
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
                    <div class=""card "" style=""margin-top:-0%"">
                        <div class=""card-header"" style=""font-weight:bold;color:darkblue;"">
                            More
                        </div>
                        <div class=""card-body"">
                            <table class=""table table-user-information"" style=""margin-top:-12%;margin-bottom:-3%"">
                                <tbody>
                                    <tr>
                                        <div class=""card-body"">
                                            <div class=""row"">
                                                <div class=""col"">
             ");
            WriteLiteral("                                       <td>");
            EndContext();
            BeginContext(13581, 57, false);
#line 231 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.Status));

#line default
#line hidden
            EndContext();
            BeginContext(13638, 64, true);
            WriteLiteral(" :</td>\n                                                    <td>");
            EndContext();
            BeginContext(13703, 53, false);
#line 232 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Update_License.Status));

#line default
#line hidden
            EndContext();
            BeginContext(13756, 183, true);
            WriteLiteral("</td>\n                                                </div>\n                                                <div class=\"col\">\n                                                    <td>");
            EndContext();
            BeginContext(13940, 55, false);
#line 235 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.Note));

#line default
#line hidden
            EndContext();
            BeginContext(13995, 289, true);
            WriteLiteral(@" :</td>
                                                    <td>
                                                        <div class=""form-group"">
                                                            <textarea class=""form-control"" id=""exampleFormControlTextarea3"" rows=""5"" cols='20'>");
            EndContext();
            BeginContext(14285, 51, false);
#line 238 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                                                                                                          Write(Html.DisplayFor(model => model.Update_License.Note));

#line default
#line hidden
            EndContext();
            BeginContext(14336, 2047, true);
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
                                     ");
            WriteLiteral(@"       </div>
                                        </div>
                                    </tr>
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
#line 278 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                         foreach (var item in Model.Employee)
                                                        {
                                                            if (Model.Update_License.Employee == item.EmployeeID)
                                                            {
                                                                

#line default
#line hidden
            BeginContext(16776, 44, false);
#line 282 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
#line 282 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                                                                             
                                                            }
                                                        }

#line default
#line hidden
            BeginContext(16941, 235, true);
            WriteLiteral("                                                    </td>\n                                                </div>\n                                                <div class=\"col\">\n                                                    <td>");
            EndContext();
            BeginContext(17177, 55, false);
#line 288 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayNameFor(model => model.Update_License.Date));

#line default
#line hidden
            EndContext();
            BeginContext(17232, 64, true);
            WriteLiteral(" :</td>\n                                                    <td>");
            EndContext();
            BeginContext(17297, 51, false);
#line 289 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.Update_License.Date));

#line default
#line hidden
            EndContext();
            BeginContext(17348, 1220, true);
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
                        ");
            WriteLiteral("        </tbody>\n                            </table>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n\n        <div>\n            ");
            EndContext();
            BeginContext(18568, 105, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c78066fb664c41bd8972712ba9c65568", async() => {
                BeginContext(18657, 12, true);
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
#line 319 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\UdateLicense\Details.cshtml"
                                                WriteLiteral(Model.Update_License.License_LicenseID);

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
            BeginContext(18673, 31, true);
            WriteLiteral("\n        </div>\n        </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.UdateLicense.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.UdateLicense.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.UdateLicense.DetailsModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.UdateLicense.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
