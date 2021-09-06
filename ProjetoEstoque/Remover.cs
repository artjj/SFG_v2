using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaEstoque;

namespace ProjetoEstoque
{
    public partial class Remover : Form
    {
        clsConexão conexao = new clsConexão();
        StringBuilder sql = new StringBuilder();
        public Remover()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //DAO d = new DAO();
            //try
            //{
            //    d.sql = "DELETE from produtos where cod = " + txtCodRem.Text;
            //    MySqlCommand cmd = new MySqlCommand(d.sql, d.mConn);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Produto removido");

            //}catch(Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    d.mConn.Close();
            //    Close();
            //}]
            sql.Remove(0, sql.Length);
            sql.Append("DELETE from produtos where cod = " + txtCodRem.Text);
            conexao.StrSql = sql.ToString();
            if (conexao.ExecutarCmd()>0)
            {
                MessageBox.Show("Produto deletado!");
            }
            else
            {
                MessageBox.Show("Erro! Tente novamente.");
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
