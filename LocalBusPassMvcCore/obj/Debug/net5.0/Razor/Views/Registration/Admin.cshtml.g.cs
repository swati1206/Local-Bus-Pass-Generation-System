#pragma checksum "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\Registration\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b3912a38467070267964f2213be2cf65dd46ce0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Registration_Admin), @"mvc.1.0.view", @"/Views/Registration/Admin.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b3912a38467070267964f2213be2cf65dd46ce0", @"/Views/Registration/Admin.cshtml")]
    #nullable restore
    public class Views_Registration_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LocalBussPassLibrary.Entities.AdminDetails>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section class=""vh-100"" style=""background-image: url('https://media.istockphoto.com/photos/chhatrapati-shivaji-picture-id667564382?k=20&m=667564382&s=612x612&w=0&h=CmUbMKkhjFdq09GWI6nrlmy-thQDmEF-EcY1djvyqFM='); background-repeat: no-repeat; background-position: center; background-size: cover; "">
    <form action=""/registration/admin"" method=""post"">
        <div class=""container py-5 h-100"">
            <div class=""row d-flex justify-content-center align-items-center h-100"">
                <div class=""col-12 col-md-8 col-lg-6 col-xl-5"">
                    <div class=""card shadow-2-strong"" style=""border-radius: 1rem;"">
                        <div class=""card-body p-5 text-center"">
");
#nullable restore
#line 9 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\Registration\Admin.cshtml"
                             if (ViewBag.Error != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-dark\">");
#nullable restore
#line 11 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\Registration\Admin.cshtml"
                                                         Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 12 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\Registration\Admin.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <h3 class=\"mb-5\">Sign Up</h3>\r\n");
#nullable restore
#line 14 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\Registration\Admin.cshtml"
                             if (ViewBag.IsValid != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-danger\">Please correct the validation errors</div>\r\n");
#nullable restore
#line 17 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\Registration\Admin.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"form-outline mb-4\">\r\n                                ");
#nullable restore
#line 19 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\Registration\Admin.cshtml"
                           Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control", @id = "name" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <label class=\"form-label\" for=\"name\">Full Name</label>\r\n                                ");
#nullable restore
#line 21 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\Registration\Admin.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Name, String.Empty, new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-outline mb-4\">\r\n                                ");
#nullable restore
#line 24 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\Registration\Admin.cshtml"
                           Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control", @id = "email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <label class=\"form-label\" for=\"email\">Email Id</label>\r\n                                ");
#nullable restore
#line 26 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\Registration\Admin.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Email, String.Empty, new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"form-outline mb-4\">\r\n                                ");
#nullable restore
#line 29 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\Registration\Admin.cshtml"
                           Write(Html.PasswordFor(m => m.Password, new { @class = "form-control", @id = "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <label class=\"form-label\" for=\"password\">Password</label>\r\n                                ");
#nullable restore
#line 31 "C:\Users\swati\Desktop\Git\Sprint Project\Local Bus Pass Generation System\LocalBusPassMvcCore\Views\Registration\Admin.cshtml"
                           Write(Html.ValidationMessageFor(m => m.Password, String.Empty, new { @style = "color:red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </div>

                            <button class=""btn btn-primary btn-lg btn-block"" type=""submit"">Register</button>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</section>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LocalBussPassLibrary.Entities.AdminDetails> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
