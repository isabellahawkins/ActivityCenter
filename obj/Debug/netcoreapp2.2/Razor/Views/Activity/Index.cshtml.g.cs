#pragma checksum "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43bab758217807f7f835af230832bb10c323348d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Activity_Index), @"mvc.1.0.view", @"/Views/Activity/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Activity/Index.cshtml", typeof(AspNetCore.Views_Activity_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/_ViewImports.cshtml"
using ActivityCenter;

#line default
#line hidden
#line 5 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
using ActivityCenter.Models;

#line default
#line hidden
#line 6 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
using System.Linq;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43bab758217807f7f835af230832bb10c323348d", @"/Views/Activity/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e339c4346f16b3c5483ad512c481a4e17eb8f1c", @"/Views/_ViewImports.cshtml")]
    public class Views_Activity_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ActivityCenter.Models.DashboardModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
            BeginContext(135, 72, true);
            WriteLiteral("\n<div class=\"header\">\n    <h1>Dojo Activity Center</h1>\n    <h5>Welcome ");
            EndContext();
            BeginContext(208, 20, false);
#line 10 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
           Write(Model.User.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(228, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(230, 19, false);
#line 10 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
                                 Write(Model.User.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(249, 58, true);
            WriteLiteral("</h5>\n    <a id=\"logout\" href=\"Logout\">Log Off</a>\n</div>\n");
            EndContext();
#line 13 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
 if (ViewBag.Error == null)
{
    

#line default
#line hidden
            BeginContext(342, 17, false);
#line 15 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
Write(TempData["error"]);

#line default
#line hidden
            EndContext();
#line 15 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
                      
}

#line default
#line hidden
            BeginContext(362, 278, true);
            WriteLiteral(@"<table class=""table"">
    <tr>
        <td><h5>Activity</h5></td>
        <td><h5>Date and Time</h5></td>
        <td><h5>Duration</h5></td>
        <td><h5>Event Coordinator</h5></td>
        <td><h5>Number of Participants</h5></td>
        <td><h5>Actions</h5></td>
    </tr>
");
            EndContext();
#line 26 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
     foreach (var activ in Model.AllActivities)
    {

#line default
#line hidden
            BeginContext(694, 31, true);
            WriteLiteral("        <tr>\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 725, "\"", 762, 2);
            WriteAttributeValue("", 732, "ActivityDetails/", 732, 16, true);
#line 29 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
WriteAttributeValue("", 748, activ.ActivId, 748, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(763, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(765, 11, false);
#line 29 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
                                                    Write(activ.Title);

#line default
#line hidden
            EndContext();
            BeginContext(776, 26, true);
            WriteLiteral("</a></td>\n            <td>");
            EndContext();
            BeginContext(803, 28, false);
#line 30 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
           Write(activ.Date.ToString("MM/dd"));

#line default
#line hidden
            EndContext();
            BeginContext(831, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(833, 2, true);
            WriteLiteral("@ ");
            EndContext();
            BeginContext(836, 10, false);
#line 30 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
                                            Write(activ.Time);

#line default
#line hidden
            EndContext();
            BeginContext(846, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 31 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
             if(activ.Duration <= 60)
            {

#line default
#line hidden
            BeginContext(904, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(925, 14, false);
#line 33 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
               Write(activ.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(939, 16, true);
            WriteLiteral(" Minute(s)</td>\n");
            EndContext();
#line 34 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
            }
            else if(activ.Duration <= 1440)
            {
                int duration = activ.Duration/60;

#line default
#line hidden
            BeginContext(1077, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(1098, 8, false);
#line 38 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
               Write(duration);

#line default
#line hidden
            EndContext();
            BeginContext(1106, 14, true);
            WriteLiteral(" Hour(s)</td>\n");
            EndContext();
#line 39 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
            }
            else
            {
                int duration = activ.Duration/1440;

#line default
#line hidden
            BeginContext(1217, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(1238, 8, false);
#line 43 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
               Write(duration);

#line default
#line hidden
            EndContext();
            BeginContext(1246, 13, true);
            WriteLiteral(" Day(s)</td>\n");
            EndContext();
#line 44 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1273, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 45 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
              
                User theUser = (Model.AllUsers.Where(u => u.UserId == activ.UserId)).SingleOrDefault();

#line default
#line hidden
            BeginContext(1392, 20, true);
            WriteLiteral("                <td>");
            EndContext();
            BeginContext(1413, 17, false);
#line 47 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
               Write(theUser.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1430, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
            BeginContext(1450, 16, true);
            WriteLiteral("            <td>");
            EndContext();
            BeginContext(1467, 24, false);
#line 49 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
           Write(activ.Participants.Count);

#line default
#line hidden
            EndContext();
            BeginContext(1491, 6, true);
            WriteLiteral("</td>\n");
            EndContext();
#line 50 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
             if(Model.User.UserId == activ.UserId)
            {

#line default
#line hidden
            BeginContext(1562, 22, true);
            WriteLiteral("                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1584, "\"", 1612, 2);
            WriteAttributeValue("", 1591, "Delete/", 1591, 7, true);
#line 52 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
WriteAttributeValue("", 1598, activ.ActivId, 1598, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1613, 17, true);
            WriteLiteral(">Delete</a></td>\n");
            EndContext();
#line 53 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
            }
            else
            {
                if(activ.Participants.Where(p => p.UserId == Model.User.UserId).Count() == 0)
                {

#line default
#line hidden
            BeginContext(1787, 26, true);
            WriteLiteral("                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1813, "\"", 1839, 2);
            WriteAttributeValue("", 1820, "Join/", 1820, 5, true);
#line 58 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
WriteAttributeValue("", 1825, activ.ActivId, 1825, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1840, 15, true);
            WriteLiteral(">Join</a></td>\n");
            EndContext();
#line 59 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1912, 26, true);
            WriteLiteral("                    <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1938, "\"", 1965, 2);
            WriteAttributeValue("", 1945, "Leave/", 1945, 6, true);
#line 62 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
WriteAttributeValue("", 1951, activ.ActivId, 1951, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1966, 16, true);
            WriteLiteral(">Leave</a></td>\n");
            EndContext();
#line 63 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
                }
            }

#line default
#line hidden
            BeginContext(2014, 14, true);
            WriteLiteral("        </tr>\n");
            EndContext();
#line 66 "/Users/bellahawkins/Desktop/c#/ActivityCenter/Views/Activity/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2034, 93, true);
            WriteLiteral("</table>\n<a href=\"NewActivity\"><button class=\"btn btn-primary\">Add New Activity!</button></a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActivityCenter.Models.DashboardModels> Html { get; private set; }
    }
}
#pragma warning restore 1591
