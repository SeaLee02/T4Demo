namespace My.Entity.Demo.Pro
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using My.Entity.Framework.Pro;
    
     /// <summary>
    /// 
    /// </summary>
    public class UspRegisterdatadict : BasePro
    {
	
        
        /// <summary>
        /// 
        /// </summary>
        public string @chvTable { get; set; } 

        
        /// <summary>
        /// 
        /// </summary>
        public string @chvFieldName { get; set; } 

        
        /// <summary>
        /// 
        /// </summary>
        public string @chvFieldNameChn { get; set; } 

                                               
        public override SqlParameter[] GetSqlParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@chvTable", this.chvTable));
            parameters.Add(new SqlParameter("@chvFieldName", this.chvFieldName));
            parameters.Add(new SqlParameter("@chvFieldNameChn", this.chvFieldNameChn));
            return parameters.ToArray();
         }

        public override string GetSql()
        {
            string sql = "EXEC dbo.usp_RegisterDataDict ";
            sql += " @chvTable =@chvTable,";
            sql += " @chvFieldName =@chvFieldName,";
            sql += " @chvFieldNameChn =@chvFieldNameChn,";
            sql = sql.Substring(0, sql.Length - 1);
            return sql;
        }

	}
}
