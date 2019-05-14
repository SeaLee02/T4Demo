﻿namespace My.Entity.Demo.View
{
    using System;   
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// 
    /// </summary>
    [Table("View_Demo_Class")]
    public class ViewDemoClass
    {
		/// <summary>
        /// 班级GUID
        /// </summary>
        [Display(Description = "班级GUID", Name = "班级GUID")]
        [Column("ClassGUID")]
        public Guid  Id { get; set; }
		/// <summary>
        /// 班级名称
        /// </summary>
        [Display(Description = "班级名称", Name = "班级名称")]
        [Column("ClassName")]
        [StringLength(256)]
        public string  Classname { get; set; }

		/// <summary>
        /// 学院GUID
        /// </summary>
        [Display(Description = "学院GUID", Name = "学院GUID")]
        [Column("SchoolGUID")]
        public Guid?  Schoolguid { get; set; }

		/// <summary>
        /// 租户的GUID
        /// </summary>
        [Display(Description = "租户的GUID", Name = "租户的GUID")]
        [Column("TenantId")]
        public Guid?  Tenantid { get; set; }

		/// <summary>
        /// 是否删除
        /// </summary>
        [Display(Description = "是否删除", Name = "是否删除")]
        [Column("IsDeleted")]
        public byte  Isdeleted { get; set; }

		/// <summary>
        /// 创建时间
        /// </summary>
        [Display(Description = "创建时间", Name = "创建时间")]
        [Column("CreateTime")]
        public DateTime?  Createtime { get; set; }

		/// <summary>
        /// 创建人GUID
        /// </summary>
        [Display(Description = "创建人GUID", Name = "创建人GUID")]
        [Column("CreateGUID")]
        public Guid?  Createguid { get; set; }

		/// <summary>
        /// 创建人名称
        /// </summary>
        [Display(Description = "创建人名称", Name = "创建人名称")]
        [Column("CreatedName")]
        [StringLength(128)]
        public string  Createdname { get; set; }

		/// <summary>
        /// 修改时间
        /// </summary>
        [Display(Description = "修改时间", Name = "修改时间")]
        [Column("ModifiedTime")]
        public DateTime?  Modifiedtime { get; set; }

		/// <summary>
        /// 修改人GUID
        /// </summary>
        [Display(Description = "修改人GUID", Name = "修改人GUID")]
        [Column("ModifiedGUID")]
        public Guid?  Modifiedguid { get; set; }

		/// <summary>
        /// 修改人名称
        /// </summary>
        [Display(Description = "修改人名称", Name = "修改人名称")]
        [Column("ModifiedName")]
        [StringLength(128)]
        public string  Modifiedname { get; set; }

		/// <summary>
        /// 审核状态
        /// </summary>
        [Display(Description = "审核状态", Name = "审核状态")]
        [Column("ApproveState")]
        [StringLength(16)]
        public string  Approvestate { get; set; }

		/// <summary>
        /// 审核人GUID
        /// </summary>
        [Display(Description = "审核人GUID", Name = "审核人GUID")]
        [Column("ApproveGUID")]
        public Guid?  Approveguid { get; set; }

		/// <summary>
        /// 审核时间
        /// </summary>
        [Display(Description = "审核时间", Name = "审核时间")]
        [Column("ApproveTime")]
        public DateTime?  Approvetime { get; set; }

    }
}

