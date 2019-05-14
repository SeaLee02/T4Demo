namespace Test.T4
{
    using System.Collections.Generic;
    using System;
    using Sealee.SqlHelper;
	using My.Entity.Framework;

	/// <summary>
    /// 
    /// </summary>
    public class fn_My_SplitArr 
    {
        /// <summary>
        /// 
        /// </summary>
        public string @Arr { get; set; } 

        /// <summary>
        /// 
        /// </summary>
        public string @Split { get; set; } 

         /// <summary>
        /// 获取List集合
        /// </summary>
        /// <returns>list集合</returns>
        public List<fn_My_SplitArrTableInfo> QueryList()
        {
            var conStr =_MyConfig.ConnectionString;
            string sql = this.GetSql();
            return DBHelper.QueryList<fn_My_SplitArrTableInfo>(conStr, sql, null);
        }

        public string GetSql()
        {
            string sql = "SELECT dbo.fn_My_SplitArr(";
            sql += $"'{this.@Arr}',";
            sql += $"'{this.@Split}',";
            sql = sql.Substring(0, sql.Length - 1);
            sql+=");";
            return sql;
        }


	}

    public class  fn_My_SplitArrTableInfo
    {
        /// <summary>
        /// 
        /// </summary>
        public int pos { get; set; } 

        /// <summary>
        /// 
        /// </summary>
        public string value { get; set; } 


    }

}
