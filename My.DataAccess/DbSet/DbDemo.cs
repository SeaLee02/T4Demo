
namespace My.DataAccess.Framework
{
    using System.Data.Entity;
    using My.Entity.Demo;

    /// <summary>
    /// 数据库对应表
    /// </summary>
	public partial class MyDbContext
    { 
		/// <summary>
        /// 班级表
        /// </summary>
		public DbSet<DemoClass> DemoClass { get; set; }
	 
		/// <summary>
        /// 课程表
        /// </summary>
		public DbSet<DemoCourse> DemoCourse { get; set; }
	 
		/// <summary>
        /// 学院表
        /// </summary>
		public DbSet<DemoSchool> DemoSchool { get; set; }
	 
		/// <summary>
        /// 学生表
        /// </summary>
		public DbSet<DemoStudent> DemoStudent { get; set; }
	 
		/// <summary>
        /// 学生课程表
        /// </summary>
		public DbSet<DemoStudent2course> DemoStudent2course { get; set; }
	 
	}
}