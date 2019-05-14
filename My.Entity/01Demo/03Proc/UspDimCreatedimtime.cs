namespace My.Entity.Demo.Pro
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using My.Entity.Framework.Pro;
    
     /// <summary>
    /// 
    /// </summary>
    public class UspDimCreatedimtime : BasePro
    {
	
        
        /// <summary>
        /// 
        /// </summary>
        public string @begin_date { get; set; } 

        
        /// <summary>
        /// 
        /// </summary>
        public string @end_date { get; set; } 

                                               
        public override SqlParameter[] GetSqlParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@begin_date", this.begin_date));
            parameters.Add(new SqlParameter("@end_date", this.end_date));
            return parameters.ToArray();
         }

        public override string GetSql()
        {
            string sql = "EXEC dbo.Usp_Dim_CreateDimTime ";
            sql += " @begin_date =@begin_date,";
            sql += " @end_date =@end_date,";
            sql = sql.Substring(0, sql.Length - 1);
            return sql;
        }

	}
}
