using Mush___Room.telaProducao;
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

namespace Mush___Room
{
    public partial class frmPrincipal : Form
    {

        Conexao con = new Conexao();
        string sql;
        SqlCommand cmd;
        string id;


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuProducao_Click(object sender, EventArgs e)
        {
            telaProducao.producao frm = new telaProducao.producao();
            this.Hide();
            frm.Show();
        }

        private void menuFornecedores_Click(object sender, EventArgs e)
        {
            telaFornecedores.fornecedores frm = new telaFornecedores.fornecedores();
            this.Hide();
            frm.Show();
        }

        private void menuProdutos_Click(object sender, EventArgs e)
        {
            telaProdutos.produtos frm = new telaProdutos.produtos();
            this.Hide();
            frm.Show();
        }

        private void menuCompras_Click(object sender, EventArgs e)
        {
            telaCompras.compras frm = new telaCompras.compras();
            this.Hide();
            frm.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ListarFornecedores();
            ListarProducao();
            ListarProdutos();
        }

        private void ListarFornecedores() //metodo para listar registros do bd na grid
        {
            con.AbrirConexao();
            sql = "SELECT * FROM TBfornecedores ORDER BY id_forn asc"; //select na tabela TBproducao pelo id em ordem crescente
            cmd = new SqlCommand(sql, con.con);
            SqlDataAdapter da = new SqlDataAdapter(); //o adapter recebe o nome de "da"
            da.SelectCommand = cmd; // o "da" recebe o comando de select 
            DataTable dt = new DataTable(); //aqui a tabela será listada
            da.Fill(dt); //"da" recebe os campos 
            gridFornecedoresPrincipal.DataSource = dt; //trazer a tabela para a grid
            con.FecharConexao();

            FormatarGDforn();
        }

        private void FormatarGDforn() //metodo para formatar a gridFornecedores
        {
            gridFornecedoresPrincipal.Columns[0].HeaderText = "ID";
            gridFornecedoresPrincipal.Columns[1].HeaderText = "Nome do fornecedor";
            gridFornecedoresPrincipal.Columns[2].HeaderText = "Nome do produto";
            gridFornecedoresPrincipal.Columns[3].HeaderText = "CNPJ";
            gridFornecedoresPrincipal.Columns[4].HeaderText = "Telefone";
            //gridProducao.Columns[5].HeaderText = "Data de registro"; preciso adicionar a data

            //gridProducao.Columns[0].Width = 500;
            //gridProducao.Columns[4].Width = 500;
            gridFornecedoresPrincipal.Columns[0].Visible = false;

            //gridProducao.Columns[5].Visible = false; parte de data que preciso adicionar


        }


        private void ListarProducao() //metodo para listar registros do bd na grid
        {
            con.AbrirConexao();
            sql = "SELECT * FROM TBproducao ORDER BY id_prod asc"; //select na tabela TBproducao pelo id em ordem crescente
            cmd = new SqlCommand(sql, con.con);
            SqlDataAdapter da = new SqlDataAdapter(); //o adapter recebe o nome de "da"
            da.SelectCommand = cmd; // o "da" recebe o comando de select 
            DataTable dt = new DataTable(); //aqui a tabela será listada
            da.Fill(dt); //"da" recebe os campos 
            gridProducaoPrincipal.DataSource = dt; //trazer a tabela para a grid
            con.FecharConexao();

            FormatarGDproducao();
        }

        private void FormatarGDproducao() //metodo para formatar a grid
        {
            gridProducaoPrincipal.Columns[0].HeaderText = "ID";
            gridProducaoPrincipal.Columns[1].HeaderText = "Nome da produção";
            gridProducaoPrincipal.Columns[2].HeaderText = "Informação da produção";
            gridProducaoPrincipal.Columns[3].HeaderText = "Início da produção";
            gridProducaoPrincipal.Columns[4].HeaderText = "Troca de substrato";
            //gridProducao.Columns[5].HeaderText = "Data de registro"; preciso adicionar a data

            //gridProducao.Columns[0].Width = 500;
            //gridProducao.Columns[4].Width = 500;
            gridProducaoPrincipal.Columns[0].Visible = false;

            //gridProducao.Columns[5].Visible = false; parte de data que preciso adicionar


        }

        private void ListarProdutos()
        {
            con.AbrirConexao();
            sql = "SELECT * FROM TBprodutos ORDER BY id_produto asc"; //select na tabela TBproducao pelo id em ordem crescente
            cmd = new SqlCommand(sql, con.con);
            SqlDataAdapter da = new SqlDataAdapter(); //o adapter recebe o nome de "da"
            da.SelectCommand = cmd; // o "da" recebe o comando de select 
            DataTable dt = new DataTable(); //aqui a tabela será listada
            da.Fill(dt); //"da" recebe os campos 
            gridProdutosPrincipal.DataSource = dt; //trazer a tabela para a grid
            con.FecharConexao();

            FormatarGDprodutos();
        }

        private void FormatarGDprodutos() //metodo para formatar a grid
        {
            gridProdutosPrincipal.Columns[0].HeaderText = "ID";
            gridProdutosPrincipal.Columns[1].HeaderText = "Nome do produto";
            gridProdutosPrincipal.Columns[2].HeaderText = "Informações do produto";
            gridProdutosPrincipal.Columns[3].HeaderText = "Quantidade Mínima";
            gridProdutosPrincipal.Columns[4].HeaderText = "Quantidade em estoque";
            //gridProducao.Columns[5].HeaderText = "Data de registro"; preciso adicionar a data

            //gridProducao.Columns[0].Width = 500;
            //gridProducao.Columns[4].Width = 500;
            gridProdutosPrincipal.Columns[0].Visible = false;


            //gridProducao.Columns[5].Visible = false; parte de data que preciso adicionar




        }


        private void gridFornecedoresPrincipal_DoubleClick(object sender, EventArgs e)
        {
            telaFornecedores.fornecedores frm = new telaFornecedores.fornecedores();
            this.Hide();
            frm.Show();
        }

        private void gridProducaoPrincipal_DoubleClick(object sender, EventArgs e)
        {
            telaProducao.producao frm = new telaProducao.producao();
            this.Hide();
            frm.Show();
        }

        private void gridProdutosPrincipal_DoubleClick(object sender, EventArgs e)
        {
            telaProdutos.produtos frm = new telaProdutos.produtos();
            this.Hide();
            frm.Show();
        }

        
    }
}
