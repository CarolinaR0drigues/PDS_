using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ProjetoVisualWPF.RegrasDeNegocio;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace ProjetoVisualWPF.Formulários
{
    /// <summary>
    /// Lógica interna para CadastroDeContato.xaml
    /// </summary>
    public partial class CadastroDeContato : Window
    {
        private MySqlConnection _conexao;

        List<Cadastro> cadastroList = new List<Cadastro>();
        public CadastroDeContato()

        public CadastroDeContato()
        {
            InitializeComponent();

            Conexao();
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";
            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }

        private void btSalvar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                dtpNascimento.Format = DateTimePickerFormat.Custom;
                dtpNascimento.CustomFormat = "yyyy-MM-dd";
                var nome = tbNome.Text;
                var email = tbEmail.Text;
                var sexo = cbSexo.Text;
                var telefone = tbTelefone.Text;
                var dataNascimento = dtpNascimento.Text;

                if (nome != "" && email != "" && telefone != "" && sexo != "" && dataNascimento != "")
                {
                    var sql = "INSERT INTO contato (nome_con, email_con, sexo_con, data_nasc_con, telefone_con) VALUES (@_nome, @_email, @_sexo, @_dataNascimento, @_telefone)";
                    var comando = new MySqlCommand(sql, _conexao);

                    comando.Parameters.AddWithValue("@_nome", nome);
                    comando.Parameters.AddWithValue("@_email", email);
                    comando.Parameters.AddWithValue("@_sexo", sexo);
                    comando.Parameters.AddWithValue("@_telefone", telefone);
                    comando.Parameters.AddWithValue("@_dataNascimento", dataNascimento);

                    comando.ExecuteNonQuery();

                    MessageBox.Show("Os dados foram salvos com sucesso");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //MessageBox.Show("Ocorreram erros ao salvar as informações!" +
                //"Contrate a equipe de suporte do sistema. (CAD 10)");
            }

            _conexao.Close();

            limpar();
        }

        public void limpar()
        {
            tbNome.Clear();
            tbEmail.Clear();
            tbTelefone.Clear();
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            limpar();
        }
    }
}
