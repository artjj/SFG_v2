using ProjetoEstoque;
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

namespace SistemaEstoque
{
    public partial class Faturamento : Form
    {
        clsConexão conexao = new clsConexão();
        StringBuilder sql = new StringBuilder();
        //DAO d = new DAO();
        string valor;
        DataSet DS = new DataSet();
        DataTable DT = new DataTable();
        public Faturamento()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToShortDateString();
            //DAO dao = new DAO();
            mostralucro();
            cboFatMensal.Items.Add("Janeiro");
            cboFatMensal.Items.Add("Fevereiro");
            cboFatMensal.Items.Add("Março");
            cboFatMensal.Items.Add("Abril");
            cboFatMensal.Items.Add("Maio");
            cboFatMensal.Items.Add("Junho");
            cboFatMensal.Items.Add("Julho");
            cboFatMensal.Items.Add("Agosto");
            cboFatMensal.Items.Add("Setembro");
            cboFatMensal.Items.Add("Outubro");
            cboFatMensal.Items.Add("Novembro");
            cboFatMensal.Items.Add("Dezembro");

            for (int ano = 2018; ano <= 2030; ano++)
            {
                cboFatAnual.Items.Add(ano);
            }

            cboFatAnual.Text = lblDate.Text.Substring(6, 4);
            switch (lblDate.Text.Substring(3, 2))
            {
                case "01":
                    cboFatMensal.Text = "Janeiro";
                    break;
                case "02":
                    cboFatMensal.Text = "Fevereiro";
                    break;
                case "03":
                    cboFatMensal.Text = "Março";
                    break;
                case "04":
                    cboFatMensal.Text = "Abril";
                    break;
                case "05":
                    cboFatMensal.Text = "Maio";
                    break;
                case "06":
                    cboFatMensal.Text = "Junho";
                    break;
                case "07":
                    cboFatMensal.Text = "Julho";
                    break;
                case "08":
                    cboFatMensal.Text = "Agosto";
                    break;
                case "09":
                    cboFatMensal.Text = "Setembro";
                    break;
                case "10":
                    cboFatMensal.Text = "Outubro";
                    break;
                case "11":
                    cboFatMensal.Text = "Novembro";
                    break;
                case "12":
                    cboFatMensal.Text = "Dezembro";
                    break;

            }
        }

        private void Faturamento_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFat_Click(object sender, EventArgs e)
        {
            //DAO dao = new DAO();
            if (rdoDTAtual.Checked == true && rdoInserirDT.Checked == false)
            {
                DateTime data = Convert.ToDateTime(lblDate.Text);
                //data.ToString("yyyy/MM/dd");
                sql.Remove(0, sql.Length);
                sql.Append("insert into lucrodiario values( REPLACE( REPLACE( '" + txtFatDiario.Text + "', '.' ,'' ), ',', '.' ),'" + data.ToString("yyyy/MM/dd") + "')");
                conexao.StrSql = sql.ToString();
                conexao.ExecutarCmd();
                MessageBox.Show("Faturamento registrado!");
                //dao.insert("insert into lucrodiario values( REPLACE( REPLACE( '" + txtFatDiario.Text + "', '.' ,'' ), ',', '.' ),'" + data.ToString("yyyy/MM/dd") + "')");


            }
            else if (rdoDTAtual.Checked == !true && rdoInserirDT.Checked == !false)
            {
                DateTime data = Convert.ToDateTime(txtInserirDT.Text);
                sql.Remove(0, sql.Length);
                sql.Append("insert into lucrodiario values( REPLACE( REPLACE( '" + txtFatDiario.Text + "', '.' ,'' ), ',', '.' ),'" + data.ToString("yyyy/MM/dd") + "')");
                conexao.StrSql = sql.ToString();
                conexao.ExecutarCmd();
                MessageBox.Show("Faturamento registrado!");
                //dao.insert("insert into lucrodiario values( REPLACE( REPLACE( '" + txtFatDiario.Text + "', '.' ,'' ), ',', '.' ),'" + data.ToString("yyyy/MM/dd") + "')");
            }
            //dtgFatDiario.DataSource = dao.select("select valor as 'Valor', data as 'Data' from lucrodiario");
            mostralucro();
            rdoInserirDT.Checked = false;
            txtFatDiario.Text = "";
            txtInserirDT.Text = "";
            
        }

        private void mostralucro()
        {
            sql.Remove(0, sql.Length);
            sql.Append("select valor as 'Valor', data as 'Data' from lucrodiario");
            conexao.StrSql = sql.ToString();
            DS = conexao.RetornarDataSet();
            DT = DS.Tables[0];
            dtgFatDiario.DataSource = DT;
        }

        private DataTable select(string a)
        {
            sql.Remove(0, sql.Length);
            sql.Append(a);
            conexao.StrSql = sql.ToString();
            DS = conexao.RetornarDataSet();
            DT = DS.Tables[0];
            return DT;
        }
        private void btnGerarMensal_Click(object sender, EventArgs e)
        {
            //DAO dao = new DAO();
            switch (cboFatMensal.Text)
            {
                case "Janeiro":

                    //dtgFatMensal.DataSource = dao.select("select sum(valor) as 'Valor' from lucrodiario where data like '%-01-%'");
                    dtgFatMensal.DataSource = select("select sum(valor) as 'Valor' from lucrodiario where data like '%-01-%'");
                    break;
                case "Fevereiro":

                    //dtgFatMensal.DataSource = dao.select("select sum(valor) as 'Valor' from lucrodiario where data like '%-02-%'");
                    dtgFatMensal.DataSource = select("select sum(valor) as 'Valor' from lucrodiario where data like '%-02-%'");
                    break;
                case "Março":

                    //dtgFatMensal.DataSource = dao.select("select sum(valor) as 'Valor' from lucrodiario where data like '%-03-%'");
                    dtgFatMensal.DataSource = select("select sum(valor) as 'Valor' from lucrodiario where data like '%-03-%'");
                    break;
                case "Abril":

                    //dtgFatMensal.DataSource = dao.select("select sum(valor) as 'Valor' from lucrodiario where data like '%-04-%'");
                    dtgFatMensal.DataSource = select("select sum(valor) as 'Valor' from lucrodiario where data like '%-04-%'");
                    break;
                case "Maio":

                    //dtgFatMensal.DataSource = dao.select("select sum(valor) as 'Valor' from lucrodiario where data like '%-05-%'");
                    dtgFatMensal.DataSource = select("select sum(valor) as 'Valor' from lucrodiario where data like '%-05-%'");
                    break;
                case "Junho":

                    //dtgFatMensal.DataSource = dao.select("select sum(valor) as 'Valor' from lucrodiario where data like '%-06-%'");
                    dtgFatMensal.DataSource = select("select sum(valor) as 'Valor' from lucrodiario where data like '%-06-%'");
                    break;
                case "Julho":

                    //dtgFatMensal.DataSource = dao.select("select sum(valor) as 'Valor' from lucrodiario where data like '%-07-%'");
                    dtgFatMensal.DataSource = select("select sum(valor) as 'Valor' from lucrodiario where data like '%-07-%'");
                    break;
                case "Agosto":

                    //dtgFatMensal.DataSource = dao.select("select sum(valor) as 'Valor' from lucrodiario where data like '%-08-%'");
                    dtgFatMensal.DataSource = select("select sum(valor) as 'Valor' from lucrodiario where data like '%-08-%'");
                    break;
                case "Setembro":

                    //dtgFatMensal.DataSource = dao.select("select sum(valor) as 'Valor' from lucrodiario where data like '%-09-%'");
                    dtgFatMensal.DataSource = select("select sum(valor) as 'Valor' from lucrodiario where data like '%-09-%'");
                    break;
                case "Outubro":

                    //dtgFatMensal.DataSource = dao.select("select sum(valor) as 'Valor' from lucrodiario where data like '%-10-%'");
                    dtgFatMensal.DataSource = select("select sum(valor) as 'Valor' from lucrodiario where data like '%-10-%'");
                    break;
                case "Novembro":

                    //dtgFatMensal.DataSource = dao.select("select sum(valor) as 'Valor' from lucrodiario where data like '%-11-%'");
                    dtgFatMensal.DataSource = select("select sum(valor) as 'Valor' from lucrodiario where data like '%-11-%'");
                    break;
                case "Dezembro":

                    //dtgFatMensal.DataSource = dao.select("select sum(valor) as 'Valor' from lucrodiario where data like '%-12-%'");
                    dtgFatMensal.DataSource = select("select sum(valor) as 'Valor' from lucrodiario where data like '%-12-%'");
                    break;
            }
        }

        private void btnGerarAnual_Click(object sender, EventArgs e)
        {
            //DAO dao = new DAO();
            //dtgFatAnual.DataSource = dao.select("select SUM(valor) as 'Valor' from lucrodiario where data like '%"+cboFatAnual.Text+"%'");
            dtgFatAnual.DataSource = select("select SUM(valor) as 'Valor' from lucrodiario where data like '%" + cboFatAnual.Text + "%'");

        }

        private void btnSalvarM_Click(object sender, EventArgs e)
        {
            if (rdoInserirValorM.Checked == true && txtInserirValorM.Text != "")
            {
                valor = txtInserirValorM.Text;
            }
            else
            {
                valor = dtgFatMensal.Rows[0].Cells[0].Value.ToString();
            }
            sql.Remove(0, sql.Length);
            sql.Append("insert into faturamento values ");
            sql.Append("(REPLACE(REPLACE('" + valor + "', '.', ''), ',', '.'),'Mensal' , '" + cboFatMensal.Text + "', '" + cboFatAnual.Text + "')");
            if (MessageBox.Show("Valor: " + valor + "\nOperação: Mensal \nMês: " + cboFatMensal.Text + "\nAno: " + cboFatAnual.Text , "Salvar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conexao.StrSql = sql.ToString();
                if (conexao.ExecutarCmd() > 0)
                {
                    MessageBox.Show("Faturamento Mensal Salvo!");
                }
                else
                {
                    MessageBox.Show("Erro! Tente novamente.");
                }
            }
        }

        private void btnSalvarA_Click(object sender, EventArgs e)
        {
            if (rdoInserirValorA.Checked == true && txtInserirValorA.Text != "")
            {
                valor = txtInserirValorA.Text;
            }
            else
            {
                valor = dtgFatAnual.Rows[0].Cells[0].Value.ToString();
            }
            sql.Remove(0, sql.Length);
            sql.Append("insert into faturamento values ");
            sql.Append("(REPLACE(REPLACE('" + valor + "', '.', ''), ',', '.'),'Anual' , '###', '" + cboFatAnual.Text + "')");
            if (MessageBox.Show("Valor: " + valor + "\nOperação: Anual \nMês: ###\nAno: " + cboFatAnual.Text, "Salvar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conexao.StrSql = sql.ToString();
                if (conexao.ExecutarCmd() > 0)
                {
                    MessageBox.Show("Faturamento Anual Salvo!");
                }
                else
                {
                    MessageBox.Show("Erro! Tente novamente.");
                }
            }
        }

        private void btnGerarF_Click(object sender, EventArgs e)
        {
            if(rdoMensal.Checked == true && rdoAnual.Checked == false && rdoAll.Checked == false)
            {
                dtgFat.DataSource = select("select valor as 'Valor', tipo as 'Tipo', mes as 'Mes', ano as 'Ano'from faturamento where tipo='Mensal'");
            }else if(rdoMensal.Checked == !true && rdoAnual.Checked == !false && rdoAll.Checked == false)
            {
                dtgFat.DataSource = select("select valor as 'Valor', tipo as 'Tipo', mes as 'Mes', ano as 'Ano' from faturamento where tipo='Anual'");
            }else if (rdoMensal.Checked == !true && rdoAnual.Checked == false && rdoAll.Checked == !false)
            {
                dtgFat.DataSource = select("select valor as 'Valor', tipo as 'Tipo', mes as 'Mes', ano as 'Ano' from faturamento");
            }
        }
    }
}
