#pragma checksum "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bbdbeca3e636e0356785ca7b07c70b13b518acb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Suppliers.Pages_Suppliers_Index), @"mvc.1.0.razor-page", @"/Pages/Suppliers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Suppliers/Index.cshtml", typeof(tbkk_AC.Pages.Suppliers.Pages_Suppliers_Index), null)]
namespace tbkk_AC.Pages.Suppliers
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bbdbeca3e636e0356785ca7b07c70b13b518acb", @"/Pages/Suppliers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Suppliers_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(93, 349, true);
            WriteLiteral(@"
<div id=""content-wrapper"">
    <div class=""container-fluid"">
        <!-- Breadcrumbs-->


        <div class=""card mb-3"">
            <div class=""card-header"">
                <div class=""dataTable_length"">
                    <i class=""fas fa-table"">Suppliers</i>
                    <div style=""float: right"">
                        ");
            EndContext();
            BeginContext(442, 211, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdda3db72cd54c47921f627f50fda162", async() => {
                BeginContext(463, 186, true);
                WriteLiteral("\r\n                            <button type=\"button\" class=\"btn btn-outline-info\">\r\n                                Create\r\n                            </button>\r\n                        ");
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
            BeginContext(653, 387, true);
            WriteLiteral(@"
                        <!--<a class=""btn btn-info"" asp-page=""Create"">Create New</a>-->
                        <button class=""btn btn-outline-success"" type=""button"" data-toggle=""collapse"" data-target=""#multiCollapseExample2"" aria-expanded=""false"" aria-controls=""multiCollapseExample2"">Import data</button>
                    </div>
                </div>
        </div>
        ");
            EndContext();
            BeginContext(1040, 829, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "faff7294a40343e38d0b340d4f553b61", async() => {
                BeginContext(1090, 772, true);
                WriteLiteral(@"
            <div class=""collapse multi-collapse"" id=""multiCollapseExample2"" style=""margin-top:1%;margin-left:auto"">
                <div class=""card card-body"" style=""margin-left:70%"">
                    <div class=""input-group"">
                        <div class=""custom-file"">
                            <input type=""file"" class=""custom-file-input"" id=""fUpload"" name=""Excel"">
                            <label class=""custom-file-label"" for=""fUpload""></label>
                        </div>
                        <div class=""input-group-append"">
                            <input class=""btn btn-outline-info"" value=""Upload"" type=""submit"" />
                        </div>
                    </div>
                </div>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1869, 326, true);
            WriteLiteral(@"
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""3"" style=""font-size:small"">
                    <thead>
                        <tr>
                            <th>
                                ");
            EndContext();
            BeginContext(2196, 60, false);
#line 49 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Supplier[0].SupplierName));

#line default
#line hidden
            EndContext();
            BeginContext(2256, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(2360, 59, false);
#line 52 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Supplier[0].ContactName));

#line default
#line hidden
            EndContext();
            BeginContext(2419, 105, true);
            WriteLiteral("\r\n                            </th>\r\n\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(2525, 53, false);
#line 56 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Supplier[0].Email));

#line default
#line hidden
            EndContext();
            BeginContext(2578, 173, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>Actions</th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 62 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                         foreach (var item in Model.Supplier)
                        {
                            if (item.Status.Equals("Using"))
                            {

#line default
#line hidden
            BeginContext(2934, 80, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n");
            EndContext();
#line 68 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                                         if (!item.SupplierName.Equals(""))
                                        {
                                            

#line default
#line hidden
            BeginContext(3179, 47, false);
#line 70 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.SupplierName));

#line default
#line hidden
            EndContext();
#line 70 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                                                                                            
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
            BeginContext(3410, 15, true);
            WriteLiteral("No SupplierName");
            EndContext();
#line 74 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                                                                        
                                        }

#line default
#line hidden
            BeginContext(3477, 129, true);
            WriteLiteral("                                        \r\n                                    </td>\r\n\r\n                                    <td>\r\n");
            EndContext();
#line 80 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                                         if (!item.ContactName.Equals(""))
                                        {
                                            

#line default
#line hidden
            BeginContext(3770, 46, false);
#line 82 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.ContactName));

#line default
#line hidden
            EndContext();
#line 82 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                                                                                           
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
            BeginContext(4000, 14, true);
            WriteLiteral("No ContactName");
            EndContext();
#line 86 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                                                                       
                                        }

#line default
#line hidden
            BeginContext(4066, 85, true);
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n");
            EndContext();
#line 90 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                                         if (!item.Email.Equals(""))
                                        {
                                            

#line default
#line hidden
            BeginContext(4309, 40, false);
#line 92 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
#line 92 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                                                                                     
                                        }
                                        else
                                        {
                                            

#line default
#line hidden
            BeginContext(4533, 8, true);
            WriteLiteral("No Email");
            EndContext();
#line 96 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                                                                 
                                        }

#line default
#line hidden
            BeginContext(4593, 178, true);
            WriteLiteral("                                       \r\n                                    </td>\r\n                                    <td width=\"20%\">\r\n                                        ");
            EndContext();
            BeginContext(4771, 316, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a40b0f4fa9d4c28aaa89bfe15299b68", async() => {
                BeginContext(4827, 256, true);
                WriteLiteral(@"

                                            <button type=""button"" class=""btn btn-outline-primary"">
                                                Deatail
                                            </button>
                                        ");
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
#line 101 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                                                                  WriteLiteral(item.SupplierID);

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
            BeginContext(5087, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(5129, 310, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "32910e8f582a4d5eba7e56f44312743e", async() => {
                BeginContext(5182, 253, true);
                WriteLiteral("\r\n                                            <button type=\"button\" class=\"btn btn-outline-warning\">\r\n                                                Edit\r\n\r\n                                            </button>\r\n                                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 107 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                                                               WriteLiteral(item.SupplierID);

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
            BeginContext(5439, 141, true);
            WriteLiteral("\r\n                                        <button type=\"button\" class=\"btn btn-outline-danger\" data-toggle=\"modal\" data-target=\"#deleteModal\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5580, "\"", 5614, 3);
            WriteAttributeValue("", 5590, "Delete(", 5590, 7, true);
#line 113 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
WriteAttributeValue("", 5597, item.SupplierID, 5597, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 5613, ")", 5613, 1, true);
            EndWriteAttribute();
            BeginContext(5615, 100, true);
            WriteLiteral(">Delete</button>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 116 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(5773, 112, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(5885, 1065, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6db775af4d86468e89074946c95a23f8", async() => {
                BeginContext(5935, 608, true);
                WriteLiteral(@"
    <div class=""modal"" tabindex=""-1"" role=""dialog"" id=""deleteModal"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Delete</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <p>Are you sure?</p>
                </div>
                ");
                EndContext();
                BeginContext(6543, 27, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4dd0583586184cfe8fab0ad8f01cf05e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 137 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Suppliers\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Deletid);

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
                BeginContext(6570, 66, true);
                WriteLiteral("\r\n                <div class=\"modal-footer\">\r\n                    ");
                EndContext();
                BeginContext(6636, 120, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f6d3271fa7e349f0a004d62db7338f08", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6756, 187, true);
                WriteLiteral("\r\n                    <button type=\"button\" class=\"btn btn-outline-secondary\" data-dismiss=\"modal\">Close</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6950, 116, true);
            WriteLiteral("\r\n\r\n\r\n<script>\r\n    function Delete(id) {\r\n        document.getElementById(\"Deletid\").value = id\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<tbkk_AC.Pages.Suppliers.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Suppliers.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<tbkk_AC.Pages.Suppliers.IndexModel>)PageContext?.ViewData;
        public tbkk_AC.Pages.Suppliers.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
