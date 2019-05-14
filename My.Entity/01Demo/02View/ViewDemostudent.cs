namespace My.Entity.Demo.View
{
    using System;   
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>
    /// 学生表视图
    /// </summary>
    [Table("view_DemoStudent")]
    public class ViewDemostudent
    {
		/// <summary>
        /// 学生主键
        /// </summary>
        [Display(Description = "学生主键", Name = "学生主键")]
        [Column("StudentGUID")]
        public Guid  Id { get; set; }
		/// <summary>
        /// 名称
        /// </summary>
        [Display(Description = "名称", Name = "名称")]
        [Column("StuName")]
        [StringLength(128)]
        public string  Stuname { get; set; }

		/// <summary>
        /// 年龄
        /// </summary>
        [Display(Description = "年龄", Name = "年龄")]
        [Column("Age")]
        public int?  Age { get; set; }

		/// <summary>
        /// 生日
        /// </summary>
        [Display(Description = "生日", Name = "生日")]
        [Column("Birthday")]
        public DateTime?  Birthday { get; set; }

		/// <summary>
        /// 身高
        /// </summary>
        [Display(Description = "身高", Name = "身高")]
        [Column("Height")]
        public decimal?  Height { get; set; }

		/// <summary>
        /// 是否VIP
        /// </summary>
        [Display(Description = "是否VIP", Name = "是否VIP")]
        [Column("IsVIP")]
        public byte?  Isvip { get; set; }

		/// <summary>
        /// 班级主键
        /// </summary>
        [Display(Description = "班级主键", Name = "班级主键")]
        [Column("ClassGUID")]
        public Guid?  Classguid { get; set; }

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

		/// <summary>
        /// 
        /// </summary>
        [Column("SexType")]
        public int?  Sextype { get; set; }

    }
}

