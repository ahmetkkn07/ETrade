#pragma checksum "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Error\InternalError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "732f8f1800a220b112526863e0e6b0381309ca0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_InternalError), @"mvc.1.0.view", @"/Views/Error/InternalError.cshtml")]
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
#line 1 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\_ViewImports.cshtml"
using WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\_ViewImports.cshtml"
using WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"732f8f1800a220b112526863e0e6b0381309ca0d", @"/Views/Error/InternalError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d8308283e147aceb640f85e77cb8c039e61219", @"/Views/_ViewImports.cshtml")]
    public class Views_Error_InternalError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("loading"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Error\InternalError.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "732f8f1800a220b112526863e0e6b0381309ca0d3738", async() => {
                WriteLiteral(@"
    <title>Bir Hata Oluştu - Kozoka</title>
    <style>
    /**/
        :root {
            --main-color: #eaeaea;
            --stroke-color: black;

        }
        /**/
        body {
            background: var(--main-color);
        }
        h1 {
            margin: 100px auto 0 auto;
            color: var(--stroke-color);
            font-family: 'Encode Sans Semi Condensed', Verdana, sans-serif;
            font-size: 10rem; line-height: 10rem;
            font-weight: 200;
            text-align: center;
        }
        h2 {
            margin: 20px auto 30px auto;
            font-family: 'Encode Sans Semi Condensed', Verdana, sans-serif;
            font-size: 1.5rem;
            font-weight: 200;
            text-align: center;
        }
        h1, h2 {
            -webkit-transition: opacity 0.5s linear, margin-top 0.5s linear; /* Safari */
            transition: opacity 0.5s linear, margin-top 0.5s linear;
        }
        .loading h1, .loading h2 {
   ");
                WriteLiteral(@"         margin-top: 0px;
            opacity: 0;
        }
        .gears {
            position: relative;
            margin: 0 auto;
            width: auto; height: 0;
        }
        .gear {
            position: relative;
            z-index: 0;
            width: 120px; height: 120px;
            margin: 0 auto;
            border-radius: 50%;
            background: var(--stroke-color);
        }
        .gear:before {
            position: absolute; left: 5px; top: 5px; right: 5px; bottom: 5px;
            z-index: 2;
            content: """";
            border-radius: 50%;
            background: var(--main-color);
        }
        .gear:after {
            position: absolute; left: 25px; top: 25px;
            z-index: 3;
            content: """";
            width: 70px; height: 70px;
            border-radius: 50%;
            border: 5px solid var(--stroke-color);
            box-sizing: border-box;
            background: var(--main-color);
        }
        ");
                WriteLiteral(@".gear.one {
            left: -130px;
        }
        .gear.two {
            top: -75px;
        }
        .gear.three {
            top: -235px;
            left: 130px;
        }
        .gear .bar {
            position: absolute; left: -15px; top: 50%;
            z-index: 0;
            width: 150px; height: 30px;
            margin-top: -15px;
            border-radius: 5px;
            background: var(--stroke-color);
        }
        .gear .bar:before {
            position: absolute; left: 5px; top: 5px; right: 5px; bottom: 5px;
            z-index: 1;
            content: """";
            border-radius: 2px;
            background: var(--main-color);
        }
        .gear .bar:nth-child(2) {
            transform: rotate(60deg);
            -webkit-transform: rotate(60deg);
        }
        .gear .bar:nth-child(3) {
            transform: rotate(120deg);
            -webkit-transform: rotate(120deg);
        }
        ");
                WriteLiteral("@-webkit-keyframes clockwise {\r\n            0% { -webkit-transform: rotate(0deg); }\r\n            100% { -webkit-transform: rotate(360deg); }\r\n        }\r\n        ");
                WriteLiteral("@-webkit-keyframes anticlockwise {\r\n            0% { -webkit-transform: rotate(360deg); }\r\n            100% { -webkit-transform: rotate(0deg); }\r\n        }\r\n        ");
                WriteLiteral(@"@-webkit-keyframes clockwiseError {
            0% { -webkit-transform: rotate(0deg); }
            20% { -webkit-transform: rotate(30deg); }
            40% { -webkit-transform: rotate(25deg); }
            60% { -webkit-transform: rotate(30deg); }
            100% { -webkit-transform: rotate(0deg); }
        }
        ");
                WriteLiteral(@"@-webkit-keyframes anticlockwiseErrorStop {
            0% { -webkit-transform: rotate(0deg); }
            20% { -webkit-transform: rotate(-30deg); }
            60% { -webkit-transform: rotate(-30deg); }
            100% { -webkit-transform: rotate(0deg); }
        }
        ");
                WriteLiteral(@"@-webkit-keyframes anticlockwiseError {
            0% { -webkit-transform: rotate(0deg); }
            20% { -webkit-transform: rotate(-30deg); }
            40% { -webkit-transform: rotate(-25deg); }
            60% { -webkit-transform: rotate(-30deg); }
            100% { -webkit-transform: rotate(0deg); }
        }
        .gear.one {
            -webkit-animation: anticlockwiseErrorStop 2s linear infinite;
        }
        .gear.two {
            -webkit-animation: anticlockwiseError 2s linear infinite;
        }
        .gear.three {
            -webkit-animation: clockwiseError 2s linear infinite;
        }
        .loading .gear.one, .loading .gear.three {
            -webkit-animation: clockwise 3s linear infinite;
        }
        .loading .gear.two {
            -webkit-animation: anticlockwise 3s linear infinite;
        }
    </style>
");
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
            WriteLiteral("\r\n<link href=\"https://fonts.googleapis.com/css?family=Encode+Sans+Semi+Condensed:100,200,300,400\" rel=\"stylesheet\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "732f8f1800a220b112526863e0e6b0381309ca0d9947", async() => {
                WriteLiteral("\r\n<h1>Üzgünüz</h1>\r\n<h2>");
#nullable restore
#line 152 "C:\Users\samet\Documents\GitHub\ETrade\ETrade\WebUI\Views\Error\InternalError.cshtml"
Write(Model.ToString());

#line default
#line hidden
#nullable disable
                WriteLiteral(@" <b>:(</b></h2>
<div class=""gears"">
    <div class=""gear one"">
        <div class=""bar""></div>
        <div class=""bar""></div>
        <div class=""bar""></div>
    </div>
    <div class=""gear two"">
        <div class=""bar""></div>
        <div class=""bar""></div>
        <div class=""bar""></div>
    </div>
    <div class=""gear three"">
        <div class=""bar""></div>
        <div class=""bar""></div>
        <div class=""bar""></div>
    </div>
</div>
<script src=""https://code.jquery.com/jquery-1.10.2.js""></script>
<script>
    $(function() {
        setTimeout(function(){
            $('body').removeClass('loading');
        }, 1000);
    });

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
