#pragma checksum "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cb3a793def5d1d194475cdc75581a5a0288dc61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_MyRecipes), @"mvc.1.0.view", @"/Views/Recipe/MyRecipes.cshtml")]
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
#line 1 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\_ViewImports.cshtml"
using Recipe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml"
using Recipe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cb3a793def5d1d194475cdc75581a5a0288dc61", @"/Views/Recipe/MyRecipes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcced5775a4feadf51c4837c4e8ddd7586532f32", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipe_MyRecipes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Recipes>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml"
  
    ViewData["Title"] = "My Recipes";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""font-bold text-xl mb-4 mt-3"">My Recipes</h1>
<div class=""flex flex-col"">
    <div class=""-my-2 overflow-x-auto sm:-mx-6 lg:-mx-8"">
        <div class=""py-2 align-middle inline-block min-w-full sm:px-6 lg:px-8"">
            <div class=""shadow overflow-hidden border-b border-gray-200 sm:rounded-lg"">
                <table class=""min-w-full divide-y divide-gray-200"">
                    <thead class=""bg-gray-50"">
                        <tr>
                            <th scope=""col""
                                class=""px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"">
                                Name
                            </th>
                            <th scope=""col""
                                class=""px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"">
                                Category
                            </th>
                            <th scope=""col""
                                c");
            WriteLiteral(@"lass=""px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"">
                                Prepare
                            </th>
                            <th scope=""col""
                                class=""px-6 py-3 text-left text-xs font-medium text-gray-500 uppercase tracking-wider"">
                                Role
                            </th>
                            <th scope=""col"" class=""relative px-6 py-3"">
                                <span class=""sr-only"">Edit</span>
                            </th>
                        </tr>
                    </thead>
                    <tbody class=""bg-white divide-y divide-gray-200"">
");
#nullable restore
#line 37 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml"
                         foreach (var recipe in Model)
                        {
                            string imageBase64Data = Convert.ToBase64String(recipe.Image);
                            string imageSource = string.Format("data:image/jpg;base64,{0}", imageBase64Data);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <tr>
                                <td class=""px-6 py-4 whitespace-nowrap"">
                                    <div class=""flex items-center"">
                                        <div class=""flex-shrink-0 h-10 w-10"">
                                            <img class=""h-10 w-10 rounded-full""");
            BeginWriteAttribute("src", " src=\"", 2447, "\"", 2465, 1);
#nullable restore
#line 45 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml"
WriteAttributeValue("", 2453, imageSource, 2453, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Recipe Image"">
                                        </div>
                                        <div class=""ml-4"">
                                            <div class=""text-sm font-medium text-gray-900"">
                                                <a");
            BeginWriteAttribute("href", " href=\"", 2739, "\"", 2771, 2);
            WriteAttributeValue("", 2746, "/Details/", 2746, 9, true);
#nullable restore
#line 49 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml"
WriteAttributeValue("", 2755, recipe.RecipeId, 2755, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-gray-900\">");
#nullable restore
#line 49 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml"
                                                                                                     Write(recipe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                            </div>
                                        </div>
                                    </div>
                                </td>
                                <td class=""px-6 py-4 whitespace-nowrap"">
                                    <div class=""text-sm text-gray-900"">");
#nullable restore
#line 55 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml"
                                                                  Write(recipe.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </td>\r\n                                <td class=\"px-6 py-4 whitespace-nowrap\">\r\n");
#nullable restore
#line 59 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml"
                                         if (@recipe.Prepare == "Easy")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span\r\n                                        class=\"px-2 inline-flex text-xs leading-5 font-semibold rounded-full bg-green-100 text-green-800\">\r\n                                                ");
#nullable restore
#line 63 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml"
                                           Write(recipe.Prepare);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </span>\r\n");
#nullable restore
#line 65 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml"
                                         
                                        if (@recipe.Prepare == "Medium")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span\r\n                                        class=\"px-2 inline-flex text-xs leading-5 font-semibold rounded-full bg-yellow-100 text-yellow-800\">\r\n                                                ");
#nullable restore
#line 70 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml"
                                           Write(recipe.Prepare);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </span>\r\n");
#nullable restore
#line 72 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml"
                                        }
                                        if (@recipe.Prepare == "Hard")
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span\r\n                                        class=\"px-2 inline-flex text-xs leading-5 font-semibold rounded-full bg-red-100 text-red-800\">\r\n                                                ");
#nullable restore
#line 77 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml"
                                           Write(recipe.Prepare);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </span>\r\n");
#nullable restore
#line 79 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </td>
                                <td class=""px-6 py-4 whitespace-nowrap text-sm text-gray-500"">
                                    Admin
                                </td>
                                <td class=""px-6 py-4 whitespace-nowrap text-right text-sm font-medium"">
                                    <a");
            BeginWriteAttribute("href", " href=\"", 5121, "\"", 5152, 2);
            WriteAttributeValue("", 5128, "/Update/", 5128, 8, true);
#nullable restore
#line 87 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml"
WriteAttributeValue("", 5136, recipe.RecipeId, 5136, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-red-600 hover:text-red-900\">Edit</a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 90 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Recipe\MyRecipes.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Recipes>> Html { get; private set; }
    }
}
#pragma warning restore 1591