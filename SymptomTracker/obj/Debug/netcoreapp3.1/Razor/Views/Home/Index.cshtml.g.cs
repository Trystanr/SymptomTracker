#pragma checksum "C:\Users\User\source\repos\SymptomTracker\SymptomTracker\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "337b7ca01782e7eeee0051bbbc2411ece5bddb13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\User\source\repos\SymptomTracker\SymptomTracker\Views\_ViewImports.cshtml"
using SymptomTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\SymptomTracker\SymptomTracker\Views\_ViewImports.cshtml"
using SymptomTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"337b7ca01782e7eeee0051bbbc2411ece5bddb13", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"019a1b8d6f638bd13305b72ff8278c2c4afb0e69", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Symptoms", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\User\source\repos\SymptomTracker\SymptomTracker\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<header>
    <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active""></li>
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""1""></li>
            <li data-target=""#carouselExampleIndicators"" data-slide-to=""2""></li>
        </ol>
        <div class=""carousel-inner"" role=""listbox"">
            <!-- Slide One - Set the background image for this slide in the line below -->
            <div class=""carousel-item active"" style=""background-image: url('https://source.unsplash.com/fAiQRv7FgE0/1920x1080')"">
                <div class=""carousel-caption d-md-block"">
                    <h2 class=""display-4"">Stay Safe</h2>
                    <p class=""lead"">Track your symptoms.</p>
                </div>
            </div>
            <!-- Slide Two - Set the background image for this slide in the line below -->
            <div cl");
            WriteLiteral(@"ass=""carousel-item"" style=""background-image: url('https://source.unsplash.com/LThqAPBpqtI/1920x1080')"">
                <div class=""carousel-caption d-md-block"">
                    <h2 class=""display-4"">Confirm Your Status</h2>
                    <p class=""lead"">Get the help you need, when you need it.</p>
                </div>
            </div>
            <!-- Slide Three - Set the background image for this slide in the line below -->
            <div class=""carousel-item"" style=""background-image: url('https://source.unsplash.com/z2v23KWm5D0/2953×3937'); background-position: center"">
                <div class=""carousel-caption d-md-block"">
                    <h2 class=""display-4"">Backed By Professionals</h2>
                    <p class=""lead"">Industry experts leading key insights.</p>
                </div>
            </div>
        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
            <span class=""carousel-contr");
            WriteLiteral(@"ol-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
</header>

<div class=""position-relative overflow-hidden p-3 p-md-5 m-md-3 text-center bg-dark"">
    <div class=""mx-auto my-5"">

        <h2 class=""display-5"">Get Started Today</h2>

        <p class=""lead font-weight-normal"">Create an account and start tracking your symptoms today.</p>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "337b7ca01782e7eeee0051bbbc2411ece5bddb137416", async() => {
                WriteLiteral("Start Tracking");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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

<div class=""row position-relative overflow-hidden p-3 p-md-5 m-md-3 text-center bg-dark"">
    <div class=""col-sm"">
    </div>
    <div class=""col-sm"">
        <p class=""icon-box"">
            <i class=""fas fa-lock fa-3x""></i>
        </p>
        <h3 class=""display-5"">Secure</h3>
        <p class=""lead"">Authenticate with the latest modern Authentication middleware.</p>
    </div>
    <div class=""col-sm"">
        <p class=""icon-box"">
            <i class=""fas fa-fighter-jet fa-3x""></i>
        </p>
        <h3 class=""display-5"">Quick</h3>
        <p class=""lead"">Spend less time waiting and more time working.</p>
    </div>
    <div class=""col-sm"">
        <p class=""icon-box"">
            <i class=""fas fa-comment-dollar fa-3x""></i>
        </p>
        <h3 class=""display-5"">Free</h3>
        <p class=""lead"">Thats right, logging with SymptomTracker is totally free to use.</p>
    </div>
    <div class=""col-sm"">
    </div>
</div>

<div class=""position-relative");
            WriteLiteral(@" overflow-hidden p-3 p-md-5 m-md-3 text-center bg-dark"">
    <div class=""mx-auto my-5"">

        <h2 class=""display-5"">About Symptom Tracker</h2>

        <div class=""container pt-3"">
            <div class=""row"">
                <div class=""col-sm"">
                    <p"">
                        By logging your data using Symptom Tracker, you can find a pattern, triggering your doctors's attention to a potential CoVid-19 issue. This is great because you can then be assured that it will know when you are sick and let you know when you need to take action.
                        </p>
                </div>
            </div>
        </div>

        <div class=""container pt-3"">
            <div class=""row"">
                <div class=""col-sm"">
                    <p>
                        A team of professionals that monitors your symptoms will set a cost for you for a subscription.  You can ask what this cost will be but your health insurance will need to cover it.  The price will be de");
            WriteLiteral(@"termined by your insurance and how many visits you need to be on it each month.
                    </p>
                </div>
            </div>
        </div>

        
    </div>
</div>

<div class=""position-relative overflow-hidden m-md-3 text-center bg-dark"">
    <div class=""mx-auto my-5"">

        <div class=""container"">
            <div class=""row"">
                <div class=""col-sm"">
                    <p"">Trystan Rivers 2020 <br /><a href=""https://github.com/Trystanr/SymptomTracker"">Github</a></p>
                </div>
            </div>
        </div>



    </div>
</div>");
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
