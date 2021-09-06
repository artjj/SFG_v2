 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaEstoque;

namespace ProjetoEstoque
{
    
    public partial class Registros : Form
    {

        clsConexão conexao = new clsConexão();
        StringBuilder sql = new StringBuilder();
        SqlDataReader sdr;
        //DAO d = new DAO();
        DataSet DS = new DataSet();
        DataTable DT = new DataTable();
        int a, b ;
        public Registros()
        {
            InitializeComponent();
        }

        private void btnRegCod_Click(object sender, EventArgs e)
        {

            sql.Remove(0, sql.Length);
            sql.Append("SELECT nomep,quantestoque from produtos where cod=" + txtRegCod.Text);
            conexao.StrSql = sql.ToString();
            sdr = conexao.RetornarDataReader();
            if (sdr.Read())
            {
                lblRegNome.Text = sdr["nomep"].ToString();
                nmReg.Text = sdr["quantestoque"].ToString();
            }
            else
            {
                MessageBox.Show("Erro!");
            }
            a = int.Parse(nmReg.Text);
        }

        private void btnREG_Click(object sender, EventArgs e)
        {
            if (int.Parse(nmReg.Text) < a)
            {
                b = a - int.Parse(nmReg.Text);
                insertMenos(b);
            }else if(int.Parse(nmReg.Text) > a)
            {
                b = int.Parse(nmReg.Text) - a;
                insertMais(b);
            }
        }

        //public void edit()
        //{
        //    DAO D = new DAO();
        //    D.sql = "SELECT nomep,quantestoque from produtos where cod=" + txtRegCod.Text;
        //    MySqlCommand cmd = new MySqlCommand(D.sql, D.mConn);
        //    D.mAdapter = new MySqlDataAdapter();
        //    D.mAdapter.SelectCommand = cmd;
        //    D.tabela = new DataTable();
        //    D.mAdapter.Fill(D.tabela);


        //    foreach (DataRow linha in D.tabela.Rows)
        //    {
        //        lblRegNome.Text = linha[0].ToString();
        //        nmReg.Text = linha[1].ToString();
        //    }
        //    D.mConn.Close();
        //}
        public void insertMenos( int b )
        {
            sql.Remove(0, sql.Length);
            sql.Append("insert into historico(cod,nomep,op,quantidade,data,notafiscal) ");
            sql.Append("values(" + txtRegCod.Text + ", '"+lblRegNome.Text+"', ");
            sql.Append("02 ," + b + ",'" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "','" + txtNF.Text + "')");
            conexao.StrSql = sql.ToString();
            if (conexao.ExecutarCmd() > 0)
            {
                MessageBox.Show("Saída Registrada!");
            }
            else
            {
                MessageBox.Show("Erro[REGISTRO.S]!");
            }
            sql.Append("update produtos set quantestoque = quantestoque - " + b + " where cod=" + txtRegCod.Text);
            conexao.StrSql = sql.ToString();
            if (conexao.ExecutarCmd() > 0)
            {
                MessageBox.Show("Concluído!");
            }
            else
            {
                MessageBox.Show("Erro[SAIDA]!");
            }
            //DAO d = new DAO();
            //MySqlCommand cmd = new MySqlCommand();
            //try {
            //d.sql = "insert into historico(cod,nomep,op,quantidade,data,notafiscal) values (" + txtRegCod.Text + ",'"+lblRegNome.Text+"', 02 ,"+ b +",'"+DateTime.Now+"','"+txtNF.Text+"')";
            //cmd = new MySqlCommand(d.sql,d.mConn);
            //cmd.ExecuteNonQuery();
            //d.sql = "update produtos set quantestoque = quantestoque - " + b + " where cod=" + txtRegCod.Text;
            //cmd = new MySqlCommand(d.sql, d.mConn);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Saída registrada!");
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    d.mConn.Close();
            //    Close();
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void insertMais(int b)
        {
            //DAO d = new DAO();
            //MySqlCommand cmd = new MySqlCommand();
            //try
            //{
            //    d.sql = "insert into historico(cod,nomep,op,quantidade,data,notafiscal) values (" + txtRegCod.Text + ",'" + lblRegNome.Text + "', 01 ," + b + ",'" + DateTime.Now + "','"+txtNF.Text+"')";
            //    cmd = new MySqlCommand(d.sql, d.mConn);
            //    cmd.ExecuteNonQuery();
            //    d.sql = "update produtos set quantestoque = quantestoque + " + b + " where cod=" + txtRegCod.Text;
            //    cmd = new MySqlCommand(d.sql, d.mConn);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Entrada registrada!");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{ 
            //    d.mConn.Close();
            //    Close();
            //}
            sql.Remove(0, sql.Length);
            sql.Append("insert into historico(cod,nomep,op,quantidade,data,notafiscal) ");
            sql.Append("values(" + txtRegCod.Text + ", '" + lblRegNome.Text + "', ");
            sql.Append("01 ," + b + ",'" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "','" + txtNF.Text + "')");
            conexao.StrSql = sql.ToString();
            if (conexao.ExecutarCmd() > 0)
            {
                MessageBox.Show("Entrada Registrada!");
            }
            else
            {
                MessageBox.Show("Erro[REGISTROE]!");
            }
            sql.Remove(0, sql.Length);
            sql.Append("update produtos set quantestoque = quantestoque + " + b + " where cod=" + txtRegCod.Text);
            conexao.StrSql = sql.ToString();
            if (conexao.ExecutarCmd() > 0)
            {
                MessageBox.Show("Concluído!");
            }
            else
            {
                MessageBox.Show("Erro[ENTRADA]!");
            }

        }


    }
}
