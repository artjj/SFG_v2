
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
    public partial class Editar : Form
    {
        clsConexão conexao = new clsConexão();
        StringBuilder sql = new StringBuilder();
        SqlDataReader sdr;
        //DAO d = new DAO();
        DataSet DS = new DataSet();
        DataTable DT = new DataTable();
        public Editar()
        {
            InitializeComponent();
        }

        

        private void btnEditNome_Click(object sender, EventArgs e)
        {
            //DAO d = new DAO();
            //try
            //{
            //    d.sql = "update produtos set nomep='" + txtEditNome.Text + "', tipop='" + txtEditTipo.Text + "',datafab='" + txtEditDataF.Text + "', marcap='" + txtEditMarca.Text + "', nomefornecedor='" + txtEditForn.Text + "', dataval='" + txtEditDataV.Text + "', valorunit=REPLACE( REPLACE( '" + txtEditValorUnit.Text + "', '.' ,'' ), ',', '.' ), precocompra= REPLACE( REPLACE( '" + txtEditPrecoCompra.Text + "', '.' ,'' ), ',', '.' ), quantestoque=" + nmEditQtEst.Text + " where cod=" + txtEditCod.Text;
            //    MySqlCommand cmd = new MySqlCommand(d.sql, d.mConn);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Produto editado");
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
            DateTime datafab = Convert.ToDateTime(txtEditDataF.Text);
            DateTime dataval = Convert.ToDateTime(txtEditDataV.Text);
            sql.Remove(0, sql.Length);
            sql.Append("update produtos set nomep = '" + txtEditNome.Text + "', ");
            sql.Append("tipop='" + txtEditTipo.Text + "', datafab='" + datafab.ToString("yyyy/MM/dd") + "', ");
            sql.Append("marcap='" + txtEditMarca.Text + "', nomefornecedor='" + txtEditForn.Text + "', dataval='" + dataval.ToString("yyyy/MM/dd") + "', ");
            sql.Append("valorunit=REPLACE( REPLACE( '" + txtEditValorUnit.Text + "', '.' ,'' ), ',', '.' ), ");
            sql.Append("precocompra= REPLACE( REPLACE( '" + txtEditPrecoCompra.Text + "', '.' ,'' ), ',', '.' ), ");
            sql.Append("quantestoque=" + nmEditQtEst.Text + " where cod=" + txtEditCod.Text);
            conexao.StrSql = sql.ToString();
            if (conexao.ExecutarCmd() > 0)
            {
                MessageBox.Show("Produto atualizado!");
            }
            else
            {
                MessageBox.Show("Erro!Tente novamente!");
            }
        }

        private void btnEditLimpar_Click(object sender, EventArgs e)
        {
            sql.Remove(0, sql.Length);
            sql.Append("SELECT nomeP, tipoP , dataFab, marcaP, nomeFornecedor, ");
            sql.Append("dataVal, valorunit, precoCompra, quantEstoque ");
            sql.Append("from produtos where cod=" + txtEditCod.Text);
            conexao.StrSql = sql.ToString();
            sdr = conexao.RetornarDataReader();
            if (sdr.Read()) 
            {
                txtEditNome.Text = sdr["nomep"].ToString();
                txtEditTipo.Text = sdr["tipop"].ToString();
                txtEditDataF.Text = sdr["datafab"].ToString().Substring(0, 11);
                txtEditMarca.Text = sdr["marcap"].ToString();
                txtEditForn.Text = sdr["nomefornecedor"].ToString();
                txtEditDataV.Text = sdr["dataval"].ToString().Substring(0,11);
                txtEditValorUnit.Text = sdr["valorunit"].ToString();
                txtEditPrecoCompra.Text = sdr["precocompra"].ToString();
                nmEditQtEst.Text = sdr["quantestoque"].ToString();
            }
            else
            {
                MessageBox.Show("Erro!");
            }


        }

        //public void edit()
        //{ 
        //    DAO D = new DAO();
        //    D.sql = "SELECT nomeP, tipoP , dataFab, marcaP, nomeFornecedor, dataVal, valorunit, precoCompra, quantEstoque from produtos where cod=" + txtEditCod.Text;
        //    MySqlCommand cmd = new MySqlCommand(D.sql, D.mConn);
        //    D.mAdapter = new MySqlDataAdapter();
        //    D.mAdapter.SelectCommand = cmd;
        //    D.tabela = new DataTable();
        //    D.mAdapter.Fill(D.tabela);


        //    foreach (DataRow linha in D.tabela.Rows)
        //    {
        //        txtEditNome.Text = linha[0].ToString();
        //        txtEditTipo.Text = linha[1].ToString();
        //        txtEditDataF.Text = linha[2].ToString();
        //        txtEditMarca.Text = linha[3].ToString();
        //        txtEditForn.Text = linha[4].ToString();
        //        txtEditDataV.Text = linha[5].ToString();
        //        txtEditValorUnit.Text = linha[6].ToString();
        //        txtEditPrecoCompra.Text = linha[7].ToString();
        //        nmEditQtEst.Text = linha[8].ToString();

        //    }
        //    D.mConn.Close();
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            txtEditValorUnit.Text = (double.Parse(txtEditPrecoCompra.Text) + (double.Parse(txtEditPrecoCompra.Text) * double.Parse(txtEditPercent.Text) / 100)).ToString();
        }

        
    }
}
