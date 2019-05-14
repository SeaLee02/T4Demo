namespace My.Entity.Demo.Pro
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using My.Entity.Framework.Pro;
    
     /// <summary>
    /// 
    /// </summary>
    public class UspMySynclayim : BasePro
    {
	
        
        /// <summary>
        /// 
        /// </summary>
        public long @UserIntID { get; set; } 

                                               
        public override SqlParameter[] GetSqlParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@UserIntID", this.UserIntID));
            return parameters.ToArray();
         }

        public override string GetSql()
        {
            string sql = "EXEC dbo.usp_My_SyncLayIM ";
            sql += " @UserIntID =@UserIntID,";
            sql = sql.Substring(0, sql.Length - 1);
            return sql;
        }

	}
}
