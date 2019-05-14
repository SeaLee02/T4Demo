
namespace My.DataAccess.Framework
{
    using System.Data.Entity;
    using My.Entity.Demo.View;

    /// <summary>
    /// 数据库对应表
    /// </summary>
	public partial class MyDbContext
    { 
		/// <summary>
        /// 
        /// </summary>
		public DbSet<ViewDemoClass> ViewDemoClass { get; set; }
	 
		/// <summary>
        /// 
        /// </summary>
		public DbSet<ViewDemoCourse> ViewDemoCourse { get; set; }
	 
		/// <summary>
        /// 
        /// </summary>
		public DbSet<ViewDemoSchool> ViewDemoSchool { get; set; }
	 
		/// <summary>
        /// 
        /// </summary>
		public DbSet<ViewDemoStudent2course> ViewDemoStudent2course { get; set; }
	 
		/// <summary>
        /// 学生表视图
        /// </summary>
		public DbSet<ViewDemostudent> ViewDemostudent { get; set; }
	 
	}
}