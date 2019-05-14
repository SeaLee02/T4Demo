namespace My.Entity.Demo.Pro
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using My.Entity.Framework.Pro;
    
     /// <summary>
    /// 
    /// </summary>
    public class UspShGencheckrecord : BasePro
    {
	
        
        /// <summary>
        /// 
        /// </summary>
        public string @Month { get; set; } 

                                               
        public override SqlParameter[] GetSqlParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@Month", this.Month));
            return parameters.ToArray();
         }

        public override string GetSql()
        {
            string sql = "EXEC dbo.usp_SH_GenCheckRecord ";
            sql += " @Month =@Month,";
            sql = sql.Substring(0, sql.Length - 1);
            return sql;
        }

	}
}
