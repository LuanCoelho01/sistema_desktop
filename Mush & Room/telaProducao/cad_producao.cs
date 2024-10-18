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

namespace Mush___Room.telaProducao
{
    public partial class cad_producao : Form
    {
        Conexao con = new Conexao();
        string sql;
        SqlCommand cmd;

        public cad_producao()
        {
            InitializeComponent();
        }

        
        private void btnCadProd_Click(object sender, EventArgs e)
        {
            if (txtNomeProducao.Text.ToString().Trim() == "") // .Trim() não permite que apenas espaços sejam inseridos e salvos
            {
                MessageBox.Show("Preencha o campo 'Nome da Produção'", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeProducao.Text = "";
                txtNomeProducao.Focus();
                return;
            }

            if (txtInfoProducao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo 'Informações da Produção'", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInfoProducao.Text = "";
                txtInfoProducao.Focus();
                return;
            }

            if (txtIniProducao.Text == "  /  /" || txtIniProducao.Text.Length < 10)
            {
                MessageBox.Show("Preencha o campo 'Início da produção'", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIniProducao.Text = "";
                txtIniProducao.Focus();
                return;
            }

            if (txtTrocaSubstrato.Text == "  /  /" || txtTrocaSubstrato.Text.Length < 10)
            {
                MessageBox.Show("Preencha o campo 'Troca de substrato'", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTrocaSubstrato.Text = "";
                txtTrocaSubstrato.Focus();
                return;
            }



            con.AbrirConexao();

            sql = "INSERT INTO TBproducao(nome_producao, info_producao, ini_producao, troca_substrato) VALUES(@nome_producao, @info_producao, @ini_producao, @troca_substrato)";
            cmd = new SqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@nome_producao", txtNomeProducao.Text);
            cmd.Parameters.AddWithValue("@info_producao", txtInfoProducao.Text);
            cmd.Parameters.AddWithValue("@ini_producao", txtIniProducao.Text);
            cmd.Parameters.AddWithValue("@troca_substrato", txtTrocaSubstrato.Text);


            cmd.ExecuteNonQuery();
            con.FecharConexao();

            MessageBox.Show("Registro salvo com sucesso!", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void cad_producao_Load(object sender, EventArgs e)
        {

        }
    }
}

