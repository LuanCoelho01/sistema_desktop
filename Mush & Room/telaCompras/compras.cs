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

namespace Mush___Room.telaCompras
{
    public partial class compras : Form
    {

        Conexao con = new Conexao();
        string sql;
        SqlCommand cmd;
        string id;


        public compras()
        {
            InitializeComponent();
        }

        private void compras_Load(object sender, EventArgs e)
        {
            Listar();
            DesabilitarCampos();
        }

        private void Listar() //metodo para listar registros do bd na grid
        {
            con.AbrirConexao();
            sql = "SELECT * FROM TBcompras ORDER BY id_compra asc"; //select na tabela TBproducao pelo id em ordem crescente
            cmd = new SqlCommand(sql, con.con);
            SqlDataAdapter da = new SqlDataAdapter(); //o adapter recebe o nome de "da"
            da.SelectCommand = cmd; // o "da" recebe o comando de select 
            DataTable dt = new DataTable(); //aqui a tabela será listada
            da.Fill(dt); //"da" recebe os campos 
            gridCompras.DataSource = dt; //trazer a tabela para a grid
            con.FecharConexao();

            FormatarGD();
        }

        private void FormatarGD() //metodo para formatar a grid
        {
            gridCompras.Columns[0].HeaderText = "ID";
            gridCompras.Columns[1].HeaderText = "Nome do fornecedor";
            gridCompras.Columns[2].HeaderText = "Produto comprado";
            gridCompras.Columns[3].HeaderText = "Quantidade comprada";
            gridCompras.Columns[4].HeaderText = "Valor total";
            //gridProducao.Columns[5].HeaderText = "Data de registro"; preciso adicionar a data

            //gridProducao.Columns[0].Width = 500;
            //gridProducao.Columns[4].Width = 500;
            gridCompras.Columns[0].Visible = false;


            //gridProducao.Columns[5].Visible = false; parte de data que preciso adicionar
        }

        private void DesabilitarCampos()
        {

            btnAltCompra.Enabled = false;
            btnCancelar.Enabled = false;
            btnRegCompra.Enabled = true;
        }

        private void btnRegCompra_Click(object sender, EventArgs e)
        {

            //ValidarCampos();





            if (txtNomeFornecedor.Text.ToString().Trim() == "") // .Trim() não permite que apenas espaços sejam inseridos e salvos
            {
                MessageBox.Show("Preencha o campo 'Nome do fornecedor'", "Registrar compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeFornecedor.Text = "";
                txtNomeFornecedor.Focus();
                return;
            }

            if (txtProdComprado.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo 'Produto comprado'", "Registrar compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProdComprado.Text = "";
                txtProdComprado.Focus();
                return;
            }

            if (txtQtdComprada.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo 'Quantidade comprada'", "Registrar compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtdComprada.Text = "";
                txtQtdComprada.Focus();
                return;
            }

            if (txtValorTotal.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo 'Valor total'", "Registrar compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorTotal.Text = "";
                txtValorTotal.Focus();
                return;
            }


            con.AbrirConexao();

            sql = "INSERT INTO TBcompras(nome_fornecedor, produto_comprado, qtd_comprada, valor_total) VALUES(@nome_fornecedor, @produto_comprado, @qtd_comprada, @valor total)";
            cmd = new SqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@nome_fornecedor", txtNomeFornecedor.Text);
            cmd.Parameters.AddWithValue("@produto_comprado", txtProdComprado.Text);
            cmd.Parameters.AddWithValue("@qtd_comprada", txtQtdComprada.Text);
            cmd.Parameters.AddWithValue("@valor_total", txtValorTotal.Text);


            cmd.ExecuteNonQuery();
            con.FecharConexao();

            Listar();
            LimparCampos();

            MessageBox.Show("Registro salvo com sucesso!", "Registro de compras", MessageBoxButtons.OK, MessageBoxIcon.Information);


            LimparCampos();
        }


        private void btnAltCompra_Click(object sender, EventArgs e)
        {
            if (txtNomeFornecedor.Text.ToString().Trim() == "") // .Trim() não permite que apenas espaços sejam inseridos e salvos
            {
                MessageBox.Show("Preencha o campo 'Nome do fornecedor'", "Registrar compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeFornecedor.Text = "";
                txtNomeFornecedor.Focus();
                return;
            }

            if (txtProdComprado.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo 'Produto comprado'", "Registrar compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProdComprado.Text = "";
                txtProdComprado.Focus();
                return;
            }

            if (txtQtdComprada.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo 'Quantidade comprada'", "Registrar compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtdComprada.Text = "";
                txtQtdComprada.Focus();
                return;
            }

            if (txtValorTotal.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo 'Valor total'", "Registrar compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorTotal.Text = "";
                txtValorTotal.Focus();
                return;
            }

            con.AbrirConexao();

            sql = "UPDATE TBcompras SET nome_fornecedor = @nome_fornecedor, produto_comprado = @produto_comprado, qtd_comprada = @qtd_comprada, valor_total = @valor_total WHERE id_compra = @id_compra";

            cmd = new SqlCommand(sql, con.con);

            cmd.Parameters.AddWithValue("@id_compra", id); //WHERE
            cmd.Parameters.AddWithValue("@nome_fornecedor", txtNomeFornecedor.Text);
            cmd.Parameters.AddWithValue("@produto_comprado", txtProdComprado.Text);
            cmd.Parameters.AddWithValue("@qtd_comprada", txtQtdComprada.Text);
            cmd.Parameters.AddWithValue("@valor_tota", txtValorTotal.Text);


            cmd.ExecuteNonQuery();
            con.FecharConexao();

            Listar();
            LimparCampos();

            MessageBox.Show("Registro alterado com sucesso!", "Alterar dados de compra", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void gridCompras_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            habilitarCampos();
            btnRegCompra.Enabled = false;

            try
            {
                if (gridCompras.SelectedRows.Count >= 0)
                {

                    id = gridCompras.SelectedRows[0].Cells[0].Value.ToString();

                    txtNomeFornecedor.Text = gridCompras.SelectedRows[0].Cells[1].Value.ToString();
                    txtProdComprado.Text = gridCompras.SelectedRows[0].Cells[2].Value.ToString();
                    txtQtdComprada.Text = gridCompras.SelectedRows[0].Cells[3].Value.ToString();
                    txtValorTotal.Text = gridCompras.SelectedRows[0].Cells[4].Value.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleção inválida! Por favor, selecione a linha desejada com duplo clique.");
            }
        }

        private void habilitarCampos()
        {
            btnRegCompra.Enabled = true;
            btnAltCompra.Enabled = true;
            btnCancelar.Enabled = true;

            txtNomeFornecedor.Enabled = true;
            txtProdComprado.Enabled = true;
            txtQtdComprada.Enabled = true;
            txtValorTotal.Enabled = true;
        }

        private void LimparCampos()
        {
            txtNomeFornecedor.Text = "";
            txtProdComprado.Text = "";
            txtQtdComprada.Text = "";
            txtValorTotal.Text = "";
        }


        private void ValidarCampos()
        {
            do
            {

                if (txtNomeFornecedor.Text.ToString().Trim() == "") // .Trim() não permite que apenas espaços sejam inseridos e salvos
                {
                    MessageBox.Show("Preencha o campo 'Nome do fornecedor'", "Registrar compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNomeFornecedor.Text = "";
                    txtNomeFornecedor.Focus();
                    return;
                }

                if (txtProdComprado.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("Preencha o campo 'Produto comprado'", "Registrar compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProdComprado.Text = "";
                    txtProdComprado.Focus();
                    return;
                }

                if (txtQtdComprada.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("Preencha o campo 'Quantidade comprada'", "Registrar compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQtdComprada.Text = "";
                    txtQtdComprada.Focus();
                    return;
                }

                if (txtValorTotal.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("Preencha o campo 'Valor total'", "Registrar compra", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtValorTotal.Text = "";
                    txtValorTotal.Focus();
                    return;
                }

            } while (txtNomeFornecedor.Text == "" || txtProdComprado.Text == "" || txtQtdComprada.Text == "" || txtValorTotal.Text == "");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomeFornecedor.Text = "";
            txtProdComprado.Text = "";
            txtQtdComprada.Text = "";
            txtValorTotal.Text = "";

            DesabilitarCampos();
        }

        private void nomeEmpresa_Click(object sender, EventArgs e)
        {
            Mush___Room.frmPrincipal frm = new Mush___Room.frmPrincipal();
            this.Hide();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        //private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            telaProdutos.produtos frm = new telaProdutos.produtos();
            this.Hide();
            frm.Show();
        }

        private void relatóriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProdComprado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQtdComprada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtValorTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
