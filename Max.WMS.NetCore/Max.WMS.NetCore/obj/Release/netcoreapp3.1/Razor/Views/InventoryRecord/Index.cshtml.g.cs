#pragma checksum "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\InventoryRecord\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6adf0ec33b35a8f0ed28cf6e12f302db1df67ee4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InventoryRecord_Index), @"mvc.1.0.view", @"/Views/InventoryRecord/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6adf0ec33b35a8f0ed28cf6e12f302db1df67ee4", @"/Views/InventoryRecord/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578525f05628b61586d02cd96131d7535f052d97", @"/Views/_ViewImports.cshtml")]
    public class Views_InventoryRecord_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""content-wrapper"">
    <section class=""content-header"">
        <h1>
            仓库管理
            <small>库存记录</small>
        </h1>
        <ol class=""breadcrumb"">
            <li><a href=""#""><i class=""fa fa-dashboard""></i> 首页</a></li>
            <li><a href=""#"">仓库管理</a></li>
            <li class=""active"">库存记录</li>
        </ol>
    </section>
    <section class=""content"">
        <div class=""row"" style=""padding-bottom:1px;"">
            <div class=""col-md-12"">
                <div class=""box"">
                    <div class=""box-header with-border"">
                        <h3 class=""box-title"">搜索条件</h3>
                        <div class=""box-tools pull-right"">
                            <button type=""button"" id=""test"" class=""btn btn-box-tool"" data-widget=""collapse"" data-toggle=""tooltip"">
                                <i class=""fa fa-minus""></i>
                            </button>
                        </div>
                    </div>
                    <div cla");
            WriteLiteral(@"ss=""box-body"">
                        <div class=""input-group"">
                            <span class=""input-group-addon"">日期范围</span>
                            <input type=""text"" ref=""datemin"" id=""datemin"" class=""form-control"" style=""width:120px;"">
                            <input type=""text"" ref=""datemax"" id=""datemax"" class=""form-control"" style=""width:120px;margin-left:10px;"">
                        </div>
                        <div class=""input-group"" style=""margin-top:5px;margin-left:-10px"">
                            <button name=""search"" v-on:click=""searchL"" type=""submit"" class=""btn btn-success"" style=""margin-left:10px;""><i class=""fa fa-search""></i> 搜库存</button>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""box"">
                    <div class=""box-body"">
");
            WriteLiteral("                        <table id=\"bootstraptable\" class=\"table table-bordered text-nowrap table-hover\"></table>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        var app = new Vue({
            el: '#app',
            data: {
                datemin: '',
                datemax: '',
                StorageRackId: ''
            },
            mounted: function () {
                var _self = this;
                _self.$nextTick(function () {
                    //显示active
                    _self.$refs.InventoryRecord.parentNode.parentNode.classList.add(""active"");
                    _self.$refs.InventoryRecord.classList.add(""active"");
                    _self.$refs.datemin.value = _self.getCurrentMonthFirst();
                    _self.$refs.datemax.value = _self.getCurrentMonthLast();
                    //_self.datemin = _self.getCurrentMonthFirst();
                    //_self.datemax = _self.getCurrentMonthLast();
                    $('#datemin').datetimepicker({
                        format: 'yyyy-mm-dd',
                        minView: 2,
                        autoclose: true,
       ");
                WriteLiteral(@"                 language: ""zh-CN""
                    });
                    $('#datemax').datetimepicker({
                        format: 'yyyy-mm-dd',
                        minView: 2,
                        autoclose: true,
                        language: ""zh-CN""
                    });
                    setTimeout(function () {
                        _self.loadL();
                        yui.getDomById(""test"").click();
                        $(""div[class='pull-right search']"")[0].children[0].setAttribute(""placeholder"", ""物料编号或名称"");
                    }, 500);
                });
            },
            methods: {
                loadL: function () {
                    _self = this;
                    var obj = [{
                        checkbox: false,             //是否显示复选框
                        visible: false
                    },
                    {
                        field: 'InventoryrecordId',
                        title: 'Id',
                  ");
                WriteLiteral(@"      visible: false
                    }, {
                        field: 'StockInNo',
                        title: '入库单号',
                        align: 'center',
                        sortable: true
                    },
                    {
                        field: 'MaterialNo',
                        title: '物料编号',
                        align: 'center',
                        sortable: true
                    }, {
                        field: 'MaterialName',
                        title: '物料名称',
                        align: 'center',
                        sortable: true
                    }, {
                        field: 'Qty',
                        title: '入库数量',
                        align: 'center',
                        sortable: true,
                        formatter: function (value, row, index) {
                            return '<span class=""label label-success radius"">' + value + '</span>';
                        }
               ");
                WriteLiteral(@"     }, {
                        field: 'StorageRackNo',
                        title: '货架编号',
                        align: 'center',
                        sortable: true
                    }, {
                        field: 'StorageRackName',
                        title: '货架名称',
                        align: 'center',
                        sortable: true
                    },
                    {
                        field: 'Remark',
                        align: 'center',
                        title: '备注'
                    }, {
                        field: 'CName',
                        title: '创建人',
                        align: 'center',
                        sortable: true
                    }, {
                        field: 'CreateDate',
                        align: 'center',
                        title: '创建时间',
                        sortable: true,
                        formatter: function (value, row, index) {
                         ");
                WriteLiteral(@"   return _self.jsonDateFormat(value);
                        }
                    }, {
                        field: 'UName',
                        align: 'center',
                        title: '修改人',
                        sortable: true
                    }, {
                        field: 'ModifiedDate',
                        title: '修改时间',
                        align: 'center',
                        sortable: true,
                        formatter: function (value, row, index) {
                            return _self.jsonDateFormat(value);
                        }
                    }];
                    //var qParams = {
                    //    StorageRackId: _self.StorageRackId
                    //};
                    yui.table(""bootstraptable"", ""/InventoryRecord/List"", obj, ""POST"", ""InventoryId"", true);
                },
                searchL: function () {
                    //var qParams = {
                    //    StorageRackId: _self.Storag");
                WriteLiteral(@"eRackId,
                    //};
                    //var query = {
                    //    silent: true,
                    //    query: qParams
                    //};
                    $(""#bootstraptable"").bootstrapTable('refresh');
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