#pragma checksum "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\Pemeliharaan\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39f007429635bcad5c04848bbf570da4063a0acd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pemeliharaan_Index), @"mvc.1.0.view", @"/Views/Pemeliharaan/Index.cshtml")]
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
#line 1 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\_ViewImports.cshtml"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\_ViewImports.cshtml"
using Inventory.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39f007429635bcad5c04848bbf570da4063a0acd", @"/Views/Pemeliharaan/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddd647dc521e354fabd3c5f5959fac0949cf3697", @"/Views/_ViewImports.cshtml")]
    public class Views_Pemeliharaan_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InventorySekolah.Models.Pemeliharaan>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-rounded btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary btn-rounded btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\Pemeliharaan\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_PemeliharaanBarang";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""main-panel"">
    <div class=""content-wrapper"">
        <div class=""row"">
            <div class=""col-lg-12 grid-margin stretch-card"">
                <div class=""card"">
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <p>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39f007429635bcad5c04848bbf570da4063a0acd5432", async() => {
                WriteLiteral("Tambah Data");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </p>
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th>
                                            ");
#nullable restore
#line 22 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\Pemeliharaan\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Nama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 25 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\Pemeliharaan\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Kerusakan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 28 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\Pemeliharaan\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Biaya));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 31 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\Pemeliharaan\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.TglPengajuan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 34 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\Pemeliharaan\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>Action</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 40 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\Pemeliharaan\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 44 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\Pemeliharaan\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Nama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 47 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\Pemeliharaan\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Kerusakan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 50 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\Pemeliharaan\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Biaya));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 53 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\Pemeliharaan\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.TglPengajuan));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 56 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\Pemeliharaan\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Status.StatusBarang));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39f007429635bcad5c04848bbf570da4063a0acd11913", async() => {
                WriteLiteral("<i class=\"ti-pencil-alt text-info\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\Pemeliharaan\Index.cshtml"
                                                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39f007429635bcad5c04848bbf570da4063a0acd14321", async() => {
                WriteLiteral("<i class=\"ti-trash text-info\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\Pemeliharaan\Index.cshtml"
                                                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\Pemeliharaan\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- content-wrapper ends -->
    <!-- partial:../../partials/_footer.html -->
    <footer class=""footer"">
        <div class=""d-sm-flex justify-content-center justify-content-sm-between"">
            <span class=""float-none float-sm-right d-block mt-1 mt-sm-0 text-center"">Copyright ?? 2022. Asset Inventory</span>
        </div>
    </footer>
    <!-- partial -->
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 83 "C:\Users\Selvianisa\source\repos\Inventory\Inventory\Views\Pemeliharaan\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InventorySekolah.Models.Pemeliharaan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
