using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Mush___Room
{
    public class Conexao{

        public string conec = @"Data Source=LUAN\SQLSERVER;integrated security=SSPI;initial catalog=BDcogumelos";
   
           public SqlConnection con = null;  //variavel com "poder" da conexao mysql


        public void AbrirConexao(){

            con = new SqlConnection(conec); //instanciando o "poder" da conexao mysql 
            con.Open(); //metodo para abrir a conexao
        }

                public void FecharConexao(){

            con = new SqlConnection(conec);//instanciando o "poder" da conexao sql
            con.Close(); //metodo para fechar a conexao
            con.Dispose(); //derruba algumas conexoes abertas
        }


    }
}
