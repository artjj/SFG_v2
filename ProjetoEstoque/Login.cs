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
    public partial class Login : Form
    {
        private string senha = "dobradinha";
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtLoginSenha.Text == senha)
            {
                Form1 f = new Form1();
                f.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Senha Incorreta! Tente novamente.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtLoginSenha.PasswordChar = char.Parse("*");
        }

       
    }
}
