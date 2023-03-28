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
using ProjetoVisualWPF.Formulários;
using MySql.Data.MySqlClient;
using ProjetoVisualWPF.RegrasDeNegocio;
using System.Data.SqlClient;
using System.Data;

namespace ProjetoVisualWPF.Formulários
{
    /// <summary>
    /// Lógica interna para ListarCadastros.xaml
    /// </summary>
    public partial class ListarCadastros : Window
    {
        private MySqlConnection _conexao;
        private MySqlCommand _command;

        public ListarCadastros()
        {
            InitializeComponent();

            Conexao();
            Listar();
        }

        private void Conexao()
        {
            string conexaoString = "server=localhost;database=app_contato_bd;user=root;password=root;port=3360";

            _conexao = new MySqlConnection(conexaoString);
            _conexao.Open();
        }

        private void Listar()
        {
            var sql = "SELECT * FROM contato;";
            var comando = new MySqlCommand(sql, _conexao);
            MySqlDataAdapter da = new MySqlDataAdapter(comando);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvLista.DataSource = dt;
        }
    }
}
