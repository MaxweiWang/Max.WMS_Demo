#pragma checksum "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\Delivery\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cc6757a722592f9d5b56189e7ad996ef9217b55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Delivery_Add), @"mvc.1.0.view", @"/Views/Delivery/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cc6757a722592f9d5b56189e7ad996ef9217b55", @"/Views/Delivery/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578525f05628b61586d02cd96131d7535f052d97", @"/Views/_ViewImports.cshtml")]
    public class Views_Delivery_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wms_delivery>
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
#line 1 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\Delivery\Add.cshtml"
  
    Layout = "_LayoutH";
    

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8cc6757a722592f9d5b56189e7ad996ef9217b556186", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc6757a722592f9d5b56189e7ad996ef9217b557450", async() => {
                WriteLiteral(@"
        <div class=""box-body"">
            <div class=""form-group"">
                <label class=""col-sm-2 control-label"">快递单号</label>
                <div class=""col-sm-10"">
                    <input class=""form-control"" v-model=""TrackingNo"" v-focus type=""text"">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-sm-2 control-label"">发货时间</label>
                <div class=""col-sm-10"">
                    <input class=""form-control"" id=""DeliveryDate"" v-model=""DeliveryDate"" type=""text"">
                </div>
            </div>
            <div class=""form-group"">
                <label class=""form-label col-sm-2"">承运商 </label>
                <div class=""col-sm-10"">
                    <select size=""1"" v-model=""CarrierId"" class=""show-menu-arrow show-tick selectpicker form-control"" data-live-search=""true""></select>
                </div>
            </div>
            <div class=""form-group"">
                <label class=""col-sm");
                WriteLiteral(@"-2 control-label"">备注</label>
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc6757a722592f9d5b56189e7ad996ef9217b5510666", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cc6757a722592f9d5b56189e7ad996ef9217b5511766", async() => {
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
            $('.selectpicker').on('show.bs.select', function (e, clickedIndex, isSelected, previousValue) {
                var divdom = $(""div[class='bs-searchbox']"")[0].childNodes[0];
                $(divdom).on(""input propertychange"", function () {
                    var dom = $(""li[class='no-results']"");
                    var text = divdom.value;
                    if (dom.length > 0) {
                            yui.$axiosget('/Carrier/Search?text=' + text).then(function (res) {
                                var data = res.data.rows;
                                var html = ""<option value=''>请选择</option>"";
                                for (var item in data) {
                                    html += ""<option value='"" + _self.CarrierList[item].CarrierId + ""' "" + ""data-subtext='"" + _self.CarrierList[item].CarrierNo + ""'>"" + _self.CarrierList[item].CarrierName + ""</option>""
                                }
                                ");
                WriteLiteral(@"$("".selectpicker"").empty();
                                $("".selectpicker"").append(html)
                                $('.selectpicker').selectpicker('refresh');
                            }).catch(function (res) {
                            });
                    } else {
                        yui.$axiosget('/Carrier/Search?text=' + text).then(function (res) {
                            var data = res.data.rows;
                            var html = ""<option value=''>请选择</option>"";
                            for (var item in data) {
                                html += ""<option value='"" + _self.CarrierList[item].CarrierId + ""' "" + ""data-subtext='"" + _self.CarrierList[item].CarrierNo + ""'>"" + _self.CarrierList[item].CarrierName + ""</option>""
                            }
                            $("".selectpicker"").empty();
                            $("".selectpicker"").append(html)
                            $('.selectpicker').selectpicker('refresh');
                      ");
                WriteLiteral(@"  }).catch(function (res) {
                        });
                    }
                });
            });
        });

        var app = new Vue({
            el: ""#app"",
            data: {
                submit: ""添加"",
                DeliveryDate: """);
#nullable restore
#line 88 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\Delivery\Add.cshtml"
                          Write(Model.DeliveryDate);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                DeliveryId:\"");
#nullable restore
#line 89 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\Delivery\Add.cshtml"
                       Write(Model.DeliveryId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                StockOutId:\"");
#nullable restore
#line 90 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\Delivery\Add.cshtml"
                       Write(Model.StockOutId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                Remark: \"");
#nullable restore
#line 91 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\Delivery\Add.cshtml"
                    Write(Model.Remark);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                CarrierId: \"");
#nullable restore
#line 92 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\Delivery\Add.cshtml"
                       Write(Model.CarrierId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n                TrackingNo: \"");
#nullable restore
#line 93 "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\Delivery\Add.cshtml"
                        Write(Model.TrackingNo);

#line default
#line hidden
#nullable disable
                WriteLiteral(@""",
                CarrierList:[]
            },
            computed: {
                count: function () {
                    return this.strLength(this.Remark, false);
                }
            },
            mounted: function(){
                var _self = this;
                _self.$nextTick(function () {
                    $("".selectpicker"").selectpicker({
                        noneSelectedText: '请选择',
                    });
                    _self.DeliveryDate = yui.getNow();
                    $('#DeliveryDate').datetimepicker({
                        format: 'yyyy-mm-dd',
                        minView: 2,
                        autoclose: true,
                        language: ""zh-CN""
                    }).on('changeDate', function (ev) {
                        _self.DeliveryDate = $.trim($('#DeliveryDate').val());
                     });
                    yui.$axiosget('/Carrier/Search').then(function (res) {
                        _self.CarrierList =");
                WriteLiteral(@" res.data.rows;
                        var html = ""<option value=''>请选择</option>"";
                        for (var item in _self.CarrierList) {
                            html += ""<option value='"" + _self.CarrierList[item].CarrierId + ""' "" + ""data-subtext='"" + _self.CarrierList[item].CarrierNo + ""'>"" + _self.CarrierList[item].CarrierName + ""</option>""
                        }
                        $("".selectpicker"").append(html)
                        $('.selectpicker').selectpicker('refresh');
                        $('.selectpicker').selectpicker('val', _self.CarrierId);
                    }).catch(function (res) {
                    });
                });
            },
            methods: {
                addL: function () {
                   var _self = this;
                    if (_self.TrackingNo.length <= 0) {
                        layer.msg(""快递单号不能为空"", { icon: 2 });
                        return false;
                    }
                    if (_self.CarrierId.");
                WriteLiteral(@"length <= 0) {
                        layer.msg(""请选择承运商"", { icon: 2 });
                        return false;
                    }
                    var index = layer.load(1, {
                        shade: [0.1, '#fff'] //0.1透明度的白色背景
                    });
                    var data = {
                        id: _self.DeliveryId,
                        StockOutId: _self.StockOutId,
                        CarrierId: _self.CarrierId,
                        TrackingNo: _self.TrackingNo,
                        DeliveryDate: _self.DeliveryDate,
                        Remark: _self.Remark
                    };
                    yui.$axiospostform('/Delivery/AddOrUpdate', data)
                        .then(function (response) {
                            if (response.data.Item1 === 101) {
                                layer.tips(response.data.Item2, '.layui-layer-setwin', {
                                    tips: [1, '#3595CC'],
                                    time: 3");
                WriteLiteral(@"000
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wms_delivery> Html { get; private set; }
    }
}
#pragma warning restore 1591