#pragma checksum "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79c9275a7c4cb9db0cd1b5de5431c78abb1f9004"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Details), @"mvc.1.0.view", @"/Views/Orders/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Orders/Details.cshtml", typeof(AspNetCore.Views_Orders_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79c9275a7c4cb9db0cd1b5de5431c78abb1f9004", @"/Views/Orders/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8790fb32df7caa621b65b0352736b3b5a908d08", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebPetShop.Models.Orders.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
  
    ViewData["Title"] = "Pedido";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(130, 114, true);
            WriteLiteral("\r\n<h2>Mostrar Pedido</h2>\r\n<br />\r\n\r\n<div class=\"row\">\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(245, 40, false);
#line 14 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
            EndContext();
            BeginContext(285, 31, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 18 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
             if (Model.Type == 1)
            {
                

#line default
#line hidden
            BeginContext(438, 25, false);
#line 20 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
           Write(Html.DisplayName("Venda"));

#line default
#line hidden
            EndContext();
#line 20 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
                                          
            }

#line default
#line hidden
            BeginContext(480, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
             if (Model.Type == 2)
            {
                

#line default
#line hidden
            BeginContext(549, 26, false);
#line 25 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
           Write(Html.DisplayName("Adoção"));

#line default
#line hidden
            EndContext();
#line 25 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
                                           
            }

#line default
#line hidden
            BeginContext(592, 41, true);
            WriteLiteral("        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(634, 42, false);
#line 29 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Person));

#line default
#line hidden
            EndContext();
            BeginContext(676, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(720, 43, false);
#line 32 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.Person.Name));

#line default
#line hidden
            EndContext();
            BeginContext(763, 19, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n");
            EndContext();
#line 35 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
         if (Model.Type == 1)
        {   

#line default
#line hidden
            BeginContext(827, 31, true);
            WriteLiteral("         <dt>\r\n                ");
            EndContext();
            BeginContext(859, 41, false);
#line 38 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(900, 49, true);
            WriteLiteral("\r\n         </dt>\r\n         <dd>\r\n                ");
            EndContext();
            BeginContext(950, 37, false);
#line 41 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
           Write(Html.DisplayFor(model => model.Total));

#line default
#line hidden
            EndContext();
            BeginContext(987, 19, true);
            WriteLiteral("\r\n          </dd>\r\n");
            EndContext();
#line 43 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1017, 29, true);
            WriteLiteral("\r\n        <dt>\r\n             ");
            EndContext();
            BeginContext(1047, 28, false);
#line 46 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
        Write(Html.DisplayName("Situação"));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 31, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 49 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
             if (Model.Situation == "A")
            {
                

#line default
#line hidden
            BeginContext(1180, 26, false);
#line 51 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
           Write(Html.DisplayName("Aberto"));

#line default
#line hidden
            EndContext();
#line 51 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
                                           
            }

#line default
#line hidden
            BeginContext(1223, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 54 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
             if (Model.Situation == "C")
            {
                

#line default
#line hidden
            BeginContext(1299, 29, false);
#line 56 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
           Write(Html.DisplayName("Cancelado"));

#line default
#line hidden
            EndContext();
#line 56 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
                                              
            }

#line default
#line hidden
            BeginContext(1345, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 59 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
             if (Model.Situation == "F")
            {
                

#line default
#line hidden
            BeginContext(1421, 30, false);
#line 61 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
           Write(Html.DisplayName("Finalizado"));

#line default
#line hidden
            EndContext();
#line 61 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
                                               
            }

#line default
#line hidden
            BeginContext(1468, 33, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n");
            EndContext();
            BeginContext(1563, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1576, 28, false);
#line 68 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
       Write(Html.DisplayName("Inclusão"));

#line default
#line hidden
            EndContext();
            BeginContext(1604, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1648, 39, false);
#line 71 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.AddDate));

#line default
#line hidden
            EndContext();
            BeginContext(1687, 4, true);
            WriteLiteral(" -  ");
            EndContext();
            BeginContext(1692, 39, false);
#line 71 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.AddUser));

#line default
#line hidden
            EndContext();
            BeginContext(1731, 31, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n");
            EndContext();
            BeginContext(1825, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1838, 29, false);
#line 75 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
       Write(Html.DisplayName("Alteração"));

#line default
#line hidden
            EndContext();
            BeginContext(1867, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1911, 40, false);
#line 78 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
       Write(Html.DisplayFor(model => model.EditDate));

#line default
#line hidden
            EndContext();
            BeginContext(1951, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1955, 40, false);
#line 78 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
                                                   Write(Html.DisplayFor(model => model.EditUser));

#line default
#line hidden
            EndContext();
            BeginContext(1995, 329, true);
            WriteLiteral(@"
        </dd>

    </dl>

    <div id=""itens"" class=""tabDetail"">
        
            <table class=""table"">
                <thead>
                    <tr>
                        <th>Item</th>
                        <th>Descrição</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 93 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
                     for (int i = 0; i <= Model.Itens.Count - 1; i++)
                    {
                        var aux = i + 1;

#line default
#line hidden
            BeginContext(2460, 62, true);
            WriteLiteral("                        <tr>\r\n                            <td>");
            EndContext();
            BeginContext(2523, 3, false);
#line 97 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
                           Write(aux);

#line default
#line hidden
            EndContext();
            BeginContext(2526, 78, true);
            WriteLiteral("</td>\r\n                            <td>\r\n                                Qtde:");
            EndContext();
            BeginContext(2605, 21, false);
#line 99 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
                                Write(Model.Itens[i].Amount);

#line default
#line hidden
            EndContext();
            BeginContext(2626, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(2661, 67, false);
#line 100 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
                           Write(Model.Itens[i].Animal.getAnimalTypeById(@Model.Itens[i].AnimalType));

#line default
#line hidden
            EndContext();
            BeginContext(2728, 35, true);
            WriteLiteral(":\r\n                                ");
            EndContext();
            BeginContext(2764, 28, false);
#line 101 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
                           Write(Model.Itens[i].Animal.Specie);

#line default
#line hidden
            EndContext();
            BeginContext(2792, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 104 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Orders\Details.cshtml"
                    }

#line default
#line hidden
            BeginContext(2883, 97, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n    </div>\r\n\r\n</div>\r\n<br />\r\n<br />\r\n\r\n<div>\r\n");
            EndContext();
            BeginContext(3072, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(3076, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a69d9e8ee20a4c18b03dad865f5ceadd", async() => {
                BeginContext(3122, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3132, 10, true);
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