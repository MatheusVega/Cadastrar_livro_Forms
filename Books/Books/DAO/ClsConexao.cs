using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    class ClsConexao
    {
        private SqlConnection sqlConn;

        public void Conectar()
        {
            sqlConn = new SqlConnection(@"Data Source=.;Initial Catalog=LariBooks;Integrated Security=True");
            sqlConn.Open();
        }

        public void ComandoSql(string sSql)
        {
            SqlCommand sqlcomando = new SqlCommand(sSql, sqlConn);
            sqlcomando.CommandTimeout = 36000;
            sqlcomando.ExecuteNonQuery();
        }
        public DataTable ComandoSqlDt(string sSql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sSql, sqlConn);
            DataTable dataSet = new DataTable();
            adapter.Fill(dataSet);
            return dataSet;
        }




    }
}
