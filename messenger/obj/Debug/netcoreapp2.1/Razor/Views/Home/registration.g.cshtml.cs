#pragma checksum "D:\0.project\c_sharp\messenger\messenger\Views\Home\registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8e8f4453095259143a0e419f486f225c2d99249"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_registration), @"mvc.1.0.view", @"/Views/Home/registration.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/registration.cshtml", typeof(AspNetCore.Views_Home_registration))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8e8f4453095259143a0e419f486f225c2d99249", @"/Views/Home/registration.cshtml")]
    public class Views_Home_registration : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:Yellow; background: url(/images/bg.jpg); background-size: cover;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(27, 551, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f328b9d2d7204b0595366cf96ec4729c", async() => {
                BeginContext(33, 538, true);
                WriteLiteral(@"
    <title>Регистрация</title>
    <style>
        .licat {
            border: 1px solid #c4c4c4;
            border-radius: 3px;
            padding: 0 5px 2px 5px;
            color: #fff;
            background: #0033FF;
            -webkit-transition: background 1s ease;
            width: 230px;
            height: 30px;
            font-size: 22px
        }
        .licat:hover {
                background: #EFEFEF;
        }
        input.licat:hover {
            color: #0000CC;
        }
    </style>
");
                EndContext();
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
            EndContext();
            BeginContext(578, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(584, 1659, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b92897609de94af3b7e055907152db71", async() => {
                BeginContext(669, 1378, true);
                WriteLiteral(@"

         <table border=""0"" cellspacing=""5"" cellpadding=""12"">
             <tr>
                 <td valign=""top"" width=""2000"" height=""515"" style=""vertical-align: middle"">
                     <center>
                         <h1 style=""font-size: 250%"">Регистрация</h1>
                         <form method=""post"">
                             <table width=""400"" border=""0"">
                                 <tr style=""font-size: 200%"">
                                     <td align=""right"">Имя:</td>
                                     <td align=""left""><input type=""text"" name=""Name"" style=""width: 200px; height: 30px; font-size:20px"" /></td>
                                 </tr>
                                 <tr style=""font-size: 200%"">
                                     <td align=""right"">Пароль:</td>
                                     <td align=""left""><input type=""text"" name=""Pass"" style=""width: 200px; height: 30px; font-size:20px"" /></td>
                                 </tr>
     ");
                WriteLiteral(@"                            <tr><td colspan=""2"" align=""center""><input type=""submit"" value=""Зарегистрироваться"" class=""licat"" /></td><td></td></tr>
                             </table>
                         </form>
                     </center>
                 </td>
             </tr>
             <tr>
                 <td align=""center"">
");
                EndContext();
#line 51 "D:\0.project\c_sharp\messenger\messenger\Views\Home\registration.cshtml"
                      if (ViewBag.except == 1)
                     {

#line default
#line hidden
                BeginContext(2117, 47, true);
                WriteLiteral("<p> Такое имя уже есть, попробуйте еще раз </p>");
                EndContext();
#line 52 "D:\0.project\c_sharp\messenger\messenger\Views\Home\registration.cshtml"
                                                                     }

#line default
#line hidden
                BeginContext(2167, 69, true);
                WriteLiteral("                 </td>\r\n             </tr>\r\n         </table>\r\n\r\n    ");
                EndContext();
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
            EndContext();
            BeginContext(2243, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591