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
    public partial class Adicionar : Form
    {
        clsConexão conexao = new clsConexão();
        StringBuilder sql = new StringBuilder();
        //SqlDataReader sdr;
        //DAO d = new DAO();
        DataSet DS = new DataSet();
        DataTable DT = new DataTable();
        
        public Adicionar()
        {
            InitializeComponent();
        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            //DAO d = new DAO();
            //try
            //{

            //    d.sql = "insert into produtos(cod, nomeP, valorunit, tipoP, dataFab, precoCompra, marcaP, nomeFornecedor, dataVal, quantestoque) values(" + txtAddCod.Text + ",'" + txtNome.Text + "', REPLACE( REPLACE( '" + txtValorV.Text + "', '.' ,'' ), ',', '.' ), '" + txtTipo.Text + "', '" + txtDataFab.Text + "', REPLACE( REPLACE( '" + txtPrecoCompra.Text + "', '.' ,'' ), ',', '.' ), '" + txtMarca.Text + "', '" + txtForn.Text + "', '" + txtVal.Text + "',0)";
            //    MySqlCommand cmd = new MySqlCommand(d.sql, d.mConn);
            //    cmd.ExecuteNonQuery();
            //    MessageBox.Show("Produto Cadastrado!");
            //    Close();
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}
            //finally
            //{
            //    d.mConn.Close();
            //}
            DateTime datafab = Convert.ToDateTime(txtDataFab.Text);
            DateTime dataval = Convert.ToDateTime(txtVal.Text);
            
                sql.Remove(0, sql.Length);
                sql.Append("insert into produtos(nomeP, valorunit, tipoP, dataFab, precoCompra, marcaP, nomeFornecedor, dataVal, quantestoque) ");
                sql.Append("values('" + txtNome.Text + "', ");
                sql.Append("REPLACE( REPLACE( '" + txtValorV.Text + "', '.' ,'' ), ',', '.' ),");
                sql.Append("'" + txtTipo.Text + "', '" + datafab.ToString("yyyy/MM/dd") + "', ");
                sql.Append("REPLACE( REPLACE( '" + txtPrecoCompra.Text + "', '.' ,'' ), ',', '.' ),");
                sql.Append(" '" + txtMarca.Text + "', '" + txtForn.Text + "', '" + dataval.ToString("yyyy/MM/dd") + "',0)");
                conexao.StrSql = sql.ToString();
                if (conexao.ExecutarCmd() > 0)
                {
                    MessageBox.Show("Produto Cadastrado!");
                }
                else
                {
                    MessageBox.Show("Erro! Tente novamente!");
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtValorV.Text = (double.Parse(txtPrecoCompra.Text) + (double.Parse(txtPrecoCompra.Text) * double.Parse(txtPercent.Text) / 100)).ToString();
        }

        //private void btnAddCod_Click(object sender, EventArgs e)
        //{
        //    //DAO d = new DAO();
        //    //dtgCod.DataSource = d.select("SELECT cod as 'Código', nomep as 'Nome' from produtos where cod="+txtAddCod.Text);
        //    sql.Remove(0, sql.Length);
        //    sql.Append("SELECT cod as 'Código', nomep as 'Nome' from produtos ");
        //    sql.Append("where cod=" + txtAddCod.Text);
        //    conexao.StrSql = sql.ToString();
        //    DS = conexao.RetornarDataSet();
        //    DT = DS.Tables[0];
        //    dtgCod.DataSource = DT;
        //}

        
    }
}
