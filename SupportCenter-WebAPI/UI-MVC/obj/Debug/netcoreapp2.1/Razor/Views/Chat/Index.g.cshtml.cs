#pragma checksum "D:\Documenten\Onderzoekstopics\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Chat\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c8d537dfe3a246fba278e570bb43ec7d8291288"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_Index), @"mvc.1.0.view", @"/Views/Chat/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Chat/Index.cshtml", typeof(AspNetCore.Views_Chat_Index))]
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
#line 1 "D:\Documenten\Onderzoekstopics\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\_ViewImports.cshtml"
using SC.UI.Web.MVC;

#line default
#line hidden
#line 2 "D:\Documenten\Onderzoekstopics\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\_ViewImports.cshtml"
using SC.UI.Web.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c8d537dfe3a246fba278e570bb43ec7d8291288", @"/Views/Chat/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b869c1a7cd3c60537d2a92e90ada1f6ab366cf1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Documenten\Onderzoekstopics\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Chat\Index.cshtml"
  
    ViewBag.Title = "Chat";

#line default
#line hidden
            BeginContext(36, 230, true);
            WriteLiteral("<h2>Chat</h2>\r\n<div class=\"container\">\r\n    <input type=\"text\" id=\"message\" />\r\n    <input type=\"button\" id=\"sendmessage\" value=\"Send\" />\r\n    <input type=\"hidden\" id=\"displayname\" />\r\n    <ul id=\"discussion\">\r\n    </ul>\r\n</div>\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(284, 1881, true);
                WriteLiteral(@"
    <!--Script references. -->
    <!--The jQuery library is required and is referenced by default in _Layout.cshtml. -->
    <!--Reference the SignalR library. -->
    <script src=""lib/signalr/dist/browser/signalr.min.js""></script>
    <!--Reference the autogenerated SignalR hub script. -->
    <script src=""signalr/hubs""></script>
    <!--SignalR script to update the chat page and send messages.--> 
    <script>
        $(function () {
            // Reference the auto-generated proxy for the hub.  
            var chat = $.connection.chatHub;
            // Create a function that the hub can call back to display messages.
            chat.client.addNewMessageToPage = function (name, message) {
                // Add the message to the page. 
                $('#discussion').append('<li><strong>' + htmlEncode(name) 
                    + '</strong>: ' + htmlEncode(message) + '</li>');
            };
            // Get the user name and store it to prepend to messages.
            $('#disp");
                WriteLiteral(@"layname').val(prompt('Enter your name:', ''));
            // Set initial focus to message input box.  
            $('#message').focus();
            // Start the connection.
            $.connection.hub.start().done(function () {
                $('#sendmessage').click(function () {
                    // Call the Send method on the hub. 
                    chat.server.send($('#displayname').val(), $('#message').val());
                    // Clear text box and reset focus for next comment. 
                    $('#message').val('').focus();
                });
            });
        });
        // This optional function html-encodes messages for display in the page.
        function htmlEncode(value) {
            var encodedValue = $('<div />').text(value).html();
            return encodedValue;
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
