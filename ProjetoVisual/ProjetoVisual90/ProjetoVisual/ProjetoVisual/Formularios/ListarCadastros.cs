using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoVisual.Formularios;
using MySql.Data.MySqlClient;
using ProjetoVisual.RegrasDeNegocio;

namespace ProjetoVisual.Formularios
{
    public partial class ListarCadastros : Form
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
