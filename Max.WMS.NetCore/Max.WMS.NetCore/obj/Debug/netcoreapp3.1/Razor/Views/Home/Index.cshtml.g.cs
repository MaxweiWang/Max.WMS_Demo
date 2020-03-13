#pragma checksum "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "38b4d8269dfbc41bed9c34d9090eca52adb7314e"
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
#line 1 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\_ViewImports.cshtml"
using Max.WMS.NetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\_ViewImports.cshtml"
using Max.WMS.NetCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\_ViewImports.cshtml"
using Max.Core.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\_ViewImports.cshtml"
using Max.Core.Orm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\Home\Index.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38b4d8269dfbc41bed9c34d9090eca52adb7314e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578525f05628b61586d02cd96131d7535f052d97", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""content-wrapper"">

    <section class=""content-header"">
        <h1>
            Dashboard
            <small>Control panel</small>
        </h1>
        <ol class=""breadcrumb"">
            <li><a href=""#""><i class=""fa fa-dashboard""></i> Home</a></li>
            <li class=""active"">Dashboard</li>
        </ol>
    </section>

    <section class=""content"">

        <!-- TO DO List -->
        <div class=""box box-primary"">
            <div class=""box-header"">
                <i class=""ion ion-clipboard""></i>
                <h3 class=""box-title"">To Do List</h3>
                <div class=""box-tools pull-right"">
                    <ul class=""pagination pagination-sm inline"">
                        <li><a href=""#"">&laquo;</a></li>
                        <li><a href=""#"">1</a></li>
                        <li><a href=""#"">2</a></li>
                        <li><a href=""#"">3</a></li>
                        <li><a href=""#"">&raquo;</a></li>
                    </ul>
         ");
            WriteLiteral(@"       </div>
            </div>
            <!-- /.box-header -->
            <div class=""box-body"">
                <!-- See dist/js/pages/dashboard.js to activate the todoList plugin -->
                <ul class=""todo-list"">
                    <li>
                        <!-- drag handle -->
                        <span class=""handle"">
                            <i class=""fa fa-ellipsis-v""></i>
                            <i class=""fa fa-ellipsis-v""></i>
                        </span>
                        <!-- checkbox -->
                        <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 1735, "\"", 1743, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <!-- todo text -->
                        <span class=""text"">Design a nice theme</span>
                        <!-- Emphasis label -->
                        <small class=""label label-danger""><i class=""fa fa-clock-o""></i> 2 mins</small>
                        <!-- General tools such as edit or delete-->
                        <div class=""tools"">
                            <i class=""fa fa-edit""></i>
                            <i class=""fa fa-trash-o""></i>
                        </div>
                    </li>
                    <li>
                        <span class=""handle"">
                            <i class=""fa fa-ellipsis-v""></i>
                            <i class=""fa fa-ellipsis-v""></i>
                        </span>
                        <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 2580, "\"", 2588, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <span class=""text"">Make the theme responsive</span>
                        <small class=""label label-info""><i class=""fa fa-clock-o""></i> 4 hours</small>
                        <div class=""tools"">
                            <i class=""fa fa-edit""></i>
                            <i class=""fa fa-trash-o""></i>
                        </div>
                    </li>
                    <li>
                        <span class=""handle"">
                            <i class=""fa fa-ellipsis-v""></i>
                            <i class=""fa fa-ellipsis-v""></i>
                        </span>
                        <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 3267, "\"", 3275, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <span class=""text"">Let theme shine like a star</span>
                        <small class=""label label-warning""><i class=""fa fa-clock-o""></i> 1 day</small>
                        <div class=""tools"">
                            <i class=""fa fa-edit""></i>
                            <i class=""fa fa-trash-o""></i>
                        </div>
                    </li>
                    <li>
                        <span class=""handle"">
                            <i class=""fa fa-ellipsis-v""></i>
                            <i class=""fa fa-ellipsis-v""></i>
                        </span>
                        <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 3957, "\"", 3965, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <span class=""text"">Let theme shine like a star</span>
                        <small class=""label label-success""><i class=""fa fa-clock-o""></i> 3 days</small>
                        <div class=""tools"">
                            <i class=""fa fa-edit""></i>
                            <i class=""fa fa-trash-o""></i>
                        </div>
                    </li>
                    <li>
                        <span class=""handle"">
                            <i class=""fa fa-ellipsis-v""></i>
                            <i class=""fa fa-ellipsis-v""></i>
                        </span>
                        <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 4648, "\"", 4656, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <span class=""text"">Check your messages and notifications</span>
                        <small class=""label label-primary""><i class=""fa fa-clock-o""></i> 1 week</small>
                        <div class=""tools"">
                            <i class=""fa fa-edit""></i>
                            <i class=""fa fa-trash-o""></i>
                        </div>
                    </li>
                    <li>
                        <span class=""handle"">
                            <i class=""fa fa-ellipsis-v""></i>
                            <i class=""fa fa-ellipsis-v""></i>
                        </span>
                        <input type=""checkbox""");
            BeginWriteAttribute("value", " value=\"", 5349, "\"", 5357, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <span class=""text"">Let theme shine like a star</span>
                        <small class=""label label-default""><i class=""fa fa-clock-o""></i> 1 month</small>
                        <div class=""tools"">
                            <i class=""fa fa-edit""></i>
                            <i class=""fa fa-trash-o""></i>
                        </div>
                    </li>
                </ul>
            </div>
            <!-- /.box-body -->
            <div class=""box-footer clearfix no-border"">
                <button type=""button"" class=""btn btn-default pull-right""><i class=""fa fa-plus""></i> Add item</button>
            </div>
        </div>
        <!-- /.box -->

        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""box"">
                    <div class=""box-header with-border"">
                        <h3 class=""box-title"">KopSoft- 技术QQ群:421635</h3>
                        <div class=""box-tools pull-right"">
            ");
            WriteLiteral(@"                <button type=""button"" class=""btn btn-box-tool"" data-widget=""collapse"" data-toggle=""tooltip""
                                    title=""Collapse"">
                                <i class=""fa fa-minus""></i>
                            </button>
                            <button type=""button"" class=""btn btn-box-tool"" data-widget=""remove"" data-toggle=""tooltip"" title=""Remove"">
                                <i class=""fa fa-times""></i>
                            </button>
                        </div>
                    </div>
                    <div class=""box-body"">
                        <table class=""table table-bordered text-nowrap table-hover"">
                            <tr>
                                <td>当前服务器OS</td>
                                <td>");
#nullable restore
#line 148 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\Home\Index.cshtml"
                               Write(Max.Core.Utils.Pub.PubSys.IsSystem());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            </tr>\r\n");
#nullable restore
#line 150 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\Home\Index.cshtml"
                              
                                var arr = _config.GetSection("Des").Get<Max.Core.Dto.ProjectDes>();

                                if (arr != null && arr.Content.Length > 0)
                                {
                                    foreach (var item in arr.Content)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 158 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\Home\Index.cshtml"
                                           Write(item.Split(':')[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 159 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\Home\Index.cshtml"
                                           Write(item.Split(':')[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 161 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\Home\Index.cshtml"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n    </section>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        var app = new Vue({
            el: '#app',
            data: {
                menuList: []
            },
            mounted: function () {
                var _self = this;
                _self.$nextTick(function () {
                    //if (!navigator.userAgent.match(/x64/i)) {
                    //    console.info(""32位浏览器"");
                    //} else {
                    //    console.info(""64位浏览器"");
                    //}
                    //home
                    //if (typeof (EventSource) !== 'undefined') {
                    //    var eventSource = new EventSource(`http://${location.host}/Home/ServerSendMsg`);
                    //    eventSource.onopen = function () {
                    //        //console.log('连接打开。。。');
                    //    }
                    //    eventSource.onerror = function (e) {
                    //        //console.log(e);
                    //    }
                    //    eve");
                WriteLiteral(@"ntSource.onmessage = function (event) {
                    //        console.log(event.data);
                    //        var origin = event.origin
                    //        var last = event.lastEventId
                    //    }
                    //    //eventSource.addEventListener('message', function (event) {
                    //    //    var origin = event.origin;
                    //    //    var lastEventId = event.lastEventId;
                    //    //    console.log(event.data, 2);
                    //    //}, false);
                    //} else {
                    //    console.info('浏览器不支持EventSource')
                    //}
                });
            },
            methods: {
                loadL: function () {

                },
            }
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration _config { get; private set; }
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