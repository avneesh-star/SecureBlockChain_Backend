#pragma checksum "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b41383f64dbced284b48271e5afce2d442ea08807aae1289417ffdc6d01c9a5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SupplyBlockChain_Backend.Pages.Pages_ShowProducts), @"mvc.1.0.razor-page", @"/Pages/ShowProducts.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/ShowProducts.cshtml", typeof(SupplyBlockChain_Backend.Pages.Pages_ShowProducts), null)]
namespace SupplyBlockChain_Backend.Pages
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\_ViewImports.cshtml"
using SupplyBlockChain_Backend

#line default
#line hidden
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b41383f64dbced284b48271e5afce2d442ea08807aae1289417ffdc6d01c9a5a", @"/Pages/ShowProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"672e7b0d84c909ec02d1ac7e4b38e31079294e64b0ec471acb6a977f704ade6d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ShowProducts : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/GenerateQrCode", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
  
    ViewData["Title"] = "MyProducts";

#line default
#line hidden

            BeginContext(110, 303, true);
            WriteLiteral(@"
<br />
<div class=""row"">
    <h3 class=""text-left"" style=""font-family:'Comic Sans MS';"">Your Products</h3>
    <table class=""table table-hover"">
        <tr>
            <th>Name</th>
            <th>Type</th>
            <th>Creation Date</th>
            <th>Product ID</th>
        </tr>
");
            EndContext();
#line 17 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
         foreach (var item in Model.MyProducts)
        {

#line default
#line hidden

            BeginContext(473, 38, true);
            WriteLiteral("            <tr>\r\n                <th>");
            EndContext();
            BeginContext(511, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b41383f64dbced284b48271e5afce2d442ea08807aae1289417ffdc6d01c9a5a4585", async() => {
                BeginContext(643, 16, false);
                Write(
#line 20 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
                                                                                                                                                        item.ProductName

#line default
#line hidden
                );
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#line 20 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
                                                                   item.ProductName

#line default
#line hidden
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#line 20 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
                                                                                                      item.ProductType

#line default
#line hidden
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-type", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#line 20 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
                                                                                                                                       item.ProductID

#line default
#line hidden
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(663, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(690, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b41383f64dbced284b48271e5afce2d442ea08807aae1289417ffdc6d01c9a5a9081", async() => {
                BeginContext(822, 16, false);
                Write(
#line 21 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
                                                                                                                                                        item.ProductType

#line default
#line hidden
                );
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#line 21 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
                                                                   item.ProductName

#line default
#line hidden
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#line 21 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
                                                                                                      item.ProductType

#line default
#line hidden
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-type", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#line 21 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
                                                                                                                                       item.ProductID

#line default
#line hidden
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(842, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(869, 167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b41383f64dbced284b48271e5afce2d442ea08807aae1289417ffdc6d01c9a5a13577", async() => {
                BeginContext(1002, 29, false);
                Write(
#line 22 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
                                                                                                                                                         item.Time + " - " + item.Date

#line default
#line hidden
                );
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#line 22 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
                                                                   item.ProductName

#line default
#line hidden
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#line 22 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
                                                                                                      item.ProductType

#line default
#line hidden
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-type", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#line 22 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
                                                                                                                                       item.ProductID

#line default
#line hidden
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1036, 27, true);
            WriteLiteral("</th>\r\n                <th>");
            EndContext();
            BeginContext(1063, 150, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b41383f64dbced284b48271e5afce2d442ea08807aae1289417ffdc6d01c9a5a18091", async() => {
                BeginContext(1195, 14, false);
                Write(
#line 23 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
                                                                                                                                                        item.ProductID

#line default
#line hidden
                );
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#line 23 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
                                                                   item.ProductName

#line default
#line hidden
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#line 23 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
                                                                                                      item.ProductType

#line default
#line hidden
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-type", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral(
#line 23 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
                                                                                                                                       item.ProductID

#line default
#line hidden
            );
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1213, 26, true);
            WriteLiteral("</th>\r\n            </tr>\r\n");
            EndContext();
#line 25 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
        }

#line default
#line hidden

            BeginContext(1250, 26, true);
            WriteLiteral("    </table>\r\n</div>\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1294, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1301, 52, false);
                Write(
#line 31 "C:\Users\avnee\source\repos\SupplyBlockChain_Backend\SupplyBlockChain_Backend\SupplyBlockChain_Backend\Pages\ShowProducts.cshtml"
     await Html.PartialAsync("_ValidationScriptsPartial")

#line default
#line hidden
                );
                EndContext();
                BeginContext(1353, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SupplyBlockChain_Backend.Pages.ShowProductsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SupplyBlockChain_Backend.Pages.ShowProductsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SupplyBlockChain_Backend.Pages.ShowProductsModel>)PageContext?.ViewData;
        public SupplyBlockChain_Backend.Pages.ShowProductsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
