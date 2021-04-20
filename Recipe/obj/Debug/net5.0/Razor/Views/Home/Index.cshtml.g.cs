#pragma checksum "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff8f6154bbf60c6333f6c9cab8aee71c2c8ea07f"
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
#line 3 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\_ViewImports.cshtml"
using Recipe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff8f6154bbf60c6333f6c9cab8aee71c2c8ea07f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcced5775a4feadf51c4837c4e8ddd7586532f32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Recipe App";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<style>
    .flex-column {
        max-width: 260px;
    }

    img {
        margin: 5px;
    }

    .scale {
        transform: scaleY(1.05);
        padding-top: 5px;
    }
</style>
<div class=""container mx-auto mb-7"">
    <div class=""text-center px-3 lg:px-0"">
        <h1 class=""my-4 text-2xl md:text-3xl lg:text-5xl font-black leading-tight"">
            <span class=""block xl:inline"">View the best</span>
            <span class=""block text-red-600 xl:inline"">recipes online</span>
        </h1>
        <p class=""leading-normal text-gray-800 text-base md:text-xl lg:text-2xl mb-8"">
            Let's start cooking with popular recipes
        </p>

        <a class=""mx-auto lg:mx-0 hover:text-red-600 text-gray-800 font-extrabold rounded my-2 md:my-6 py-4 px-8 shadow-lg w-48""
            href=""/Account/Register"">
            Sign Up
        </a>
        <a href=""/Recipe/Index""
            class=""inline-block mx-auto lg:mx-0 hover:text-red-600 hover:no-underline bg-transparent text-");
            WriteLiteral("gray-600 font-extrabold my-2 md:my-6 py-2 lg:py-4 px-8\">View\r\n            Recipes</a>\r\n    </div>\r\n\r\n");
            WriteLiteral(@"</div>
<div class=""container-fluid mb-7"">
    <div class=""d-flex flex-row flex-wrap justify-content-center"">
        <div class=""d-flex flex-column"">
            <img src=""https://images.unsplash.com/photo-1485963631004-f2f00b1d6606?auto=format&fit=crop&w=750&q=80""
                class=""img-fluid"">

            <img src=""https://images.unsplash.com/photo-1482049016688-2d3e1b311543?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=353&q=80""
                class=""img-fluid"">
        </div>

        <div class=""d-flex flex-column"">
            <img src=""https://images.unsplash.com/photo-1500816558239-6b91f4256ead?auto=format&fit=crop&w=331&q=80""
                class=""img-fluid"">

            <img src=""https://images.unsplash.com/photo-1487376318617-f43c7b41e2e2?auto=format&fit=crop&w=750&q=80""
                class=""img-fluid"">
        </div>

        <div class=""d-flex flex-column"">
            <img src=""https://images.unsplash.com/photo-1497888329096");
            WriteLiteral(@"-51c27beff665?auto=format&fit=crop&w=751&q=80""
                class=""img-fluid"">
            <img src=""https://images.unsplash.com/photo-1505253468034-514d2507d914?auto=format&fit=crop&w=210&q=80""
                class=""img-fluid"">
        </div>

        <div class=""d-flex flex-column"">
            <img src=""https://images.unsplash.com/photo-1502550900787-e956c314a221?auto=format&fit=crop&w=334&q=80""
                class=""img-fluid"">
            <img src=""https://images.unsplash.com/photo-1455853659719-4b521eebc76d?auto=format&fit=crop&w=760&q=80""
                class=""img-fluid"">
        </div>
    </div>
</div>
<footer class=""container text-gray-600 px-6 lg:px-8 mt-16"">
    <div class=""max-w-screen-xl mx-auto grid md:grid-cols-2 lg:grid-cols-3 gap-6 lg:gap-x-8"">
        <div>
            <h5 class=""text-xl font-bold text-gray-700"">Legal</h5>
            <nav class=""mt-4"">
                <ul class=""space-y-2"">
                    <li>
                        <a href=""#"" class=""font-");
            WriteLiteral(@"normal text-base hover:text-gray-500"">General Terms & Conditions</a>
                    </li>
                    <li>
                        <a href=""#"" class=""font-normal text-base hover:text-gray-500"">Data Processing Agreement</a>
                    </li>
                    <li>
                        <a href=""#"" class=""font-normal text-base hover:text-gray-500"">Privacy Statement</a>
                    </li>
                </ul>
            </nav>
        </div>
        <div>
            <h5 class=""text-xl font-bold text-gray-700"">Contact</h5>
            <div class=""space-y-4 md:space-y-6 mt-4"">
                <div class=""flex items-start space-x-4"">
                    <div>
                        <svg class=""w-6 h-6 mt-1 text-gray-500"" fill=""none"" stroke=""currentColor"" viewBox=""0 0 24 24""
                            xmlns=""http://www.w3.org/2000/svg"">
                            <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2""
                            ");
            WriteLiteral(@"    d=""M17.657 16.657L13.414 20.9a1.998 1.998 0 01-2.827 0l-4.244-4.243a8 8 0 1111.314 0z"">
                            </path>
                            <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2""
                                d=""M15 11a3 3 0 11-6 0 3 3 0 016 0z""></path>
                        </svg>
                    </div>
                    <div class=""flex-1"">
                        <address class=""not-italic"">
                            Mitrovica, 40000<br>
                            Kosovo<br>
                        </address>
                    </div>
                </div>
                <div class=""flex items-start space-x-4"">
                    <div>
                        <svg class=""w-6 h-6 mt-1 text-gray-500"" fill=""none"" stroke=""currentColor"" viewBox=""0 0 24 24""
                            xmlns=""http://www.w3.org/2000/svg"">
                            <path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2""
               ");
            WriteLiteral(@"                 d=""M3 8l7.89 5.26a2 2 0 002.22 0L21 8M5 19h14a2 2 0 002-2V7a2 2 0 00-2-2H5a2 2 0 00-2 2v10a2 2 0 002 2z"">
                            </path>
                        </svg>
                    </div>
                    <div class=""flex-1"">
                        <a href=""mailto:jetonkorenica@gmail.com"" class=""hover:text-gray-500"">jetonkorenica@gmail.com</a>
                    </div>
                </div>
            </div>
        </div>
        <div>
            <h5 class=""text-xl font-bold text-gray-700"">Latest recipes</h5>
");
#nullable restore
#line 156 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Home\Index.cshtml"
             foreach (var recipe in ViewBag.RecentRecipes)
            {
                string imageBase64Data = Convert.ToBase64String(recipe.Recipe.Image);
                string imageSource = string.Format("data:image/jpg;base64,{0}", imageBase64Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"space-y-8 mt-4\">\r\n                    <div class=\"flex items-start space-x-4\">\r\n                        <img class=\"h-12 mt-1 rounded-lg overflow-hidden\"");
            BeginWriteAttribute("src", " src=\"", 6986, "\"", 7004, 1);
#nullable restore
#line 162 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Home\Index.cshtml"
WriteAttributeValue("", 6992, imageSource, 6992, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Gray image placeholder\">\r\n                        <div class=\"flex-1\">\r\n                            <p>");
#nullable restore
#line 164 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Home\Index.cshtml"
                          Write(recipe.Recipe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <strong\r\n                            class=\"font-bold block mt-2 text-sm text-gray-500\">");
#nullable restore
#line 166 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Home\Index.cshtml"
                                                                          Write(recipe.Recipe.CreatedAt.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 170 "C:\Users\Lenovo\Desktop\Recipe\recipe\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
    </div>
    <div class=""max-w-screen-xl mx-auto flex flex-col items-center mt-7"">
        <div class=""flex items-center space-x-2"">
            <a href=""https://www.facebook.com"" class=""hover:text-gray-200"">
                <span class=""sr-only"">Facebook</span>
                <svg class=""h-6 w-6 text-gray-500"" aria-hidden=""true"" fill=""currentColor"" viewBox=""0 0 24 24"">
                    <path fill-rule=""evenodd""
                        d=""M22 12c0-5.523-4.477-10-10-10S2 6.477 2 12c0 4.991 3.657 9.128 8.438 9.878v-6.987h-2.54V12h2.54V9.797c0-2.506 1.492-3.89 3.777-3.89 1.094 0 2.238.195 2.238.195v2.46h-1.26c-1.243 0-1.63.771-1.63 1.562V12h2.773l-.443 2.89h-2.33v6.988C18.343 21.128 22 16.991 22 12z""
                        clip-rule=""evenodd"" />
                </svg>
            </a>
            <a href=""https://www.instagram.com"" class=""hover:text-gray-200"">
                <span class=""sr-only"">Instagram</span>
                <svg class=""h-6 w-6 text-gray-500"" aria-hidde");
            WriteLiteral(@"n=""true"" fill=""currentColor"" viewBox=""0 0 24 24"">
                    <path fill-rule=""evenodd""
                        d=""M12.315 2c2.43 0 2.784.013 3.808.06 1.064.049 1.791.218 2.427.465a4.902 4.902 0 011.772 1.153 4.902 4.902 0 011.153 1.772c.247.636.416 1.363.465 2.427.048 1.067.06 1.407.06 4.123v.08c0 2.643-.012 2.987-.06 4.043-.049 1.064-.218 1.791-.465 2.427a4.902 4.902 0 01-1.153 1.772 4.902 4.902 0 01-1.772 1.153c-.636.247-1.363.416-2.427.465-1.067.048-1.407.06-4.123.06h-.08c-2.643 0-2.987-.012-4.043-.06-1.064-.049-1.791-.218-2.427-.465a4.902 4.902 0 01-1.772-1.153 4.902 4.902 0 01-1.153-1.772c-.247-.636-.416-1.363-.465-2.427-.047-1.024-.06-1.379-.06-3.808v-.63c0-2.43.013-2.784.06-3.808.049-1.064.218-1.791.465-2.427a4.902 4.902 0 011.153-1.772A4.902 4.902 0 015.45 2.525c.636-.247 1.363-.416 2.427-.465C8.901 2.013 9.256 2 11.685 2h.63zm-.081 1.802h-.468c-2.456 0-2.784.011-3.807.058-.975.045-1.504.207-1.857.344-.467.182-.8.398-1.15.748-.35.35-.566.683-.748 1.15-.137.353-.3.882-.344 1.857-.047 1.023-.");
            WriteLiteral(@"058 1.351-.058 3.807v.468c0 2.456.011 2.784.058 3.807.045.975.207 1.504.344 1.857.182.466.399.8.748 1.15.35.35.683.566 1.15.748.353.137.882.3 1.857.344 1.054.048 1.37.058 4.041.058h.08c2.597 0 2.917-.01 3.96-.058.976-.045 1.505-.207 1.858-.344.466-.182.8-.398 1.15-.748.35-.35.566-.683.748-1.15.137-.353.3-.882.344-1.857.048-1.055.058-1.37.058-4.041v-.08c0-2.597-.01-2.917-.058-3.96-.045-.976-.207-1.505-.344-1.858a3.097 3.097 0 00-.748-1.15 3.098 3.098 0 00-1.15-.748c-.353-.137-.882-.3-1.857-.344-1.023-.047-1.351-.058-3.807-.058zM12 6.865a5.135 5.135 0 110 10.27 5.135 5.135 0 010-10.27zm0 1.802a3.333 3.333 0 100 6.666 3.333 3.333 0 000-6.666zm5.338-3.205a1.2 1.2 0 110 2.4 1.2 1.2 0 010-2.4z""
                        clip-rule=""evenodd"" />
                </svg>
            </a>
            <a href=""https://www.twitter.com"" class=""hover:text-gray-200"">
                <span class=""sr-only"">Twitter</span>
                <svg class=""h-6 w-6 text-gray-500"" aria-hidden=""true"" fill=""currentColor"" viewBox=""0 0 24");
            WriteLiteral(@" 24"">
                    <path
                        d=""M8.29 20.251c7.547 0 11.675-6.253 11.675-11.675 0-.178 0-.355-.012-.53A8.348 8.348 0 0022 5.92a8.19 8.19 0 01-2.357.646 4.118 4.118 0 001.804-2.27 8.224 8.224 0 01-2.605.996 4.107 4.107 0 00-6.993 3.743 11.65 11.65 0 01-8.457-4.287 4.106 4.106 0 001.27 5.477A4.072 4.072 0 012.8 9.713v.052a4.105 4.105 0 003.292 4.022 4.095 4.095 0 01-1.853.07 4.108 4.108 0 003.834 2.85A8.233 8.233 0 012 18.407a11.616 11.616 0 006.29 1.84"" />
                </svg>
            </a>
        </div>
        <div class=""text-sm mt-4"">
            ©2020 Company. All rights reserved.
        </div>
    </div>
</footer>");
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