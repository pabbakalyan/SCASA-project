#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "274ab1af6489929d41e0af224094c297fb4f1bdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_QuoteModel), @"mvc.1.0.view", @"/Views/Sales/QuoteModel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"274ab1af6489929d41e0af224094c297fb4f1bdb", @"/Views/Sales/QuoteModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_QuoteModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCASA.Models.ModelClasses.QuoteModelForMail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/SApp/assets/images/header.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("700"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family:\'Cabin\', Arial, \'Helvetica Neue\', Helvetica, sans-serif;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
  
    int rCnt = 1;
    System.Globalization.CultureInfo Indian = new System.Globalization.CultureInfo("hi-IN");
    var totQty = 0;
    decimal totPrice = 0;
    Layout = null;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional //EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">

<html xmlns=""http://www.w3.org/1999/xhtml"" xmlns:o=""urn:schemas-microsoft-com:office:office"" xmlns:v=""urn:schemas-microsoft-com:vml"">
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "274ab1af6489929d41e0af224094c297fb4f1bdb5145", async() => {
                WriteLiteral(@"

    <meta content=""text/html; charset=utf-8"" http-equiv=""Content-Type"" />
    <meta content=""width=device-width"" name=""viewport"" />
    <!--[if !mso]><!-->
    <meta content=""IE=edge"" http-equiv=""X-UA-Compatible"" />
    <!--<![endif]-->
    <title>Quotation</title>
    <!--[if !mso]><!-->
    <!--<![endif]-->

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "274ab1af6489929d41e0af224094c297fb4f1bdb6445", async() => {
                WriteLiteral(@"
    <style type=""text/css"">
        body {
            margin: 0;
            padding: 0;
            background-color: rgb(237, 237, 240);
        }

        table,
        td,
        tr {
            vertical-align: top;
            border-collapse: collapse;
        }

        * {
            line-height: inherit;
        }

        a[x-apple-data-detectors=true] {
            color: inherit !important;
            text-decoration: none !important;
        }
    </style>
    <table width=""700px"" style=""margin: 0 auto; border:2px solid #a3080d;background-color: #fff; padding: 20px;"" cellspacing=""0"" cellpadding=""0"">
        <tbody>
            <tr>
                <td>
                    <table width=""100%;"">
                        <tbody>
                            <tr bgcolor=""#5e3f37"">
                                <td>
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "274ab1af6489929d41e0af224094c297fb4f1bdb7625", async() => {
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
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
                WriteLiteral(@"                        </tbody>
                    </table>
                </td>
            </tr>

            <tr>
                <td>
                    <table width=""100%"" border=""1"" bordercolor=""#5e3f37"" style=""color:#5e3f37"">
                        <tr>
                            <td width=""50%"">
                                Date : <strong>");
#nullable restore
#line 79 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                          Write(DateTime.Now.ToString("d"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                            </td>\r\n                            <td width=\"50%\">\r\n                                Attn : <strong>");
#nullable restore
#line 82 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                          Write(Model.sExecutive.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td width=\"50%\">\r\n                                Company : <strong>");
#nullable restore
#line 87 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                             Write(Model.companyDetails.CompanyDisplayName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                            </td>\r\n                            <td width=\"50%\">\r\n                                Contact  : <strong>");
#nullable restore
#line 90 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                              Write(Model.sExecutive.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </strong>\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td width=\"50%\">\r\n                                E-mail : <strong>");
#nullable restore
#line 95 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                            Write(Model.companyDetails.ShowroomEmail);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong>
                            </td>
                            <td width=""50%"">
                                Mobile : <strong>7995562304</strong>
                            </td>
                        </tr>
                        <tr>
                            <td width=""50%"">
                                Website : <strong>");
#nullable restore
#line 103 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                             Write(Model.companyDetails.CompanyWebsite);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>

            <tr>
                <td height=""20px""></td>
            </tr>

            <tr>
                <td>
                    <table width=""100%"" border=""1"" bordercolor=""#5e3f37"" style=""color:#5e3f37"">
                        <tr>
                            <td width=""100%"">
                                To,
                            </td>
                        </tr>
                        <tr>
                            <td width=""100%"">
                                Customer Name: <strong>");
#nullable restore
#line 124 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                                  Write(Model.custMaster.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td width=\"100%\">\r\n                                E-mail : <strong>");
#nullable restore
#line 129 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                            Write(Model.custMaster.EmailId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td width=\"100%\">\r\n                                Mobile : <strong>");
#nullable restore
#line 134 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                            Write(Model.custMaster.MobileNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>

            <tr>
                <td height=""20px""></td>
            </tr>

            <tr>
                <td>
                    <table width=""100%"" style=""color:#5e3f37;"">
                        <tr style=""border-top:2px solid #5e3f37;"">
                            <th style=""border-right:2px solid #5e3f37;"">Sl No.</th>
                            <th style=""border-right:2px solid #5e3f37;"">Brand</th>
                            <th style=""border-right:2px solid #5e3f37;"">Product Name</th>
                            <th style=""border-right:2px solid #5e3f37;"">Image</th>
                            <th style=""border-right:2px solid #5e3f37;"">Unit price </th>
                            <th style=""border-right:2px solid #5e3f37;"">Discount %</th>
                            <th style=""border-right:2px solid #5e3f37;"">Discounted Price </th>
 ");
                WriteLiteral("                           <th style=\"border-right:2px solid #5e3f37;\">Quantity </th>\r\n                            <th style=\"border-right:2px solid #5e3f37;\">Total  Price </th>\r\n                        </tr>\r\n");
#nullable restore
#line 159 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                         foreach (var a in Model.crfqsList)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr style=\"border-top:2px solid #5e3f37; border-bottom: 2px solid #5e3f37;\">\r\n                                <td style=\"border-right: 2px solid #5e3f37;\">");
#nullable restore
#line 162 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                                                         Write(rCnt++);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"border-right: 2px solid #5e3f37;\">Scasa</td>\r\n                                <td style=\"border-right: 2px solid #5e3f37;\">");
#nullable restore
#line 164 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                                                        Write(a.InventoryTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 165 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                  
                                    var imgname = a.InventoryImage.Split(",");
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td style=\"border-right: 2px solid #5e3f37;\"><img");
                BeginWriteAttribute("src", " src=\"", 7298, "\"", 7328, 2);
#nullable restore
#line 168 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
WriteAttributeValue("", 7304, Model.imgURL, 7304, 13, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 168 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
WriteAttributeValue("", 7317, imgname[0], 7317, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"110\" height=\"77\"></td>\r\n\r\n");
#nullable restore
#line 170 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                  
                                    decimal dis = (decimal)(a.DisAmtByHead + a.DisAmtBySE);
                                    decimal adDis = (decimal)(a.AdminDiscount == null ? 0 : a.AdminDiscount);
                                    dis += adDis;
                                    var disPrice = ((decimal)a.ItemPrise) - ((decimal)a.ItemPrise * dis / 100);
                                    totQty += (int)a.Quantity;
                                    totPrice += (decimal)(a.TotalPrice);
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td style=\"border-right: 2px solid #5e3f37;\">");
#nullable restore
#line 178 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                                                        Write(String.Format(Indian, "{0:N}", a.ItemPrise));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"border-right: 2px solid #5e3f37;\">");
#nullable restore
#line 179 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                                                        Write(dis);

#line default
#line hidden
#nullable disable
                WriteLiteral("%</td>\r\n                                <td style=\"border-right: 2px solid #5e3f37;\">");
#nullable restore
#line 180 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                                                        Write(String.Format(Indian, "{0:N}", disPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"border-right: 2px solid #5e3f37;\">");
#nullable restore
#line 181 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                                                        Write(a.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"border-right: 2px solid #5e3f37;\"> ₹");
#nullable restore
#line 182 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                                                          Write(String.Format(Indian, "{0:N}", a.TotalPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 184 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <tr bgcolor=""#5e3f37"" style=""color:#fff; padding: 10px;"">
                            <td style=""border-right: 2px solid #5e3f37; border-bottom: 2px solid #5e3f37; padding: 5px"" colspan=""7""><strong>Total No. Of Items and Total Cost : </strong></td>
                            <td style=""border-right: 2px solid #5e3f37; border-bottom: 2px solid #5e3f37; padding: 5px""><strong>");
#nullable restore
#line 199 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                                                                                                           Write(totQty);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></td>\r\n                            <td style=\"border-right: 2px solid #5e3f37; border-bottom: 2px solid #5e3f37; padding: 5px\"> <strong>₹");
#nullable restore
#line 200 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\QuoteModel.cshtml"
                                                                                                                             Write(String.Format(Indian, "{0:N}", totPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </strong></td>
                        </tr>
                    </table>
                </td>
            </tr>

            <tr>
                <td height=""10px""></td>
            </tr>

            <tr>
                <td style=""background-color: #5e3f37; color: #fff; text-align: center;"">
                    <h5> Terms of Sales</h5>
                </td>
            </tr>
            <tr>
                <td style="" font-size: 13px;"">
                    <table>
                        <tr>
                            <td><strong>1) Price</strong> -The prices mentioned above are subject to revision , in case of any change in the above BOQ</td>
                        </tr>
                        <tr>
                            <td><strong>2) Taxes</strong> -GST 18% is inclusive on the above prices.</td>
                        </tr>
                        <tr>
                            <td><strong>3) Trans charges</strong> -No transportation charges if delivery is within ");
                WriteLiteral(@"Hyderabad, Transportation charges extra as per actuals if delivered outside Hyderabad.</td>
                        </tr>
                        <tr>
                            <td><strong>4) Delivery</strong> -Immediate delivery will be processed within 48 hours for available products, products on order will take 12-16 weeks from the date of Order placed/ Advance received.</td>
                        </tr>
                        <tr>
                            <td><strong>5) Payment</strong> - 70% advance against order received and 30% before delivery, Delivery is subject to realization of cheque payments.  Amount once received on order finalisation will not be refunded. </td>
                        </tr>
                        <tr>
                            <td><strong>6) Validity</strong> - Quotation is valid for 15 days.</td>
                        </tr>
                        <tr>
                            <td><strong>7) Forms </strong>- Please provide statutory forms as may be r");
                WriteLiteral(@"equired.</td>
                        </tr>
                        <tr>
                            <td><p style=""color: red;"">8) Cancellation - Order once placed cannot be cancelled or altered, incase of cancellation complete deposit amount shall be forfieted.</p></td>
                        </tr>
");
                WriteLiteral(@"                    </table>
                </td>
            </tr>

            <tr>
                <td height=""10px""></td>
            </tr>


            <tr>
                <td>
                    <table width=""100%"">
                        <tr>
                            <td width=""70%"" style=""text-align: left"">
                                <div><strong>EMPIRE HOME Acceptance</strong></div>
                            </td>
                            <td width=""30%"" style=""text-align: center; font-style: italic; padding: 5px"">
                                <div>For <strong>Client Acceptance</strong></div>
                                <div style=""padding-top: 50px;""><strong>Authorised Signatory</strong></div>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>

        </tbody>
    </table>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCASA.Models.ModelClasses.QuoteModelForMail> Html { get; private set; }
    }
}
#pragma warning restore 1591
