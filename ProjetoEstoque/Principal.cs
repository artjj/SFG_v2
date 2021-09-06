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
    public partial class Principal : Form
    {

        clsConexão conexao = new clsConexão();
        StringBuilder sql = new StringBuilder();
        //SqlDataReader sdr;
        //DAO d = new DAO();
        DataSet DS = new DataSet();
        DataTable DT = new DataTable();
        public Principal()
        {
            InitializeComponent();
            //dtgBaixaDiaria.DataSource = d.select("SELECT cod as 'Código', nomep as 'Nome', quant as 'Quantidade', codvenda as 'Cod. Venda' FROM diario");
            //dtgEst.DataSource = d.select("SELECT cod as 'Código', nomep as 'Nome', valorunit as 'Valor de Venda', tipop as 'Tipo', datafab as 'Fabricação', precocompra as 'Preço de Compra', marcap as 'Marca', nomefornecedor as 'Fornecedor', dataval as 'Validade', quantestoque as 'Qt. Estoque' FROM produtos");
            mostrarEst();
            mostrarDiario();
        }

        private void mostrarEst()
        {
            sql.Remove(0, sql.Length);
            sql.Append("SELECT cod as 'Código', nomep as 'Nome', valorunit as 'Valor de Venda', ");
            sql.Append("tipop as 'Tipo', datafab as 'Fabricação', precocompra as 'Preço de Compra', marcap as 'Marca', ");
            sql.Append("nomefornecedor as 'Fornecedor', dataval as 'Validade', quantestoque as 'Qt. Estoque' FROM produtos");
            conexao.StrSql = sql.ToString();
            DS = conexao.RetornarDataSet();
            DT = DS.Tables[0];
            dtgEst.DataSource = DT;
        }
        private void mostrarDiario()
        {
            sql.Remove(0, sql.Length);
            sql.Append("SELECT codvenda as 'Cod. Venda', cod as 'Código', quant as 'Quantidade',  ");
            sql.Append(" nomep as 'Nome' FROM diario");
            conexao.StrSql = sql.ToString();
            DS = conexao.RetornarDataSet();
            DT = DS.Tables[0];
            dtgBaixaDiaria.DataSource = DT;
        }
        



        //private void btnAdd_Click_1(object sender, EventArgs e)
        //{
        //    Adicionar a = new Adicionar();
        //    a.ShowDialog();
            
        //}

        //private void btnRem_Click_1(object sender, EventArgs e)
        //{
        //    Remover r = new Remover();
        //    r.ShowDialog();
            
            
        //}

        //private void btnEdit_Click(object sender, EventArgs e)
        //{
        //    Editar E = new Editar();
        //    E.ShowDialog();
            
        //}

        //private void btnAtt_Click(object sender, EventArgs e)
        //{
        //    //DAO d = new DAO();
        //    //dtgEst.DataSource = d.select("SELECT cod as 'Código', nomep as 'Nome', valorunit as 'Valor de Venda', tipop as 'Tipo', datafab as 'Fabricação', precocompra as 'Preço de Compra', marcap as 'Marca', nomefornecedor as 'Fornecedor', dataval as 'Validade', quantestoque as 'Qt. Estoque' FROM produtos");
        //    //d.mConn.Close();
        //    mostrarEst();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Close();
        //}
        
        

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        

        //private void btnRegistrar_Click(object sender, EventArgs e)
        //{
        //    Registros r = new Registros();
        //    r.Show();
        //}

        private void dtgEst_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (int.Parse(dtgEst.CurrentRow.Cells[9].Value.ToString())>0)
            {
                lblBaixaCod.Text = dtgEst.CurrentRow.Cells[0].Value.ToString();
                lblBaixaNome.Text = dtgEst.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                MessageBox.Show("Quantidade insuficiente para baixas no estoque!");
            }

            
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            //DAO d = new DAO();
            //try
            //{
            //d.insert("insert into diario(cod,nomep,quant) values(" + lblBaixaCod.Text + ",'" + lblBaixaNome.Text + "'," + txtBaixaQt.Text + ")");
            //    MessageBox.Show("Registro transferido");
            //    dtgBaixaDiaria.DataSource = d.select("SELECT cod as 'Código', nomep as 'Nome', quant as 'Quantidade', codvenda as 'Cod. Venda' FROM diario");


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //}


            sql.Remove(0, sql.Length);
            sql.Append("insert into diario(cod,nomep,quant) values");
            sql.Append("(" + lblBaixaCod.Text + ",'" + lblBaixaNome.Text + "'," + txtBaixaQt.Text + ")");
            conexao.StrSql = sql.ToString();
            if (conexao.ExecutarCmd() > 0)
            {
                MessageBox.Show("Registro transferido!");
                mostrarDiario();
                lblBaixaCod.Text = "";
                lblBaixaNome.Text = "";
                txtBaixaQt.Text = "";

            }
            else
            {
                MessageBox.Show("Erro! Tente novamente.");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            for (int a = int.Parse(dtgBaixaDiaria.RowCount.ToString()); a > 1 ; a--)
            {
                //DAO d = new DAO();
                //d.darBaixa(int.Parse(dtgBaixaDiaria.Rows[0].Cells[0].Value.ToString()), int.Parse(dtgBaixaDiaria.Rows[0].Cells[2].Value.ToString()), int.Parse(dtgBaixaDiaria.Rows[0].Cells[3].Value.ToString()));
                //dtgBaixaDiaria.DataSource = d.select("SELECT cod as 'Código', nomep as 'Nome', quant as 'Quantidade', codvenda as 'Cod. Venda' FROM diario");
                //d.mConn.Close();
                sql.Remove(0, sql.Length);
                sql.Append("update produtos set quantestoque = ");
                sql.Append("quantestoque - " + int.Parse(dtgBaixaDiaria.Rows[0].Cells[2].Value.ToString()) + " where ");
                sql.Append("cod = " + int.Parse(dtgBaixaDiaria.Rows[0].Cells[1].Value.ToString()));
                conexao.StrSql = sql.ToString();
                conexao.ExecutarCmd();
                sql.Remove(0, sql.Length);
                sql.Append("delete from diario where codvenda=" + int.Parse(dtgBaixaDiaria.Rows[0].Cells[0].Value.ToString()));
                conexao.StrSql = sql.ToString();
                conexao.ExecutarCmd();
                mostrarDiario();

            }
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adicionar a = new Adicionar();
            a.ShowDialog();
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remover r = new Remover();
            r.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar editar = new Editar();
            editar.ShowDialog();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mostrarEst();
        }

        private void registrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registros r = new Registros();
            r.Show();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dtgBaixaDiaria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if(MessageBox.Show("Registro:\nCod.Venda: " + dtgBaixaDiaria.CurrentRow.Cells[0].Value.ToString() + "\nCod.Produto: " + dtgBaixaDiaria.CurrentRow.Cells[1].Value.ToString() + "\nQuantidade: " + dtgBaixaDiaria.CurrentRow.Cells[2].Value.ToString() + "\nNome: " + dtgBaixaDiaria.CurrentRow.Cells[3].Value.ToString(), "Apagar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes){


                sql.Remove(0, sql.Length);
                sql.Append("delete from diario where codvenda=" + dtgBaixaDiaria.CurrentRow.Cells[0].Value.ToString());
                conexao.StrSql = sql.ToString();
                if (conexao.ExecutarCmd() > 0)
                {
                    MessageBox.Show("Concluído!");
                    mostrarDiario();

                }
                else
                {
                    MessageBox.Show("Erro!");
                }
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                txtSearch.Text = "Pesquise...";
            }
        }

        private void lblSearch_Click(object sender, EventArgs e)
        {
            sql.Remove(0, sql.Length);
            sql.Append("SELECT cod as 'Código', nomep as 'Nome', valorunit as 'Valor de Venda', ");
            sql.Append("tipop as 'Tipo', datafab as 'Fabricação', precocompra as 'Preço de Compra', marcap as 'Marca', ");
            sql.Append("nomefornecedor as 'Fornecedor', dataval as 'Validade', quantestoque as 'Qt. Estoque' FROM produtos ");
            sql.Append("where nomep like '%" + txtSearch.Text + "%' OR cod like '%" + txtSearch.Text +"%'");
            conexao.StrSql = sql.ToString();
            DS = conexao.RetornarDataSet();
            DT = DS.Tables[0];
            dtgEst.DataSource = DT;
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void pcbLogo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Arthur Dylan\n Email: arthurdylanjj@gmail.com\n Telefone: 1197029-9713","Contato:",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }








        //public void darBaixa(int cod, int quant, int codvenda)
        //{
        //    try
        //    {
        //        if (mConn.State == ConnectionState.Closed)
        //        {
        //            mConn.Open();
        //        }
        //        sql = "update produtos set quantestoque = quantestoque - "+quant+" where cod="+cod;
        //        MySqlCommand cmd = new MySqlCommand(sql, mConn);
        //        cmd.ExecuteNonQuery();
        //        sql = "delete from diario where codvenda="+codvenda;
        //        cmd = new MySqlCommand(sql, mConn);
        //        cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        mConn.Close();
        //    }

        //}
    }
}
