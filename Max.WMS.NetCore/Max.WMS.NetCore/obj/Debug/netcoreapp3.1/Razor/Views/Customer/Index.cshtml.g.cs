#pragma checksum "D:\max\Git\Max_WMS\Max.WMS.NetCore\Max.WMS.NetCore\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e99e7b25e5355028e6bebda299d5c9c1fabc14f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e99e7b25e5355028e6bebda299d5c9c1fabc14f", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578525f05628b61586d02cd96131d7535f052d97", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""content-wrapper"">
    <section class=""content-header"">
        <h1>
            基础资料
            <small>客户管理</small>
        </h1>
        <ol class=""breadcrumb"">
            <li><a href=""#""><i class=""fa fa-dashboard""></i> 首页</a></li>
            <li><a href=""#"">基础资料</a></li>
            <li class=""active"">客户管理</li>
        </ol>
    </section>
    <section class=""content"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""box"">
                    <div class=""box-body"">
                        <div class=""input-group"">
                            <span class=""input-group-addon"">日期范围</span>
                            <input type=""text"" v-model=""datemin"" ref=""datemin"" id=""datemin"" class=""form-control"" style=""width:120px;"">
                            <input type=""text"" v-model=""datemax"" ref=""datemax"" id=""datemax"" class=""form-control"" style=""width:120px;margin-left:10px;"">
                            <button name=""search"" v-on:click=""sear");
            WriteLiteral(@"chL"" type=""submit"" class=""btn btn-success"" style=""margin-left:10px;""><i class=""fa fa-search""></i> 搜客户</button>
                        </div>
                        <div id=""toolbar"" class=""btn-group"">
                            <button id=""btn_add"" v-on:click=""showL"" type=""button"" class=""btn btn-default"">
                                <span class=""glyphicon glyphicon-plus"" aria-hidden=""true""></span>新增
                            </button>
                            <button id=""btn_edit"" v-on:click=""editL"" type=""button"" class=""btn btn-default"">
                                <span class=""glyphicon glyphicon-pencil"" aria-hidden=""true""></span>修改
                            </button>
                            <button id=""btn_delete"" v-on:click=""deleteL"" type=""button"" class=""btn btn-default"">
                                <span class=""glyphicon glyphicon-remove"" aria-hidden=""true""></span>删除
                            </button>
                            <button id=""btn_import"" v-on:click=""");
            WriteLiteral(@"importL"" type=""button"" class=""btn btn-default"">
                                <span class=""glyphicon glyphicon-import"" aria-hidden=""true""></span>导入
                            </button>
                        </div>
                        <table id=""bootstraptable"" class=""table table-bordered text-nowrap table-hover""></table>
                    </div>
                </div>
            </div>
        </div>
    </section>
</div>
");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"">
        var app = new Vue({
            el: '#app',
            data: {
                datemin: '',
                datemax: ''
            },
            mounted: function () {
                var _self = this;
                _self.$nextTick(function () {
                    //显示active
                    _self.$refs.Customer.parentNode.parentNode.classList.add(""active"");
                    _self.$refs.Customer.classList.add(""active"");

                    //_self.datemin = _self.getCurrentMonthFirst();
                    _self.datemax = _self.getCurrentMonthLast();
                    $('#datemin').datetimepicker({
                        format: 'yyyy-mm-dd',
                        minView: 2,
                        autoclose: true,
                        language: ""zh-CN""
                    });
                    $('#datemax').datetimepicker({
                        format: 'yyyy-mm-dd',
                        minView: 2,
          ");
                WriteLiteral(@"              autoclose: true,
                        language: ""zh-CN""
                    });
                    setTimeout(function () {
                        _self.loadL();
                        $(""div[class='pull-right search']"")[0].children[0].setAttribute(""placeholder"", ""客户编号或名称"");
                    }, 500);
                });
            },
            methods: {
                loadL: function () {
                    _self = this;
                    var obj = [{
                        checkbox: true,             //是否显示复选框
                        visible: true
                    },
                    {
                        field: 'CustomerId',
                        title: 'Id',
                        visible: false
                    },
                    {
                        field: 'CustomerNo',
                        title: '客户编号',
                        align: 'center',
                        sortable: true
                    },
            ");
                WriteLiteral(@"        {
                        field: 'CustomerName',
                        title: '客户名称',
                        align: 'center',
                        sortable: true
                    },
                    {
                        field: 'Tel',
                        title: '电话',
                        align: 'center',
                        sortable: true
                    },
                    {
                        field: 'Email',
                        title: '邮箱',
                        align: 'center',
                        sortable: true
                    },
                    {
                        field: 'CustomerPerson',
                        title: '联系人',
                        align: 'center',
                        sortable: true
                    },
                    {
                        field: 'CustomerLevel',
                        title: '等级',
                        align: 'center',
                        sortable: t");
                WriteLiteral(@"rue,
                        formatter: function (value, row, index) {
                            switch (value) {
                                case ""1"":
                                    return ""一级"";
                                case ""2"":
                                    return ""二级"";
                                case ""3"":
                                    return ""三级"";
                                default:
                                    return ""-"";
                            }
                        }
                    },
                    {
                        field: 'Address',
                        title: '地址',
                        align: 'center',
                        sortable: true
                    },
                    {
                        field: 'Remark',
                        align: 'center',
                        title: '备注'
                    },
                    {
                        field: 'CName',
           ");
                WriteLiteral(@"             title: '创建人',
                        align: 'center',
                        sortable: true
                    },
                    {
                        field: 'CreateDate',
                        align: 'center',
                        title: '创建时间',
                        sortable: true,
                        formatter: function (value, row, index) {
                            return _self.jsonDateFormat(value);
                        }
                    },
                    {
                        field: 'UName',
                        align: 'center',
                        title: '修改人',
                        sortable: true
                    },
                    {
                        field: 'ModifiedDate',
                        title: '修改时间',
                        align: 'center',
                        sortable: true,
                        formatter: function (value, row, index) {
                            return _self.json");
                WriteLiteral(@"DateFormat(value);
                        }
                    }];
                    yui.table(""bootstraptable"", ""/Customer/List"", obj, ""POST"", ""CustomerId"");
                },
                showL: function () {
                    yui.layershow(""添加客户"", ""/Customer/Add"", 550, 600);
                },
                searchL: function () {
                    $(""#bootstraptable"").bootstrapTable('refresh');
                },
                editL: function () {
                    var arr = $(""#bootstraptable"").bootstrapTable('getSelections');
                    if (arr.length > 0) {
                        var index = layer.confirm(""您确定要修改吗？"", { btn: [""确定"", ""取消""] }, function () {
                            layer.close(index);
                            var id = arr[0].CustomerId;
                            yui.layershow(""修改客户"", ""/Customer/Add?id="" + id, 550, 600);
                        }, function () {

                        });
                    } else {
                ");
                WriteLiteral(@"        layer.alert(""请选中行"", { icoon: 3, skin: ""layer-ext-moon"" });
                    }
                },
                deleteL: function () {
                    var _self = this;
                    var arr = $(""#bootstraptable"").bootstrapTable('getSelections');
                    if (arr.length > 0) {
                        var index = layer.confirm(""您确定要删除吗？"", { btn: [""确定"", ""取消""] }, function () {
                            var id = arr[0].CustomerId;
                            yui.$axiosget('/Customer/Delete?id=' + id)
                                .then(function (response) {
                                    if (response.data.Item1) {
                                        layer.msg(response.data.Item2 || errorMsg, { icon: 1 });
                                        _self.searchL();
                                    } else {
                                        layer.msg(response.data.Item2 || errorMsg, { icon: 5 });
                                    }
             ");
                WriteLiteral(@"                   })
                                .catch(function (error) {
                                    layer.msg(error.message, { icon: 5 });
                                });
                            layer.close(index);
                        });
                    } else {
                        layer.alert(""请选中行"", { icoon: 3, skin: ""layer-ext-moon"" });
                    }
                },
                importL: function () {
                    yui.layershow(""导入"", ""/Customer/Import"", 550, 300);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591