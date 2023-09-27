#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\_PaymentReceipt.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "832f62552d314c148e8631edfc9b1bff4449645d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Finance__PaymentReceipt), @"mvc.1.0.view", @"/Views/Finance/_PaymentReceipt.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"832f62552d314c148e8631edfc9b1bff4449645d", @"/Views/Finance/_PaymentReceipt.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Finance__PaymentReceipt : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCASA.Models.ModelClasses.FinanceTransactionsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-family:\'Cabin\', Arial, \'Helvetica Neue\', Helvetica, sans-serif;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\_PaymentReceipt.cshtml"
  
    System.Globalization.CultureInfo Indian = new System.Globalization.CultureInfo("hi-IN");

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-12 pinpin"">
        <div class=""card"" data-sortable=""true"">
            <div id=""printPanel"">
                <html xmlns=""http://www.w3.org/1999/xhtml"" xmlns:o=""urn:schemas-microsoft-com:office:office"" xmlns:v=""urn:schemas-microsoft-com:vml"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "832f62552d314c148e8631edfc9b1bff4449645d4251", async() => {
                WriteLiteral(@"
                    <!--[if gte mso 9]><xml><o:OfficeDocumentSettings><o:AllowPNG/><o:PixelsPerInch>96</o:PixelsPerInch></o:OfficeDocumentSettings></xml><![endif]-->
                    <meta content=""text/html; charset=utf-8"" http-equiv=""Content-Type"" />
                    <meta content=""width=device-width"" name=""viewport"" />
                    <!--[if !mso]><!-->
                    <meta content=""IE=edge"" http-equiv=""X-UA-Compatible"" />
                    <!--<![endif]-->
                    <title>Recept Voucher</title>
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
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "832f62552d314c148e8631edfc9b1bff4449645d5881", async() => {
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
");
                WriteLiteral(@"                    <table width=""700px"" style=""margin: 0 auto; border:2px solid #a3080d;background-color: #fff; padding: 20px;"" cellspacing=""0"" cellpadding=""0"">
                        <tbody>
                            <tr>
                                <td style=""padding: 10px;"">
                                    <table width=""100%;"">
                                        <tbody>
                                            <tr>
                                                <td style=""text-align: center; font-size: 40px; font-weight: bold;"">SCASA</td>
                                            </tr>
                                            <tr>
                                                <td style=""text-align: center; font-size:16px; font-weight: bold;"">");
#nullable restore
#line 57 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\_PaymentReceipt.cshtml"
                                                                                                              Write(Model.companyDetails.CompanyAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</td>
                                            </tr>
                                            <tr>
                                                <td style=""text-align: center; font-size: 22px;  font-weight: bold; text-decoration: underline; padding-top:20px;"">Payment Voucher</td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </td>
                            </tr>

");
                WriteLiteral(@"
                            <tr>
                                <td>
                                    <table width=""100%"" style=""border: 2px solid; border-collapse: collapse;"" cellpadding=""0"" , cellspacing=""0"">
                                        <tr>
                                            <!--<td width=""60%"">
                                                <table width=""100%"" style=""border-collapse: collapse;"" cellpadding=""0"" , cellspacing=""0"">
                                                    <tr>
                                                        <td style=""border-right:2px solid; border-bottom: 2px solid; padding: 5px""><span id=""amtInWords"" style=""font-weight:bold;""></span></td>
                                                    </tr>-->
");
                WriteLiteral(@"                                                <!--</table>
                                            </td>-->
                                                <td width=""100%"" style=""vertical-align: middle; text-align: left; padding: 5px"">Rs. <span style=""color:blue; font-weight: bold;"" id=""amtReceived""> ");
#nullable restore
#line 122 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\_PaymentReceipt.cshtml"
                                                                                                                                                                                               Write(String.Format(Indian,"{0:N}", Model.Credit));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>

                            <tr>
                                <td>
                                    <table width=""100%"" style=""border-bottom: 2px solid;"">
                                        <tr>
                                            <td width=""60%"" style=""border-right:2px solid; border-left: 2px solid; padding: 5px;"">
                                                <table width=""100%"">
                                                    <tr>
                                                        <td width=""100%"">Dated <span id=""rDate"" style=""font-weight:bold;"">");
#nullable restore
#line 135 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\_PaymentReceipt.cshtml"
                                                                                                                      Write(Convert.ToDateTime(Model.DateOfTransaction).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\r\n");
                WriteLiteral("                                                    </tr>\r\n                                                </table>\r\n                                            </td>\r\n");
                WriteLiteral(@"                                        </tr>
                                    </table>
                                </td>

                            </tr>

                            <tr>
                                <td>
                                    <table width=""100%"" style=""border: 2px solid; border-top: 0; border-collapse: collapse;"" cellpadding=""0"" , cellspacing=""0"">
                                        <tr>
                                            <td width=""60%"">
                                                <table width=""100%"" style=""border-collapse: collapse;"" cellpadding=""0"" , cellspacing=""0"">
                                                    <tr>
                                                        <td style=""border-right:2px solid; border-bottom: 2px solid; padding: 5px"">On Account of : ");
#nullable restore
#line 154 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\_PaymentReceipt.cshtml"
                                                                                                                                              Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <span");
                BeginWriteAttribute("style", " style=\"", 10080, "\"", 10088, 0);
                EndWriteAttribute();
                WriteLiteral(@"> </span></td>
                                                    </tr>
                                                    <tr>
                                                        <td style=""border-right:2px solid; padding: 5px; padding-top: 100px;"">Payment by Cheques are Subject to realization</td>
                                                    </tr>
                                                </table>
                                            </td>
                                            <td width=""40%"" style=""text-align: center; font-style: italic; padding: 5px"">
                                                <div>For <strong>SCASA</strong></div>
                                                <div style=""padding-top: 100px;""><strong>Authorised Signatory</strong></div>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                          ");
                WriteLiteral("  </tr>\r\n                        </tbody>\r\n                    </table>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </html>
        </div>

        <div class=""card-body"">
            <div class=""row"">
                <div class=""col-md-2""></div>
                <div class=""col-md-10"">
                    <a class=""btn btn-success"" onclick=""printDiv()"">Print now</a>
                </div>
            </div>
        </div>
    </div>

</div>
</div>

<script>

    var a = ['', 'One ', 'Two ', 'Three ', 'Four ', 'Five ', 'Six ', 'Seven ', 'Eight ', 'Nine ', 'Ten ', 'Eleven ', 'Twelve ', 'Thirteen ', 'Fourteen ', 'Fifteen ', 'Sixteen ', 'Seventeen ', 'Eighteen ', 'Nineteen '];
    var b = ['', '', 'Twenty', 'Thirty', 'Forty', 'Fifty', 'Sixty', 'Seventy', 'Eighty', 'Ninety'];
    function inWords(num) {
        if ((num = num.toString()).length > 9) return 'overflow';
        n = ('000000000' + num).substr(-9).match(/^(\d{2})(\d{2})(\d{2})(\d{1})(\d{2})$/);
        if (!n) return; var str = '';
            str += (n[1] != 0) ? (a[Number(n[1])] || b[n[1][0]] + ' ' + a[n[1][1]]) + 'crore ' : ");
            WriteLiteral(@"'';
            str += (n[2] != 0) ? (a[Number(n[2])] || b[n[2][0]] + ' ' + a[n[2][1]]) + 'lakh ' : '';
            str += (n[3] != 0) ? (a[Number(n[3])] || b[n[3][0]] + ' ' + a[n[3][1]]) + 'thousand ' : '';
            str += (n[4] != 0) ? (a[Number(n[4])] || b[n[4][0]] + ' ' + a[n[4][1]]) + 'hundred ' : '';
            str += (n[5] != 0) ? ((str != '') ? 'and ' : '') + (a[Number(n[5])] || b[n[5][0]] + ' ' + a[n[5][1]]) + 'only ' : '';
            return str;
        }
    $(document).ready(function () {
        var cAmount = 0;
        var vtype = """);
#nullable restore
#line 205 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\_PaymentReceipt.cshtml"
                Write(Model.VoucherType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        if (vtype   == \"Receipt\") {\r\n            cAmount = ");
#nullable restore
#line 207 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\_PaymentReceipt.cshtml"
                 Write(Model.Credit);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n        }\r\n        else {\r\n            cAmount = ");
#nullable restore
#line 210 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Finance\_PaymentReceipt.cshtml"
                 Write(Model.Debit);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
        }

        var inwordsa = inWords(parseFloat(cAmount));
        $('#amtInWords').html(""Rs. "" + inwordsa); //inWords(your amount)


    })

    function printDiv() {

        var divToPrint = document.getElementById('printPanel');

        var newWin = window.open('', 'Print-Window');

        newWin.document.open();

        newWin.document.write('<html><body onload=""window.print()"">' + divToPrint.innerHTML + '</body></html>');

        newWin.document.close();

        setTimeout(function () { newWin.close(); }, 10);

    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCASA.Models.ModelClasses.FinanceTransactionsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
