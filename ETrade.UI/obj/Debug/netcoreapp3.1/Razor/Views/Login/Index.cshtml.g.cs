#pragma checksum "C:\Users\ener-\source\repos\ETrade\ETrade.UI\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d31e81098d1296abd9890ed1208b9f7047a044f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
#line 1 "C:\Users\ener-\source\repos\ETrade\ETrade.UI\Views\_ViewImports.cshtml"
using ETrade.UI;

#line default
#line hidden
#line 2 "C:\Users\ener-\source\repos\ETrade\ETrade.UI\Views\_ViewImports.cshtml"
using ETrade.UI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d31e81098d1296abd9890ed1208b9f7047a044f5", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8c48c315d0e64d94c4900c72630ecfc105e0683", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Util/Ajax.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#line 2 "C:\Users\ener-\source\repos\ETrade\ETrade.UI\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            WriteLiteral(@"<style>
    .multipleChosen, .multipleSelect2 {
        width: 300px;
    }
</style>
<div class=""login_left"">
    <div class=""loginlogo""></div>
    <div class=""question1 ha"" style=""margin-top:5px;"">Members</div>
    <div class=""question2 ha"" style=""margin-top:5px;"">Login</div>
    <div class=""login_text"">Lorem Ipsum is simply dummy text of the printing and <b>typesetting</b> industry. Lorem Ipsum has.</div>

    <div>
        <input type=""text"" id=""UserNameLog"" value=""Username"" onfocus=""if(this.value=='Username')this.value=''"" onblur=""if(this.value=='')this.value='Username'"" class=""login_name"" />
        <br />
        <input type=""text"" id=""PasswordLog"" value=""******"" onfocus=""if(this.value=='******')this.value=''"" onblur=""if(this.value=='')this.value='******'"" class=""login_password"" />
        <input value=""Go »"" id=""btnLogin"" class=""go"" type=""submit"" />
    </div>



    <div style=""clear:both;""></div>
    <div class=""italicblue""><span id=""span"" style=""color: red;font-size: large;""></s");
            WriteLiteral(@"pan></div>
    <br />
    <br />
    <br />

    <div style=""clear:both;""></div>
    <div class=""hbar"">-</div>
    <div class=""italicblue""><a href=""#"">Forgot Password?</a></div>
    <div style=""clear:both;""></div>
    <div class=""hbar"">-</div>
    <div class=""italicblue""><a href=""#"">Forgot Username?</a></div>
</div>




<div class=""login_right"">
    <div class=""registerlogo""></div>
    <div class=""question1 ha"" style=""margin-top:5px;"">Kayıt Ol</div>
    <div class=""question2 ha"" style=""margin-top:5px;"">Şimdi</div>

    <div>
        <input type=""text"" id=""UserName"" value=""Username"" onfocus=""if(this.value=='Username')this.value=''"" onblur=""if(this.value=='')this.value='Username'"" class=""register_name"" />
        <br />
        <input type=""text"" id=""Password"" value=""Password"" onfocus=""if(this.value=='Password')this.value=''"" onblur=""if(this.value=='')this.value='Password'"" class=""register_password"" />
        <br />
        <input type=""text"" id=""Email"" value=""Em@il"" onfocus=""if(this.");
            WriteLiteral(@"value=='Em@il')this.value=''"" onblur=""if(this.value=='')this.value='Em@il'"" class=""register_password"" />
        <br />
      
        <input value=""Register"" id=""btnRegister"" class=""register_account"" type=""submit"" />

    </div>


    <div class=""checkbox"">
        <input type=""checkbox"" id=""cb"" name=""box"" />
    </div>
    <div class=""cbtext"">Do you advice lorem?</div>
    <div class=""cbtextsmall"">You should read <a href=""#"">equired</a> pisum lotus</div>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d31e81098d1296abd9890ed1208b9f7047a044f56301", async() => {
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
    <script>
        $(""#btnRegister"").click(function () {

            var data = {
                ""UserName"": $(""#UserName"").val(),
                ""Password"": $(""#Password"").val(),
                ""Email"": $(""#Email"").val(),
                ""UserType"": ""2"",
            };

            Util.Ajax.Generic(""log"", data, ""POST"", ""json"", false, null, success, null, null);



            function success(status) {
                var asd = 0;
            }

        });
    </script>

    <script>
        $(""#btnLogin"").click(function () {

            var data = {
                ""UserNameLog"": $(""#UserNameLog"").val(),
                ""PasswordLog"": $(""#PasswordLog"").val()
            };
            //logg


            Util.Ajax.Generic(""logg"", data, ""POST"", ""json"", false, null, success, null, null);

            function success(status) {
                if (status.operation == ""Success"") {
                    window.location.href = ""anasayfa"";
                } else if (st");
            WriteLiteral("atus.operation == \"Wrong\") {\r\n                    $(\"#span\").append(\"Hatalı Giriş\");\r\n                }\r\n            }\r\n        });\r\n    </script>\r\n</div>\r\n\r\n");
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
