#pragma checksum "C:\Users\ar8i38c\Desktop\Training Assignment\AppointmentDairy\Views\Home\MyCalendar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd52cdda87a6a887fc643cf24954a718e5987176"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MyCalendar), @"mvc.1.0.view", @"/Views/Home/MyCalendar.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd52cdda87a6a887fc643cf24954a718e5987176", @"/Views/Home/MyCalendar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"507c64b0289c2ffe92872f40624e6f8f8529ceaa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MyCalendar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ar8i38c\Desktop\Training Assignment\AppointmentDairy\Views\Home\MyCalendar.cshtml"
  
    ViewData["Title"] = "My Calendar";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .popper,
    .tooltip {
        position: absolute;
        z-index: 9999;
        background: #FFC107;
        color: white;
        width: 150px;
        border-radius: 3px;
        box-shadow: 0 0 2px rgba(0,0,0,0.7);
        padding: 10px;
        text-align: center;
    }
</style>

<script>

      document.addEventListener('DOMContentLoaded', function() {
        var calendarEl = document.getElementById('calendar');
        var calendar = new FullCalendar.Calendar(calendarEl, {
            initialView: 'dayGridMonth',
            events: ");
#nullable restore
#line 26 "C:\Users\ar8i38c\Desktop\Training Assignment\AppointmentDairy\Views\Home\MyCalendar.cshtml"
               Write(Html.Raw(ViewData["Events"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\n            resources: ");
#nullable restore
#line 27 "C:\Users\ar8i38c\Desktop\Training Assignment\AppointmentDairy\Views\Home\MyCalendar.cshtml"
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
            eventDidMount: function (info) {
                var tooltip = new Tooltip(info.el, {
                    title: info.event.extendedProps.description,
                    placement: 'top',
                    trigger: 'hover',
                    container: 'body'
                });
            }
        });
        calendar.render();
      });

</script>

<div class=""text-center"">
    <h1 class=""display-4"">Book Your Appointment !!!</h1><br />
    <div id='calendar'></div>
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