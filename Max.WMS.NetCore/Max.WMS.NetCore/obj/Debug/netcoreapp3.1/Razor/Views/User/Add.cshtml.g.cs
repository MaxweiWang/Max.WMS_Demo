#pragma checksum "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\User\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "796d2ad6b60af8fc8e02e17cc76201dc58232850"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Add), @"mvc.1.0.view", @"/Views/User/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"796d2ad6b60af8fc8e02e17cc76201dc58232850", @"/Views/User/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578525f05628b61586d02cd96131d7535f052d97", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sys_user>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\User\Add.cshtml"
  
    Layout = "_LayoutH";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"app\" v-cloak>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "796d2ad6b60af8fc8e02e17cc76201dc582328504911", async() => {
                WriteLiteral("\r\n        <div class=\"box-body\">\r\n");
                WriteLiteral(@"            <table class=""table table-bordered"">
                <tr>
                    <td>
                        <div class=""form-group"">
                            <label class=""col-sm-2 control-label""><span class=""c-red"">*</span>用户名：</label>
                            <div class=""col-sm-10"">
                                <input v-model=""UserName"" type=""text"" class=""form-control"" v-focus>
                            </div>
                        </div>
                    </td>
                    <td>
                        <div class=""form-group"">
                            <label class=""control-label col-sm-2""><span class=""c-red"">*</span>昵称：</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" class=""form-control"" v-model=""UserNickname"">
                            </div>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                    ");
                WriteLiteral(@"    <div class=""form-group"" v-if=""UserId<=0"">
                            <label class=""control-label col-sm-2""><span class=""c-red"">*</span>初始密码：</label>
                            <div class=""col-sm-10"">
                                <input type=""password"" class=""form-control"" autocomplete=""off""");
                BeginWriteAttribute("value", " value=\"", 3799, "\"", 3807, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""密码"" v-model=""Pwd1"">
                            </div>
                        </div>
                    </td>
                    <td>
                        <div class=""form-group"" v-if=""UserId<=0"">
                            <label class=""control-label col-sm-2""><span class=""c-red"">*</span>确认密码：</label>
                            <div class="" col-sm-10"">
                                <input type=""password"" class=""form-control"" autocomplete=""off"" placeholder=""确认新密码"" v-model=""Pwd2"">
                            </div>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td colspan=""2"">
                        <div class=""form-group"">
                            <label class=""control-label col-sm-2""><span class=""c-red"">*</span>性别：</label>
                            <div class=""col-sm-10 "">
                                <label class=""radio-inline"">
                                    <input type=""radio""");
                WriteLiteral(@" value=""1"" v-model=""sex"">男
                                </label>
                                <label class=""radio-inline"">
                                    <input type=""radio"" value=""0"" v-model=""sex"">女
                                </label>
                            </div>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class=""form-group"">
                            <label class=""control-label col-sm-2""><span class=""c-red"">*</span>手机：</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" class=""form-control"" v-model=""Tel"">
                            </div>
                        </div>
                    </td>
                    <td>
                        <div class=""form-group"">
                            <label class=""col-sm-2 control-label""><span class=""c-red"">*</span>邮箱：</label>
                         ");
                WriteLiteral(@"   <div class=""col-sm-10"">
                                <input type=""text"" class=""form-control"" v-model=""Email"">
                            </div>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        ");
#nullable restore
#line 126 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\User\Add.cshtml"
                   Write(await Component.InvokeAsync("Dept"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
                WriteLiteral(@"                    </td>
                    <td>
                        <div class=""form-group"">
                            <label class=""col-sm-2 control-label"">角色：</label>
                            <div class=""col-sm-10"">
                                <select class=""form-control"" v-model=""RoleId"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "796d2ad6b60af8fc8e02e17cc76201dc582328509966", async() => {
                    WriteLiteral("请选择");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 151 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\User\Add.cshtml"
                                      
                                        if (ViewBag.Role != null || ViewBag.Role.Count > 0)
                                        {
                                            foreach (var item in ViewBag.Role)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "796d2ad6b60af8fc8e02e17cc76201dc5823285011727", async() => {
#nullable restore
#line 156 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\User\Add.cshtml"
                                                                        Write(item.RoleName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 156 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\User\Add.cshtml"
                                                   WriteLiteral(item.RoleId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 157 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\User\Add.cshtml"
                                            }
                                        }
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </select>
                            </div>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td colspan=""2"">
                        <div class=""form-group"">
                            <label class=""col-sm-2 control-label"">备注：</label>
                            <div class=""col-sm-10"">
                                <textarea v-model=""Remark"" class=""form-control"" rows=""3"" placeholder=""备注...100个字符以内""></textarea>
                                <p class=""textarea-numberbar""><em class=""textarea-length"">{{count}}</em>/100</p>
                            </div>
                        </div>
                    </td>
                </tr>
            </table>
            <div class=""box-footer"">
                <div class=""pull-right box-tools"">
                    <input v-on:click=""addL"" class=""btn btn-primary radius"" type=""submit"" v-model=""submit"">
                </div>
            </");
                WriteLiteral("div>\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>
        $(function () {
            parent.$(""span[class='layui-layer-setwin']"")[0].childNodes[1].onclick = function () {
                //var iframeH = parent.$(""div[type='iframe']"")[0].clientHeight;
                //parent.$(""div[class='layui-layer-content']"")[0].childNodes[0].style.height = 1000;
                var index = parent.layer.getFrameIndex(window.name);
                //console.info(parent.$(""#layui-layer"" + index)[0].style[""height""]);
                parent.$(""#layui-layer-iframe"" + index)[0].style.height = parent.document.body.clientHeight + ""px"";
            };
        });
        var app = new Vue({
            el: ""#app"",
            data: {
                submit: ""添加"",
                sex: """);
#nullable restore
#line 200 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\User\Add.cshtml"
                 Write(Model.Sex);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                Remark: \"");
#nullable restore
#line 201 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\User\Add.cshtml"
                    Write(Model.Remark);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                Tel: \"");
#nullable restore
#line 202 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\User\Add.cshtml"
                 Write(Model.Tel);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                Email: \"");
#nullable restore
#line 203 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\User\Add.cshtml"
                   Write(Model.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                UserName: \"");
#nullable restore
#line 204 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\User\Add.cshtml"
                      Write(Model.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                UserNickname: \"");
#nullable restore
#line 205 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\User\Add.cshtml"
                          Write(Model.UserNickname);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                Pwd1: \"\",\r\n                Pwd2: \"\",\r\n                RoleId: \"");
#nullable restore
#line 208 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\User\Add.cshtml"
                    Write(Model.RoleId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                DeptId: \"");
#nullable restore
#line 209 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\User\Add.cshtml"
                    Write(Model.DeptId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                UserId: \"");
#nullable restore
#line 210 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\User\Add.cshtml"
                    Write(Model.UserId);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"""
            },
            computed: {
                count: function () {
                    return this.strLength(this.Remark, false);
                }
            },
            methods: {
                addL: function () {
                    var _self = this;
                    if (_self.UserName.length <= 0) {
                        layer.msg(""姓名不能为空"", { icon: 2 });
                        return false;
                    }
                    if (_self.UserNickname.length <= 0) {
                        layer.msg(""昵称不能为空"", { icon: 2 });
                        return false;
                    }
                    if (_self.UserId.length<=0) {
                        if (_self.Pwd1.length <= 0) {
                            layer.msg(""密码不能为空"", { icon: 2 });
                            return false;
                        }
                        if (_self.Pwd2 !== _self.Pwd1) {
                            layer.msg(""两次输入密码不一致"", { icon: 2 });
                        ");
                WriteLiteral(@"    return false;
                        }
                    }
                    if (_self.DeptId.length <= 0) {
                        layer.msg(""请选择部门"", { icon: 2 });
                        return false;
                    }
                    if (_self.RoleId.length <= 0) {
                        layer.msg(""请选择角色"", { icon: 2 });
                        return false;
                    }
                    var index = layer.load(1, {
                        shade: [0.1, '#fff'] //0.1透明度的白色背景
                    });
                    var data = {
                        id: _self.UserId,
                        UserName: _self.UserName,
                        UserNickname: _self.UserNickname,
                        Pwd: _self.Pwd2,
                        Remark: _self.Remark,
                        Tel: _self.Tel,
                        RoleId: _self.RoleId,
                        sex: _self.sex,
                        Email: _self.Email,
                        D");
                WriteLiteral(@"eptId: _self.DeptId
                    };
                    yui.$axiospostform('/User/AddOrUpdate', data)
                        .then(function (response) {
                            if (response.data.Item1 === 101) {
                                layer.tips(response.data.Item2, '.layui-layer-setwin', {
                                    tips: [1, '#3595CC'],
                                    time: 3000
                                });
                                layer.close(index);
                                return false;
                            }
                            if (response.data.Item1) {
                                layer.msg(response.data.Item2, { icon: 1, time: 1000 });
                                setTimeout(function () {
                                    yui.layer_close3();
                                }, 500);
                            } else {
                                layer.msg(response.data.Item2, { icon: 5 });
           ");
                WriteLiteral(@"                 }
                            layer.close(index);
                        })
                        .catch(function (error) {
                            layer.close(index);
                        });
                }
            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sys_user> Html { get; private set; }
    }
}
#pragma warning restore 1591