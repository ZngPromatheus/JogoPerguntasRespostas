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

namespace JogoDesktop
{
    public partial class Pergunta1 : Form
    {
        public Pergunta1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rdbResposta4.Checked == true)
            {
                MessageBox.Show("ACERTOUUU");
                //Cadastrar no banco de dados a pergunta e a resposta

                using (SqlConnection conexao = new SqlConnection("Server=AME0556347W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
                {

                    using (SqlCommand comando = new SqlCommand("insert into tb_Perguntas(pergunta,resposta_correta) values(@pergunta,@resposta_correta)", conexao))
                    {
                        comando.Parameters.AddWithValue("pergunta", lblPergunta.Text);
                        comando.Parameters.AddWithValue("resposta_correta", rdbResposta4.Text);
                        comando.Parameters.AddWithValue("id_Jogador", id_jogador_banco);
                        conexao.Open();

                        if (comando.ExecuteNonQuery() == 1;

                        int id_jogador = (int)comando.ExecuteScalar();

                        MessageBox.Show("O id inserido foi: " + id_jogador);
                    }

                }
            }
            else
            {
                MessageBox.Show("ERROUU");
            }
        }
    }
}
