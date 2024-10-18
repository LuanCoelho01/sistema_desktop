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
using System.Security.Cryptography.X509Certificates;

namespace Mush___Room.telaProducao
{
    public partial class alt_producao : Form
    {

        Conexao con = new Conexao();
        string sql;
        SqlCommand cmd;
        string id;
        //string producaoAntiga;

        public static alt_producao frm;
        public static alt_producao getalt_producao
        {
            get
            {
                if (frm == null)
                {
                    frm = new alt_producao();
            }

                return frm;
            }
        }

        public alt_producao()
        {
            InitializeComponent();

        }


        //private void alt_producao_Load(object sender, EventArgs e)
        //{

        //    id = producao.selectedrow.Cells[0].Value.ToString();
        //    txtAltNomeProducao.Text = producao.selectedrow.Cells[1].Value.ToString();
        //    txtAltInfoProducao.Text = producao.selectedrow.Cells[2].Value.ToString();       // recebe as informações da grid e as mostra nos respectivos campos
        //    //producaoAntiga = producao.selectedrow.Cells[2].Value.ToString();
        //    txtAltIniProducao.Text = producao.selectedrow.Cells[3].Value.ToString();
        //    txtAltTrocaSubstrato.Text = producao.selectedrow.Cells[4].Value.ToString();
        //}



        private void btnAltProd_Click_1(object sender, EventArgs e)
        {
            {
                if (txtAltNomeProducao.Text.ToString().Trim() == "") // .Trim() não permite que apenas espaços sejam inseridos e salvos
                {
                    MessageBox.Show("Preencha o campo 'Nome da Produção'", "Alterar produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAltNomeProducao.Text = "";
                    txtAltNomeProducao.Focus();
                    return;
                }

                
                }

                if (txtAltInfoProducao.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("Preencha o campo 'Informações da Produção'", "Alterar produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAltInfoProducao.Text = "";
                    txtAltInfoProducao.Focus();
                    return;
                }

                if (txtAltIniProducao.Text == "  /  /" || txtAltIniProducao.Text.Length < 10)
                {
                    MessageBox.Show("Preencha o campo 'Início da produção'", "Alterar produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAltIniProducao.Text = "";
                    txtAltIniProducao.Focus();
                    return;
                }

                if (txtAltTrocaSubstrato.Text == "  /  /" || txtAltTrocaSubstrato.Text.Length < 10)
                {
                    MessageBox.Show("Preencha o campo 'Troca de substrato'", "Alterar produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAltTrocaSubstrato.Text = "";
                    txtAltTrocaSubstrato.Focus();
                    return;
                }



                con.AbrirConexao();

                sql = "UPDATE TBproducao SET nome_producao = @nome_producao, info_producao = @info_producao, ini_producao = @ini_producao, troca_substrato = @troca_substrato WHERE id_prod = @id_prod";
                
                cmd = new SqlCommand(sql, con.con);

                cmd.Parameters.AddWithValue("@id_prod", id); //WHERE
                cmd.Parameters.AddWithValue("@nome_producao", txtAltNomeProducao.Text);
                cmd.Parameters.AddWithValue("@info_producao", txtAltInfoProducao.Text);
                cmd.Parameters.AddWithValue("@ini_producao", txtAltIniProducao.Text);
                cmd.Parameters.AddWithValue("@troca_substrato", txtAltTrocaSubstrato.Text);


                cmd.ExecuteNonQuery();
                con.FecharConexao();

                MessageBox.Show("Registro alterado com sucesso!", "Alterar produção", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
    }


////verificar se a produção já existe
//if (txtAltNomeProducao.Text != producaoAntiga)
//{
//    SqlCommand cmdVerificar;
//    cmdVerificar = new SqlCommand("SELECT * FROM TBproducao WHERE nome_producao = @nome_producao", con.con);
//    SqlDataAdapter da = new SqlDataAdapter();
//    da.SelectCommand = cmdVerificar;
//    cmdVerificar.Parameters.AddWithValue("@nome_producao", txtAltNomeProducao.Text);
//    DataTable dt = new DataTable();
//    da.Fill(dt);
//    if (dt.Rows.Count > 0)
//    {
//        MessageBox.Show("Produção já registrada", "Alterar produção", MessageBoxButtons.OK, MessageBoxIcon.Stop);
//        txtAltNomeProducao.Text = "";
//        txtAltNomeProducao.Focus();
//        return;
//    }