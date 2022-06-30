using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DESAFIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            picture.Image = Properties.Resources.xaropinho;

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string nome;
            string sobrenome;
            int anodenascimento;
            int idade;

            nome = txtNome.Text;
            sobrenome = txtSobrenome.Text;
            anodenascimento = int.Parse(txtData.Text);
            idade = int.Parse(DateTime.Now.ToString("yyyy")) - anodenascimento;
            

            if (idade >= 18)
            {
                lblResultado.Text = "Pode entrar :)";
                picture.Image = Properties.Resources.Sem_título;
            }
            else
            {
                lblResultado.Text = "Não pode entrar :(";
                picture.Image = Properties.Resources.o_apresentador_carlos_massa_o_ratinho;
            }






        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            txtData.Clear();
            lblResultado.Text = "";
        }
    }
}
