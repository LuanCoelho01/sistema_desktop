using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mush___Room.telaProducao;
using System.Linq.Expressions;


namespace Mush___Room.telaProducao
{
    public partial class producao : Form
    {
        private const string V = "";
        Conexao con = new Conexao();
        string sql;
        SqlCommand cmd;
        string id;

        public producao()
        {
            InitializeComponent();
        }

        private void producao_Load_1(object sender, EventArgs e)
        {
            Listar();
            DesabilitarCampos();
        }
        

        private void Listar() //metodo para listar registros do bd na grid
        {
            con.AbrirConexao();
            sql = "SELECT * FROM TBproducao ORDER BY id_prod asc"; //select na tabela TBproducao pelo id em ordem crescente
            cmd = new SqlCommand(sql, con.con);
            SqlDataAdapter da = new SqlDataAdapter(); //o adapter recebe o nome de "da"
            da.SelectCommand = cmd; // o "da" recebe o comando de select 
            DataTable dt = new DataTable(); //aqui a tabela será listada
            da.Fill(dt); //"da" recebe os campos 
            gridProducao.DataSource = dt; //trazer a tabela para a grid
            con.FecharConexao();

            FormatarGD();
        }

        private void FormatarGD() //metodo para formatar a grid
        {
            gridProducao.Columns[0].HeaderText = "ID";
            gridProducao.Columns[1].HeaderText = "Nome da produção";
            gridProducao.Columns[2].HeaderText = "Informações da produção";
            gridProducao.Columns[3].HeaderText = "Início da produção";
            gridProducao.Columns[4].HeaderText = "Troca do substrato";
            //gridProducao.Columns[5].HeaderText = "Data de registro"; preciso adicionar a data

            //gridProducao.Columns[0].Width = 500;
            //gridProducao.Columns[4].Width = 500;
            gridProducao.Columns[0].Visible = false;

            //gridProducao.Columns[5].Visible = false; parte de data que preciso adicionar


        }


        private void btnCadProd_Click_1(object sender, EventArgs e)
        {
            //ValidarCampos();





            if (txtNomeProducao.Text.ToString().Trim() == "") // .Trim() não permite que apenas espaços sejam inseridos e salvos
            {
                MessageBox.Show("Preencha o campo 'Nome da produção'", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeProducao.Text = "";
                txtNomeProducao.Focus();
                return;
            }

            if (txtInfoProducao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo 'Informações da produção'", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInfoProducao.Text = "";
                txtInfoProducao.Focus();
                return;
            }

            if (mskIniProducao.Text == "  /  /    " || mskIniProducao.Text.Length < 10)
            {
                MessageBox.Show("Preencha o campo 'Início da produção'", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskIniProducao.Text = "";
                mskIniProducao.Focus();
                return;
            }

            if (mskTrocaSubstrato.Text == "  /  /    " || mskTrocaSubstrato.Text.Length < 10)
            {
                MessageBox.Show("Preencha o campo 'Troca de substrato'", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTrocaSubstrato.Text = "";
                mskTrocaSubstrato.Focus();
                return;
            }


            con.AbrirConexao();

            sql = "INSERT INTO TBproducao(nome_producao, info_producao, ini_producao, troca_substrato) VALUES(@nome_producao, @info_producao, @ini_producao, @troca_substrato)";
            cmd = new SqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@nome_producao", txtNomeProducao.Text);
            cmd.Parameters.AddWithValue("@info_producao", txtInfoProducao.Text);
            cmd.Parameters.AddWithValue("@ini_producao", mskIniProducao.Text);
            cmd.Parameters.AddWithValue("@troca_substrato", mskTrocaSubstrato.Text);


            cmd.ExecuteNonQuery();
            con.FecharConexao();

            Listar();
            LimparCampos();

            MessageBox.Show("Registro salvo com sucesso!", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Information);


            LimparCampos();
        }


        private void btnAltProd_Click(object sender, EventArgs e)
        {
            if (txtNomeProducao.Text.ToString().Trim() == "") // .Trim() não permite que apenas espaços sejam inseridos e salvos
            {
                MessageBox.Show("Preencha o campo 'Nome da produção'", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeProducao.Text = "";
                txtNomeProducao.Focus();
                return;
            }

            if (txtInfoProducao.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo 'Informações da produção'", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInfoProducao.Text = "";
                txtInfoProducao.Focus();
                return;
            }

            if (mskIniProducao.Text == "  /  /    " || mskIniProducao.Text.Length < 10)
            {
                MessageBox.Show("Preencha o campo 'Início da produção'", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskIniProducao.Text = "";
                mskIniProducao.Focus();
                return;
            }

            if (mskTrocaSubstrato.Text == "  /  /    " || mskTrocaSubstrato.Text.Length < 10)
            {
                MessageBox.Show("Preencha o campo 'Troca de substrato'", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTrocaSubstrato.Text = "";
                mskTrocaSubstrato.Focus();
                return;
            }



            con.AbrirConexao();

            sql = "UPDATE TBproducao SET nome_producao = @nome_producao, info_producao = @info_producao, ini_producao = @ini_producao, troca_substrato = @troca_substrato WHERE id_prod = @id_prod";

            cmd = new SqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@id_prod", id); //WHERE
            cmd.Parameters.AddWithValue("@nome_producao", txtNomeProducao.Text);
            cmd.Parameters.AddWithValue("@info_producao", txtInfoProducao.Text);
            cmd.Parameters.AddWithValue("@ini_producao", mskIniProducao.Text);
            cmd.Parameters.AddWithValue("@troca_substrato", mskTrocaSubstrato.Text);


            cmd.ExecuteNonQuery();
            con.FecharConexao();

            Listar();
            LimparCampos();

            MessageBox.Show("Registro alterado com sucesso!", "Alterar produção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnExcProd_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            sql = "DELETE FROM TBproducao WHERE id_prod = @id_prod";
            cmd = new SqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id_prod", id);
            cmd.ExecuteNonQuery();
            con.FecharConexao();

            Listar();
            LimparCampos();

            MessageBox.Show("Produção deletado com sucesso!", "Excluir produção", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomeProducao.Text = "";
            txtInfoProducao.Text = "";
            mskIniProducao.Text = "";
            mskTrocaSubstrato.Text = "";

            DesabilitarCampos();
        }


        private void gridProducao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if(e.RowIndex >= 0)
            //    {

            //    id = gridFornecedores.SelectedRows[0].Cells[0].Value.ToString();

            //    txtNomeFornecedor.Text = gridFornecedores.SelectedRows[0].Cells[1].Value.ToString();
            //    txtNomeProduto.Text = gridFornecedores.SelectedRows[0].Cells[2].Value.ToString();
            //    mskCNPJ.Text = gridFornecedores.SelectedRows[0].Cells[3].Value.ToString();
            //    mskTelefone.Text = gridFornecedores.SelectedRows[0].Cells[4].Value.ToString();

            //}
        }

        private void gridProducao_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            habilitarCampos();
            btnCadProd.Enabled = false;

            try
            {
                if (gridProducao.SelectedRows.Count >= 0)
                {

                    id = gridProducao.SelectedRows[0].Cells[0].Value.ToString();

                    txtNomeProducao.Text = gridProducao.SelectedRows[0].Cells[1].Value.ToString();
                    txtInfoProducao.Text = gridProducao.SelectedRows[0].Cells[2].Value.ToString();
                    mskIniProducao.Text = gridProducao.SelectedRows[0].Cells[3].Value.ToString();
                    mskTrocaSubstrato.Text = gridProducao.SelectedRows[0].Cells[4].Value.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleção inválida! Por favor, selecione a linha desejada com duplo clique.");
            }
        }


           


        private void habilitarCampos()
        {
            btnCadProd.Enabled = true;
            btnExcProd.Enabled = true;
            btnAltProd.Enabled = true;
            btnCancelar.Enabled = true;

            txtNomeProducao.Enabled = true;
            txtInfoProducao.Enabled = true;
            mskIniProducao.Enabled = true;
            mskTrocaSubstrato.Enabled = true;


        }

        private void LimparCampos()
        {
            txtNomeProducao.Text = "";
            txtInfoProducao.Text = "";
            mskIniProducao.Text = "";
            mskTrocaSubstrato.Text = "";
        }


        private void ValidarCampos()
        {
            do
            {
                if (txtNomeProducao.Text.ToString().Trim() == "") // .Trim() não permite que apenas espaços sejam inseridos e salvos
                {
                    MessageBox.Show("Preencha o campo 'Nome da produção'", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomeProducao.Text = "";
                    txtNomeProducao.Focus();
                    return;
                }

                if (txtInfoProducao.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("Preencha o campo 'Informações da produção'", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInfoProducao.Text = "";
                    txtInfoProducao.Focus();
                    return;
                }

                if (mskIniProducao.Text == "  /  /    " || mskIniProducao.Text.Length < 10)
                {
                    MessageBox.Show("Preencha o campo 'Início da produção'", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskIniProducao.Text = "";
                    mskIniProducao.Focus();
                    return;
                }

                if (mskTrocaSubstrato.Text == "(  )    -    " || mskTrocaSubstrato.Text.Length < 14)
                {
                    MessageBox.Show("Preencha o campo 'Troca de substrato'", "Cadastro de produção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mskTrocaSubstrato.Text = "";
                    mskTrocaSubstrato.Focus();
                    return;
                }
            } while (txtNomeProducao.Text == "" || txtInfoProducao.Text == "" || mskIniProducao.Text == "  /  /    " || mskTrocaSubstrato.Text == "  /  /    ");
        }

        private void DesabilitarCampos()
        {

            btnAltProd.Enabled = false;
            btnExcProd.Enabled = false;
            btnCancelar.Enabled = false;
            btnCadProd.Enabled = true;
        }

        private void nomeEmpresa_Click_1(object sender, EventArgs e)
        {
            Mush___Room.frmPrincipal frm = new Mush___Room.frmPrincipal();
            this.Hide();
            frm.Show();
        }

        private void logoEmpresa_Click_1(object sender, EventArgs e)
        {
            Mush___Room.frmPrincipal frm = new Mush___Room.frmPrincipal();
            this.Hide();
            frm.Show();
        }
        private void fornecedoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            telaFornecedores.fornecedores frm = new telaFornecedores.fornecedores();
            this.Hide();
            frm.Show();
        }

        private void comprasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            telaCompras.compras frm = new telaCompras.compras();
            this.Hide();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            telaProdutos.produtos frm = new telaProdutos.produtos();
            this.Hide();
            frm.Show();
        }

        private void txtNomeProducao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtInfoProducao_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
    }






