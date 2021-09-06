using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using SistemaEstoque.Properties;

namespace SistemaEstoque
{
    class clsConexão
    {
        private string _StrSql;

        public string StrSql
        {
            get { return _StrSql; }
            set { _StrSql = value; }
        }
        private SqlConnection strConexao = new SqlConnection(Settings.Default.myConnection);
        //private string strConexao = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\MG Gerenciamento de Materiais\ProjetoEstoque\ProjetoEstoque\projeto.mdf;Integrated Security=True";

        private SqlConnection AbrirBanco()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = strConexao.ConnectionString;
            Conn.Open();
            return Conn;
        }

        private void Fechar(SqlConnection Conn)
        {
            if (Conn.State == ConnectionState.Open)
            {
                Conn.Close();
            }
        }

        public int ExecutarCmd()
        {
            SqlConnection Conn = new SqlConnection();
            SqlCommand CmdComando = new SqlCommand();

            try
            {
                Conn = AbrirBanco();
                CmdComando.CommandText = _StrSql;
                CmdComando.CommandType = CommandType.Text;
                CmdComando.Connection = Conn;

                return CmdComando.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw new Exception("Erro " + ex.Message.ToString());
            }

            finally
            {
                Conn.Close();
            }
        }

        public DataSet RetornarDataSet()
        {
            SqlConnection Conn = new SqlConnection();
            SqlCommand CmdComando = new SqlCommand();
            SqlDataAdapter DA = new SqlDataAdapter();
            DataSet DS = new DataSet();

            try
            {
                Conn = AbrirBanco();
                CmdComando.CommandText = _StrSql;
                CmdComando.CommandType = CommandType.Text;
                CmdComando.Connection = Conn;

                DA.SelectCommand = CmdComando;
                DA.Fill(DS);

                return (DS);
            }

            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                Conn.Close();
            }
        }

        public SqlDataReader RetornarDataReader()
        {
            SqlConnection Conn = new SqlConnection();
            SqlCommand CmdComando = new SqlCommand();

            try
            {
                Conn = AbrirBanco();
                CmdComando.CommandText = _StrSql;
                CmdComando.CommandType = CommandType.Text;
                CmdComando.Connection = Conn;

                return CmdComando.ExecuteReader(CommandBehavior.CloseConnection);
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
