#pragma checksum "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StorageRack\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e4e2159ec4f44df3c5f21f929b349760b419161"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StorageRack_Add), @"mvc.1.0.view", @"/Views/StorageRack/Add.cshtml")]
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
#line 1 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\_ViewImports.cshtml"
using Max.WMS.NetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\_ViewImports.cshtml"
using Max.WMS.NetCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\_ViewImports.cshtml"
using Max.Core.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\_ViewImports.cshtml"
using Max.Core.Orm;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e4e2159ec4f44df3c5f21f929b349760b419161", @"/Views/StorageRack/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578525f05628b61586d02cd96131d7535f052d97", @"/Views/_ViewImports.cshtml")]
    public class Views_StorageRack_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wms_storagerack>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute(":value", new global::Microsoft.AspNetCore.Html.HtmlString("item.ReservoirAreaId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StorageRack\Add.cshtml"
  
    Layout = "_LayoutH";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"app\" v-cloak>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e4e2159ec4f44df3c5f21f929b349760b4191615351", async() => {
                WriteLiteral(@"
        <div class=""box-body"">
            <div class=""form-group"">
                <label class=""col-sm-2 control-label"">货架编号</label>
                <div class=""col-sm-10"">
                    <input class=""form-control"" v-model=""StorageRackNo"" v-focus type=""text"">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-sm-2 control-label"">货架名称</label>
                <div class=""col-sm-10"">
                    <input class=""form-control"" v-model=""StorageRackName"" type=""text"">
                </div>
            </div>
            ");
#nullable restore
#line 20 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StorageRack\Add.cshtml"
       Write(await Component.InvokeAsync("Warehouse"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            <div class=""form-group"">
                <label class=""form-label col-sm-2"">所属库区</label>
                <div class=""col-sm-10"">
                    <select class=""form-control"" v-model=""ReservoirAreaId"" size=""1"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e4e2159ec4f44df3c5f21f929b349760b4191616769", async() => {
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
                WriteLiteral("\r\n                        <template v-for=\"item in list\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e4e2159ec4f44df3c5f21f929b349760b4191618078", async() => {
                    WriteLiteral("{{item.ReservoirAreaName}}");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </template>
                    </select>
                </div>
            </div>
            <div class=""form-group"">
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
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        var app = new Vue({\r\n            el: \"#app\",\r\n            data: {\r\n                submit: \"添加\",\r\n                Remark: \"");
#nullable restore
#line 53 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StorageRack\Add.cshtml"
                    Write(Model.Remark);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                StorageRackId:\"");
#nullable restore
#line 54 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StorageRack\Add.cshtml"
                          Write(Model.StorageRackId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                WarehouseId: \"");
#nullable restore
#line 55 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StorageRack\Add.cshtml"
                         Write(Model.WarehouseId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                ReservoirAreaId:\"");
#nullable restore
#line 56 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StorageRack\Add.cshtml"
                            Write(Model.ReservoirAreaId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                StorageRackName: \"");
#nullable restore
#line 57 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StorageRack\Add.cshtml"
                             Write(Model.StorageRackName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                StorageRackNo: \"");
#nullable restore
#line 58 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StorageRack\Add.cshtml"
                           Write(Model.StorageRackNo);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                list: [] //库区
            },
            computed: {
                count: function () {
                    return this.strLength(this.Remark, false);
                }
            },
            watch: {
                WarehouseId: function () {
                    var _self = this;
                    _self.loadL(_self.WarehouseId);
                }
            },
            mounted: function () {
                var _self = this;
                if (_self.WarehouseId.length > 1) {
                    _self.loadL(_self.WarehouseId);
                }
            },
            methods: {
                loadL: function (id) {
                    var _self = this;
                    yui.$axiosget('/StorageRack/GetReservoirarea?id=' + id).then(function (response) {
                        _self.list = response.data;
                    });
                },
                addL: function () {
                    var _self = this;
                    if (_");
                WriteLiteral(@"self.StorageRackNo.length <= 0) {
                        layer.msg(""库区编号不能为空"", { icon: 2 });
                        return false;
                    }
                    if (_self.StorageRackName.length <= 0) {
                        layer.msg(""库区名称不能为空"", { icon: 2 });
                        return false;
                    }
                    if (_self.WarehouseId.length <= 0) {
                        layer.msg(""请选择仓库"", { icon: 2 });
                        return false;
                    }
                    if (_self.ReservoirAreaId.length <= 0) {
                        layer.msg(""请选择库区"", { icon: 2 });
                        return false;
                    }
                    var index = layer.load(1, {
                        shade: [0.1, '#fff'] //0.1透明度的白色背景
                    });
                    var data = {
                        id: _self.StorageRackId,
                        StorageRackName: _self.StorageRackName,
                        StorageRackNo:");
                WriteLiteral(@" _self.StorageRackNo,
                        Remark: _self.Remark,
                        WarehouseId: _self.WarehouseId,
                        ReservoirAreaId:_self.ReservoirAreaId
                    };
                    yui.$axiospostform('/StorageRack/AddOrUpdate', data)
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
                                    yui.layer_clos");
                WriteLiteral(@"e3();
                                }, 500);
                            } else {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wms_storagerack> Html { get; private set; }
    }
}
#pragma warning restore 1591