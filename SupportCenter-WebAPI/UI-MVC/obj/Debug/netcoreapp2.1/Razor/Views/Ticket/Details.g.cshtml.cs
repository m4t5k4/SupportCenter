#pragma checksum "D:\Documenten\Onderzoekstopics\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "252e6d9cb2e3ff74bb64bc44e3e4fc80ca133dcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_Details), @"mvc.1.0.view", @"/Views/Ticket/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ticket/Details.cshtml", typeof(AspNetCore.Views_Ticket_Details))]
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
#line 1 "D:\Documenten\Onderzoekstopics\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
using SC.BL.Domain;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"252e6d9cb2e3ff74bb64bc44e3e4fc80ca133dcc", @"/Views/Ticket/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b869c1a7cd3c60537d2a92e90ada1f6ab366cf1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SC.BL.Domain.Ticket>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_TicketDetailsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 4 "D:\Documenten\Onderzoekstopics\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
  
    ViewBag.Title = "Ticket";

#line default
#line hidden
            BeginContext(83, 18, true);
            WriteLiteral("\n<h2>Ticket</h2>\n\n");
            EndContext();
            BeginContext(364, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a7d127da55e34cc78a8a1cd819ddcb24", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 17 "D:\Documenten\Onderzoekstopics\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(416, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(418, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b474b8f89674cf88efc2154392cc958", async() => {
                BeginContext(474, 6, true);
                WriteLiteral("Bewerk");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 19 "D:\Documenten\Onderzoekstopics\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
                       WriteLiteral(Model.TicketNumber);

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
            BeginContext(484, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(487, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9de443ee1634f7b95e44f4c6a329a39", async() => {
                BeginContext(509, 5, true);
                WriteLiteral("Lijst");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(518, 55, true);
            WriteLiteral("\n\n<h3>Responses</h3>\n<p><button class=\"btn btn-default\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 573, "\"", 625, 3);
            WriteAttributeValue("", 583, "loadResponsesOfTicket(", 583, 22, true);
#line 22 "D:\Documenten\Onderzoekstopics\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
WriteAttributeValue("", 605, Model.TicketNumber, 605, 19, false);

#line default
#line hidden
            WriteAttributeValue("", 624, ")", 624, 1, true);
            EndWriteAttribute();
            BeginContext(626, 155, true);
            WriteLiteral(">(Her)laad antwoorden</button></p>\n<table id=\"responses\" class=\"table\">\n    <tr>\n        <th>Antwoord</th><th>Datum</th><th>Klant antwoord?</th>\n    </tr>\n");
            EndContext();
#line 27 "D:\Documenten\Onderzoekstopics\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
     foreach (TicketResponse response in (IEnumerable<TicketResponse>) ViewBag.Responses)
    {

#line default
#line hidden
            BeginContext(877, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(907, 13, false);
#line 30 "D:\Documenten\Onderzoekstopics\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
           Write(response.Text);

#line default
#line hidden
            EndContext();
            BeginContext(920, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(930, 13, false);
#line 30 "D:\Documenten\Onderzoekstopics\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
                                  Write(response.Date);

#line default
#line hidden
            EndContext();
            BeginContext(943, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(952, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "72e58f22aecd465eab4040bac3a775da", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 30 "D:\Documenten\Onderzoekstopics\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => response.IsClientResponse);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1006, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 32 "D:\Documenten\Onderzoekstopics\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(1032, 163, true);
            WriteLiteral("</table>\n<input id=\"responseText\" name=\"responseText\" type=\"text\" style=\"margin-right: 5px\" />\n<button type=\"button\" onclick=\"postResponse()\">Verzenden</button>\n\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1213, 1312, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        // Toon responses
        function loadResponsesOfTicket(ticketNumber) {
            $.ajax('/api/TicketResponses?ticketnumber='+ticketNumber, {
                    type: 'GET',
                    dataType: 'json' // data-type expected back (response-data parsed to object)
                })
                .done(function (data) { showTicketResponses(data); })
                .fail(function () { alert('Oeps, something went wrong!'); });
        }
        function showTicketResponses(responses) {
            $('table#responses').find('tr:gt(0)').remove();
            setTimeout(function () {
                    responses.forEach(function (response) { addResponseToList(response); });
            }, 1000);
        }
        function addResponseToList(response) {
            var date = new Date(response.date);
            var checked = response.isClientResponse ? 'checked=""checked""' : '';
            $('table#responses').append('<tr>'
                +'<td>'+response.");
                WriteLiteral(@"text+'</td>'
                +'<td>'+date.toLocaleString()+'</td>'
                +'<td><input type=""checkbox"" disabled '+checked+'/></td>'
                +'</tr>');
        }
        
        // Voeg nieuw response toe
        function postResponse() {
            var ticketNumber = '");
                EndContext();
                BeginContext(2526, 18, false);
#line 68 "D:\Documenten\Onderzoekstopics\SupportCenter-WebAPI\SupportCenter-WebAPI\UI-MVC\Views\Ticket\Details.cshtml"
                           Write(Model.TicketNumber);

#line default
#line hidden
                EndContext();
                BeginContext(2544, 770, true);
                WriteLiteral(@"';
            var answer = $('#responseText').val();
            if (answer) {
                var newResponse = { ticketNumber: ticketNumber, responseText: answer, 
                                    isClientResponse: false }
                $.ajax('/api/TicketResponses', { 
                        type: 'POST',
                        data: JSON.stringify(newResponse),
                        contentType : 'application/json',
                        dataType: 'json' // data-type expected back
                    })
                    .done(function (data) { addResponseToList(data); 
                        $('#responseText').val(''); })
                    .fail(function () { alert('Oeps, something went wrong!'); });
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SC.BL.Domain.Ticket> Html { get; private set; }
    }
}
#pragma warning restore 1591
