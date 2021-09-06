using SistemaEstoque;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoEstoque
{
    public partial class Histórico : Form
    {
            clsConexão conexao = new clsConexão();
            StringBuilder sql = new StringBuilder();
            //SqlDataReader sdr;
            //DAO d = new DAO();
            DataSet DS = new DataSet();
            DataTable DT = new DataTable();
        public Histórico()
        {
            InitializeComponent();
            //DAO d = new DAO();
            //dtgHist.DataSource = d.select("SELECT notafiscal as 'Nota Fiscal', cod as 'Código', nomep as 'Nome', op as 'Operação', quantidade as 'Quantidade', data as 'Data' FROM historico");
            sql.Remove(0, sql.Length);
            sql.Append("SELECT notafiscal as 'Nota Fiscal', cod as 'Código', nomep as 'Nome', ");
            sql.Append("op as 'Operação', quantidade as 'Quantidade', data as 'Data' FROM historico");
            conexao.StrSql = sql.ToString();
            DS = conexao.RetornarDataSet();
            DT = DS.Tables[0];
            dtgHist.DataSource = DT;
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DAO d = new DAO();
            //dtgHist.DataSource = d.select("SELECT notafiscal as 'Nota Fiscal', cod as 'Código', nomep as 'Nome', op as 'Operação', quantidade as 'Quantidade', data as 'Data' FROM historico where op= 01");
            sql.Remove(0, sql.Length);
            sql.Append("SELECT notafiscal as 'Nota Fiscal', cod as 'Código', nomep as 'Nome', ");
            sql.Append("op as 'Operação', quantidade as 'Quantidade', data as 'Data' FROM historico where op= 01");
            conexao.StrSql = sql.ToString();
            DS = conexao.RetornarDataSet();
            DT = DS.Tables[0];
            dtgHist.DataSource = DT;
        }

        private void saídasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DAO d = new DAO();
            //dtgHist.DataSource = d.select("SELECT notafiscal as 'Nota Fiscal', cod as 'Código', nomep as 'Nome', op as 'Operação', quantidade as 'Quantidade', data as 'Data' FROM historico where op= 02");
            sql.Remove(0, sql.Length);
            sql.Append("SELECT notafiscal as 'Nota Fiscal', cod as 'Código', nomep as 'Nome', ");
            sql.Append("op as 'Operação', quantidade as 'Quantidade', data as 'Data' FROM historico where op= 02");
            conexao.StrSql = sql.ToString();
            DS = conexao.RetornarDataSet();
            DT = DS.Tables[0];
            dtgHist.DataSource = DT;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DAO d = new DAO();
            //dtgHist.DataSource = d.select("SELECT notafiscal as 'Nota Fiscal', cod as 'Código', nomep as 'Nome', op as 'Operação', quantidade as 'Quantidade', data as 'Data' FROM historico");
            sql.Remove(0, sql.Length);
            sql.Append("SELECT notafiscal as 'Nota Fiscal', cod as 'Código', nomep as 'Nome', ");
            sql.Append("op as 'Operação', quantidade as 'Quantidade', data as 'Data' FROM historico");
            conexao.StrSql = sql.ToString();
            DS = conexao.RetornarDataSet();
            DT = DS.Tables[0];
            dtgHist.DataSource = DT;

        }
    }
}
