#pragma checksum "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fda438c4359814d1687b95b89643a40095ec05ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Delete), @"mvc.1.0.view", @"/Views/Orders/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Delete.cshtml", typeof(AspNetCore.Views_Orders_Delete))]
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
#line 1 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\_ViewImports.cshtml"
using WebPetShop;

#line default
#line hidden
#line 2 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\_ViewImports.cshtml"
using WebPetShop.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fda438c4359814d1687b95b89643a40095ec05ae", @"/Views/Orders/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8790fb32df7caa621b65b0352736b3b5a908d08", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebPetShop.Models.Orders.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
  
    ViewData["Title"] = "Pedido";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 138, true);
            WriteLiteral("\r\n<h2>Excluir Pedido</h2>\r\n\r\n<h3>Deseja mesmo excluir esse pedido?</h3>\r\n<div>\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(269, 40, false);
#line 14 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(309, 31, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 18 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
             if (Model.Type == 1)
            {
                

#line default
#line hidden
            BeginContext(462, 25, false);
#line 20 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
           Write(Html.DisplayName("Venda"));

#line default
#line hidden
            EndContext();
#line 20 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
                                          
            }

#line default
#line hidden
            BeginContext(504, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
             if (Model.Type == 2)
            {
                

#line default
#line hidden
            BeginContext(573, 26, false);
#line 25 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
           Write(Html.DisplayName("Adoção"));

#line default
#line hidden
            EndContext();
#line 25 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
                                           
            }

#line default
#line hidden
            BeginContext(616, 41, true);
            WriteLiteral("        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(658, 42, false);
#line 29 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Person));

#line default
#line hidden
            EndContext();
            BeginContext(700, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(744, 43, false);
#line 32 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Person.Name));

#line default
#line hidden
            EndContext();
            BeginContext(787, 19, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n");
            EndContext();
#line 35 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
         if (Model.Type == 1)
        {

#line default
#line hidden
            BeginContext(848, 34, true);
            WriteLiteral("            <dt>\r\n                ");
            EndContext();
            BeginContext(883, 41, false);
#line 38 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(924, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(980, 37, false);
#line 41 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(1017, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
#line 43 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
        }

#line default
#line hidden
            BeginContext(1049, 20, true);
            WriteLiteral("\r\n            <dt>\r\n");
            EndContext();
            BeginContext(1135, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1152, 28, false);
#line 47 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
           Write(Html.DisplayName("Inclusão"));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1236, 39, false);
#line 50 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
           Write(Html.DisplayFor(model => model.AddDate));

#line default
#line hidden
            EndContext();
            BeginContext(1275, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1279, 39, false);
#line 50 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
                                                      Write(Html.DisplayFor(model => model.AddUser));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 39, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt>\r\n");
            EndContext();
            BeginContext(1424, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1441, 29, false);
#line 54 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
           Write(Html.DisplayName("Alteração"));

#line default
#line hidden
            EndContext();
            BeginContext(1470, 55, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(1526, 40, false);
#line 57 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
           Write(Html.DisplayFor(model => model.EditDate));

#line default
#line hidden
            EndContext();
            BeginContext(1566, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1570, 40, false);
#line 57 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
                                                       Write(Html.DisplayFor(model => model.EditUser));

#line default
#line hidden
            EndContext();
            BeginContext(1610, 59, true);
            WriteLiteral("\r\n            </dd>\r\n           \r\n        </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1669, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eccb90b51e4541e6a4bcb927c97d38ea", async() => {
                BeginContext(1695, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1705, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3b6289803c2b47fa8af25661c897cbd1", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 63 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1741, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1825, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f5e15bd44dd4737bdd54e9e2ed91084", async() => {
                    BeginContext(1847, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1863, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1876, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebPetShop.Models.Orders.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
