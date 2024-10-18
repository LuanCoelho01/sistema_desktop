using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mush___Room.telaLogin
{
    public partial class telaLogin : Form
    {

        Conexao con = new Conexao();
        string sql;
        SqlCommand cmd;
        string id;

        public telaLogin()
        {
            InitializeComponent();
        }

        private void telaLogin_Load(object sender, EventArgs e)
        {
            con.AbrirConexao();

            sql = "SELECT * FROM TBusuario WHERE nome_usuario = '"+txtUsuario.Text+"' AND senha_usuario = '"+txtSenha.Text+"'"; //select na tabela TBproducao pelo id em ordem crescente
            cmd = new SqlCommand(sql, con.con);
            SqlDataAdapter da = new SqlDataAdapter(); //o adapter recebe o nome de "da"
            da.SelectCommand = cmd; // o "da" recebe o comando de select 
            DataTable dt = new DataTable(); //aqui a tabela será listada
            da.Fill(dt); //"da" recebe os campos 
            //gridProducao.DataSource = dt; //trazer a tabela para a grid

            if(dt.Rows.Count == 1)
            {
                frmPrincipal principal = new frmPrincipal();
                this.Hide();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            con.FecharConexao();
        }
    }
}
