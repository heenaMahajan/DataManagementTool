#pragma checksum "D:\DataManagementTool\DataManagementTool\Views\Shared\_AdminRightSidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76e516e04f6051a39cb34ec1ba87d24554a81052"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__AdminRightSidebar), @"mvc.1.0.view", @"/Views/Shared/_AdminRightSidebar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_AdminRightSidebar.cshtml", typeof(AspNetCore.Views_Shared__AdminRightSidebar))]
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
#line 1 "D:\DataManagementTool\DataManagementTool\Views\_ViewImports.cshtml"
using DataManagementTool;

#line default
#line hidden
#line 2 "D:\DataManagementTool\DataManagementTool\Views\_ViewImports.cshtml"
using DataManagementTool.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e516e04f6051a39cb34ec1ba87d24554a81052", @"/Views/Shared/_AdminRightSidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2892875b7b33dc3f7823988473617aaa90ab03d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__AdminRightSidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle message-avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/a1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/a2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/a3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/a4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/a8.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/a7.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1132, true);
            WriteLiteral(@"<div id=""right-sidebar"">
    <div class=""sidebar-container"">

        <ul class=""nav nav-tabs navs-3"">

            <li class=""active"">
                <a data-toggle=""tab"" href=""#tab-1"">
                    Notes
                </a>
            </li>
            <li>
                <a data-toggle=""tab"" href=""#tab-2"">
                    Projects
                </a>
            </li>
            <li class="""">
                <a data-toggle=""tab"" href=""#tab-3"">
                    <i class=""fa fa-gear""></i>
                </a>
            </li>
        </ul>

        <div class=""tab-content"">


            <div id=""tab-1"" class=""tab-pane active"">

                <div class=""sidebar-title"">
                    <h3> <i class=""fa fa-comments-o""></i> Latest Notes</h3>
                    <small><i class=""fa fa-tim""></i> You have 10 new message.</small>
                </div>

                <div>

                    <div class=""sidebar-message"">
                        <a ");
            WriteLiteral("href=\"#\">\r\n                            <div class=\"pull-left text-center\">\r\n                                ");
            EndContext();
            BeginContext(1132, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cebd46d186d54f1e903b87ef1d9d4bf9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1205, 840, true);
            WriteLiteral(@"

                                <div class=""m-t-xs"">
                                    <i class=""fa fa-star text-warning""></i>
                                    <i class=""fa fa-star text-warning""></i>
                                </div>
                            </div>
                            <div class=""media-body"">

                                There are many variations of passages of Lorem Ipsum available.
                                <br>
                                <small class=""text-muted"">Today 4:21 pm</small>
                            </div>
                        </a>
                    </div>
                    <div class=""sidebar-message"">
                        <a href=""#"">
                            <div class=""pull-left text-center"">
                                ");
            EndContext();
            BeginContext(2045, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1cab4124ace64cfb8a62252c1fd3b35c", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2118, 597, true);
            WriteLiteral(@"
                            </div>
                            <div class=""media-body"">
                                The point of using Lorem Ipsum is that it has a more-or-less normal.
                                <br>
                                <small class=""text-muted"">Yesterday 2:45 pm</small>
                            </div>
                        </a>
                    </div>
                    <div class=""sidebar-message"">
                        <a href=""#"">
                            <div class=""pull-left text-center"">
                                ");
            EndContext();
            BeginContext(2715, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f3209fb329e84794b218399d9b6cc92e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2788, 956, true);
            WriteLiteral(@"

                                <div class=""m-t-xs"">
                                    <i class=""fa fa-star text-warning""></i>
                                    <i class=""fa fa-star text-warning""></i>
                                    <i class=""fa fa-star text-warning""></i>
                                </div>
                            </div>
                            <div class=""media-body"">
                                Mevolved over the years, sometimes by accident, sometimes on purpose (injected humour and the like).
                                <br>
                                <small class=""text-muted"">Yesterday 1:10 pm</small>
                            </div>
                        </a>
                    </div>
                    <div class=""sidebar-message"">
                        <a href=""#"">
                            <div class=""pull-left text-center"">
                                ");
            EndContext();
            BeginContext(3744, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b64b1199ed574494922b1123077ab1b8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3817, 608, true);
            WriteLiteral(@"
                            </div>

                            <div class=""media-body"">
                                Lorem Ipsum, you need to be sure there isn't anything embarrassing hidden in the
                                <br>
                                <small class=""text-muted"">Monday 8:37 pm</small>
                            </div>
                        </a>
                    </div>
                    <div class=""sidebar-message"">
                        <a href=""#"">
                            <div class=""pull-left text-center"">
                                ");
            EndContext();
            BeginContext(4425, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1cae4ba924bf47d0b859508bcf5b2667", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4498, 589, true);
            WriteLiteral(@"
                            </div>
                            <div class=""media-body"">

                                All the Lorem Ipsum generators on the Internet tend to repeat.
                                <br>
                                <small class=""text-muted"">Today 4:21 pm</small>
                            </div>
                        </a>
                    </div>
                    <div class=""sidebar-message"">
                        <a href=""#"">
                            <div class=""pull-left text-center"">
                                ");
            EndContext();
            BeginContext(5087, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30b51ea562ed42149e51df98d753ac0e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5160, 642, true);
            WriteLiteral(@"
                            </div>
                            <div class=""media-body"">
                                Renaissance. The first line of Lorem Ipsum, ""Lorem ipsum dolor sit amet.."", comes from a line in section 1.10.32.
                                <br>
                                <small class=""text-muted"">Yesterday 2:45 pm</small>
                            </div>
                        </a>
                    </div>
                    <div class=""sidebar-message"">
                        <a href=""#"">
                            <div class=""pull-left text-center"">
                                ");
            EndContext();
            BeginContext(5802, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fbef0ba28a674a3f8c3309f175325cea", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5875, 931, true);
            WriteLiteral(@"

                                <div class=""m-t-xs"">
                                    <i class=""fa fa-star text-warning""></i>
                                    <i class=""fa fa-star text-warning""></i>
                                    <i class=""fa fa-star text-warning""></i>
                                </div>
                            </div>
                            <div class=""media-body"">
                                The standard chunk of Lorem Ipsum used since the 1500s is reproduced below.
                                <br>
                                <small class=""text-muted"">Yesterday 1:10 pm</small>
                            </div>
                        </a>
                    </div>
                    <div class=""sidebar-message"">
                        <a href=""#"">
                            <div class=""pull-left text-center"">
                                ");
            EndContext();
            BeginContext(6806, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8d3417bc194f4558be71110ee6f462c9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6879, 11863, true);
            WriteLiteral(@"
                            </div>
                            <div class=""media-body"">
                                Uncover many web sites still in their infancy. Various versions have.
                                <br>
                                <small class=""text-muted"">Monday 8:37 pm</small>
                            </div>
                        </a>
                    </div>
                </div>

            </div>

            <div id=""tab-2"" class=""tab-pane"">

                <div class=""sidebar-title"">
                    <h3> <i class=""fa fa-cube""></i> Latest projects</h3>
                    <small><i class=""fa fa-tim""></i> You have 14 projects. 10 not completed.</small>
                </div>

                <ul class=""sidebar-list"">
                    <li>
                        <a href=""#"">
                            <div class=""small pull-right m-t-xs"">9 hours ago</div>
                            <h4>Business valuation</h4>
                       ");
            WriteLiteral(@"     It is a long established fact that a reader will be distracted.

                            <div class=""small"">Completion with: 22%</div>
                            <div class=""progress progress-mini"">
                                <div style=""width: 22%;"" class=""progress-bar progress-bar-warning""></div>
                            </div>
                            <div class=""small text-muted m-t-xs"">Project end: 4:00 pm - 12.06.2014</div>
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <div class=""small pull-right m-t-xs"">9 hours ago</div>
                            <h4>Contract with Company </h4>
                            Many desktop publishing packages and web page editors.

                            <div class=""small"">Completion with: 48%</div>
                            <div class=""progress progress-mini"">
                                <div style=""width: 48%;"" class=""progr");
            WriteLiteral(@"ess-bar""></div>
                            </div>
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <div class=""small pull-right m-t-xs"">9 hours ago</div>
                            <h4>Meeting</h4>
                            By the readable content of a page when looking at its layout.

                            <div class=""small"">Completion with: 14%</div>
                            <div class=""progress progress-mini"">
                                <div style=""width: 14%;"" class=""progress-bar progress-bar-info""></div>
                            </div>
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <span class=""label label-primary pull-right"">NEW</span>
                            <h4>The generated</h4>
                            <!--<div class=""small pull-right m-t-xs"">9 hours ago</div>--");
            WriteLiteral(@">
                            There are many variations of passages of Lorem Ipsum available.
                            <div class=""small"">Completion with: 22%</div>
                            <div class=""small text-muted m-t-xs"">Project end: 4:00 pm - 12.06.2014</div>
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <div class=""small pull-right m-t-xs"">9 hours ago</div>
                            <h4>Business valuation</h4>
                            It is a long established fact that a reader will be distracted.

                            <div class=""small"">Completion with: 22%</div>
                            <div class=""progress progress-mini"">
                                <div style=""width: 22%;"" class=""progress-bar progress-bar-warning""></div>
                            </div>
                            <div class=""small text-muted m-t-xs"">Project end: 4:00 pm - 12.06.2014</div>
");
            WriteLiteral(@"                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <div class=""small pull-right m-t-xs"">9 hours ago</div>
                            <h4>Contract with Company </h4>
                            Many desktop publishing packages and web page editors.

                            <div class=""small"">Completion with: 48%</div>
                            <div class=""progress progress-mini"">
                                <div style=""width: 48%;"" class=""progress-bar""></div>
                            </div>
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <div class=""small pull-right m-t-xs"">9 hours ago</div>
                            <h4>Meeting</h4>
                            By the readable content of a page when looking at its layout.

                            <div class=""small"">Completion with: 1");
            WriteLiteral(@"4%</div>
                            <div class=""progress progress-mini"">
                                <div style=""width: 14%;"" class=""progress-bar progress-bar-info""></div>
                            </div>
                        </a>
                    </li>
                    <li>
                        <a href=""#"">
                            <span class=""label label-primary pull-right"">NEW</span>
                            <h4>The generated</h4>
                            <!--<div class=""small pull-right m-t-xs"">9 hours ago</div>-->
                            There are many variations of passages of Lorem Ipsum available.
                            <div class=""small"">Completion with: 22%</div>
                            <div class=""small text-muted m-t-xs"">Project end: 4:00 pm - 12.06.2014</div>
                        </a>
                    </li>

                </ul>

            </div>

            <div id=""tab-3"" class=""tab-pane"">

                <div class=""si");
            WriteLiteral(@"debar-title"">
                    <h3><i class=""fa fa-gears""></i> Settings</h3>
                    <small><i class=""fa fa-tim""></i> You have 14 projects. 10 not completed.</small>
                </div>

                <div class=""setings-item"">
                    <span>
                        Show notifications
                    </span>
                    <div class=""switch"">
                        <div class=""onoffswitch"">
                            <input type=""checkbox"" name=""collapsemenu"" class=""onoffswitch-checkbox"" id=""example"">
                            <label class=""onoffswitch-label"" for=""example"">
                                <span class=""onoffswitch-inner""></span>
                                <span class=""onoffswitch-switch""></span>
                            </label>
                        </div>
                    </div>
                </div>
                <div class=""setings-item"">
                    <span>
                        Disable Chat
     ");
            WriteLiteral(@"               </span>
                    <div class=""switch"">
                        <div class=""onoffswitch"">
                            <input type=""checkbox"" name=""collapsemenu"" checked class=""onoffswitch-checkbox"" id=""example2"">
                            <label class=""onoffswitch-label"" for=""example2"">
                                <span class=""onoffswitch-inner""></span>
                                <span class=""onoffswitch-switch""></span>
                            </label>
                        </div>
                    </div>
                </div>
                <div class=""setings-item"">
                    <span>
                        Enable history
                    </span>
                    <div class=""switch"">
                        <div class=""onoffswitch"">
                            <input type=""checkbox"" name=""collapsemenu"" class=""onoffswitch-checkbox"" id=""example3"">
                            <label class=""onoffswitch-label"" for=""example3"">
        ");
            WriteLiteral(@"                        <span class=""onoffswitch-inner""></span>
                                <span class=""onoffswitch-switch""></span>
                            </label>
                        </div>
                    </div>
                </div>
                <div class=""setings-item"">
                    <span>
                        Show charts
                    </span>
                    <div class=""switch"">
                        <div class=""onoffswitch"">
                            <input type=""checkbox"" name=""collapsemenu"" class=""onoffswitch-checkbox"" id=""example4"">
                            <label class=""onoffswitch-label"" for=""example4"">
                                <span class=""onoffswitch-inner""></span>
                                <span class=""onoffswitch-switch""></span>
                            </label>
                        </div>
                    </div>
                </div>
                <div class=""setings-item"">
                    <span");
            WriteLiteral(@">
                        Offline users
                    </span>
                    <div class=""switch"">
                        <div class=""onoffswitch"">
                            <input type=""checkbox"" checked name=""collapsemenu"" class=""onoffswitch-checkbox"" id=""example5"">
                            <label class=""onoffswitch-label"" for=""example5"">
                                <span class=""onoffswitch-inner""></span>
                                <span class=""onoffswitch-switch""></span>
                            </label>
                        </div>
                    </div>
                </div>
                <div class=""setings-item"">
                    <span>
                        Global search
                    </span>
                    <div class=""switch"">
                        <div class=""onoffswitch"">
                            <input type=""checkbox"" checked name=""collapsemenu"" class=""onoffswitch-checkbox"" id=""example6"">
                            <lab");
            WriteLiteral(@"el class=""onoffswitch-label"" for=""example6"">
                                <span class=""onoffswitch-inner""></span>
                                <span class=""onoffswitch-switch""></span>
                            </label>
                        </div>
                    </div>
                </div>
                <div class=""setings-item"">
                    <span>
                        Update everyday
                    </span>
                    <div class=""switch"">
                        <div class=""onoffswitch"">
                            <input type=""checkbox"" name=""collapsemenu"" class=""onoffswitch-checkbox"" id=""example7"">
                            <label class=""onoffswitch-label"" for=""example7"">
                                <span class=""onoffswitch-inner""></span>
                                <span class=""onoffswitch-switch""></span>
                            </label>
                        </div>
                    </div>
                </div>

         ");
            WriteLiteral(@"       <div class=""sidebar-content"">
                    <h4>Settings</h4>
                    <div class=""small"">
                        I belive that. Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                        And typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s.
                        Over the years, sometimes by accident, sometimes on purpose (injected humour and the like).
                    </div>
                </div>

            </div>
        </div>

    </div>



</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
