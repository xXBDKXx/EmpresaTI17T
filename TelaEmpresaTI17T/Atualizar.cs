using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaEmpresaTI17T
{
    public partial class Atualizar : Form
    {
        DAO atu;
        public Atualizar()
        {
            InitializeComponent();
            atu = new DAO();
        }

        private void Atualizar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            atu.Atualizar(Convert.ToInt64(CPF.Text), "pessoa", "Nome", Nome.Text);//Atualizar o nome
            atu.Atualizar(Convert.ToInt64(CPF.Text), "pessoa", "Telefone", Telefone.Text);//Atualizar o Telefone
            atu.Atualizar(Convert.ToInt64(CPF.Text), "pessoa", "Cidade", Cidade.Text);//Atualizar o Cidade
            atu.Atualizar(Convert.ToInt64(CPF.Text), "pessoa", "UF", UF.Text);//Atualizar o UF
            MessageBox.Show("Dados Atualizados com sucesso");
        }//Botão Atualizar

        private void CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do CPF

        private void Nome_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Nome

        private void Telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do Telefone

        private void Cidade_TextChanged(object sender, EventArgs e)
        {

        }//Fim da Cidade

        private void UF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim da UF
    }//Fim da Classe
}//Fim do Projeto
