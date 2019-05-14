namespace My.Entity.Demo.Pro
{
    using My.Entity.Framework.Pro;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;

    /// <summary>
    /// 
    /// </summary>
    public class UspMyGetflownumber : BasePro
    {


        /// <summary>
        /// 
        /// </summary>
        public string @TableName { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string @OutNo { get; set; }


        public override SqlParameter[] GetSqlParameters()
        {
            List<SqlParameter> parameters = new List<SqlParameter>();
            parameters.Add(new SqlParameter("@TableName", this.TableName));
            SqlParameter paramOutNo = new SqlParameter("@OutNo", SqlDbType.NVarChar);
            paramOutNo.Direction = ParameterDirection.Output;
            parameters.Add(paramOutNo);
            return parameters.ToArray();
        }

        public override string GetSql()
        {
            string sql = "EXEC dbo.usp_My_GetFlowNumber ";
            sql += " @TableName =@TableName,";
            sql += " @OutNo =@OutNo OUT,";
            sql = sql.Substring(0, sql.Length - 1);
            return sql;
        }

    }
}
