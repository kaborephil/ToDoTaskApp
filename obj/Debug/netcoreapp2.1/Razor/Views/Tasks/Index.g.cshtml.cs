#pragma checksum "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "761ee62a4eeed9356820b931ca4107eeea632a70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tasks_Index), @"mvc.1.0.view", @"/Views/Tasks/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tasks/Index.cshtml", typeof(AspNetCore.Views_Tasks_Index))]
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
#line 1 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\_ViewImports.cshtml"
using ToDoTaskApp;

#line default
#line hidden
#line 2 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\_ViewImports.cshtml"
using ToDoTaskApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"761ee62a4eeed9356820b931ca4107eeea632a70", @"/Views/Tasks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48af03e3b2375eaff950a7130d8f3eb04a87bc34", @"/Views/_ViewImports.cshtml")]
    public class Views_Tasks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ToDoTaskApp.Models.Task>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(88, 60, true);
            WriteLiteral("\r\n<h1 class=\"text-success\">To Do Task List</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(148, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d1bf87d973a8433582f94554036beafb", async() => {
                BeginContext(171, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(185, 424, true);
            WriteLiteral(@"
</p>
<table class=""table table-striped table-bordered table-hover"">
    <thead>
        <tr>
            <th>
                Task Title
            </th>
            <th>
               Task Comment
            </th>
            <th>
               Task Date
            </th>
            <th>
                Task Status
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 31 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(641, 32, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n");
            EndContext();
#line 34 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
                 if ((item.TaskStatus == "done") || (item.TaskStatus == "Done") || (item.TaskStatus == "DONE"))
                {


#line default
#line hidden
            BeginContext(807, 48, true);
            WriteLiteral("                    <strike class=\"text-danger\">");
            EndContext();
            BeginContext(856, 44, false);
#line 37 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.TaskTitle));

#line default
#line hidden
            EndContext();
            BeginContext(900, 12, true);
            WriteLiteral(" </strike>\r\n");
            EndContext();
#line 38 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"

                }
                else
                {

                    

#line default
#line hidden
            BeginContext(997, 44, false);
#line 43 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TaskTitle));

#line default
#line hidden
            EndContext();
#line 43 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                                                 
                }

#line default
#line hidden
            BeginContext(1062, 41, true);
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 49 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
                 if ((item.TaskStatus == "done") || (item.TaskStatus == "Done") || (item.TaskStatus == "DONE"))
                {


#line default
#line hidden
            BeginContext(1237, 48, true);
            WriteLiteral("                    <strike class=\"text-danger\">");
            EndContext();
            BeginContext(1286, 46, false);
#line 52 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.TaskComment));

#line default
#line hidden
            EndContext();
            BeginContext(1332, 12, true);
            WriteLiteral(" </strike>\r\n");
            EndContext();
#line 53 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"

                }
                else
                {

                    

#line default
#line hidden
            BeginContext(1429, 46, false);
#line 58 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TaskComment));

#line default
#line hidden
            EndContext();
#line 58 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                                                   
                }

#line default
#line hidden
            BeginContext(1496, 37, true);
            WriteLiteral("            </td>\r\n            <td>\r\n");
            EndContext();
#line 62 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
                 if ((item.TaskStatus == "done") || (item.TaskStatus == "Done") || (item.TaskStatus == "DONE"))
                {


#line default
#line hidden
            BeginContext(1667, 48, true);
            WriteLiteral("                    <strike class=\"text-danger\">");
            EndContext();
            BeginContext(1716, 43, false);
#line 65 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.TaskDate));

#line default
#line hidden
            EndContext();
            BeginContext(1759, 12, true);
            WriteLiteral(" </strike>\r\n");
            EndContext();
#line 66 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"

                }
                else
                {

                    

#line default
#line hidden
            BeginContext(1856, 43, false);
#line 71 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TaskDate));

#line default
#line hidden
            EndContext();
#line 71 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                                                
                }

#line default
#line hidden
            BeginContext(1920, 37, true);
            WriteLiteral("            </td>\r\n            <td>\r\n");
            EndContext();
#line 75 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
                 if ((item.TaskStatus == "done") || (item.TaskStatus == "Done") || (item.TaskStatus == "DONE"))
                {


#line default
#line hidden
            BeginContext(2091, 48, true);
            WriteLiteral("                    <strike class=\"text-danger\">");
            EndContext();
            BeginContext(2140, 45, false);
#line 78 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.TaskStatus));

#line default
#line hidden
            EndContext();
            BeginContext(2185, 12, true);
            WriteLiteral(" </strike>\r\n");
            EndContext();
#line 79 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"

                }
                else
                {

                    

#line default
#line hidden
            BeginContext(2282, 45, false);
#line 84 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TaskStatus));

#line default
#line hidden
            EndContext();
#line 84 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                                                  
                }

#line default
#line hidden
            BeginContext(2348, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2401, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3fbbeda3222e4f5eb4c6a9f55f2fe773", async() => {
                BeginContext(2450, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 88 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                       WriteLiteral(item.TaskId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2458, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2478, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9b44e1897ced43ac9447a89a95959da7", async() => {
                BeginContext(2530, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 89 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                          WriteLiteral(item.TaskId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2541, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2561, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6dcf045719074888b2f8c98efe6f5c52", async() => {
                BeginContext(2612, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 90 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
                                         WriteLiteral(item.TaskId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2622, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 93 "C:\Users\Administrator\Desktop\Source\ToDoTaskApp\ToDoTaskApp\Views\Tasks\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2661, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ToDoTaskApp.Models.Task>> Html { get; private set; }
    }
}
#pragma warning restore 1591
