#pragma checksum "C:\Users\ar8i38c\Desktop\Training Assignment\AppointmentDairy\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "133ff4d9a95a01c04e547374c746bee3cf37e320"
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
#line 1 "C:\Users\ar8i38c\Desktop\Training Assignment\AppointmentDairy\Views\_ViewImports.cshtml"
using DotNetCoreCalendar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ar8i38c\Desktop\Training Assignment\AppointmentDairy\Views\_ViewImports.cshtml"
using DotNetCoreCalendar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"133ff4d9a95a01c04e547374c746bee3cf37e320", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"507c64b0289c2ffe92872f40624e6f8f8529ceaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ar8i38c\Desktop\Training Assignment\AppointmentDairy\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>

      document.addEventListener('DOMContentLoaded', function() {
        var calendarEl = document.getElementById('calendar');
        var calendar = new FullCalendar.Calendar(calendarEl, {
            initialView: 'dayGridMonth',
            events: ");
#nullable restore
#line 11 "C:\Users\ar8i38c\Desktop\Training Assignment\AppointmentDairy\Views\Home\Index.cshtml"
               Write(Html.Raw(ViewData["Events"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n            resources: ");
#nullable restore
#line 12 "C:\Users\ar8i38c\Desktop\Training Assignment\AppointmentDairy\Views\Home\Index.cshtml"
                  Write(Html.Raw(ViewData["Resources"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            headerToolbar: {
                left: 'today prev,next',
                center: 'title',
                right: 'timeGridWeek,dayGridMonth,listMonth'
            },
        });
        calendar.render();
      });

</script>

<div class=""text-center"">
    <h1 class=""display-4"">Appointment Dairy !!!</h1><br /><br /><br />
    <h3 class=""display-4""><i>by </i>  ""Anant Saini""</h3><br /><br /><br />
");
            WriteLiteral(@"</div>

<div class=""d-flex justify-content-around"" >
    <div class=""col-md-4"">
        <a href=""/Event""><h1>Events</h1></a>
    </div>
    <div class=""col-md-4"">
        <a href=""/Location""><h1>Locations</h1></a>
    </div>
    <div class=""col-md-4"">
        <a href=""/MyCalendar""><h1>My Calendar</h1></a>
    </div>
</div>

");
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
