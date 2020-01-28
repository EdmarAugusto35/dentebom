using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace server
{
    class conexao
    {
        private SqlConnection sqlcon;
        private String dadosCon = @"SERVER=LAB604-4;DATABASE=Dentebao;INTEGRATED SECURITY= TRUE;";
        public void conectar()
        {
            sqlcon = new SqlConnection(dadosCon);
            try
            {
                sqlcon.Open();
                Console.WriteLine("conectado");
            }
            catch (SqlException sqlE)
            {
                Console.WriteLine("ERROR:" + sqlE);
            }

        }
        public void deconectar()
        {
            sqlcon.Close();
        }
        public int executar(string sql)
        {
            SqlCommand sqlC = new SqlCommand(sql, sqlcon);
            return sqlC.ExecuteNonQuery();      
        }
        public SqlDataReader execonsulta(string sql){
            SqlCommand sqlC = new SqlCommand(sql, sqlcon);
            return sqlC.ExecuteReader();
        }
    }
}

