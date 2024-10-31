#pragma checksum "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Categoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "406a356a517468653e31b963791ae5b8355186b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_Index), @"mvc.1.0.view", @"/Views/Categoria/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"406a356a517468653e31b963791ae5b8355186b0", @"/Views/Categoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b5c1a03ea3d6c8a00ee7337eb8b84349075d571", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RelivMVC.Models.ViewModels.CategoriaViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addCategoriaForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Categoria\Index.cshtml"
   ViewData["Title"] = "Index"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#addCategoriaModal\">Agregar</button>\r\n</p>\r\n\r\n<table id=\"categoriaTable\" class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 14 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Categoria\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.First().Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 19 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Categoria\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Categoria\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button class=\"btn btn-link editCategoriaBtn\" data-id=\"");
#nullable restore
#line 24 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Categoria\Index.cshtml"
                                                                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-descripcion=\"");
#nullable restore
#line 24 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Categoria\Index.cshtml"
                                                                                                  Write(item.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-toggle=\"modal\" data-target=\"#addCategoriaModal\">Editar</button> |\r\n                    ");
#nullable restore
#line 25 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Categoria\Index.cshtml"
               Write(Html.ActionLink("Details", "Details", "Categoria", new { id = item.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    <button class=\"btn btn-danger deleteCategoriaBtn\" data-id=\"");
#nullable restore
#line 26 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Categoria\Index.cshtml"
                                                                          Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Eliminar</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Categoria\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<!-- Modal para agregar o editar una Categoria -->
<div class=""modal fade"" id=""addCategoriaModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""addCategoriaModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""addCategoriaModalLabel"">Agregar Categoria</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "406a356a517468653e31b963791ae5b8355186b07379", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" id=""categoriaId"" name=""categoriaId"" />
                    <div class=""form-group"">
                        <label for=""descripcion"">Descripción</label>
                        <input type=""text"" class=""form-control"" id=""descripcion"" name=""Descripcion"" required /> <!-- Cambia 'descripcion' a 'Descripcion' -->
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
                <button type=""button"" class=""btn btn-primary"" id=""saveCategoriaBtn"">Guardar</button>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#categoriaTable').DataTable({
                ""language"": {
                    ""url"": ""//cdn.datatables.net/plug-ins/1.11.5/i18n/Spanish.json""
                }
            });

            // Función para manejar la edición
            $('.editCategoriaBtn').on('click', function () {
                var categoriaId = $(this).data('id');
                var descripcion = $(this).data('descripcion');

                $('#categoriaId').val(categoriaId);
                $('#descripcion').val(descripcion);
                $('#addCategoriaModalLabel').text('Editar Categoria');
            });

            // Enviar el formulario mediante AJAX cuando se presiona el botón Guardar
            $('#saveCategoriaBtn').on('click', function () {
                var descripcion = $('#descripcion').val();
                var categoriaId = $('#categoriaId').val();

                var url = categoriaId ? '");
#nullable restore
#line 84 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Categoria\Index.cshtml"
                                    Write(Url.Action("Put", "Categoria"));

#line default
#line hidden
#nullable disable
                WriteLiteral("/\' + categoriaId : \'");
#nullable restore
#line 84 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Categoria\Index.cshtml"
                                                                                       Write(Url.Action("Create", "Categoria"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
                var method = categoriaId ? 'PUT' : 'POST';

                // Asegúrate de que la propiedad sea ""Descripcion""
                var dataToSend = { Id: categoriaId, Descripcion: descripcion };

                $.ajax({
                    url: url,
                    type: method,
                    contentType: 'application/json',
                    data: JSON.stringify(dataToSend), // Enviar JSON correctamente
                    success: function (result) {
                        if (result.success) {
                            $('#addCategoriaModal').modal('hide');
                            location.reload();
                        } else {
                            alert(""Error al "" + (categoriaId ? ""actualizar"" : ""agregar"") + "" la categoria: "" + (result.errorMessage || ""Error desconocido""));
                        }
                    },
                    error: function (xhr, status, error) {
                        console.log(""Status: "" + status);
 ");
                WriteLiteral(@"                       console.log(""Error: "" + error);
                        console.log(""Response: "" + xhr.responseText);
                        alert(""Error en la solicitud AJAX: "" + error);
                    }
                });
            });

            // Función para manejar la eliminación
            $('.deleteCategoriaBtn').on('click', function () {
                var categoriaId = $(this).data('id');
                var confirmDelete = confirm(""¿Estás seguro de que deseas eliminar esta categoría?"");

                if (confirmDelete) {
                    $.ajax({
                        url: '");
#nullable restore
#line 119 "D:\Visual Studio\Net8\RelivMVC\RelivMVC\Views\Categoria\Index.cshtml"
                         Write(Url.Action("Delete", "Categoria"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/' + categoriaId,
                        type: 'DELETE',
                        success: function (result) {
                            if (result.success) {
                                location.reload(); // Recarga la página para mostrar los cambios
                            } else {
                                alert(""Error al eliminar la categoría: "" + (result.errorMessage || ""Error desconocido""));
                            }
                        },
                        error: function (xhr, status, error) {
                            console.log(""Status: "" + status);
                            console.log(""Error: "" + error);
                            console.log(""Response: "" + xhr.responseText);
                            alert(""Error en la solicitud AJAX: "" + error);
                        }
                    });
                }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RelivMVC.Models.ViewModels.CategoriaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
