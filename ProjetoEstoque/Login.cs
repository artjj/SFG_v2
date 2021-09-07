using SistemaEstoque;
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

namespace ProjetoEstoque
{
    public partial class Login : Form
    {
        clsConexão conexao = new clsConexão();
        StringBuilder sql = new StringBuilder();
        SqlDataReader sdr;
        DataSet DS = new DataSet();
        DataTable DT = new DataTable();
        public string Usuario { get; private set; }
        public string NomeUsuario { get; private set; }
        private string senha;

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario = txtUsuario.Text;
            sql.Remove(0, sql.Length);
            sql.Append("select vchNome, vchSenha from usuario ");
            sql.Append($"where vchCodUsuario = '{Usuario}'");
            conexao.StrSql = sql.ToString();
            sdr = conexao.RetornarDataReader();
            

            if (sdr.Read())
            {
                NomeUsuario = sdr["vchNome"].ToString();
                senha = sdr["vchSenha"].ToString();
            }


            if (txtLoginSenha.Text == senha)
            {
                Form1 f = new Form1(NomeUsuario);
                f.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos! Tente novamente.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtLoginSenha.PasswordChar = char.Parse("*");
        }

        private void lblLoginSenha_Click(object sender, EventArgs e)
        {

        }
    }
}
