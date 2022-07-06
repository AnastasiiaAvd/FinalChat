#pragma checksum "D:\FinalChat\Chat\Views\Chat\GetChats.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec51132a39b5cbd8a5bd307d3db26fbfed642a8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Chat_GetChats), @"mvc.1.0.view", @"/Views/Chat/GetChats.cshtml")]
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
#line 1 "D:\FinalChat\Chat\Views\_ViewImports.cshtml"
using Chat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FinalChat\Chat\Views\_ViewImports.cshtml"
using Chat.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\FinalChat\Chat\Views\Chat\GetChats.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\FinalChat\Chat\Views\Chat\GetChats.cshtml"
using Newtonsoft.Json.Converters;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec51132a39b5cbd8a5bd307d3db26fbfed642a8e", @"/Views/Chat/GetChats.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae0d8c26f1bac4ebadd6a59a67055e7526028212", @"/Views/_ViewImports.cshtml")]
    public class Views_Chat_GetChats : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chat.Models.ChatsInfoDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\FinalChat\Chat\Views\Chat\GetChats.cshtml"
  
    ViewData["Title"] = "My Chats";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />

<div>
    <div class=""chat-body"">
            <div class=""chat-content"">
    <input type=""text"" data-bind=""value: $root.NewCompanion"" />
    </div></div>
    <input class=""btn btn-primary"" type=""button"" id=""sendBtn"" value=""Создать чат"" data-bind=""click: $root.TryCreateChat""/>
</div>

<br/>

<div id=""chats"">
    <div class=""chat-body"">
            <div class=""chat-content"">
    <h4>Мои чаты</h4>
    
    <div data-bind=""foreach: $root.Model.Chats()"">
        <div style=""cursor: pointer;"" data-bind=""click: $root.OpenChat"">
            <span data-bind=""text: Companion""></span>
        </div>
    </div>
    </div></div>
</div>

<script");
            BeginWriteAttribute("src", " src=\"", 811, "\"", 860, 1);
#nullable restore
#line 33 "D:\FinalChat\Chat\Views\Chat\GetChats.cshtml"
WriteAttributeValue("", 817, Url.Content("~/lib/jquery/dist/jquery.js"), 817, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"></script>
<script type=""text/javascript"" src=""https://ajax.aspnetcdn.com/ajax/knockout/knockout-3.4.0.js""></script>
<script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/knockout.mapping/2.4.1/knockout.mapping.js""></script>

<script>


    function MyChatsViewModel(model) {
        var vm = this;
        vm.Model = ko.mapping.fromJS(model);
        vm.NewCompanion = ko.observable("""");

        var openChatUrl = '");
#nullable restore
#line 45 "D:\FinalChat\Chat\Views\Chat\GetChats.cshtml"
                      Write(Url.Action("GetChat", "Chat"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        var tryCreateChatUrl = \'");
#nullable restore
#line 46 "D:\FinalChat\Chat\Views\Chat\GetChats.cshtml"
                           Write(Url.Action("TryCreateChat", "Chat"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';

        vm.OpenChat = function(currentChat) {

            window.open(openChatUrl + '?chatId=' + currentChat.ChatId(), '_blank');
        }
        //if (vm.NewCompanion === null)
        //    alert(""Введите имя собеседника"");
        //else 
        vm.TryCreateChat = function () {
            jQuery.ajax({
                url: tryCreateChatUrl + '?companion=' + vm.NewCompanion(),
                success: function (result) {
                    if (result.success === false) {
                        alert(result.message);
                    } else {
                        location.reload();
                    }
                    }
                });
        }
    }
    $(function() {

        var model = new MyChatsViewModel(");
#nullable restore
#line 70 "D:\FinalChat\Chat\Views\Chat\GetChats.cshtml"
                                    Write(Html.Raw(JsonConvert.SerializeObject(Model, new IsoDateTimeConverter())));

#line default
#line hidden
#nullable disable
            WriteLiteral(");\r\n        ko.applyBindings(model);\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chat.Models.ChatsInfoDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
