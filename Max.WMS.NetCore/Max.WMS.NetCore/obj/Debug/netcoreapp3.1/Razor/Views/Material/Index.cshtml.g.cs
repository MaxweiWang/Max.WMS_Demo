#pragma checksum "D:\max\WMS\Max.WMS_Demo\Max.WMS.NetCore\Max.WMS.NetCore\Views\Material\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ba301d1e6489a35f46d5f0b4aa39378b332c26a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Material_Index), @"mvc.1.0.view", @"/Views/Material/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ba301d1e6489a35f46d5f0b4aa39378b332c26a", @"/Views/Material/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"578525f05628b61586d02cd96131d7535f052d97", @"/Views/_ViewImports.cshtml")]
    public class Views_Material_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""content-wrapper"">
    <section class=""content-header"">
        <h1>
            基础资料
            <small>物料管理</small>
        </h1>
        <ol class=""breadcrumb"">
            <li><a href=""#""><i class=""fa fa-dashboard""></i> 首页</a></li>
            <li><a href=""#"">基础资料</a></li>
            <li class=""active"">物料管理</li>
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
            WriteLiteral(@"chL"" type=""submit"" class=""btn btn-success"" style=""margin-left:10px;""><i class=""fa fa-search""></i> 搜物料</button>
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
                            <button id=""btn_export"" v-on:click=""");
            WriteLiteral(@"exportL"" type=""button"" class=""btn btn-default"">
                                <span class=""glyphicon glyphicon-export"" aria-hidden=""true""></span>导出
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
                    _self.$refs.Material.parentNode.parentNode.classList.add(""active"");
                    _self.$refs.Material.classList.add(""active"");

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
                        $(""div[class='pull-right search']"")[0].children[0].setAttribute(""placeholder"", ""物料编号或名称"");
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
                        field: 'MaterialId',
                        title: 'Id',
                        visible: false
                    }, {
                        field: 'MaterialNo',
                        title: '物料编号',
                        align: 'center',
                        sortable: true
                    }, {
                        field: ");
                WriteLiteral(@"'MaterialName',
                        title: '物料名称',
                        align: 'center',
                        sortable: true
                    }, {
                        field: 'MaterialType',
                        title: '物料分类',
                        align: 'center',
                        sortable: true
                    }, {
                        field: 'Unit',
                        title: '单位类别',
                        align: 'center',
                        sortable: true
                    },
                    {
                        field: 'Qty',
                        title: '安全库存',
                        align: 'center',
                        sortable: true
                    },
                    {
                        field: 'ExpiryDate',
                        title: '有效期(天)',
                        align: 'center',
                        sortable: true
                    }, {
                        field: 'StorageRackName',");
                WriteLiteral(@"
                        title: '所属货架',
                        align: 'center',
                        sortable: true
                    }, {
                        field: 'ReservoirAreaName',
                        title: '所属库区',
                        align: 'center',
                        sortable: true
                    }, {
                        field: 'WarehouseName',
                        title: '所属仓库',
                        align: 'center',
                        sortable: true
                    }
                        , {
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
                        titl");
                WriteLiteral(@"e: '创建时间',
                        sortable: true,
                        formatter: function (value, row, index) {
                            return _self.jsonDateFormat(value);
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
                    yui.table(""bootstraptable"", ""/Material/List"", obj, ""POST"", ""StorageRackId"");
                },
                showL: function () {
                    yui.layershow(""添加物料"", ""/Material/Add"", 550, 600);
                ");
                WriteLiteral(@"},
                searchL: function () {
                    $(""#bootstraptable"").bootstrapTable('refresh');
                },
                editL: function () {
                    var arr = $(""#bootstraptable"").bootstrapTable('getSelections');
                    if (arr.length > 0) {
                        var index = layer.confirm(""您确定要修改吗？"", { btn: [""确定"", ""取消""] }, function () {
                            layer.close(index);
                            var id = arr[0].MaterialId;
                            yui.layershow(""修改物料"", ""/Material/Add?id="" + id, 550, 600);
                        }, function () {

                        });
                    } else {
                        layer.alert(""请选中行"", { icoon: 3, skin: ""layer-ext-moon"" });
                    }
                },
                deleteL: function () {
                    var _self = this;
                    var arr = $(""#bootstraptable"").bootstrapTable('getSelections');
                    if (arr.length > ");
                WriteLiteral(@"0) {
                        var index = layer.confirm(""您确定要删除吗？"", { btn: [""确定"", ""取消""] }, function () {
                            var id = arr[0].MaterialId;
                            yui.$axiosget('/Material/Delete?id=' + id)
                                .then(function (response) {
                                    if (response.data.Item1) {
                                        layer.msg(response.data.Item2 || errorMsg, { icon: 1 });
                                        _self.searchL();
                                    } else {
                                        layer.msg(response.data.Item2 || errorMsg, { icon: 5 });
                                    }
                                })
                                .catch(function (error) {
                                    layer.msg(error.message, { icon: 5 });
                                });
                            layer.close(index);
                        });
                    } else {
         ");
                WriteLiteral(@"               layer.alert(""请选中行"", { icoon: 3, skin: ""layer-ext-moon"" });
                    }
                },
                exportL: function () {
                    var _self = this;
                    var data = {
                        datemin: _self.$refs.datemin.value,
                        datemax: _self.$refs.datemax.value,
                    };
                    var index = layer.confirm(""您确定要导出吗？"", { btn: [""确定"", ""取消""] }, function () {
                        axios.get('/Material/Export?' + Qs.stringify(data), {
                            headers: {
                                'promise': 'promise'
                            },
                            responseType: 'arraybuffer'
                        }).then(function (response) {
                            var type = response.headers['content-type']
                            if (type === ""application/json"") {
                                var enc = new TextDecoder('utf-8')
                             ");
                WriteLiteral(@"   var res = JSON.parse(enc.decode(new Uint8Array(response.data)))
                                layer.msg(res.Item2, { icon: 2 });
                            } else {
                                console.info(response);
                                let disposition = response.headers['content-disposition']
                                let fileName = decodeURI(disposition.substring(disposition.indexOf('filename=') + 9, disposition.indexOf('filename*=') - 2))
                                console.info(fileName);
                                let blob = new Blob([response.data], { type: 'application/ms-excelapplication/vnd.openxmlformats-officedocument.spreadsheetml.sheet;charset=utf-8' })
                                if (window.navigator.msSaveOrOpenBlob) {
                                    navigator.msSaveBlob(blob, fileName);
                                } else {
                                    var link = document.createElement('a');
                                    ");
                WriteLiteral(@"link.href = window.URL.createObjectURL(blob);
                                    link.download = fileName;
                                    document.body.appendChild(link);
                                    link.click();
                                    document.body.removeChild(link);
                                    window.URL.revokeObjectURL(link.href);
                                }
                            }
                            }).catch(function (error) {
                                location.href = ""/Material/Export?"" + Qs.stringify(data);
                            //layer.msg(error.message, { icon: 5 });
                        });
                        layer.close(index);
                    });
                    //location.href = ""/Material/Export?"" + Qs.stringify(data);
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
