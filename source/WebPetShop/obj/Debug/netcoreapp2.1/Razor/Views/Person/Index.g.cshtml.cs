#pragma checksum "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1233a1bfde1fbfca1e1ff8da80703f590332bcb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Index), @"mvc.1.0.view", @"/Views/Person/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Index.cshtml", typeof(AspNetCore.Views_Person_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1233a1bfde1fbfca1e1ff8da80703f590332bcb", @"/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8790fb32df7caa621b65b0352736b3b5a908d08", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebPetShop.Models.People.Person>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Find", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
  
    ViewBag.Title = "Pessoas";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 48, true);
            WriteLiteral("\r\n<h2>Lista de Pessoas</h2>\r\n<br />\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(189, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "67b5ebc2d0fd4c339334e61434700019", async() => {
                BeginContext(236, 4, true);
                WriteLiteral("Novo");
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
            BeginContext(244, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(250, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4edf89a4fd042b0b933159884dd610b", async() => {
                BeginContext(295, 9, true);
                WriteLiteral("Consultar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(308, 211, true);
            WriteLiteral("\r\n</p>\r\n\r\n<div id=\"grid\" style=\"border:1px solid black; height:350px; overflow-y: auto; font-size:10pt;\">\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(520, 40, false);
#line 21 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(560, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(628, 45, false);
#line 24 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Document1));

#line default
#line hidden
            EndContext();
            BeginContext(673, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(741, 45, false);
#line 27 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Document2));

#line default
#line hidden
            EndContext();
            BeginContext(786, 47, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n");
            EndContext();
            BeginContext(908, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(929, 31, false);
#line 31 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
               Write(Html.DisplayName("Cidade - UF"));

#line default
#line hidden
            EndContext();
            BeginContext(960, 25, true);
            WriteLiteral("\r\n                </th>\r\n");
            EndContext();
            BeginContext(1114, 42, true);
            WriteLiteral("                <th>\r\n                    ");
            EndContext();
            BeginContext(1157, 27, false);
#line 37 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
               Write(Html.DisplayName("Contato"));

#line default
#line hidden
            EndContext();
            BeginContext(1184, 47, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n");
            EndContext();
            BeginContext(1301, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1322, 28, false);
#line 41 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
               Write(Html.DisplayName("Inclução"));

#line default
#line hidden
            EndContext();
            BeginContext(1350, 47, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n");
            EndContext();
            BeginContext(1468, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1489, 29, false);
#line 45 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
               Write(Html.DisplayName("Alteração"));

#line default
#line hidden
            EndContext();
            BeginContext(1518, 106, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 51 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1681, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1754, 39, false);
#line 55 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1793, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1873, 44, false);
#line 58 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Document1));

#line default
#line hidden
            EndContext();
            BeginContext(1917, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1997, 44, false);
#line 61 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Document2));

#line default
#line hidden
            EndContext();
            BeginContext(2041, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
            BeginContext(2350, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(2401, 47, false);
#line 70 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Address.City));

#line default
#line hidden
            EndContext();
            BeginContext(2448, 4, true);
            WriteLiteral(" -  ");
            EndContext();
            BeginContext(2453, 48, false);
#line 70 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
                                                                       Write(Html.DisplayFor(modelItem => item.Address.State));

#line default
#line hidden
            EndContext();
            BeginContext(2501, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
            BeginContext(2670, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(2721, 28, false);
#line 76 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
                   Write(item.Contacts[0].Description);

#line default
#line hidden
            EndContext();
            BeginContext(2749, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2829, 42, false);
#line 79 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AddDate));

#line default
#line hidden
            EndContext();
            BeginContext(2871, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2873, 42, false);
#line 79 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
                                                               Write(Html.DisplayFor(modelItem => item.AddUser));

#line default
#line hidden
            EndContext();
            BeginContext(2915, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2995, 43, false);
#line 82 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EditDate));

#line default
#line hidden
            EndContext();
            BeginContext(3038, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3040, 43, false);
#line 82 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
                                                                Write(Html.DisplayFor(modelItem => item.EditUser));

#line default
#line hidden
            EndContext();
            BeginContext(3083, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3162, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3168ff3025b647a9a299ecfe16be4e49", async() => {
                BeginContext(3207, 7, true);
                WriteLiteral("Alterar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 85 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
                                               WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3218, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(3246, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92adeadbf37b472085492dfbe002bc94", async() => {
                BeginContext(3293, 7, true);
                WriteLiteral("Excluir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 86 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
                                                 WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3304, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(3332, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6826805f737f4c78969b3ce9fe627907", async() => {
                BeginContext(3380, 7, true);
                WriteLiteral("Mostrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 87 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
                                                  WriteLiteral(item.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(3391, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 90 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3458, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebPetShop.Models.People.Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
