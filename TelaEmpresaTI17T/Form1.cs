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
    public partial class Form1 : Form
    {
        Cadastar cad;
        Consultar con;
        Atualizar atu;
        Excluir exc;
        DAO consul;
        Consultar cons;
        
        public Form1()
        {
            InitializeComponent();
            cad = new Cadastar();
            con = new Consultar();
            atu = new Atualizar();
            exc = new Excluir();
            consul = new DAO();
            
        }//Fim do Construtor


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            cad.ShowDialog();//Abrir a Tela
        }//Fim do Botão Cadastrar

        private void Atualizar_Click(object sender, EventArgs e)
        {
            atu.ShowDialog();
        }//Fim do Botão Atualizar

        private void Consultar_Click(object sender, EventArgs e)
        {
            con.ShowDialog();
        }//Fim do Botão Consultar

        private void Excluir_Click(object sender, EventArgs e)
        {
            exc.ShowDialog();
        }//Fim do Botão Excluir
    }//Fim da Classe
}//Fim do Projeto
