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

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            verificar();

            sql = "SELECT * FROM TBusuarios WHERE nome_usuario = '"+txtUsuario.Text+"' AND senha_usuario ='"+txtSenha.Text+"'"; 
            cmd = new SqlCommand(sql, con.con);
            SqlDataAdapter da = new SqlDataAdapter(); //o adapter recebe o nome de "da"
            da.SelectCommand = cmd; // o "da" recebe o comando de select 
            DataTable dt = new DataTable(); //aqui a tabela será listada
            da.Fill(dt); //"da" recebe os campos 


            if (dt.Rows.Count == 1)
            {
                frmPrincipal principal = new frmPrincipal();
                this.Hide();
                principal.Show();


            }            
            else
            {
                MessageBox.Show("Usuário ou senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuario.Text = "";
                txtSenha.Text = "";

                txtUsuario.Select();
            }

           
            con.FecharConexao();

        }



        void verificar()
        {
            if (txtUsuario.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Preencha os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }
    }
}

// validação login com try catch
//try
//{
//    if (dt.Rows.Count == 1)
//    {
//        frmPrincipal principal = new frmPrincipal();
//        this.Hide();
//        principal.Show();


//    }
//}
//catch(Exception) 
//{
//   MessageBox.Show("Usuário ou senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        txtUsuario.Text = "";
//        txtSenha.Text = "";

//        txtUsuario.Select();
//}

//con.FecharConexao();
