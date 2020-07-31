using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace Max.Core.Entity
{
    public partial class Sys_companyWXW
    {
        public Sys_companyWXW()
        {
        }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:False
        /// </summary>
        [SugarColumn(IsPrimaryKey = true)]
        public long CompanyWXWId { get; set; }

        /// <summary>
        /// Desc:公司编号
        /// Default:
        /// Nullable:True
        /// </summary>
        public string CompanyWXWNo { get; set; }

        /// <summary>
        /// Desc:公司名称
        /// Default:
        /// Nullable:True
        /// </summary>
        public string CompanyWXWName { get; set; }

        /// <summary>
        /// Desc:1未删除   0删除
        /// Default:
        /// Nullable:True
        /// </summary>
        public byte? IsDel { get; set; } = 1;

        /// <summary>
        /// Desc:备注
        /// Default:
        /// Nullable:False
        /// </summary>
        public string Remark { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>
        public long? CreateBy { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>
        public DateTime? CreateDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>
        public long? ModifiedBy { get; set; }

        /// <summary>
        /// Desc:
        /// Default:
        /// Nullable:True
        /// </summary>
        public DateTime? ModifiedDate { get; set; }
    }
}
