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

namespace TelaEmpresaTI17T
{
    public partial class Cadastar : Form
    {
        DAO conectar;
        public Cadastar()
        {
            InitializeComponent();
            conectar = new DAO();//Ligado o Banco de dados a tabela
        }//Fim do Constrututor

        private void Cadastar_Load(object sender, EventArgs e)
        {
            
        }//Fim do metodo

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string result = conectar.Inserir(Convert.ToInt64(cpf.Text), nome.Text, telefone.Text, cidade.Text, uf.Text, "Pessoa");
                MessageBox.Show(result);
            }catch(Exception erro)
            {
                MessageBox.Show("Algo deu errado\n\n" + erro.Message);
            }//Fim do TryCatch
        }//Botão Cadastrar

        private void cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do CPF

        private void nome_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Nome

        private void telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//FIm do Telefone

        private void cidade_TextChanged(object sender, EventArgs e)
        {

        }//Fim da Cidade

        private void uf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim da UF
    }//Fim da classe
}//Fim do Projeto
