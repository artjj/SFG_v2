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
    public partial class Form1 : Form
    {
        //public string NomeUsuario { get; set; }
        public Form1(string NomeUsuario)
        {
            InitializeComponent();
            lblWelcome.Text = $"Bem vindo(a) {NomeUsuario}!";
            
        }
        private void lblEstoque_Click(object sender, EventArgs e)
        {
            Principal P = new Principal();
            P.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void lblHistórico_Click(object sender, EventArgs e)
        {
            Histórico h = new Histórico();
            h.ShowDialog();
        }

        private void lblEstoque_MouseEnter(object sender, EventArgs e)
        {
            lblEstoque.BackColor = Color.White;
        }

        private void lblEstoque_MouseLeave(object sender, EventArgs e)
        {
            lblEstoque.BackColor = Color.Transparent;
        }

        private void lblHistórico_MouseEnter(object sender, EventArgs e)
        {
            lblHistórico.BackColor = Color.White;
        }

        private void lblHistórico_MouseLeave(object sender, EventArgs e)
        {
            lblHistórico.BackColor = Color.Transparent;
        }

        private void lblFaturamento_MouseEnter(object sender, EventArgs e)
        {
            lblFaturamento.BackColor = Color.White;
        }

        private void lblFaturamento_MouseLeave(object sender, EventArgs e)
        {
            lblFaturamento.BackColor = Color.Transparent;
        }

        private void lblFaturamento_Click(object sender, EventArgs e)
        {
            Faturamento faturamento = new Faturamento();
            faturamento.ShowDialog();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
