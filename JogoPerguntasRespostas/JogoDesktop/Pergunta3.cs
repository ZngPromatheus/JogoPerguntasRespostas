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
    public partial class Pergunta3 : Form
    {
        public int id_jogador_banco;
        public Pergunta3(int id_jogador)
        {
            InitializeComponent();

            id_jogador_banco = id_jogador;
        }

        private void rdbResposta3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnProxima_Click(object sender, EventArgs e)
            //inicio
        {
            if (rdbResposta4.Checked == true)
            {
                MessageBox.Show("ACERTOUUU");
                //Cadastrar no banco de dados a pergunta e a resposta

                using (SqlConnection conexao = new SqlConnection("Server=AME0556347W10-1\\SQLEXPRESS;Database=db_PerguntasERespostas;Trusted_Connection=Yes"))
                {

                    using (SqlCommand comando = new SqlCommand("insert into tb_Perguntas(pergunta,resposta_correta, id_jogador) values(@pergunta,@resposta_correta, @id_jogador)", conexao))
                    {
                        comando.Parameters.AddWithValue("pergunta", lblPergunta.Text);
                        comando.Parameters.AddWithValue("resposta_correta", rdbResposta4.Text);
                        comando.Parameters.AddWithValue("tb_Jogador", id_jogador_banco);
                        conexao.Open();
                        comando.ExecuteNonQuery();

                        if (comando.ExecuteNonQuery() == 1)
                        {
                            
                            MessageBox.Show("Salvei");
                            this.Close();
                            
                        }



                        MessageBox.Show("O id inserido foi: " + id_jogador_banco);
                    }

                }
            }
            else
            {
                MessageBox.Show("ERROUU");
            }
            //fim
        }
    }
}
