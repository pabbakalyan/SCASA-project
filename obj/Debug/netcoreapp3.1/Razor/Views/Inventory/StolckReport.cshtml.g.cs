#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f61195761efcb7474da289512dbfeb56995f525"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventory_StolckReport), @"mvc.1.0.view", @"/Views/Inventory/StolckReport.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\_ViewImports.cshtml"
using SCASA.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f61195761efcb7474da289512dbfeb56995f525", @"/Views/Inventory/StolckReport.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventory_StolckReport : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCASA.Models.ModelClasses.PrintList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Inventory/StolckReport"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
  
    int rCnt = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""header-icon"">
            <i class=""fa fa-dashboard""></i>
        </div>
        <div class=""header-title"">
            <h1>Inventory - Total :  ");
#nullable restore
#line 13 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                Write(Model.Items.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
            <small>Very Detail Inventory.</small>
        </div>
    </section>
    <!-- Main content -->
    <section class=""content"">
        <div class=""row"">
            <div class=""col-lg-12 pinpin"">
                <div class=""card"" data-sortable=""true"">
                    <div class=""card-header"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f61195761efcb7474da289512dbfeb56995f5256488", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-2"">
                                    <div class=""card-title custom_title"">
                                        <h4>Inventory List</h4>
                                    </div>
                                </div>
                                <div class=""col-md-2"">
                                    <div class=""form-group"">
                                        <label>Category</label>
                                        ");
#nullable restore
#line 33 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                   Write(Html.DropDownListFor(x => Model.CategoryId,
                                                new SelectList(new[] {
                                                new {CategoryId = 0,CategoryName = "-- Select Category --" }}
                                                .Union(
                                                    Model.catDrops
                                                    .Select(o => new { CategoryId = o.CategoryId, CategoryName = o.CategoryName })),
                                                    "CategoryId", "CategoryName"), null,
                                                    new { @id = "catDD", @class = "form-control select2", @onchange = "GetSubCats()" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    </div>

                                </div>
                                <div class=""col-md-2"">
                                    <div class=""form-group"">
                                        <label>Sub Category</label>

                                        ");
#nullable restore
#line 48 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                   Write(Html.DropDownListFor(x => Model.SubCategoryId,
                                                new SelectList(new[] {
                                                new {SubCategoryId = 0,SubCategoryName = "-- Select SubCategory --" }}
                                                .Union(
                                                    Model.SubDrops
                                                    .Select(o => new { SubCategoryId = o.SubCategoryId, SubCategoryName = o.SubCategoryName })),
                                                    "SubCategoryId", "SubCategoryName"), null,
                                                    new { @id = "subcatDD", @class = "form-control select2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-md-2"">
                                    <label>Location </label>
                                    <label>Location</label>
                                    <select name=""lId"" class=""form-control select2"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f61195761efcb7474da289512dbfeb56995f5259967", async() => {
                    WriteLiteral("All");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f61195761efcb7474da289512dbfeb56995f52511227", async() => {
                    WriteLiteral("Showroom");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f61195761efcb7474da289512dbfeb56995f52512493", async() => {
                    WriteLiteral("WareHouse");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                    </select>
                                </div>
                                <div clas=""col-md-2"">
                                    <button type=""submit"" class=""btn btn-success serchgaptop"">
                                        Search
                                    </button>
                                </div>
                                <div class=""col-md-2"">
                                    <button class=""btn btn-success serchgaptop"" onclick=""exportExel('xlsx')"">
                                        <span class=""glyphicon glyphicon-download""></span>
                                        Export list
                                    </button>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        
                    </div>
                    <div class=""card-body"">
                        <!-- Plugin content:powerpoint,txt,pdf,png,word,xl -->
                        <!-- Plugin content:powerpoint,txt,pdf,png,word,xl -->
                        <div class=""table-responsive"">
                            <table id=""printTable1"" class=""table table-bordered table-striped table-hover"">
                                <thead class=""back_table_color"">
                                    <tr class=""info"">
                                        <th>#</th>
                                        <th>M.No.</th>
                                        <th>Image</th>
                                        <th>Description</th>
                                        <th>Dimension</th>
                                        <th>Colour</th>
                                        <th>Quantity</th>
                                        <th colspan=""2"" class=""text-center""");
            WriteLiteral(">Location</th>\r\n                                        <th>MRP</th>\r\n                                    </tr>\r\n                                    <tr>\r\n                                        <th colspan=\"7\"></th>\r\n");
            WriteLiteral(@"                                        <th>Warehouse</th>
                                        <th>Showroom</th>
                                        <th colspan=""4""></th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 111 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                     if (Model.Items != null)
                                    {
                                        foreach (var v in Model.Items)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 116 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                                Write(rCnt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>\r\n                                                    <div>\r\n");
            WriteLiteral("                                                        <strong>\r\n                                                            ");
#nullable restore
#line 122 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                                       Write(v.ModelNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </strong>\r\n                                                    </div>\r\n                                                    <div>\r\n                                                        ");
#nullable restore
#line 126 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                                   Write(v.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </div>\r\n                                                    <div style=\"font-style:12px;color:cadetblue\">\r\n                                                        ");
#nullable restore
#line 129 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                                   Write(v.SubCategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </div>\r\n                                                </td>\r\n                                                <td>\r\n");
#nullable restore
#line 133 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                                      
                                                        string[] pImages = v.PrimaryImage.Split(",");
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <img");
            BeginWriteAttribute("src", " src=\"", 8095, "\"", 8152, 2);
            WriteAttributeValue("", 8101, "http://crms.empirehome.in/ProductImages/", 8101, 40, true);
#nullable restore
#line 136 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
WriteAttributeValue("", 8141, pImages[0], 8141, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"150\" height=\"150\">\r\n                                                </td>\r\n                                                <td>\r\n                                                    ");
#nullable restore
#line 139 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                                Write(v.ItemDescription.Length > 100 ? v.ItemDescription.Substring(0,100) : v.ItemDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td>");
#nullable restore
#line 141 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                               Write(v.Height);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Feet x  ");
#nullable restore
#line 141 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                                                 Write(v.Breadth);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Feet x  ");
#nullable restore
#line 141 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                                                                    Write(v.Width);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Feet</td>\r\n                                                <td>\r\n");
#nullable restore
#line 143 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                                      
                                                        string[] cImage = v.ColorImage.Split(",");
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 146 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                                     foreach (var ci in cImage)
                                                    {
                                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 148 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                                   Write(v.ColorName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7f61195761efcb7474da289512dbfeb56995f52523770", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9142, "~/ProductImages/", 9142, 16, true);
#nullable restore
#line 149 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
AddHtmlAttributeValue("", 9158, ci, 9158, 3, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 150 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </td>\r\n                                                <td class=\"text-center\">\r\n                                                    ");
#nullable restore
#line 153 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                               Write(v.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td class=\"text-center\">\r\n                                                    ");
#nullable restore
#line 156 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                               Write(v.WharehouseQty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                                <td class=\"text-center\">");
#nullable restore
#line 158 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                                                   Write(v.ShowroomQty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td width=\"12%;\">\r\n");
#nullable restore
#line 160 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                                      
                                                        System.Globalization.CultureInfo Indian = new System.Globalization.CultureInfo("hi-IN");
                                                        string mrp = String.Format(Indian, "{0:N}", v.ActualPrice);
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    Rs. ");
#nullable restore
#line 164 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                                   Write(mrp);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 167 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Inventory\StolckReport.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class=""card-footer"">
                        
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- /.content -->
</div>
<script type=""text/javascript"" src=""https://unpkg.com/xlsx@0.15.1/dist/xlsx.full.min.js""></script>
<script>
    function exportExel(type, fn, dl) {

        var elt = document.getElementById('printTable1');
        var wb = XLSX.utils.table_to_book(elt, { sheet: ""sheet1"" });
        return dl ?
            XLSX.write(wb, { bookType: type, bookSST: true, type: 'base64' }) :
            XLSX.writeFile(wb, fn || ('StockReport.' + (type || 'xlsx')));

    }
</script>
<script>
    $(document).ready(function () {
        $('.select2').select2();
        GetSubCats();
        $('#loading').hide();
    });

    $(document).on(""click"", "".open-EditTodo"", fun");
            WriteLiteral(@"ction () {
        var todoId = $('#myData').data('todo').id;
        var wh = $('#myData').data('todo').wh;
        var sh = $('#myData').data('todo').sh;
        $(""#inventoryid"").val(todoId);
        $(""#shqty"").val(sh);
        $(""#avsh"").html(sh);
        $(""#whqty"").val(wh);
        $(""#avwh"").html(wh);
        $('#loading').show();

    });

    function GetSubCats() {
        var catid = $('#catDD option:selected').val();
        $.ajax({
            url: GlobalUrl + ""Common/GetAllSubCats?catId="" + catid,
            type: 'post',
            data: '{}',
            success: function (res) {
                var r = res.result.length;
                var row = '';

                if (r > 0) {

                    for (var i = 0; i < r; i++) {
                        row = row + '<option value=""' + res.result[i].subCategoryId + '"">' + res.result[i].subCategoryName + '</option>';

                    }
                }
                $('#subcatDD').html('');
            ");
            WriteLiteral("    $(\'#subcatDD\').html(row);\r\n            }\r\n        });\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCASA.Models.ModelClasses.PrintList> Html { get; private set; }
    }
}
#pragma warning restore 1591
