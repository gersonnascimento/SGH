using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AnaliseSoftware
{
    public static class Dao
    {

        public static MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbsenhahospital");
        public static DateTime agora = DateTime.Now;
        public static string fila;
        public static string dataEhora;
        public static void conectar()
        {
            conn.Open();
        }


        public static string InserirPaciente(string nome, string cpf, string sexo)
        {
            string msgRetorno;
            conectar();
            String sql = "insert into paciente (nome, cpf, sexo) values ('" + nome + "','" + cpf + "','"+sexo+"')";

            MySqlCommand cnn = new MySqlCommand(sql, conn);

                try
                {

                    cnn.ExecuteNonQuery();
                    cnn.Dispose();
                    conn.Close();
                   msgRetorno = "Paciente adicionado.";
                return msgRetorno;
                }
                catch (Exception)
                {
                    msgRetorno="Não foi possível cadastrar.";
                fecharConexao();
                return msgRetorno;
                throw;
                
            }
            }

        //CONSULTAR PACIENTE NO BANCO DE DADOS POR CPF

        public static Paciente pegaPaciente(string cpf)
        {
            Paciente paciente;
            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbsenhahospital");
            

            String sql = "select * from paciente where cpf = '"+ cpf+"'";

            MySqlCommand cnn = new MySqlCommand(sql, conn);

            conn.Open();

            MySqlDataReader dr = cnn.ExecuteReader();

            if (dr.Read())
            {
                fecharConexao();
                paciente = new Paciente(Convert.ToInt16(dr["id"]), dr["nome"].ToString(), dr["cpf"].ToString(), dr["sexo"].ToString());
                return paciente;
            }
            else
                fecharConexao();
            return null; 
        }

        //INSERIR TRIAGEM   

        public static string inserirTriagem(int idpaciente, string descricao, string pressao, string temperatura, string alergia, string tipo)
        {
            string msgRetorno;
            agora = DateTime.Now;
            dataEhora = agora.ToString("dd/MM/yyyy HH:mm:ss");
            conectar();
            String sql = "insert into triagem (idpaciente, descricao, pressao, temperatura, data , alergia, tipo) values (" + idpaciente + ",'" + descricao + "','" + pressao + "','" + temperatura + "','" + dataEhora +"','"+ alergia+ "','" + tipo + "')";

            MySqlCommand cnn = new MySqlCommand(sql, conn);

            try
            {

                cnn.ExecuteNonQuery();
                cnn.Dispose();
                conn.Close();
                msgRetorno = "Triagem Cadastrada.";
                triagemNaFila(fila, pegaTriagem().id);
                fecharConexao();
                return msgRetorno;
            }
            catch (Exception)
            {
                msgRetorno = "Não foi possível cadastrar a triagem";
                fecharConexao();
                return msgRetorno;
                throw;
            }
        }

        //INSERE TRIAGEM NA FILA CORRETA.


            public static void triagemNaFila(string fila, int id)
        {
          
            conectar();
            String sql = "insert into "+fila+" (idTriagem) values ("+id+")";

            MySqlCommand cnn = new MySqlCommand(sql, conn);

            try
            {

                cnn.ExecuteNonQuery();
                cnn.Dispose();
                conn.Close();

            }
            catch (Exception)
            {
                
                fecharConexao();

                throw;
            }
        }



        //BUSCAR TRIAGEM NO BANCO

            public static Triagem pegaTriagem()
        {
            Triagem triagem;
            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbsenhahospital");


            String sql = "select * from triagem where data = '" + dataEhora + "'";

            MySqlCommand cnn = new MySqlCommand(sql, conn);

            conn.Open();

            MySqlDataReader dr = cnn.ExecuteReader();

            if (dr.Read())
            {
                fecharConexao();
                triagem = new Triagem(Convert.ToInt16(dr["id"]), Convert.ToInt16(dr["idpaciente"]), dr["descricao"].ToString(), dr["pressao"].ToString(), dr["temperatura"].ToString(), dr["alergia"].ToString(), dr["data"].ToString(), dr["tipo"].ToString());
                return triagem;
            }
            else
                fecharConexao();
            return null;
        }

        //PEGAR CÓDIGO DA FILA PARA GERAR SENHA DO ATENDIMENTO.

            public static int pegaNfila(int nTriagem)
        {
           
            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbsenhahospital");


            String sql = "select * from "+ fila +" where idTriagem = " + nTriagem ;

            MySqlCommand cnn = new MySqlCommand(sql, conn);

            conn.Open();

            MySqlDataReader dr = cnn.ExecuteReader();

            if (dr.Read())
            {
                fecharConexao();
                return Convert.ToInt16(dr["id"]);
            }
            else
                fecharConexao();
            return 0;
        }

        public static void fecharConexao()
        {
            conn.Close();
        }
    }
}
