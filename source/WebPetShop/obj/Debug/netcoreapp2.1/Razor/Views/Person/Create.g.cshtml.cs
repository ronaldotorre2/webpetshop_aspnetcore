#pragma checksum "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "000ca0db0da9142ae64020081355fe2fd77c51bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Create), @"mvc.1.0.view", @"/Views/Person/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Create.cshtml", typeof(AspNetCore.Views_Person_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"000ca0db0da9142ae64020081355fe2fd77c51bc", @"/Views/Person/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8790fb32df7caa621b65b0352736b3b5a908d08", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebPetShop.Models.People.Person>
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
  
    ViewBag.Title = "Pessoa";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 34, true);
            WriteLiteral("\r\n<h2>Nova Pessoa</h2>\r\n<br />\r\n\r\n");
            EndContext();
#line 11 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(196, 23, false);
#line 13 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(223, 45, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n\r\n        ");
            EndContext();
            BeginContext(269, 64, false);
#line 17 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(333, 50, true);
            WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(384, 93, false);
#line 20 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
       Write(Html.LabelFor(model => model.Type, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(477, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(533, 139, false);
#line 22 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.RadioButtonFor(model => model.Type, 0, htmlAttributes: new { @class = "control-label", @id = "pf", @name = "type" , @checked = true }));

#line default
#line hidden
            EndContext();
            BeginContext(672, 25, true);
            WriteLiteral(" Física\r\n                ");
            EndContext();
            BeginContext(698, 121, false);
#line 23 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.RadioButtonFor(model => model.Type, 1, htmlAttributes: new { @class = "control-label", @id = "pj", @name = "type" }));

#line default
#line hidden
            EndContext();
            BeginContext(819, 27, true);
            WriteLiteral(" Jurídica\r\n                ");
            EndContext();
            BeginContext(847, 82, false);
#line 24 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Type, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(929, 152, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n        <fieldset>\r\n            <legend>Geral</legend>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1082, 93, false);
#line 32 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1175, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(1239, 129, false);
#line 34 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control", autocomplete = "off", @id = "Name" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1391, 82, false);
#line 35 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1473, 115, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div id=\"cpj\" class=\"form-group\">\r\n                    ");
            EndContext();
            BeginContext(1589, 99, false);
#line 40 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.LabelFor(model => model.SocialName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1688, 71, true);
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
            EndContext();
            BeginContext(1760, 141, false);
#line 42 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
                   Write(Html.EditorFor(model => model.SocialName, new { htmlAttributes = new { @class = "form-control", autocomplete = "off", @id = "SocialName" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1901, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1928, 88, false);
#line 43 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.SocialName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2016, 118, true);
            WriteLiteral("\r\n                    </div>\r\n            </div>\r\n            \r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(2135, 95, false);
#line 48 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.LabelFor(model => model.Gender, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2230, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(2294, 410, false);
#line 50 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.DropDownListFor(model => model.Gender, new List<SelectListItem>
                        {
                           new SelectListItem() {Text = "", Value= "0"},
                           new SelectListItem() {Text = "Feminino", Value= "0"},
                           new SelectListItem() {Text = "Masculino", Value= "1"}
                        }, new { @class = "form-control", @id = "Gender" }));

#line default
#line hidden
            EndContext();
            BeginContext(2704, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2727, 84, false);
#line 56 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Gender, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2811, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(2914, 98, false);
#line 61 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.LabelFor(model => model.Birthdate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3012, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(3076, 150, false);
#line 63 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.EditorFor(model => model.Birthdate, new { htmlAttributes = new { @class = "form-control datePicker", autocomplete = "off", @id = "Birthdate" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3226, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3342, 100, true);
            WriteLiteral("                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(3443, 98, false);
#line 69 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.LabelFor(model => model.Document1, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3541, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(3605, 139, false);
#line 71 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.EditorFor(model => model.Document1, new { htmlAttributes = new { @class = "form-control", autocomplete = "off", @id = "Document1" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3744, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3767, 87, false);
#line 72 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Document1, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3854, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(3957, 98, false);
#line 77 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.LabelFor(model => model.Document2, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4055, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(4119, 139, false);
#line 79 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.EditorFor(model => model.Document2, new { htmlAttributes = new { @class = "form-control", autocomplete = "off", @id = "Document2" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4258, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(4281, 87, false);
#line 80 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Document2, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4368, 186, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        </fieldset>\r\n\r\n        <fieldset>\r\n            <legend>Filiação</legend>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(4555, 99, false);
#line 90 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.LabelFor(model => model.MotherName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(4654, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(4718, 141, false);
#line 92 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.EditorFor(model => model.MotherName, new { htmlAttributes = new { @class = "form-control", autocomplete = "off", @id = "MotherName" } }));

#line default
#line hidden
            EndContext();
            BeginContext(4859, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(4882, 88, false);
#line 93 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.MotherName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4970, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(5073, 99, false);
#line 98 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.LabelFor(model => model.FatherName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(5172, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(5236, 141, false);
#line 100 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.EditorFor(model => model.FatherName, new { htmlAttributes = new { @class = "form-control", autocomplete = "off", @id = "FatherName" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5377, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(5400, 88, false);
#line 101 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.FatherName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5488, 184, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </fieldset>\r\n\r\n        <fieldset>\r\n            <legend>Endereço</legend>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(5673, 111, false);
#line 110 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.LabelFor(model => model.Address.ZipCode, "CEP", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(5784, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(5848, 143, false);
#line 112 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.EditorFor(model => model.Address.ZipCode, new { htmlAttributes = new { @class = "form-control", autocomplete = "off", @id = "ZipCode" } }));

#line default
#line hidden
            EndContext();
            BeginContext(5991, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(6014, 93, false);
#line 113 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Address.ZipCode, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(6107, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(6210, 113, false);
#line 118 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.LabelFor(model => model.Address.Name, "Endereço", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(6323, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(6387, 140, false);
#line 120 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.EditorFor(model => model.Address.Name, new { htmlAttributes = new { @class = "form-control", autocomplete = "off", @id = "Address" } }));

#line default
#line hidden
            EndContext();
            BeginContext(6527, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(6550, 90, false);
#line 121 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Address.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(6640, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(6743, 113, false);
#line 126 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.LabelFor(model => model.Address.Number, "Número", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(6856, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(6920, 141, false);
#line 128 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.EditorFor(model => model.Address.Number, new { htmlAttributes = new { @class = "form-control", autocomplete = "off", @id = "Number" } }));

#line default
#line hidden
            EndContext();
            BeginContext(7061, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(7084, 92, false);
#line 129 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Address.Number, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(7176, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(7279, 122, false);
#line 134 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.LabelFor(model => model.Address.Complement, "Complemento", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(7401, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(7465, 129, false);
#line 136 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.EditorFor(model => model.Address.Complement, new { htmlAttributes = new { @class = "form-control", autocomplete = "off" } }));

#line default
#line hidden
            EndContext();
            BeginContext(7594, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(7617, 96, false);
#line 137 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Address.Complement, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(7713, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(7816, 115, false);
#line 142 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.LabelFor(model => model.Address.District, "Bairro", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(7931, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(7995, 145, false);
#line 144 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.EditorFor(model => model.Address.District, new { htmlAttributes = new { @class = "form-control", autocomplete = "off", @id = "District" } }));

#line default
#line hidden
            EndContext();
            BeginContext(8140, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(8163, 94, false);
#line 145 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Address.District, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(8257, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(8360, 111, false);
#line 150 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.LabelFor(model => model.Address.City, "Cidade", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(8471, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(8535, 137, false);
#line 152 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.EditorFor(model => model.Address.City, new { htmlAttributes = new { @class = "form-control", autocomplete = "off", @id = "City" } }));

#line default
#line hidden
            EndContext();
            BeginContext(8672, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(8695, 90, false);
#line 153 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Address.City, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(8785, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(8888, 112, false);
#line 158 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.LabelFor(model => model.Address.State, "Estado", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(9000, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(9064, 139, false);
#line 160 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.EditorFor(model => model.Address.State, new { htmlAttributes = new { @class = "form-control", autocomplete = "off", @id = "State" } }));

#line default
#line hidden
            EndContext();
            BeginContext(9203, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(9226, 91, false);
#line 161 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Address.State, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(9317, 186, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        </fieldset>\r\n\r\n        <fieldset>\r\n            <legend>Contatos</legend>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(9504, 106, false);
#line 171 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.LabelFor(model => model.Phone, "Telefone", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(9610, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(9674, 131, false);
#line 173 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.EditorFor(model => model.Phone, new { htmlAttributes = new { @class = "form-control", autocomplete = "off", @id = "Phone" } }));

#line default
#line hidden
            EndContext();
            BeginContext(9805, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(9828, 83, false);
#line 174 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Phone, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(9911, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(10014, 104, false);
#line 179 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.LabelFor(model => model.Cell, "Celular", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(10118, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(10182, 129, false);
#line 181 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.EditorFor(model => model.Cell, new { htmlAttributes = new { @class = "form-control", autocomplete = "off", @id = "Cell" } }));

#line default
#line hidden
            EndContext();
            BeginContext(10311, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(10334, 82, false);
#line 182 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Cell, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(10416, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(10519, 103, false);
#line 187 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
           Write(Html.LabelFor(model => model.Mail, "E-mail", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(10622, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(10686, 129, false);
#line 189 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.EditorFor(model => model.Mail, new { htmlAttributes = new { @class = "form-control", autocomplete = "off", @id = "Mail" } }));

#line default
#line hidden
            EndContext();
            BeginContext(10815, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(10838, 82, false);
#line 190 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Mail, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(10920, 288, true);
            WriteLiteral(@"
                </div>
            </div>


        </fieldset>
        <br />
        <br />

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Salvar"" class=""btn btn-default"" />
                ");
            EndContext();
            BeginContext(11208, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aaa660f4de144c71bb7f55b965cbae98", async() => {
                BeginContext(11254, 8, true);
                WriteLiteral("Cancelar");
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
            BeginContext(11266, 50, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 206 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
}

#line default
#line hidden
            BeginContext(11319, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(11341, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 210 "C:\Users\Ronaldo.NSAB\Deve\C#\WebPetShop\WebPetShop\Views\Person\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(11411, 464, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $('#pf').on('click', function () {
            $('#cpj').hide();
        });

        $('#pj').on('click', function () {
            $('#cpj').show();
        });

        $(document).ready(function () {
            $('#pf').attr('checked', true);
            $('#cpj').hide();

            $('#Phone').mask('(00)0000-0000');
            $('#Cell').mask('(00)00000-0000');
        });

    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebPetShop.Models.People.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591