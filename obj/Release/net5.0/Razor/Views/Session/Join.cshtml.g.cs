#pragma checksum "/Users/richmooremiro/Projects/Miro.WebSockets/Miro.WebSockets/Views/Session/Join.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ba6233f36008baf2c406fd4ad7dcd5aa164f67e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Session_Join), @"mvc.1.0.view", @"/Views/Session/Join.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ba6233f36008baf2c406fd4ad7dcd5aa164f67e", @"/Views/Session/Join.cshtml")]
    public class Views_Session_Join : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            WriteLiteral("\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ba6233f36008baf2c406fd4ad7dcd5aa164f67e2661", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta http-equiv=""Cache-Control"" content=""no-cache, no-store, must-revalidate"" />
    <meta http-equiv=""Pragma"" content=""no-cache"" />
    <meta http-equiv=""Expires"" content=""0"" />
    <link rel=""stylesheet"" href=""../css/semantic.min.css"">
    <script src=""../js/signalr/dist/browser/signalr.js""></script>
    <script>
        var connection = new signalR.HubConnectionBuilder().withUrl(""/qr/miroHub"").build();


        connection.start().then(function () {
            console.log(""Connected"");

            connection.invoke('BoardConnected', getParameterByName(""code""))
                .then(function (value) {
                    if (value == true) {
                        console.log(""Good Link"");

                        document.getElementById(""loader"").style.display = ""none"";
                        document.getElementById(""main"").style.display = ""block"";

                    } else {
                        console.log(""Bad Link"");

                        document.getEleme");
                WriteLiteral(@"ntById(""loader"").style.display = ""none"";
                        document.getElementById(""errorLink"").style.display = ""block"";
                    }

                });


        }).catch(function (err) {

            document.getElementById(""loader"").style.display = ""none"";
            document.getElementById(""error"").style.display = ""block"";
            return console.error(err.toString());

        });

        function addSticky() {

            document.getElementById(""errorsticky"").style.display = ""none"";

            var value = document.getElementById(""txtSticker"").value;

            document.getElementById(""txtSticker"").value = """";

            var clientID = getParameterByName(""code"");

            console.log(""Value: "" + value + "" Client: "" + clientID);

            connection.invoke(""SendSticky"", value, clientID).catch(function (err) {
                document.getElementById(""txtSticker"").value = value;
                document.getElementById(""errorsticky"").style.display = ""block"";
             ");
                WriteLiteral(@"   return console.error(err.toString());
            });

        }

        function getParameterByName(name, url = window.location.href) {
            name = name.replace(/[\[\]]/g, '\\$&');
            var regex = new RegExp('[?&]' + name + '(=([^&#]*)|&|#|$)'),
                results = regex.exec(url);
            if (!results) return null;
            if (!results[2]) return '';
            return decodeURIComponent(results[2].replace(/\+/g, ' '));
        }

    </script>
    <title>QR Session for Board</title>
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ba6233f36008baf2c406fd4ad7dcd5aa164f67e6328", async() => {
                WriteLiteral(@"

    <div class=""ui active inverted dimmer"" id=""loader"">
        <div class=""ui text loader"">Establishing Connection</div>
    </div>

    <div class=""ui negative message"" id=""error"" style=""display:none; margin-left:10px; margin-right:10px;"">
        <div class=""header"">
            Connection Error
        </div>
        <p>
            Sorry, there was an issue establishing a connection.  <br />Please reload this page to try again.
        </p>
    </div>

    <div class=""ui negative message"" id=""errorLink"" style=""display:none; margin-left:10px; margin-right:10px;"">
        <div class=""header"">
            Bad Link
        </div>
        <p>
            It appears the user that has launched the QR Participation app has disconnected.  <br />Please scan a new QR Code.
        </p>
    </div>

    <div class=""ui negative message"" id=""errorConnection"" style=""display:none; margin-left:10px; margin-right:10px;"">
        <div class=""header"">
            Miro Connection Lost
        </div>
        <p>
            ");
                WriteLiteral(@"It appears the user that has launched the QR Participation app has disconnected.  <br />Please scan a new QR Code.
        </p>
    </div>

    <div id=""main"" class=""ui very padded text container basic segment center aligned"" style=""display:none;"">
        <h2 class=""ui header"">Send a Sticky</h2>
        <p>This feature allows anonymous guests to dynamically create stickies on a Miro board.</p>
        <p>Please complete the form below and press Send Sticky.</p>

        <div class=""ui negative message"" id=""errorsticky"" style=""display:none; margin-left:10px; margin-right:10px;"">
            <div class=""header"">
                Error
            </div>
            <p>
                Sorry, there was an issue sending your sticky.  <br /><br />Please try again.
            </p>
        </div>

        <div>
            <div class=""ui form fluid big center"" style=""text-align:center;"">
                <textarea autofocus rows=""5"" id=""txtSticker"" placeholder=""Your text here...""></textarea>
            </div>
     ");
                WriteLiteral("   </div>\n        <div>\n            <button class=\"ui blue button\" style=\"margin-top:15px;\" onclick=\"addSticky();\">\n                Send Sticky\n            </button>\n        </div>\n\n\n\n    </div>\n\n\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
