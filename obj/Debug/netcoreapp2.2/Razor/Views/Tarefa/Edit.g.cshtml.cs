#pragma checksum "C:\Users\Maicon Esperafico\Desktop\ControleDeTarefas\Views\Tarefa\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "035b8b54cfc9d30583403a964627c05ed6c0144b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tarefa_Edit), @"mvc.1.0.view", @"/Views/Tarefa/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tarefa/Edit.cshtml", typeof(AspNetCore.Views_Tarefa_Edit))]
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
#line 1 "C:\Users\Maicon Esperafico\Desktop\ControleDeTarefas\Views\_ViewImports.cshtml"
using ControleDeTarefas;

#line default
#line hidden
#line 2 "C:\Users\Maicon Esperafico\Desktop\ControleDeTarefas\Views\_ViewImports.cshtml"
using ControleDeTarefas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"035b8b54cfc9d30583403a964627c05ed6c0144b", @"/Views/Tarefa/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c53a11d7287b570a4a0657b5914cf41bcdf5a20", @"/Views/_ViewImports.cshtml")]
    public class Views_Tarefa_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ControleDeTarefas.Models.Tarefa>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Maicon Esperafico\Desktop\ControleDeTarefas\Views\Tarefa\Edit.cshtml"
  
    ViewData["Title"] = "Editando Tarefa " + @Model.codigo;

#line default
#line hidden
            BeginContext(110, 72, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Editando Tarefa #");
            EndContext();
            BeginContext(183, 12, false);
#line 8 "C:\Users\Maicon Esperafico\Desktop\ControleDeTarefas\Views\Tarefa\Edit.cshtml"
                                      Write(Model.codigo);

#line default
#line hidden
            EndContext();
            BeginContext(195, 52, true);
            WriteLiteral("</h1>\r\n</div>\r\n\r\n<div class=\"form-horizontal\">\r\n    ");
            EndContext();
            BeginContext(247, 952, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "035b8b54cfc9d30583403a964627c05ed6c0144b4779", async() => {
                BeginContext(283, 177, true);
                WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            <label>Prioridade</label>\r\n            <input class=\"form-control\" type=\"number\" min=\"0\" max=\"100\" step=\".10\" name=\"prioridade\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 460, "\"", 485, 1);
#line 16 "C:\Users\Maicon Esperafico\Desktop\ControleDeTarefas\Views\Tarefa\Edit.cshtml"
WriteAttributeValue("", 468, Model.prioridade, 468, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(486, 152, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Nome</label>\r\n            <input class=\"form-control\" type=\"text\" name=\"nome\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 638, "\"", 657, 1);
#line 21 "C:\Users\Maicon Esperafico\Desktop\ControleDeTarefas\Views\Tarefa\Edit.cshtml"
WriteAttributeValue("", 646, Model.nome, 646, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(658, 165, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Data Limite</label>\r\n            <input class=\"form-control\" type=\"date\" name=\"dataLimite\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 823, "\"", 871, 1);
#line 26 "C:\Users\Maicon Esperafico\Desktop\ControleDeTarefas\Views\Tarefa\Edit.cshtml"
WriteAttributeValue("", 831, Model.dataLimite.ToString("yyyy-MM-dd"), 831, 40, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(872, 195, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            <label>Percentual</label>\r\n            <input class=\"form-control\" type=\"number\" min=\"0\" max=\"100\" step=\".10\" name=\"percentual\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1067, "\"", 1092, 1);
#line 31 "C:\Users\Maicon Esperafico\Desktop\ControleDeTarefas\Views\Tarefa\Edit.cshtml"
WriteAttributeValue("", 1075, Model.percentual, 1075, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1093, 99, true);
                WriteLiteral("/>\r\n        </div>\r\n\r\n        <input class=\"btn btn-primary\" type=\"submit\" value=\"Salvar\"/>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1199, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ControleDeTarefas.Models.Tarefa> Html { get; private set; }
    }
}
#pragma warning restore 1591