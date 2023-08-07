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
    public partial class Excluir : Form
    {
        DAO exc;
        public Excluir()
        {
            InitializeComponent();
            exc = new DAO();
        }

        private void Excluir_Load(object sender, EventArgs e)
        {

        }

        private void CPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do CPF

        private void button1_Click(object sender, EventArgs e)
        {
            string result = exc.Excluir(Convert.ToInt64(CPF.Text), "pessoa");
            MessageBox.Show(result);
        }//Botão Excluir

    }//Fim da Classe
}//Fim do Projeto
