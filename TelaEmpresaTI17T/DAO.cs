using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TelaEmpresaTI17T
{
    class DAO
    {
        public MySqlConnection conexao;
        public long[] CPF;
        public string[] Nome;
        public string[] Telefone;
        public string[] Cidade;
        public string[] UF;
        public int i;
        public int contador;

        public DAO()
        {
            conexao = new MySqlConnection("server=localhost;DataBase=EmpresaTI17T;Uid=root;password=");
            try
            {
                conexao.Open();//Abrir a conexão com o banco de dados
                MessageBox.Show("Conectado");
            }catch (Exception erro)
            {
                MessageBox.Show("Algo deu errado!\n\n" + erro.Message);//Exibir qual foi o erro caso haja um
            }
        }//Fim do Metodo

        //Metodo de inserção
        public string Inserir(long CPF, string Nome, string Telefone,string Cidade, string UF, string nomeTabela)
        {
            string inserir = $"Insert into {nomeTabela}(CPF, Nome, Telefone, Cidade, UF) values ('{CPF}', '{Nome}', '{Telefone}', '{Cidade}', '{UF}')";//Insert os dados especificados dentro de uma tabela especificada
            MySqlCommand sql = new MySqlCommand(inserir, conexao);
            string resultado = sql.ExecuteNonQuery() + " Executado!";//Ctrl enter no banco basicamente
            return resultado;
        }//Fim do Metodo

        public void preecherVetor()
        {
            string query = "Select * from pessoa";

            //Instaciar os vetores

            this.CPF = new long[100];
            this.Nome = new string[100];
            this.Telefone = new string[100];
            this.Cidade = new string[100];
            this.UF = new string[100];

            //Preparar o comando
            MySqlCommand sql = new MySqlCommand(query, conexao);
            //Leitor
            MySqlDataReader leitura = sql.ExecuteReader();

            i = 0;
            contador = 0;
            while (leitura.Read()) 
            {
                CPF[i] = Convert.ToInt64(leitura["CPF"]);
                Nome[i] = leitura["Nome"] + "";
                Telefone[i] = leitura["Telefone"] + "";
                Cidade[i] = leitura["Cidade"] + "";
                UF[i] = leitura["UF"] + "";
                
                i++;
                contador++;
            }//Fim do while

            //Encerrar a comunicação com o banco
            leitura.Close();
        }//Fim do Metodo

        public int quantidadeDados()
        { 
            return contador; 
        }//Fim do metodo

        public string Atualizar(long CPF, string nomeTabela, string campo, string dado)
        {
            string query = $"update {nomeTabela} set {campo} = '{dado}' where CPF = '{CPF}' ";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Atualizado";
            return resultado;
        }//Fim do Metodo

        public string Excluir(long CPF, string nomeTabela)
        {
            string query = $"delete from {nomeTabela} where CPF = {CPF}";
            MySqlCommand sql = new MySqlCommand(query, conexao);
            string resultado = sql.ExecuteNonQuery() + " Excluido";
            return resultado;
        }//Fim do metodo


    }//Fim da Classe
}//Fim do Projeto
