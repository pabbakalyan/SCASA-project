#pragma checksum "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75d403b618c423a689dd24187a2ab5ef52402500"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Master_CompanyData), @"mvc.1.0.view", @"/Views/Master/CompanyData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75d403b618c423a689dd24187a2ab5ef52402500", @"/Views/Master/CompanyData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61f59c02fdbf6895e021479e28253e13dd514c2e", @"/Views/_ViewImports.cshtml")]
    public class Views_Master_CompanyData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SCASA.Models.Repositories.Entity.CompanyMaster>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-add"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Master/Company"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Master/CompanyData"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""content-wrapper"">
    <!-- Content Header (Page header) -->
    <section class=""content-header"">
        <div class=""header-icon"">
            <i class=""fa fa-dashboard""></i>
        </div>
        <div class=""header-title"">
            <div class=""row"">
                <div class=""col-md-6"">
                    <h1>Add Company</h1>
                    <small>Add Details of Company.</small>
                </div>
                <div class=""col-md-6"">
                    <div class=""btn-group float-right"" role=""group"">
                        <div class=""buttonexport"" id=""buttonlist"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75d403b618c423a689dd24187a2ab5ef524025005787", async() => {
                WriteLiteral("\r\n                                <i class=\"fa fa-reply mr-2\"></i>Back\r\n                            ");
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
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
            </div>

        </div>
    </section>
    <!-- Main content -->
    <div class=""content"">
        <div class=""row"">
            <div class=""col-sm-12"">
                <div class=""card all_btn_card"" id=""lobicard-custom-control1"" data-sortable=""true"">
                    <div class=""card-header all_card_btn"">
                        <div class=""row"">
                            <div class=""col-md-6"">
                                <div class=""card-title custom_title"">
                                    <h5>Add Company</h5>
                                </div>
                            </div>
                            <div class=""col-md-6"">

                            </div>

                        </div>
                    </div>
                    <div class=""card-body all_card_btn"">
                        <!-- Form controls -->
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75d403b618c423a689dd24187a2ab5ef524025008066", async() => {
                WriteLiteral(@"
                            <div class=""col-sm-12"">
                                <div class=""card all_btn_card"" id=""lobicard-custom-control1"" data-sortable=""true"">
                                    <div class=""card-body"">
                                        ");
#nullable restore
#line 56 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                   Write(Html.HiddenFor(m => m.CompanyId));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                        
                                        <div class=""row"">
                                            <div class=""col-sm-3"">
                                                <div class=""form-group"">
                                                    <label>Company Name<span class=""text-danger"">*</span></label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Enter Company Name"" name=""CompanyName""");
                BeginWriteAttribute("value", " value=\"", 2872, "\"", 2898, 1);
#nullable restore
#line 62 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
WriteAttributeValue("", 2880, Model.CompanyName, 2880, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 63 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.CompanyName, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-sm-6"">
                                                <div class=""form-group"">
                                                    <label>Company Address<span class=""text-danger"">*</span></label>
                                                    <textarea class=""form-control"" placeholder=""Enter Company Address"" name=""CompanyAddress""");
                BeginWriteAttribute("value", " value=\"", 3548, "\"", 3577, 1);
#nullable restore
#line 69 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
WriteAttributeValue("", 3556, Model.CompanyAddress, 3556, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 69 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                                                                                                                                                      Write(Model.CompanyAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n                                                    ");
#nullable restore
#line 70 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.CompanyAddress, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-sm-6"">
                                                <div class=""form-group"">
                                                    <label>Warehouse Address</label>
                                                    <textarea class=""form-control"" placeholder=""Enter Warehouse Address"" name=""WarehouseAddress""");
                BeginWriteAttribute("value", " value=\"", 4234, "\"", 4265, 1);
#nullable restore
#line 76 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
WriteAttributeValue("", 4242, Model.WarehouseAddress, 4242, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 76 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                                                                                                                                                            Write(Model.WarehouseAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n                                                    ");
#nullable restore
#line 77 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.WarehouseAddress, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-sm-6"">
                                                <div class=""form-group"">
                                                    <label>Showroom Address</label>
                                                    <textarea class=""form-control"" placeholder=""Enter Showroom Address"" name=""ShowroomAddress""");
                BeginWriteAttribute("value", " value=\"", 4923, "\"", 4953, 1);
#nullable restore
#line 83 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
WriteAttributeValue("", 4931, Model.ShowroomAddress, 4931, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 83 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                                                                                                                                                         Write(Model.ShowroomAddress);

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n                                                    ");
#nullable restore
#line 84 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.ShowroomAddress, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </div>

                                            <div class=""col-sm-3"">
                                                <div class=""form-group"">
                                                    <label>CEO Name <span class=""text-danger"">*</span></label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Enter CEO Name"" name=""CEOName""");
                BeginWriteAttribute("value", " value=\"", 5631, "\"", 5653, 1);
#nullable restore
#line 91 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
WriteAttributeValue("", 5639, Model.CEOName, 5639, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 92 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.CEOName, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-sm-3"">
                                                <div class=""form-group"">
                                                    <label>CEO Email</label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Enter CEO Email"" name=""CEOEmail""");
                BeginWriteAttribute("value", " value=\"", 6256, "\"", 6279, 1);
#nullable restore
#line 98 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
WriteAttributeValue("", 6264, Model.CEOEmail, 6264, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 99 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.CEOEmail, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-sm-3"">
                                                <div class=""form-group"">
                                                    <label>CEO Contact Number<span class=""text-danger"">*</span></label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Enter CEO Number"" name=""CEOContactNumber""");
                BeginWriteAttribute("value", " value=\"", 6935, "\"", 6966, 1);
#nullable restore
#line 105 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
WriteAttributeValue("", 6943, Model.CEOContactNumber, 6943, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 106 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.CEOContactNumber, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-sm-3"">
                                                <div class=""form-group"">
                                                    <label>WareHouse Numbers</label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Enter WareHouse Number"" name=""WarehousePhoneNumbers""");
                BeginWriteAttribute("value", " value=\"", 7606, "\"", 7642, 1);
#nullable restore
#line 112 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
WriteAttributeValue("", 7614, Model.WarehousePhoneNumbers, 7614, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 113 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.WarehousePhoneNumbers, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-sm-3"">
                                                <div class=""form-group"">
                                                    <label>Showroom Numbers</label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Enter Showroom Number"" name=""ShowroomPhoneNumbers""");
                BeginWriteAttribute("value", " value=\"", 8284, "\"", 8319, 1);
#nullable restore
#line 119 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
WriteAttributeValue("", 8292, Model.ShowroomPhoneNumbers, 8292, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 120 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.ShowroomPhoneNumbers, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-sm-3"">
                                                <div class=""form-group"">
                                                    <label>Showroom Email</label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Enter Showroom Email"" name=""ShowroomEmail""");
                BeginWriteAttribute("value", " value=\"", 8950, "\"", 8978, 1);
#nullable restore
#line 126 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
WriteAttributeValue("", 8958, Model.ShowroomEmail, 8958, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 127 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.ShowroomEmail, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-sm-3"">
                                                <div class=""form-group"">
                                                    <label>WareHouse Email</label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Enter WareHouse Email"" name=""WarehouseEmail""");
                BeginWriteAttribute("value", " value=\"", 9605, "\"", 9634, 1);
#nullable restore
#line 133 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
WriteAttributeValue("", 9613, Model.WarehouseEmail, 9613, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 134 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.WarehouseEmail, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-sm-3"">
                                                <div class=""form-group"">
                                                    <label>GST Number</label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Enter GST Number"" name=""GSTIN""");
                BeginWriteAttribute("value", " value=\"", 10243, "\"", 10263, 1);
#nullable restore
#line 140 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
WriteAttributeValue("", 10251, Model.GSTIN, 10251, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 141 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.GSTIN, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-sm-3"">
                                                <div class=""form-group"">
                                                    <label>Code</label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Enter Code"" name=""Code""");
                BeginWriteAttribute("value", " value=\"", 10850, "\"", 10869, 1);
#nullable restore
#line 147 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
WriteAttributeValue("", 10858, Model.Code, 10858, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 148 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.Code, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-sm-3"">
                                                <div class=""form-group"">
                                                    <label>Display Name</label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Enter Display Name"" name=""CompanyDisplayName""");
                BeginWriteAttribute("value", " value=\"", 11485, "\"", 11518, 1);
#nullable restore
#line 154 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
WriteAttributeValue("", 11493, Model.CompanyDisplayName, 11493, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 155 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.CompanyDisplayName, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </div>
                                            <div class=""col-sm-3"">
                                                <div class=""form-group"">
                                                    <label>Company Website Name</label>
                                                    <input type=""text"" class=""form-control"" placeholder=""Enter Website Link"" name=""CompanyWebsite""");
                BeginWriteAttribute("value", " value=\"", 12152, "\"", 12181, 1);
#nullable restore
#line 161 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
WriteAttributeValue("", 12160, Model.CompanyWebsite, 12160, 21, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 162 "D:\Marolix\Projects\SCASA\Project\SCASA\Views\Master\CompanyData.cshtml"
                                               Write(Html.ValidationMessageFor(m => m.CompanyWebsite, null, new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""submit-button"">
                                    <button class=""btn btn-success"" type=""submit""> Save</button>
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- /.content -->\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SCASA.Models.Repositories.Entity.CompanyMaster> Html { get; private set; }
    }
}
#pragma warning restore 1591
