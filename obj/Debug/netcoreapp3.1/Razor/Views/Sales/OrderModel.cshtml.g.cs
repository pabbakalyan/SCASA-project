#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bafb44e2b898e683c50a6956299b61abfb8b71eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_OrderModel), @"mvc.1.0.view", @"/Views/Sales/OrderModel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bafb44e2b898e683c50a6956299b61abfb8b71eb", @"/Views/Sales/OrderModel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_OrderModel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCASA.Models.ModelClasses.OrderModerForMail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/SApp/assets/images/header-sales.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
  
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bafb44e2b898e683c50a6956299b61abfb8b71eb5151", async() => {
                WriteLiteral(@"

    <meta content=""text/html; charset=utf-8"" http-equiv=""Content-Type"" />
    <meta content=""width=device-width"" name=""viewport"" />
    <!--[if !mso]><!-->
    <meta content=""IE=edge"" http-equiv=""X-UA-Compatible"" />
    <!--<![endif]-->
    <title>Sales Order</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bafb44e2b898e683c50a6956299b61abfb8b71eb6453", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bafb44e2b898e683c50a6956299b61abfb8b71eb7633", async() => {
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
#line 78 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                                          Write(DateTime.Now.ToString("d"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                            </td>\r\n                            <td width=\"50%\">\r\n                                Attn : <strong>");
#nullable restore
#line 81 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                                          Write(Model.sExecutive.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td width=\"50%\">\r\n                                Company : <strong>");
#nullable restore
#line 86 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                                             Write(Model.companyDetails.CompanyDisplayName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                            </td>\r\n                            <td width=\"50%\">\r\n                                Contact  : <strong>");
#nullable restore
#line 89 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                                              Write(Model.sExecutive.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </strong>\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td width=\"50%\">\r\n                                E-mail : <strong>");
#nullable restore
#line 94 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
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
#line 102 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
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
#line 123 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                                                  Write(Model.custMaster.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td width=\"100%\">\r\n                                E-mail : <strong>");
#nullable restore
#line 128 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                                            Write(Model.custMaster.EmailId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                            </td>\r\n                        </tr>\r\n                        <tr>\r\n                            <td width=\"100%\">\r\n                                Mobile : <strong>");
#nullable restore
#line 133 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
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
#line 158 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                         foreach (var a in Model.Orders)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr style=\"border-top:2px solid #5e3f37; border-bottom: 2px solid #5e3f37;\">\r\n                                <td style=\"border-right: 2px solid #5e3f37;\">");
#nullable restore
#line 161 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                                                                         Write(rCnt++);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"border-right: 2px solid #5e3f37;\">Scasa</td>\r\n                                <td style=\"border-right: 2px solid #5e3f37;\">");
#nullable restore
#line 163 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                                                                        Write(a.InventoryTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 164 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                                  
                                    var imgname = a.InventoryImage.Split(",");
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td style=\"border-right: 2px solid #5e3f37;\"><img");
                BeginWriteAttribute("src", " src=\"", 7329, "\"", 7359, 2);
#nullable restore
#line 167 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
WriteAttributeValue("", 7335, Model.imgURL, 7335, 13, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 167 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
WriteAttributeValue("", 7348, imgname[0], 7348, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" width=\"110\" height=\"77\"></td>\r\n\r\n");
#nullable restore
#line 169 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                                  
                                    decimal dis = (decimal)(a.DisAmtByHead + a.DisAmtBySE);
                                    decimal adDis = (decimal)(a.AdminDiscount == null ? 0 : a.AdminDiscount);
                                    dis += adDis;
                                    var disPrice = ((decimal)a.ItemPrice) - ((decimal)a.ItemPrice * dis / 100);
                                    totQty += (int)a.Quantity;
                                    totPrice += (decimal)(a.TotalPrice);
                                

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td style=\"border-right: 2px solid #5e3f37;\">");
#nullable restore
#line 177 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                                                                        Write(String.Format(Indian, "{0:N}", a.ItemPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"border-right: 2px solid #5e3f37;\">");
#nullable restore
#line 178 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                                                                        Write(dis);

#line default
#line hidden
#nullable disable
                WriteLiteral("%</td>\r\n                                <td style=\"border-right: 2px solid #5e3f37;\">");
#nullable restore
#line 179 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                                                                        Write(String.Format(Indian, "{0:N}", disPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"border-right: 2px solid #5e3f37;\">");
#nullable restore
#line 180 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                                                                        Write(a.Quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td style=\"border-right: 2px solid #5e3f37;\"> ₹");
#nullable restore
#line 181 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                                                                          Write(String.Format(Indian, "{0:N}", a.TotalPrice));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 183 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 184 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                         if (Model.delivaryCharges != 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <tr>
                                <td colspan=""8"" style=""border-right: 2px solid #000; text-align: center; border-bottom: 2px solid #000;"">
                                    Delivery Charges  : -
                                </td>
                                <td style="" text-align: right; text-align: right; border-bottom: 2px solid #000;"">
                                    ");
#nullable restore
#line 191 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                               Write(Model.delivaryCharges);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 194 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 195 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                         if (Model.roundedValue != 0)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            <tr>
                                <td colspan=""8"" style=""border-right: 2px solid #000; text-align: center"">
                                    Rounding value : -
                                </td>
                                <td style="" text-align: right; text-align: right"">
                                    ");
#nullable restore
#line 202 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                               Write(Model.roundedValue);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 205 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                        }
                        

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                        <tr bgcolor=""#5e3f37"" style=""color:#fff; padding: 10px;"">
                            <td style=""border-right: 2px solid #5e3f37; border-bottom: 2px solid #5e3f37; padding: 5px"" colspan=""7""><strong>Total No. Of Items and Total Cost : </strong></td>
                            <td style=""border-right: 2px solid #5e3f37; border-bottom: 2px solid #5e3f37; padding: 5px""><strong>");
#nullable restore
#line 220 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                                                                                                                           Write(totQty);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></td>\r\n                            <td style=\"border-right: 2px solid #5e3f37; border-bottom: 2px solid #5e3f37; padding: 5px\"> <strong>₹");
#nullable restore
#line 221 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\OrderModel.cshtml"
                                                                                                                             Write(String.Format(Indian, "{0:N}", (totPrice+ Model.roundedValue+Model.delivaryCharges)));

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
                <td style=""background-color: #5e3f37; color: #fff; text-align: center; height: 20px"">
                    <b>Terms of Sales</b>
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
                            <td><strong>3) Trans charges</strong> -No transportation charges if delivery ");
                WriteLiteral(@"is within Hyderabad, Transportation charges extra as per actuals if delivered outside Hyderabad.</td>
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
                            <td><strong>7) Forms </strong>- Please provide statutory forms a");
                WriteLiteral(@"s may be required.</td>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCASA.Models.ModelClasses.OrderModerForMail> Html { get; private set; }
    }
}
#pragma warning restore 1591
