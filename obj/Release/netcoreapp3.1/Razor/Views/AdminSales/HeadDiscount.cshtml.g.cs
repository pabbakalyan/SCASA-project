#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b3954cadb1c43960cc8c2f26c18911aaa7b0f87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminSales_HeadDiscount), @"mvc.1.0.view", @"/Views/AdminSales/HeadDiscount.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b3954cadb1c43960cc8c2f26c18911aaa7b0f87", @"/Views/AdminSales/HeadDiscount.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminSales_HeadDiscount : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCASA.Models.ModelClasses.QuotesSubmittedForApprovalModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminSales/Discounts"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Inventory/All"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminSales/GiveAdminDiscount"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("discountForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/AdminSales/GiveHeadDiscount"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
  
    System.Globalization.CultureInfo Indian = new System.Globalization.CultureInfo("hi-IN");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""header-icon"">
            <i class=""fa fa-dashboard""></i>
        </div>
        <div class=""header-title"">
            <h1>Quotation Details - Submitted for additional Discount</h1>
            <br />
            <h4><b>");
#nullable restore
#line 14 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
              Write(Model.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b> , ");
#nullable restore
#line 14 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                         Write(Model.CustomerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        </div>\r\n    </section>\r\n    <!-- Main content -->\r\n    <div class=\"content\">\r\n        <div class=\"row\">\r\n            <div class=\"card w-100\">\r\n                <div class=\"card-header\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b3954cadb1c43960cc8c2f26c18911aaa7b0f878289", async() => {
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-2\">\r\n                                <h5>Submitted by<br /> <b>");
#nullable restore
#line 25 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                                     Write(Model.SubmittedBy);

#line default
#line hidden
#nullable disable
                WriteLiteral("</b> </h5>\r\n                            </div>\r\n                            <div class=\"col-md-2\">\r\n                                <h5>Submitted On <br /><b>");
#nullable restore
#line 28 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                                     Write(Convert.ToDateTime(Model.SubmittedOn).ToString("dd/MMM/yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b> </h5>\r\n                            </div>\r\n                            <div class=\"col-md-2\">\r\n");
#nullable restore
#line 31 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                  
                                    decimal? tAmount = Model.quoteDetails.crfqDetails.Sum(a=>a.OrderLineTotal);
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <h5>Order Amount<br /><b> Rs. ");
#nullable restore
#line 34 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                                          Write(String.Format(Indian,"{0:N}", tAmount));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b> </h5>\r\n                            </div>\r\n                            <div class=\"col-md-2\">\r\n                                <h5>Total Discount<br /><b>Rs.  ");
#nullable restore
#line 37 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                                            Write(String.Format(Indian,"{0:N}",(Model.quoteDetails.crfqDetails.Sum(a=>a.OrderLineTotal) * (Model.SalesExecDiscount + Model.DiscountGiven) /100)));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b> </h5>\r\n                            </div>\r\n                            <div class=\"col-md-2\">\r\n                                <h5>Total Amount<br /><b>Rs.  ");
#nullable restore
#line 40 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                                          Write(String.Format(Indian,"{0:N}",(Model.quoteDetails.crfqDetails.Sum(a=>a.TotalPrice))));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b> </h5>\r\n                            </div>\r\n                            <div clas=\"col-md-2\">\r\n\r\n\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b3954cadb1c43960cc8c2f26c18911aaa7b0f8711547", async() => {
                    WriteLiteral("\r\n                                    Back to list\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
                    <div class=""row"">

                        <div class=""col-md-12"">
                            <div class=""table-responsive"">
                                <table id=""mydatatable"" class=""table table-bordered table-striped table-hover"">
									<thead class=""back_table_color"">
										<tr>
											<th>Title</th>
											<th>Qty</th>
											<th>Price</th>
											<th>Order Total</th>
											<th>SE Desc. %</th>
											<th>Other Disc.</th>
											<th>Admin Disc.</th>
											<th>Total Discount</th>
											<th>Total</th>
											<th>Image</th>
											<th>Size</th>
											<th>Color</th>

										</tr>
									</thead>
");
#nullable restore
#line 78 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                     foreach (var d in Model.quoteDetails.crfqDetails)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 81 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                           Write(d.InventoryTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 82 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                           Write(d.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"text-right\">");
#nullable restore
#line 83 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                                               Write(String.Format(Indian, "{0:N}", d.ItemPrise));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"text-right\">");
#nullable restore
#line 84 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                                               Write(String.Format(Indian, "{0:N}",(d.Quantity * d.ItemPrise)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"text-right\">");
#nullable restore
#line 85 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                                              Write(d.DisAmtBySE);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"text-right\">");
#nullable restore
#line 86 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                                              Write(d.DisAmtByHead);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                            <td class=\"text-right\">");
#nullable restore
#line 87 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                                              Write(d.AdminDiscount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                            <td class=\"text-right\">Rs. ");
#nullable restore
#line 88 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                                                   Write(String.Format(Indian,"{0:N}", (d.DisAmtByHead + d.DisAmtBySE * (d.Quantity * d.ItemPrise) / 100)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"text-right\">\r\n                                                Rs.\r\n                                                ");
#nullable restore
#line 91 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                            Write(String.Format(Indian, "{0:N}", d.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7b3954cadb1c43960cc8c2f26c18911aaa7b0f8719131", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4687, "~/ProductImages/", 4687, 16, true);
#nullable restore
#line 93 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
AddHtmlAttributeValue("", 4703, d.InventoryImage, 4703, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 95 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                           Write(d.Height);

#line default
#line hidden
#nullable disable
            WriteLiteral(" X <br />  ");
#nullable restore
#line 95 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                                               Write(d.Width);

#line default
#line hidden
#nullable disable
            WriteLiteral(" X <br /> ");
#nullable restore
#line 95 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                                                                 Write(d.Breadth);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7b3954cadb1c43960cc8c2f26c18911aaa7b0f8721879", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5061, "~/ProductImages/", 5061, 16, true);
#nullable restore
#line 98 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
AddHtmlAttributeValue("", 5077, d.ColorImage, 5077, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            </td>\r\n\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 103 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </table>\r\n                            </div>\r\n                        </div>\r\n\r\n\r\n                    </div>\r\n\r\n                </div>\r\n                <div class=\"card-body\">\r\n");
#nullable restore
#line 114 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                     if (ViewBag.LoggedUser.userTypeCode < 5)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b3954cadb1c43960cc8c2f26c18911aaa7b0f8724321", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"TRId\"");
                BeginWriteAttribute("value", " value=\"", 5709, "\"", 5728, 1);
#nullable restore
#line 117 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
WriteAttributeValue("", 5717, Model.TRId, 5717, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"SEDisc\"");
                BeginWriteAttribute("value", " value=\"", 5796, "\"", 5828, 1);
#nullable restore
#line 118 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
WriteAttributeValue("", 5804, Model.SalesExecDiscount, 5804, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                          
                            <div class=""row"">
                                <div class=""col-sm-3"">
                                    <div class=""form-group"">
                                        <label>Discount %</label>
                                        <input type=""text"" name=""GivenPercentage"" id=""DiscountAmount"" class=""form-control"" />
                                        <span class=""text-danger"" id=""DisError""></span>
                                        <span class=""text-danger"">");
#nullable restore
#line 126 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                                             Write(ViewBag.excedError);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                    </div>
                                </div>
                                <div class=""col-sm-4"">
                                    <div class=""form-group"">
                                        <label>Remarks</label>
                                        <input type=""text"" name=""Remarks"" id=""Remarks"" class=""form-control"" />
                                        <span class=""text-danger"" id=""remarkError""></span>
                                    </div>
                                </div>
                                <div class=""col-sm-2"">
                                    <div class=""form-group"">
                                        <button type=""submit"" class=""btn btn-success serchgaptop"">Save</button>
                                    </div>
                                </div>

                            </div>
                            <div class=""row"">
                                <div class=""col-sm-4"">
     ");
                WriteLiteral("                               <span class=\"text-danger\" id=\"errorMessage\"> </span>\r\n                                </div>\r\n\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 150 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7b3954cadb1c43960cc8c2f26c18911aaa7b0f8729530", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"TRId\"");
                BeginWriteAttribute("value", " value=\"", 7850, "\"", 7869, 1);
#nullable restore
#line 154 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
WriteAttributeValue("", 7858, Model.TRId, 7858, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"SEDisc\"");
                BeginWriteAttribute("value", " value=\"", 7937, "\"", 7969, 1);
#nullable restore
#line 155 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
WriteAttributeValue("", 7945, Model.SalesExecDiscount, 7945, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                            <div class=""row"">
                                <div class=""col-sm-3"">
                                    <div class=""form-group"">
                                        <label>Discount %</label>
                                        <input type=""text"" name=""GivenPercentage"" id=""DiscountAmount"" class=""form-control"" />
                                        <span class=""text-danger"" id=""DisError""></span>
                                        <span class=""text-danger"">");
#nullable restore
#line 162 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                                                             Write(ViewBag.excedError);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
                                    </div>
                                </div>
                                <div class=""col-sm-4"">
                                    <div class=""form-group"">
                                        <label>Remarks</label>
                                        <input type=""text"" name=""Remarks"" id=""Remarks"" class=""form-control"" />
                                        <span class=""text-danger"" id=""remarkError""></span>
                                    </div>
                                </div>
                                <div class=""col-sm-2"">
                                    <div class=""form-group"">
                                        <button type=""submit"" class=""btn btn-success serchgaptop"">Save</button>
                                    </div>
                                </div>

                            </div>
                            <div class=""row"">
                                <div class=""col-sm-4"">
     ");
                WriteLiteral("                               <span class=\"text-danger\" id=\"errorMessage\"> </span>\r\n                                </div>\r\n\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 186 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\AdminSales\HeadDiscount.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
            </div>
            <!-- /.content -->
        </div>
    </div>
    </div>

<script>
    $(""#discountForm"").submit(function (e) {
        e.preventDefault();
        var rem = $('#Remarks').val();
        var dis = $('#DiscountAmount').val();
        if (rem == null || rem == undefined || rem == '' || dis == null || dis == undefined || dis == '') {
            $('#errorMessage').html('Fill all the fields');
            if (rem == null || rem == undefined || rem == '') {
                $('#remarkError').html('Remarks Field should be filled');
            }
            if (dis == null || dis == undefined || dis == '') {
                $('#DisError').html('Discount Field should not be empty');
            }
            return fals;
        }
        else {
            this.submit();
        }
     
});
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCASA.Models.ModelClasses.QuotesSubmittedForApprovalModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
