#pragma checksum "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\Dict\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31f9497ccfc34e87023d205ad4dd28e72041835b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dict_Add), @"mvc.1.0.view", @"/Views/Dict/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31f9497ccfc34e87023d205ad4dd28e72041835b", @"/Views/Dict/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578525f05628b61586d02cd96131d7535f052d97", @"/Views/_ViewImports.cshtml")]
    public class Views_Dict_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sys_dict>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\Dict\Add.cshtml"
  
    Layout = "_LayoutH";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"app\" v-cloak>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31f9497ccfc34e87023d205ad4dd28e72041835b4489", async() => {
                WriteLiteral("\r\n        <div class=\"box-body\">\r\n            ");
#nullable restore
#line 8 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\Dict\Add.cshtml"
       Write(await Component.InvokeAsync("DictType"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            <div class=""form-group"">
                <label class=""col-sm-2 control-label"">字典名称</label>
                <div class=""col-sm-10"">
                    <input class=""form-control"" v-model=""DictName"" v-focus type=""text"">
                </div>
            </div>
");
                WriteLiteral(@"            <div class=""form-group"">
                <label class=""col-sm-2 control-label"">备注</label>
                <div class=""col-sm-10"">
                    <textarea v-model=""Remark"" class=""form-control"" rows=""3"" placeholder=""备注...100个字符以内""></textarea>
                    <p class=""textarea-numberbar""><em class=""textarea-length"">{{count}}</em>/100</p>
                </div>
            </div>
        </div>
        <div class=""box-footer"">
            <div class=""pull-right box-tools"">
                <input v-on:click=""addL"" class=""btn btn-primary radius"" type=""submit"" v-model=""submit"">
            </div>
        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        var app = new Vue({\r\n            el: \"#app\",\r\n            data: {\r\n                submit: \"添加\",\r\n                DictId:\"");
#nullable restore
#line 43 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\Dict\Add.cshtml"
                   Write(Model.DictId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                Remark: \"");
#nullable restore
#line 44 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\Dict\Add.cshtml"
                    Write(Model.Remark);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                DictName: \"");
#nullable restore
#line 45 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\Dict\Add.cshtml"
                      Write(Model.DictName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                DictType:\"");
#nullable restore
#line 46 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\Dict\Add.cshtml"
                     Write(Model.DictType);

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
            //mounted: function(){
            //    var _self = this;
            //    _self.$nextTick(function () {
            //    });
            //},
            methods: {
                addL: function () {
                   var _self = this;
                    if (_self.DictName.length <= 0) {
                        layer.msg(""字典名称不能为空"", { icon: 2 });
                        return false;
                    }
                    if (_self.DictType.length <= 0) {
                        layer.msg(""请选择字典类型"", { icon: 2 });
                        return false;
                    }
                    var index = layer.load(1, {
                        shade: [0.1, '#fff'] //0.1透明度的白色背景
                    });
                    var data = {
                        id: _self.DictId,
               ");
                WriteLiteral(@"         DictName: _self.DictName,
                        DictType: _self.DictType,
                        Remark: _self.Remark
                    };
                    yui.$axiospostform('/Dict/AddOrUpdate', data)
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
               ");
                WriteLiteral(@"             } else {
                                layer.msg(response.data.Item2 || errorMsg, { icon: 5 });
                            }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sys_dict> Html { get; private set; }
    }
}
#pragma warning restore 1591