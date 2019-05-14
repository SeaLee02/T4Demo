namespace Test.T4
{
    using System.Collections.Generic;
    using System;
    using Sealee.SqlHelper;
	using My.Entity.Framework;

	/// <summary>
    /// 
    /// </summary>
    public class fn_My_GetDays 
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime @StartDate { get; set; } 

        /// <summary>
        /// 
        /// </summary>
        public DateTime @EndDate { get; set; } 

         /// <summary>
        /// 获取List集合
        /// </summary>
        /// <returns>list集合</returns>
        public List<fn_My_GetDaysTableInfo> QueryList()
        {
            var conStr =_MyConfig.ConnectionString;
            string sql = this.GetSql();
            return DBHelper.QueryList<fn_My_GetDaysTableInfo>(conStr, sql, null);
        }

        public string GetSql()
        {
            string sql = "SELECT dbo.fn_My_GetDays(";
            sql += $"'{this.@StartDate}',";
            sql += $"'{this.@EndDate}',";
            sql = sql.Substring(0, sql.Length - 1);
            sql+=");";
            return sql;
        }


	}

    public class  fn_My_GetDaysTableInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public DateTime Days { get; set; } 


    }

}
