#pragma checksum "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StockIn\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9620f1e51f51932d6807dd5f18319d3dbe5a2746"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StockIn_Detail), @"mvc.1.0.view", @"/Views/StockIn/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9620f1e51f51932d6807dd5f18319d3dbe5a2746", @"/Views/StockIn/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578525f05628b61586d02cd96131d7535f052d97", @"/Views/_ViewImports.cshtml")]
    public class Views_StockIn_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wms_stockindetail>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap-select.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onsubmit", new global::Microsoft.AspNetCore.Html.HtmlString("return false"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap-select.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/defaults-zh_CN.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StockIn\Detail.cshtml"
  
    Layout = "_LayoutH";
    

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9620f1e51f51932d6807dd5f18319d3dbe5a27466203", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("<div id=\"app\" v-cloak>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9620f1e51f51932d6807dd5f18319d3dbe5a27467467", async() => {
                WriteLiteral(@"
        <div class=""box-body"">
            <div class=""form-group"">
                <label class=""col-sm-2 control-label"">物料</label>
                <div class=""col-sm-10"">
                    <select size=""1"" id=""MaterialId"" v-model=""MaterialId"" class=""show-menu-arrow show-tick selectpicker form-control"" data-live-search=""true""></select>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-sm-2 control-label"">计划数量</label>
                <div class=""col-sm-10"">
                    <input class=""form-control"" v-model=""PlanInQty"" v-focus type=""text"">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-sm-2 control-label"">实际数量</label>
                <div class=""col-sm-10"">
                    <input class=""form-control"" v-model=""ActInQty"" v-focus type=""text"">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""for");
                WriteLiteral(@"m-label col-sm-2"">货架</label>
                <div class=""col-sm-10"">
                    <select size=""1"" id=""StoragerackId"" v-model=""StoragerackId"" class=""show-menu-arrow show-tick selectpicker form-control"" data-live-search=""true""></select>
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
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9620f1e51f51932d6807dd5f18319d3dbe5a274611063", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9620f1e51f51932d6807dd5f18319d3dbe5a274612163", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $(function () {
            $('#MaterialId').on('show.bs.select', function (e, clickedIndex, isSelected, previousValue) {
                var divdom = $(""div[class='bs-searchbox']"")[0].childNodes[0];
                $(divdom).on(""input propertychange"", function () {
                    var dom = $(""li[class='no-results']"");
                    var text = divdom.value;
                    if (dom.length > 0) {
                        app.searchMaterial(text, 2);
                    }
                    if (app.MaterialList.length <= 0) {
                        app.searchMaterial(text, 2);
                    }
                    //if (dom.length > 0) {
                    //    yui.$axiosget('/Material/Search?text=' + text).then(function (res) {
                    //        var data = res.data.rows;
                    //        var html = ""<option value=''>请选择</option>"";
                    //        for (var item in data) {
                    //            html +");
                WriteLiteral(@"= ""<option value='"" + data[item].MaterialId + ""' "" + ""data-subtext='"" + data[item].MaterialNo + ""'>"" + data[item].MaterialName + ""</option>""
                    //        }
                    //        $(""#MaterialId"").empty();
                    //        $(""#MaterialId"").append(html)
                    //        $('#MaterialId').selectpicker('refresh');
                    //    }).catch(function (res) {
                    //    });
                    //} else {
                    //    yui.$axiosget('/Material/Search?text=' + text).then(function (res) {
                    //        var data = res.data.rows;
                    //        var html = ""<option value=''>请选择</option>"";
                    //        for (var item in data) {
                    //            html += ""<option value='"" + data[item].MaterialId + ""' "" + ""data-subtext='"" + data[item].MaterialNo + ""'>"" + data[item].MaterialName + ""</option>""
                    //        }
                    //        $(""#MaterialI");
                WriteLiteral(@"d"").empty();
                    //        $(""#MaterialId"").append(html)
                    //        $('#MaterialId').selectpicker('refresh');
                    //    }).catch(function (res) {
                    //    });
                    //}
                });
            });

            $('#StoragerackId').on('show.bs.select', function (e, clickedIndex, isSelected, previousValue) {
                var divdom = $(""div[class='bs-searchbox']"")[0].childNodes[0];
                $(divdom).on(""input propertychange"", function () {
                    var dom = $(""li[class='no-results']"");
                    var text = divdom.value;
                    if (dom.length > 0) {
                        app.searchStorageRack(text, 2);
                    }
                    if (app.StorageRackList.length <= 0) {
                        app.searchStorageRack(text, 2);
                    }
                    //if (dom.length > 0) {
                    //    yui.$axiosget('/Storagerack/Se");
                WriteLiteral(@"arch?text=' + text).then(function (res) {
                    //        var data = res.data.rows;
                    //        var html = ""<option value=''>请选择</option>"";
                    //        for (var item in data) {
                    //            html += ""<option value='"" + data[item].StorageRackId + ""' "" + ""data-subtext='"" + data[item].StorageRackNo + ""'>"" + data[item].StorageRackName + ""</option>""
                    //        }
                    //        $(""#StoragerackId"").empty();
                    //        $(""#StoragerackId"").append(html)
                    //        $('#StoragerackId').selectpicker('refresh');
                    //    }).catch(function (res) {
                    //    });
                    //} else {
                    //    yui.$axiosget('/Storagerack/Search?text=' + text).then(function (res) {
                    //        var data = res.data.rows;
                    //        var html = ""<option value=''>请选择</option>"";
                    //");
                WriteLiteral(@"        for (var item in data) {
                    //            html += ""<option value='"" + data[item].StorageRackId + ""' "" + ""data-subtext='"" + data[item].StorageRackNo + ""'>"" + data[item].StorageRackName + ""</option>""
                    //        }
                    //        $(""#StoragerackId"").empty();
                    //        $(""#StoragerackId"").append(html)
                    //        $('#StoragerackId').selectpicker('refresh');
                    //    }).catch(function (res) {
                    //    });
                    //}
                });
            });
        });
        var app = new Vue({
            el: ""#app"",
            data: {
                submit: ""添加"",
                MaterialId:""");
#nullable restore
#line 138 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StockIn\Detail.cshtml"
                       Write(Model.MaterialId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                StockInId:\"");
#nullable restore
#line 139 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StockIn\Detail.cshtml"
                      Write(Model.StockInId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                StockInDetailId:\"");
#nullable restore
#line 140 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StockIn\Detail.cshtml"
                            Write(Model.StockInDetailId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                Remark: \"");
#nullable restore
#line 141 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StockIn\Detail.cshtml"
                    Write(Model.Remark);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                StoragerackId: \"");
#nullable restore
#line 142 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StockIn\Detail.cshtml"
                           Write(Model.StoragerackId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                PlanInQty:\"");
#nullable restore
#line 143 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StockIn\Detail.cshtml"
                      Write(Model.PlanInQty);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                ActInQty: \"");
#nullable restore
#line 144 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\StockIn\Detail.cshtml"
                      Write(Model.ActInQty);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                MaterialList: [],
                StorageRackList: [],
                urlM: '',
                urlS:''
            },
            computed: {
                count: function () {
                    return this.strLength(this.Remark, false);
                }
            },
            mounted: function(){
                var _self = this;
                _self.$nextTick(function () {
                    $(""#MaterialId"").selectpicker({
                        noneSelectedText: '请选择',
                    });
                    $(""#StoragerackId"").selectpicker({
                        noneSelectedText: '请选择',
                    });
                    _self.searchMaterial("""", 1);
                    _self.searchStorageRack("""",1);
                });
            },
            methods: {
                searchMaterial: function (val,type) {
                    _self = this;
                    if (type === 1) {
                        _self.urlS = ""/Material/Se");
                WriteLiteral(@"arch"";
                    } else {
                        _self.urlS = ""/Material/Search?text="" + val;
                    }
                    yui.$axiosget('/Material/Search').then(function (res) {
                        _self.MaterialList = res.data.rows;
                        var html = ""<option value=''>请选择</option>"";
                        for (var item in _self.MaterialList) {
                            html += ""<option value='"" + _self.MaterialList[item].MaterialId + ""' "" + ""data-subtext='"" + _self.MaterialList[item].MaterialNo + ""'>"" + _self.MaterialList[item].MaterialName + ""</option>""
                        }
                        if (type !== 1) {
                            $(""#MaterialId"").empty()
                        }
                        $(""#MaterialId"").append(html)
                        $('#MaterialId').selectpicker('refresh');
                        $('#MaterialId').selectpicker('val', _self.MaterialId);
                    }).catch(function (res) {
   ");
                WriteLiteral(@"                 });
                },
                searchStorageRack: function (val, type) {
                    _self = this;
                    if (type === 1) {
                        _self.urlS = ""/StorageRack/Search"";
                    } else {
                        _self.urlS = ""/StorageRack/Search?text=""+val;
                    }
                    yui.$axiosget(_self.urlS).then(function (res) {
                        _self.StorageRackList = res.data.rows;
                        var html = ""<option value=''>请选择</option>"";
                        for (var item in _self.StorageRackList) {
                            html += ""<option value='"" + _self.StorageRackList[item].StorageRackId + ""' "" + ""data-subtext='"" + _self.StorageRackList[item].StorageRackNo + ""'>"" + _self.StorageRackList[item].StorageRackName + ""</option>""
                        }
                        if (type !== 1) {
                            $(""#StoragerackId"").empty()
                        }
     ");
                WriteLiteral(@"                   $(""#StoragerackId"").append(html)
                        $('#StoragerackId').selectpicker('refresh');
                        $('#StoragerackId').selectpicker('val', _self.StoragerackId);
                    }).catch(function (res) {
                    });
                },
                addL: function () {
                   var _self = this;
                    if (_self.MaterialId.length <= 0) {
                        layer.msg(""请选择物料"", { icon: 2 });
                        return false;
                    }
                    if (!yui.signlessInteger(_self.PlanInQty)) {
                        layer.msg(""计划数量为正整数"", { icon: 2 });
                        return false;
                    }
                    if (!yui.signlessInteger(_self.ActInQty)) {
                        layer.msg(""实际数量为正整数"", { icon: 2 });
                        return false;
                    }
                    if (_self.StoragerackId.length <= 0) {
                        layer.msg");
                WriteLiteral(@"(""请选择入库货架"", { icon: 2 });
                        return false;
                    }

                    var index = layer.load(1, {
                        shade: [0.1, '#fff'] //0.1透明度的白色背景
                    });
                    var data = {
                        id: _self.StockInDetailId,
                        StockInId: _self.StockInId,
                        MaterialId: _self.MaterialId,
                        StoragerackId: _self.StoragerackId,
                        PlanInQty: _self.PlanInQty,
                        ActInQty: _self.ActInQty,
                        Remark: _self.Remark
                    };
                    yui.$axiospostform('/StockIn/AddOrUpdateD', data)
                        .then(function (response) {
                            if (response.data.Item1 === 101) {
                                layer.tips(response.data.Item2, '.layui-layer-setwin', {
                                    tips: [1, '#3595CC'],
                                 ");
                WriteLiteral(@"   time: 3000
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wms_stockindetail> Html { get; private set; }
    }
}
#pragma warning restore 1591
