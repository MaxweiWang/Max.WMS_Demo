#pragma checksum "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\InventoryMove\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65b1d17c6922c6197a1061b76829a8e9f77a6f70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InventoryMove_Detail), @"mvc.1.0.view", @"/Views/InventoryMove/Detail.cshtml")]
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
#line 1 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\InventoryMove\Detail.cshtml"
using Max.Core.Utils.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65b1d17c6922c6197a1061b76829a8e9f77a6f70", @"/Views/InventoryMove/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578525f05628b61586d02cd96131d7535f052d97", @"/Views/_ViewImports.cshtml")]
    public class Views_InventoryMove_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Max.Core.Dto.Wms_invmovedetailDto>
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
#line 2 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\InventoryMove\Detail.cshtml"
  
    Layout = "_LayoutH";
    

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65b1d17c6922c6197a1061b76829a8e9f77a6f706418", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65b1d17c6922c6197a1061b76829a8e9f77a6f707682", async() => {
                WriteLiteral("\r\n        <div class=\"box-body\">\r\n            <table class=\"table table-bordered\">\r\n                <tr>\r\n");
                WriteLiteral(@"                    <td colspan=""2"">
                        <div class=""form-group"">
                            <label class=""col-sm-2 control-label"">物料</label>
                            <div class=""col-sm-10"">
                                <select size=""1"" id=""MaterialId"" v-model=""MaterialId"" class=""show-menu-arrow show-tick selectpicker form-control"" data-live-search=""true""></select>
                            </div>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class=""form-group"">
                            <label class=""form-label col-sm-2"">库存数量</label>
                            <div class=""col-sm-10"">
                                <input class=""form-control"" readonly v-model=""Qty"" type=""text"">
                            </div>
                        </div>
                    </td>
                    <td>
                        <div class=""form-group"">
          ");
                WriteLiteral(@"                  <label class=""col-sm-2 control-label"">实际数量</label>
                            <div class=""col-sm-10"">
                                <input class=""form-control"" v-model=""ActQty"" v-focus type=""text"">
                            </div>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td colspan=""2"">
                        <div class=""form-group"">
                            <label class=""col-sm-2 control-label"">备注</label>
                            <div class=""col-sm-10"">
                                <textarea v-model=""Remark"" class=""form-control"" rows=""3"" placeholder=""备注...100个字符以内""></textarea>
                                <p class=""textarea-numberbar""><em class=""textarea-length"">{{count}}</em>/100</p>
                            </div>
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <input v-");
                WriteLiteral(@"on:click=""addD"" class=""btn btn-primary radius"" type=""submit"" v-model=""addDe"">
                    </td>
                    <td>
                        <input v-on:click=""addL"" class=""btn btn-primary radius"" type=""submit"" v-model=""submit"">
                    </td>
                </tr>
                <tr>
                    <td colspan=""2"">
                        <div class=""form-group"">
                            <table class=""table table-bordered text-nowrap table-hover"" id=""bootstraptable"">
                                <thead>
                                    <tr>
                                        <th data-field=""MaterialNo"">物料编号</th>
                                        <th data-field=""MaterialName"">物料名称</th>
                                        <th data-field=""Qty"">库存数量</th>
                                        <th data-field=""ActQty"">实际数量</th>
                                        <th data-field=""Remark"">备注</th>
                                        <th da");
                WriteLiteral(@"ta-field=""InventorymoveId"" data-visible=""false"">InventorymoveId</th>
                                        <th data-formatter=""operateFormatter"" data-events=""operateEvents"">删除</th>
                                    </tr>
                                </thead>
                            </table>
                        </div>
                    </td>
                </tr>
            </table>
        </div>
");
                WriteLiteral("    ");
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65b1d17c6922c6197a1061b76829a8e9f77a6f7013092", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65b1d17c6922c6197a1061b76829a8e9f77a6f7014192", async() => {
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
                });
            });
            $(""#bootstraptable"").bootstrapTable({ data: app.list });
            //$('#MaterialId').on('changed.bs.select', function (e, clickedIndex, isSelected, previousValue) {
            //});
        });

        function operateFormatter(value, row, index) {
            //fa-heart
            return [
             ");
                WriteLiteral(@"   '<a class=""remove"" href=""javascript:void(0)"" title=""Remove"">',
                '<i class=""fa fa-trash"">删除</i>',
                '</a>'
            ].join('')
        };
        window.operateEvents = {
            //删除选中行
            'click .remove': function (e, value, row, index) {
                $(""#bootstraptable"").bootstrapTable('remove', {
                    field: 'MaterialNo',
                    values: [row.MaterialNo]
                })
            }
        }
        var app = new Vue({
            el: ""#app"",
            data: {
                addDe:'添加明细',
                submit: ""添加"",
                Storagerack: '',
                SStoragerackId:'");
#nullable restore
#line 143 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\InventoryMove\Detail.cshtml"
                           Write(Model.SourceStoragerackId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                AStoragerackId:\'");
#nullable restore
#line 144 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\InventoryMove\Detail.cshtml"
                           Write(Model.AimStoragerackId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                MaterialId:\"");
#nullable restore
#line 145 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\InventoryMove\Detail.cshtml"
                       Write(Model.MaterialId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                MaterialNo:\"\",\r\n                MaterialName:\"\",\r\n                InventorymoveId:\"");
#nullable restore
#line 148 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\InventoryMove\Detail.cshtml"
                            Write(Model.Pid);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                MoveDetailId:\"");
#nullable restore
#line 149 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\InventoryMove\Detail.cshtml"
                         Write(Model.MoveDetailId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                Remark: \"");
#nullable restore
#line 150 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\InventoryMove\Detail.cshtml"
                    Write(Model.Remark);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                ActQty: \"");
#nullable restore
#line 151 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\InventoryMove\Detail.cshtml"
                    Write(Model.ActQty);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                MaterialList: [],\r\n                StorageRackList: [],\r\n                updateList:");
#nullable restore
#line 154 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\InventoryMove\Detail.cshtml"
                      Write(Html.Raw(Model.Detail.JilToJson()));

#line default
#line hidden
#nullable disable
                WriteLiteral(@",
                Qty: """",
                urlM: '',
                list: [],
            },
            computed: {
                count: function () {
                    return this.strLength(this.Remark, false);
                }
            },
            watch: {
                MaterialId: function (val) {
                    var _self = this;
                    _self.Qty = """";
                    _self.qtyL(val);
                    //yui.$axiosget('/StockOut/SearchInventory?id='+val).then(function (res) {
                    //    _self.StorageRackList = res.data.rows;
                    //    _self.qtyL(_self.SStoragerackId);
                    //}).catch(function (res) {
                    //});
                },
                updateList: function () {
                    var _self = this;
                    var obj = _self.updateList;
                    if (obj.length > 0) {
                        for (var item in obj) {
                            var a = obj");
                WriteLiteral(@"[item];
                            var data = {
                                ""MaterialId"": a.MaterialId,
                                ""MaterialNo"": a.MaterialNo,
                                ""MaterialName"": a.MaterialName,
                                ""Qty"": a.Qty,
                                ""ActQty"": a.ActQty,
                                ""Remark"": a.Remark,
                                ""Status"": a.Status,
                                ""InventorymoveId"": a.InventorymoveId,
                            }
                            _self.list.push(data);
                        }
                    }

                }
            },
            mounted: function(){
                var _self = this;
                _self.$nextTick(function () {
                    $(""#MaterialId"").selectpicker({
                        noneSelectedText: '请选择',
                    });
                    _self.updateList=");
#nullable restore
#line 203 "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\InventoryMove\Detail.cshtml"
                                Write(Html.Raw(Model.Detail.JilToJson()));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
                    _self.searchMaterial("""", 1);
                    $(""#bootstraptable"").bootstrapTable(""prepend"", _self.list);
                });
            },
            methods: {
                searchMaterial: function (val,type) {
                    var _self = this;
                    if (type === 1) {
                        //_self.urlM = ""/Material/Search"";
                        _self.urlM = ""/StockOut/SearchInventory?storagerackId="" + _self.SStoragerackId;
                    } else {
                        _self.urlM = ""/StockOut/SearchInventory?id"" + val + ""&storagerackId=""+ _self.SStoragerackId;
                    }
                    yui.$axiosget(_self.urlM).then(function (res) {
                        _self.StorageRackList=_self.MaterialList = res.data.rows;
                        var html = ""<option value=''>请选择</option>"";
                        for (var item in _self.MaterialList) {
                            var a = _self.MaterialList[item];
            ");
                WriteLiteral(@"                html += ""<option value='"" + a.MaterialId + ""' "" + ""data-subtext='"" + a.MaterialNo + ""'>"" + a.MaterialName + ""</option>""
                        }
                        if (type !== 1) {
                            $(""#MaterialId"").empty();
                        }
                        $(""#MaterialId"").append(html)
                        $('#MaterialId').selectpicker('refresh');
                        $('#MaterialId').selectpicker('val', _self.MaterialId);
                    }).catch(function (res) {
                    });
                },
                qtyL: function (val) {
                    var _self = this;
                    for (var item in _self.StorageRackList) {
                        var a = _self.StorageRackList[item];
                        if (a.MaterialId == val) {
                            _self.Qty = a.Qty;
                            _self.MaterialNo = a.MaterialNo;
                            _self.MaterialName = a.MaterialName;
        ");
                WriteLiteral(@"                    return false;
                        }
                    }
                },
                addD: function () {
                    var _self = this;
                    if (_self.MaterialId.length<=0) {
                        layer.msg(""请选择物料"", { icon: 2 });
                        return false;
                    }
                    if (!yui.signlessInteger(_self.ActQty)) {
                        layer.msg(""实际数量为正整数"", { icon: 2 });
                        return false;
                    }
                    if (_self.ActQty > _self.Qty) {
                        layer.msg(""实际数量不能大于库存数量"", { icon: 2 });
                        return false;
                    }
                    _self.list = $(""#bootstraptable"").bootstrapTable('getData');
                    for (var item in _self.list) {
                        var a = _self.list[item];
                        if (a.MaterialNo == _self.MaterialNo) {
                            layer.msg(""不允许重复添加"", { i");
                WriteLiteral(@"con: 2 });
                            return false;
                        }
                    }
                    var data = {
                        ""MaterialId"": _self.MaterialId,
                        ""MaterialNo"": _self.MaterialNo,
                        ""MaterialName"": _self.MaterialName,
                        ""Qty"": _self.Qty,
                        ""ActQty"": _self.ActQty,
                        ""Remark"": _self.Remark,
                        ""Status"": 1,
                        ""InventorymoveId"": _self.InventorymoveId,
                    }
                    $(""#bootstraptable"").bootstrapTable(""prepend"",data);
                    //$(""#bootstraptable"").bootstrapTable(""refsrefresh"");
                },
                addL: function () {
                    var _self = this;
                    _self.list = $(""#bootstraptable"").bootstrapTable('getData');
                    if (_self.list.length <= 0) {
                        layer.msg(""请添加明细"", { icon: 2 });
     ");
                WriteLiteral(@"                   return false;
                    }

                    var index = layer.load(1, {
                        shade: [0.1, '#fff'] //0.1透明度的白色背景
                    });
                    _self.list = $(""#bootstraptable"").bootstrapTable('getData');
                    var data = {
                        id: _self.InventorymoveId, //存在修改
                        list: _self.list,
                    };
                    yui.$axiospostform('/InventoryMove/AddOrUpdateD', data)
                        .then(function (response) {
                            if (response.data.Item1 === 101) {
                                layer.tips(response.data.Item2, '.layui-layer-setwin', {
                                    tips: [1, '#3595CC'],
                                    time: 3000
                                });
                                layer.close(index);
                                return false;
                            }
                            if");
                WriteLiteral(@" (response.data.Item1) {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Max.Core.Dto.Wms_invmovedetailDto> Html { get; private set; }
    }
}
#pragma warning restore 1591