#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c3aa27de471d1aa561114ab3685717119ea53ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sales_MyCart), @"mvc.1.0.view", @"/Views/Sales/MyCart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c3aa27de471d1aa561114ab3685717119ea53ff", @"/Views/Sales/MyCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Sales_MyCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCASA.Models.ModelClasses.CartMasterModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sales/Index"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("close"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sales/CreateCRFQ"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
  
    Layout = "~/Views/Shared/_SalesMaster.cshtml";
    System.Globalization.CultureInfo Indian = new System.Globalization.CultureInfo("hi-IN");
    decimal totalPrice = 0;
    if (Model != null)
    {
        if (Model.cartDetails != null)
        {
            if (Model.cartDetails.Count > 0)
            {
                totalPrice = (decimal)Model.cartDetails.Sum(b => b.TotalPrice);
            }
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""page-title-area"">
    <div class=""d-table"">
        <div class=""d-table-cell"">
            <div class=""container"">
                <div class=""title-content"">
                    <h2>Cart</h2>
                    <ul>
                        <li>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c3aa27de471d1aa561114ab3685717119ea53ff6283", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </li>
                        <li>
                            <span>Cart</span>
                        </li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<div class=""user-area ptb-60"">
    <div class=""container"">
        <div class=""searchBox mb-2"">
            <div class=""modal-header"">
                <h5>Shopping Cart <span>");
#nullable restore
#line 41 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
                                   Write(ViewBag.CartCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Items</span></h5>               \r\n            </div>\r\n            <div class=\"cart-table\">\r\n                <table class=\"table\">\r\n                    <tbody>\r\n");
#nullable restore
#line 46 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
                         if (Model != null)
                        {
                            int rowcount = 0;
                            if (Model.cartDetails.Count > 0)
                            {
                                foreach (var r in Model.cartDetails)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 55 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
                                        Write(++rowcount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 58 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
                                       Write(r.InventoryTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n");
#nullable restore
#line 60 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
                                          
                                            var imgname = r.InventoryImage.Split(",");
                                         

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <th scope=\"row\">\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8c3aa27de471d1aa561114ab3685717119ea53ff9972", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2379, "~/ProductImages/", 2379, 16, true);
#nullable restore
#line 64 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
AddHtmlAttributeValue("", 2395, imgname[0], 2395, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </th>\r\n                                        <td>\r\n");
#nullable restore
#line 67 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
                                              
                                                string amount = String.Format(Indian, "{0:N}", r.ItemPrice);
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"rate\">\r\n                                                Rs. ");
#nullable restore
#line 71 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
                                               Write(amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" x ");
#nullable restore
#line 71 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
                                                         Write(r.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </span>
                                        </td>
                                        <td>
                                            <ul class=""number"">
                                                <li>
                                                    <span class=""minus"">-</span>
                                                    <input type=""text""");
            BeginWriteAttribute("id", " id=\"", 3283, "\"", 3310, 2);
            WriteAttributeValue("", 3288, "prdQty_", 3288, 7, true);
#nullable restore
#line 78 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
WriteAttributeValue("", 3295, r.CartDetailId, 3295, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 3311, "\"", 3325, 1);
#nullable restore
#line 78 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
WriteAttributeValue("", 3319, r.Qty, 3319, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <span class=""plus"">+</span>
                                                </li>
                                            </ul>
                                            <div style=""padding:20px; align-content:center;"">
                                                <a class=""btn btn-success"" href=""javascript:void(0);""");
            BeginWriteAttribute("onclick", " onclick=\"", 3712, "\"", 3749, 3);
            WriteAttributeValue("", 3722, "UpdateCart(", 3722, 11, true);
#nullable restore
#line 83 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
WriteAttributeValue("", 3733, r.CartDetailId, 3733, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3748, ")", 3748, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Update Cart</a>\r\n                                            </div>\r\n                                        </td>\r\n                                        <td>\r\n");
#nullable restore
#line 87 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
                                              
                                                string lineTotal = String.Format(Indian, "{0:N}", (r.ItemPrice * r.Qty));
                                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            Rs. ");
#nullable restore
#line 90 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
                                           Write(lineTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c3aa27de471d1aa561114ab3685717119ea53ff15754", async() => {
                WriteLiteral("\r\n                                                <i class=\"bx bx-x\"></i>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4351, "~/Sales/DeleteCart?id=", 4351, 22, true);
#nullable restore
#line 93 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
AddHtmlAttributeValue("", 4373, r.CartDetailId, 4373, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 98 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
                                }
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n");
#nullable restore
#line 103 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
                if (Model != null)
                {
                    if (Model.cartDetails.Count > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c3aa27de471d1aa561114ab3685717119ea53ff18246", async() => {
                WriteLiteral(@"
                            <div class=""row"">
                                <div class=""col-md-4"">
                                    <input type=""text"" name=""seDisPercen"" required placeholder=""Discount Percent"" value=""0""/>
                                    <p class=""text-danger"">");
#nullable restore
#line 111 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
                                                      Write(ViewBag.errorMsg);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                </div>
                                <div class=""col-md-4"">
                                    <button class=""btn btn-primary"">Create Quote</button>
                                </div>
                                <div class=""col-md-4 pull-right"">
                                   <h4>
                                    Total: <span>
");
#nullable restore
#line 119 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
                                          
                                            string mrp = String.Format(Indian, "{0:N}", totalPrice);
                                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    Rs.  ");
#nullable restore
#line 122 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
                                    Write(mrp);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                           </span>\r\n                                   </h4>\r\n                                </div>\r\n                            </div>    \r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
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
#line 128 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Sales\MyCart.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""clearfix""></div>
            </div>
        </div>
    </div>
</div>
<script>
    function CreateCRFQ(cid) {
        swal(""Are you sure to create CRFQ ?"", {
            buttons: {
                yes: {
                    text: ""Yes"",
                    value: ""yes""
                },
                no: {
                    text: ""No"",
                    value: ""no""
                }
            }
        }).then((value) => {
            if (value === ""yes"") {

                item = $('#prdQty_' + prid).val(); 
                //$.ajax({
                //    url: GlobalUrl + ""Sales/UpdateCart?detailId="" + prid + ""&qty="" + item,
                //    type: 'post',
                //    data: '{}',
                //    success: function (result) {
                //        toastr[""success""](""Successuflly Updated!"");
                //        window.location.href = window.location.href;
                //    }
                //}); 
            }");
            WriteLiteral(@"
            else {
                toastr[""error""](""Add to cart Cancelled!"")
            }
            return false;
        });
    }
    function UpdateCart(prid) {
        var userid = $('#cuid').val();
        if (userid == 0) {
            toastr[""error""](""Login first to add to cart!"");
        }
        else {
            swal(""Are you sure to update this to Cart ?"", {
                buttons: {
                    yes: {
                        text: ""Yes"",
                        value: ""yes""
                    },
                    no: {
                        text: ""No"",
                        value: ""no""
                    }
                }
            }).then((value) => {
                if (value === ""yes"") {
                    item = $('#prdQty_' + prid).val();
                        $.ajax({    
                            url: GlobalUrl + ""Sales/UpdateCart?detailId="" + prid + ""&qty="" + item,
                            type: 'post',
                     ");
            WriteLiteral(@"       data: '{}',
                            success: function (result) {
                                if (result.result.statusCode == 1) {
                                    toastr[""success""](""Successuflly Updated!"");
                                    window.location.href = window.location.href;
                                }
                                else {
                                    toastr[""error""](result.result.statusMessage);
                                }
                            }
                        });
                }
                else {
                    toastr[""error""](""Add to cart Cancelled!"")
                }
                return false;
            });
        }
    }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCASA.Models.ModelClasses.CartMasterModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
