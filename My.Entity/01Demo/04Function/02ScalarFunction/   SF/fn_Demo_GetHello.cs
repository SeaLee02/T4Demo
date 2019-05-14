namespace My.Entity.Demo.Function
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using Sealee.SqlHelper;
	using My.Entity.Framework;

	/// <summary>
    /// 
    /// </summary>
    public class fn_Demo_GetHello 
    {

        /// <summary>
        /// 
        /// </summary>
        public string @Str { get; set; } 

        /// <summary>
        /// 获取单个值
        /// </summary>
        /// <typeparam name="T">值得类型</typeparam>
        /// <returns>单个值</returns>
        public T ExecuteScalar<T>()
        {
            var conStr = _MyConfig.ConnectionString;
            string sql = this.GetSql();
            return DBHelper.ExecuteScalar<T>(conStr, sql, null);
        }

        public string GetSql()
        {
            string sql = "SELECT dbo.fn_Demo_GetHello(";
            sql += $"'{this.@Str}',";
            sql = sql.Substring(0, sql.Length - 1);
            sql+=");";
            return sql;
        }

	}
}
