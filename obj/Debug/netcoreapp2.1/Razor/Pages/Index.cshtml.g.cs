#pragma checksum "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5795c84bdf2d91dee26e39d7fd9de8d2ed03743"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(tbkk_AC.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(tbkk_AC.Pages.Pages_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5795c84bdf2d91dee26e39d7fd9de8d2ed03743", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69d77135ec122947e94bf66dec5647f0745c94b6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(66, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 7 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(105, 577, true);
            WriteLiteral(@"
<div id=""content-wrapper"">
    <div class=""container-fluid"">

        <div class=""row"">
            <div class=""col-xl-3 col-md-6 mb-4"">
                <div class=""card border-left-primary shadow h-100 py-2"">
                    <div class=""card-body"">
                        <div class=""row no-gutters align-items-center"">
                            <div class=""col mr-2"">
                                <div class=""text-xs font-weight-bold text-primary text-uppercase mb-1"">Asset</div>
                                <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
            EndContext();
            BeginContext(683, 15, false);
#line 21 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                                                                               Write(Model.Asset_All);

#line default
#line hidden
            EndContext();
            BeginContext(698, 853, true);
            WriteLiteral(@"</div>
                            </div>
                            <div class=""col-auto"">
                                <i class=""fas fa-boxes fa-2x text-gray-300 ""></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Earnings (Monthly) Card Example -->
            <div class=""col-xl-3 col-md-6 mb-4"">
                <div class=""card border-left-success shadow h-100 py-2"">
                    <div class=""card-body"">
                        <div class=""row no-gutters align-items-center"">
                            <div class=""col mr-2"">
                                <div class=""text-xs font-weight-bold text-success text-uppercase mb-1"">License</div>
                                <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
            EndContext();
            BeginContext(1552, 17, false);
#line 37 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                                                                               Write(Model.License_All);

#line default
#line hidden
            EndContext();
            BeginContext(1569, 995, true);
            WriteLiteral(@"</div>
                            </div>
                            <div class=""col-auto"">
                                <i class=""fas fa-atlas fa-2x text-gray-300""></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Earnings (Monthly) Card Example -->
            <div class=""col-xl-3 col-md-6 mb-4"">
                <div class=""card border-left-info shadow h-100 py-2"">
                    <div class=""card-body"">
                        <div class=""row no-gutters align-items-center"">
                            <div class=""col mr-2"">
                                <div class=""text-xs font-weight-bold text-info text-uppercase mb-1"">Employee</div>
                                <div class=""row no-gutters align-items-center"">
                                    <div class=""col-auto"">
                                        <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
            EndContext();
            BeginContext(2565, 18, false);
#line 56 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                                                                                       Write(Model.Employee_All);

#line default
#line hidden
            EndContext();
            BeginContext(2583, 940, true);
            WriteLiteral(@"</div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-auto"">
                                <i class=""fas fa-address-card fa-2x text-gray-300""></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <!-- Pending Requests Card Example -->
            <div class=""col-xl-3 col-md-6 mb-4"">
                <div class=""card border-left-warning shadow h-100 py-2"">
                    <div class=""card-body"">
                        <div class=""row no-gutters align-items-center"">
                            <div class=""col mr-2"">
                                <div class=""text-xs font-weight-bold text-warning text-uppercase mb-1"">Network</div>
                                <div class=""h5 mb-0 font-weight-bold text-gray-800"">");
            EndContext();
            BeginContext(3524, 17, false);
#line 75 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                                                                               Write(Model.Network_All);

#line default
#line hidden
            EndContext();
            BeginContext(3541, 2130, true);
            WriteLiteral(@"</div>
                            </div>
                            <div class=""col-auto"">
                                <i class=""fas fa-broadcast-tower fa-2x text-gray-300""></i>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
</div>
<!-- Area Chart -->

        <!-- Card Body -->
        <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
            <li class=""nav-item"">
                <a class=""nav-link active"" id=""Asset-tab"" data-toggle=""tab"" href=""#Asset"" role=""tab"" aria-controls=""Asset"" aria-selected=""true"">Asset</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" id=""License-tab"" data-toggle=""tab"" href=""#License"" role=""tab"" aria-controls=""License"" aria-selected=""false"" onclick=""chart1()"">License</a>
            </li>
            <li class=""nav-item"">
                <a class=""nav-link"" id=""Employee-tab"" data-toggle=""tab"" href=""#Employee"" role=""t");
            WriteLiteral(@"ab"" aria-controls=""Employee"" aria-selected=""false""onclick=""chart2()"">Employee</a>
            </li>
        </ul>
        <div class=""tab-content"" id=""myTabContent"">
            <div class=""tab-pane fade show active"" id=""Asset"" role=""tabpanel"" aria-labelledby=""Asset-tab"">

                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-sm-12 col-md-8 col-lg-8"">
                            <div id=""chartContainer"" style=""height: 370px; width: 100%;""></div>
                        </div>
                        <div class=""col-sm-12 col-md-4 col-lg-4"" style=""margin-top: 2%;"">
                            <table class=""table"">
                                <thead >
                                    <tr>
                                        <th scope=""col"">Category</th>
                                        <th scope=""col"">Using</th>
                                        <th scope=""col"">Instock</th>
                                    </tr>
 ");
            WriteLiteral("                               </thead>\r\n                                <tbody>\r\n");
            EndContext();
#line 120 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                                         foreach (var item in Model.status)
                                        {

#line default
#line hidden
            BeginContext(5791, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(5886, 39, false);
#line 123 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(5925, 58, true);
            WriteLiteral(" :</td>\r\n                                            <td >");
            EndContext();
            BeginContext(5984, 40, false);
#line 124 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Using));

#line default
#line hidden
            EndContext();
            BeginContext(6024, 56, true);
            WriteLiteral("</td>\r\n                                            <td >");
            EndContext();
            BeginContext(6081, 42, false);
#line 125 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Instock));

#line default
#line hidden
            EndContext();
            BeginContext(6123, 54, true);
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
            EndContext();
#line 127 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"

                                    }

#line default
#line hidden
            BeginContext(6218, 1123, true);
            WriteLiteral(@"                                    </tbody>
                                </table>
                        </div>

                    </div>
                </div>
            </div>
            <div class=""tab-pane fade"" id=""License"" role=""tabpanel"" aria-labelledby=""License-tab"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-sm-12 col-md-8 col-lg-8"" id=""chartContainer1"" style=""height: 370px; width: 100%;"" align=""center"">
                           
                        </div>
                        <div class=""col-sm-12 col-md-4 col-lg-4"" style=""margin-top: 2%;"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">Supplier</th>
                                        <th scope=""col"">Using</th>
                                        <th scope=""col"">Instock</th>
                           ");
            WriteLiteral("         </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
            EndContext();
#line 152 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                                     foreach (var item in Model.statusLicense)
                                    {

#line default
#line hidden
            BeginContext(7460, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(7555, 39, false);
#line 155 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(7594, 58, true);
            WriteLiteral(" :</td>\r\n                                            <td >");
            EndContext();
            BeginContext(7653, 40, false);
#line 156 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Using));

#line default
#line hidden
            EndContext();
            BeginContext(7693, 56, true);
            WriteLiteral("</td>\r\n                                            <td >");
            EndContext();
            BeginContext(7750, 42, false);
#line 157 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Instock));

#line default
#line hidden
            EndContext();
            BeginContext(7792, 54, true);
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
            EndContext();
#line 159 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"

                                    }

#line default
#line hidden
            BeginContext(7887, 1081, true);
            WriteLiteral(@"                                </tbody>
                            </table>
                           
                        </div>

                    </div>
                </div>
            </div>
            <div class=""tab-pane fade"" id=""Employee"" role=""tabpanel"" aria-labelledby=""Employee-tab"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-sm-8"">
                            <div id=""chartContainer2"" style=""height: 370px; width: 100%;""></div>
                        </div>
                        <div class=""col-sm-4"" style=""margin-top: 2%;"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th scope=""col"">Department</th>
                                        <th scope=""col"">Working</th>
                                        
                                    </tr>
                          ");
            WriteLiteral("      </thead>\r\n                                <tbody>\r\n");
            EndContext();
#line 185 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                                     foreach (var item in Model.statusEmployee)
                                    {

#line default
#line hidden
            BeginContext(9088, 94, true);
            WriteLiteral("                                        <tr>\r\n                                            <td>");
            EndContext();
            BeginContext(9183, 39, false);
#line 188 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(9222, 72, true);
            WriteLiteral(" :</td>\r\n                                            <td align=\"center\">");
            EndContext();
            BeginContext(9295, 40, false);
#line 189 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                                                          Write(Html.DisplayFor(modelItem => item.Using));

#line default
#line hidden
            EndContext();
            BeginContext(9335, 56, true);
            WriteLiteral("</td>\r\n\r\n                                        </tr>\r\n");
            EndContext();
#line 192 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"

                                    }

#line default
#line hidden
            BeginContext(9432, 827, true);
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>

                    </div>
                </div>

            </div>
        </div>
 

        <script src=""https://canvasjs.com/assets/script/canvasjs.min.js""></script>
        <script>
    window.onload = function () {
        var chart = new CanvasJS.Chart(""chartContainer"", {
            animationEnabled: true,
            title: {
                text: ""Asset"",
                horizontalAlign: ""left""
            },
            data: [{
                type: ""doughnut"",
                startAngle: 60,
                //innerRadius: 60,
                indexLabelFontSize: 17,
                indexLabel: ""{label} - {y}"",
                toolTipContent: ""<b>{label}:</b> {y} "",
                dataPoints: ");
            EndContext();
            BeginContext(10260, 38, false);
#line 221 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                       Write(Html.Raw(Json.Serialize(Model.chart1)));

#line default
#line hidden
            EndContext();
            BeginContext(10298, 717, true);
            WriteLiteral(@",

            }]
        });
        chart.render();
       
            }
            function chart1() {
                var chart1 = new CanvasJS.Chart(""chartContainer1"", {
                    animationEnabled: true,
                    title: {
                        text: ""License"",
                        horizontalAlign: ""left""
                    },
                    data: [{
                        type: ""doughnut"",
                        startAngle: 60,
                        //innerRadius: 60,
                        indexLabelFontSize: 17,
                        indexLabel: ""{label} - {y}"",
                        toolTipContent: ""<b>{label}:</b> {y} "",
                        dataPoints: ");
            EndContext();
            BeginContext(11016, 38, false);
#line 242 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                               Write(Html.Raw(Json.Serialize(Model.chart2)));

#line default
#line hidden
            EndContext();
            BeginContext(11054, 735, true);
            WriteLiteral(@",

                    }]
                });
                chart1.render();
            }
            function chart2() {
                var chart2 = new CanvasJS.Chart(""chartContainer2"", {
                    animationEnabled: true,
                    title: {
                        text: ""Employee"",
                        horizontalAlign: ""left""
                    },
                    data: [{
                        type: ""doughnut"",
                        startAngle: 60,
                        //innerRadius: 60,
                        indexLabelFontSize: 17,
                        indexLabel: ""{label} - {y}"",
                        toolTipContent: ""<b>{label}:</b> {y} "",
                        dataPoints: ");
            EndContext();
            BeginContext(11790, 38, false);
#line 262 "C:\Users\Anuruk\Desktop\TbkkAsset-master\Pages\Index.cshtml"
                               Write(Html.Raw(Json.Serialize(Model.chart3)));

#line default
#line hidden
            EndContext();
            BeginContext(11828, 112, true);
            WriteLiteral(",\n\n                    }]\n                });\n                chart2.render();\n            }\n\n        </script>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
