using System.Data;
using System.Data.SqlClient;

namespace MvcPaginacao.Conexao
{
    public class DataConexo
    {
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataReader Dr;
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SqlConnection OpenCon()
        {
            string strCon = string.Format(@"Data Source=DESKTOP-1Q2TUU2\LEMOSDATABASE;Initial Catalog=DemoDatabase;Integrated Security=True");
           
            con = new SqlConnection(strCon);
            
                if(con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
            
            return con;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SqlConnection CloseCon()
        {
            if(con.State == ConnectionState.Open)
            {
                con.Close();
            }
            return con;
        }
    }
}