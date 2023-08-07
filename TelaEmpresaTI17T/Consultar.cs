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
    public partial class Consultar : Form
    {
        DAO consul;
        public Consultar()
        {
            consul = new DAO();
            InitializeComponent();
            configurarDataGrid();
            nomeColunas(); //Nomear os titulos das colunas
            AdicionarDados();//Preenchendo o DataGridView
        }

        public void nomeColunas()
        {
            dataGridView1.Columns[0].Name = "CPF";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Telefone";
            dataGridView1.Columns[3].Name = "Cidade";
            dataGridView1.Columns[4].Name = "UF";
        }//Fim do Metodo

        public void configurarDataGrid()
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            
            dataGridView1.ColumnCount = 5;
        }//Fim do Metodo

        private void Consultar_Load(object sender, EventArgs e)
        {

        }//Fim do metodo

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//Fim do Metodo

        public void AdicionarDados()
        {
            consul.preecherVetor();//Preencher os vetores
            for (int i = 0; i < consul.quantidadeDados(); i++)
            {
                dataGridView1.Rows.Add(consul.CPF[i], consul.Nome[i], consul.Telefone[i], consul.Cidade[i], consul.UF[i]);
            }//Fim do For
        }//Fim do metodo

    }//Fim da Classe
}//Fim do Projeto
