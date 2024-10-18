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

namespace Mush___Room.telaProdutos
{
    public partial class produtos : Form
    {

        Conexao con = new Conexao();
        string sql;
        SqlCommand cmd;
        string id;
        public produtos()
        {
            InitializeComponent();
        }

        private void produtos_Load(object sender, EventArgs e)
        {
            Listar();
            DesabilitarCampos();
        }

        private void Listar() //metodo para listar registros do bd na grid
        {
            con.AbrirConexao();
            sql = "SELECT * FROM TBprodutos ORDER BY id_produto asc"; //select na tabela TBproducao pelo id em ordem crescente
            cmd = new SqlCommand(sql, con.con);
            SqlDataAdapter da = new SqlDataAdapter(); //o adapter recebe o nome de "da"
            da.SelectCommand = cmd; // o "da" recebe o comando de select 
            DataTable dt = new DataTable(); //aqui a tabela será listada
            da.Fill(dt); //"da" recebe os campos 
            gridProdutos.DataSource = dt; //trazer a tabela para a grid
            con.FecharConexao();

            FormatarGD();
        }

        private void FormatarGD() //metodo para formatar a grid
        {
            gridProdutos.Columns[0].HeaderText = "ID";
            gridProdutos.Columns[1].HeaderText = "Nome do produto";
            gridProdutos.Columns[2].HeaderText = "Informações do produto";
            gridProdutos.Columns[3].HeaderText = "Quantidade Mínima";
            gridProdutos.Columns[4].HeaderText = "Quantidade em estoque";
            //gridProducao.Columns[5].HeaderText = "Data de registro"; preciso adicionar a data

            //gridProducao.Columns[0].Width = 500;
            //gridProducao.Columns[4].Width = 500;
            gridProdutos.Columns[0].Visible = false;


            //gridProducao.Columns[5].Visible = false; parte de data que preciso adicionar




        }

        private void DesabilitarCampos()
        {

            btnAltProduto.Enabled = false;
            btnExcProduto.Enabled = false;
            btnCancelar.Enabled = false;
            btnCadProduto.Enabled = true;
        }

        private void btnCadProduto_Click(object sender, EventArgs e)
        {



            //ValidarCampos();





            if (txtNomeProduto.Text.ToString().Trim() == "") // .Trim() não permite que apenas espaços sejam inseridos e salvos
            {
                MessageBox.Show("Preencha o campo 'Nome do produto'", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeProduto.Text = "";
                txtNomeProduto.Focus();
                return;
            }

            if (txtInfoProduto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo 'Informações do produto'", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInfoProduto.Text = "";
                txtInfoProduto.Focus();
                return;
            }

            if (txtQtdMin.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo 'Quantidade mínima'", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtdMin.Text = "";
                txtQtdMin.Focus();
                return;
            }

            if (txtQtdEst.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo 'Quantidade em estoque'", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtdEst.Text = "";
                txtQtdEst.Focus();
                return;
            }


            con.AbrirConexao();

            sql = "INSERT INTO TBprodutos(nome_produto, info_produto, quant_minima, quant_estoque) VALUES(@nome_produto, @info_produto, @quant_minima, @quant_estoque)";
            cmd = new SqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@nome_produto", txtNomeProduto.Text);
            cmd.Parameters.AddWithValue("@info_produto", txtInfoProduto.Text);
            cmd.Parameters.AddWithValue("@quant_minima", txtQtdMin.Text);
            cmd.Parameters.AddWithValue("@quant_estoque", txtQtdEst.Text);


            cmd.ExecuteNonQuery();
            con.FecharConexao();

            Listar();
            LimparCampos();

            MessageBox.Show("Registro salvo com sucesso!", "Cadastro de produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);


            LimparCampos();
        }



        private void btnAltProduto_Click(object sender, EventArgs e)
        {
            if (txtNomeProduto.Text.ToString().Trim() == "") // .Trim() não permite que apenas espaços sejam inseridos e salvos
            {
                MessageBox.Show("Preencha o campo 'Nome do produto'", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeProduto.Text = "";
                txtNomeProduto.Focus();
                return;
            }

            if (txtInfoProduto.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo 'Informações do produto'", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtInfoProduto.Text = "";
                txtInfoProduto.Focus();
                return;
            }

            if (txtQtdMin.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo 'Quantidade mínima'", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtdMin.Text = "";
                txtQtdMin.Focus();
                return;
            }

            if (txtQtdEst.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo 'Quantidade em estoque'", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtdEst.Text = "";
                txtQtdEst.Focus();
                return;
            }

            con.AbrirConexao();

            sql = "UPDATE TBprodutos SET nome_produto = @nome_produto, info_produto = @info_produto, quant_minima = @quant_minima, quant_estoque = @quant_estoque WHERE id_produto = @id_produto";

            cmd = new SqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@id_produto", id); //WHERE
            cmd.Parameters.AddWithValue("@nome_produto", txtNomeProduto.Text);
            cmd.Parameters.AddWithValue("@info_produto", txtInfoProduto.Text);
            cmd.Parameters.AddWithValue("@quant_minima", txtQtdMin.Text);
            cmd.Parameters.AddWithValue("@quant_estoque", txtQtdEst.Text);


            cmd.ExecuteNonQuery();
            con.FecharConexao();

            Listar();
            LimparCampos();

            MessageBox.Show("Registro alterado com sucesso!", "Alterar dados do produto", MessageBoxButtons.OK, MessageBoxIcon.Information);



        }

        private void btnExcProduto_Click(object sender, EventArgs e)
        {
            con.AbrirConexao();
            sql = "DELETE FROM TBprodutos WHERE id_produto = @id_produto";
            cmd = new SqlCommand(sql, con.con);
            cmd.Parameters.AddWithValue("@id_produto", id);
            cmd.ExecuteNonQuery();
            con.FecharConexao();

            Listar();
            LimparCampos();

            MessageBox.Show("Fornecedor deletado com sucesso!", "Excluir fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridProdutos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            habilitarCampos();
            btnCadProduto.Enabled = false;

            try
            {
                if (gridProdutos.SelectedRows.Count >= 0)
                {

                    id = gridProdutos.SelectedRows[0].Cells[0].Value.ToString();

                    txtNomeProduto.Text = gridProdutos.SelectedRows[0].Cells[1].Value.ToString();
                    txtInfoProduto.Text = gridProdutos.SelectedRows[0].Cells[2].Value.ToString();
                    txtQtdMin.Text = gridProdutos.SelectedRows[0].Cells[3].Value.ToString();
                    txtQtdEst.Text = gridProdutos.SelectedRows[0].Cells[4].Value.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleção inválida! Por favor, selecione a linha desejada com duplo clique.");
            }
        }

        private void habilitarCampos()
        {
            btnCadProduto.Enabled = true;
            btnExcProduto.Enabled = true;
            btnAltProduto.Enabled = true;
            btnCancelar.Enabled = true;

            txtNomeProduto.Enabled = true;
            txtInfoProduto.Enabled = true;
            txtQtdMin.Enabled = true;
            txtQtdEst.Enabled = true;
        }

        private void LimparCampos()
        {
            txtNomeProduto.Text = "";
            txtInfoProduto.Text = "";
            txtQtdMin.Text = "";
            txtQtdEst.Text = "";
        }


        private void ValidarCampos()
        {
            do
            {

                if (txtNomeProduto.Text.ToString().Trim() == "") // .Trim() não permite que apenas espaços sejam inseridos e salvos
                {
                    MessageBox.Show("Preencha o campo 'Nome do produto'", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomeProduto.Text = "";
                    txtNomeProduto.Focus();
                    return;
                }

                if (txtInfoProduto.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("Preencha o campo 'Informações do produto'", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtInfoProduto.Text = "";
                    txtInfoProduto.Focus();
                    return;
                }

                if (txtQtdMin.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("Preencha o campo 'Quantidade mínima'", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQtdMin.Text = "";
                    txtQtdMin.Focus();
                    return;
                }

                if (txtQtdEst.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("Preencha o campo 'Quantidade em estoque'", "Cadastro de produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQtdEst.Text = "";
                    txtQtdEst.Focus();
                    return;
                }

            } while (txtNomeProduto.Text == "" || txtInfoProduto.Text == "" || txtQtdMin.Text == "" || txtQtdEst.Text == "");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Text = "";
            txtInfoProduto.Text = "";
            txtQtdMin.Text = "";
            txtQtdEst.Text = "";

            DesabilitarCampos();
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

        private void produçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaProducao.producao frm = new telaProducao.producao();
            this.Hide();
            frm.Show();
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaFornecedores.fornecedores frm = new telaFornecedores.fornecedores();
            this.Hide();
            frm.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaCompras.compras frm = new telaCompras.compras();
            this.Hide();
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaProdutos.produtos frm = new telaProdutos.produtos();
            this.Hide();
            frm.Show();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtInfoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQtdMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQtdEst_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
