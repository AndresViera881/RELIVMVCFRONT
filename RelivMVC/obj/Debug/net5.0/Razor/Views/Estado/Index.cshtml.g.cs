#pragma checksum "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Estado\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8ab385471940c4c094d5326fc8726dcb7e9b070"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estado_Index), @"mvc.1.0.view", @"/Views/Estado/Index.cshtml")]
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
#line 1 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\_ViewImports.cshtml"
using RelivMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\_ViewImports.cshtml"
using RelivMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8ab385471940c4c094d5326fc8726dcb7e9b070", @"/Views/Estado/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b5c1a03ea3d6c8a00ee7337eb8b84349075d571", @"/Views/_ViewImports.cshtml")]
    public class Views_Estado_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RelivMVC.Models.ViewModels.EstadoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addEstadoForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Estado\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>

<p>
    <!-- Botón para abrir el modal -->
    <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#addEstadoModal"">Agregar</button>
</p>

<!-- Tabla para mostrar los estados -->
<table id=""estadoTable"" class=""table"">
    <thead>
        <tr>
            <th>");
#nullable restore
#line 16 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Estado\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 21 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Estado\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Estado\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <!-- Cambiar ActionLink por un botón que abre el modal -->\r\n                    <button class=\"btn btn-link editEstadoBtn\" data-id=\"");
#nullable restore
#line 27 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Estado\Index.cshtml"
                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-descripcion=\"");
#nullable restore
#line 27 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Estado\Index.cshtml"
                                                                                               Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#addEstadoModal\">Editar</button> |\r\n                    ");
#nullable restore
#line 28 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Estado\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 29 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Estado\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 32 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Estado\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<!-- Modal para agregar o editar un Estado -->
<div class=""modal fade"" id=""addEstadoModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addEstadoModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""addEstadoModalLabel"">Agregar Estado</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8ab385471940c4c094d5326fc8726dcb7e9b0707323", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" id=""estadoId"" name=""estadoId"" />
                    <div class=""form-group"">
                        <label for=""descripcion"">Descripción</label>
                        <input type=""text"" class=""form-control"" id=""descripcion"" name=""descripcion"" required />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" class=""btn btn-primary"" id=""saveEstadoBtn"">Guardar</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#estadoTable').DataTable({
                ""language"": {
                    ""url"": ""//cdn.datatables.net/plug-ins/1.11.5/i18n/Spanish.json""
                }
            });

            // Función para manejar la edición
            $('.editEstadoBtn').on('click', function () {
                var estadoId = $(this).data('id');
                var descripcion = $(this).data('descripcion');

                // Carga los datos en el modal
                $('#estadoId').val(estadoId);
                $('#descripcion').val(descripcion);

                // Cambia el título del modal
                $('#addEstadoModalLabel').text('Editar Estado');
            });

            // Enviar el formulario mediante AJAX cuando se presiona el botón Guardar
            $('#saveEstadoBtn').on('click', function () {
                var descripcion = $('#descripcion').val();
                var estadoId = $('#estadoId').val();

 ");
                WriteLiteral("               var url = estadoId ? \'");
#nullable restore
#line 90 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Estado\Index.cshtml"
                                 Write(Url.Action("Put", "Estado"));

#line default
#line hidden
#nullable disable
                WriteLiteral("/\' + estadoId : \'");
#nullable restore
#line 90 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Estado\Index.cshtml"
                                                                              Write(Url.Action("Create", "Estado"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
                var method = estadoId ? 'PUT' : 'POST';

                console.log(url); // Verifica la URL

                $.ajax({
                    url: url,
                    type: method,
                    contentType: 'application/json',
                    data: JSON.stringify({ Id: estadoId, Descripcion: descripcion }), // Asegúrate que las propiedades coincidan con el modelo
                    success: function (result) {
                        if (result.success) {
                            $('#addEstadoModal').modal('hide');
                            location.reload(); // Recarga la página para mostrar los cambios
                        } else {
                            alert(""Error al "" + (estadoId ? ""actualizar"" : ""agregar"") + "" el estado: "" + (result.errorMessage || ""Error desconocido""));
                        }
                    },
                    error: function (xhr, status, error) {
                        console.log(""Status: "" + status);
  ");
                WriteLiteral(@"                      console.log(""Error: "" + error);
                        console.log(""Response: "" + xhr.responseText); // Muestra la respuesta completa
                        alert(""Error en la solicitud AJAX: "" + error);
                    }
                });
            });
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RelivMVC.Models.ViewModels.EstadoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
