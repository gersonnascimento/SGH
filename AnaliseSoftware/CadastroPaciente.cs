using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AnaliseSoftware
{
    public partial class CadastroPaciente : Form
    {
        public string sexo;
        public int count = 0;

        public void preencheCpf(string cpf)
        {
            this.txtCpf.Text = cpf;
            this.txtCpf.Enabled = false;
        }
        public bool vazio()
        {
            if (txtNome.Text == "" || txtCpf.Text == "")
                return true;
            else if (this.sMasc.Checked == false && this.sFem.Checked == false)
            {
                count++;
                return true;
            }
            else return false;
        }
        public void limparTela()
        {
            this.txtNome.Text = "";
            this.txtCpf.Text = "";
            this.sMasc.Checked = false;
            this.sFem.Checked = false;
          
        }
        public CadastroPaciente()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (sMasc.Checked == true)
                sexo = "Masculino";
            else if (sFem.Checked == true)
                sexo = "Feminino";
            if (!vazio())
            {
                string res = Dao.InserirPaciente(txtNome.Text, txtCpf.Text, sexo);
                if ( res == "Paciente adicionado.")
                {
                    Paciente t = Dao.pegaPaciente(txtCpf.Text);
                    Consulta.pacienteSelecionado = new Paciente(t.id, txtNome.Text, txtCpf.Text, t.sexo);
                    TriagemForm tr = new TriagemForm();
                    tr.preenchePaciente(Consulta.pacienteSelecionado.nome,Consulta.pacienteSelecionado.cpf, Consulta.pacienteSelecionado.sexo);
                    this.Hide();
                    tr.Show();
                }
                else MessageBox.Show(res);
            }
            else if (count == 0)
                MessageBox.Show("Preencha todos os campos!");
            else MessageBox.Show("Escolha o sexo do paciente!");
            count = 0;
        }

        private void CadastroPaciente_Load(object sender, EventArgs e)
        {

        }
        //Exemplo de conexão para facilitar depois
        /*
        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(0, null, txtUsuario.Text, txtSenha.Text, null);


            MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbanalise");
            String sql = "select * from usuarios where login='" + usuario.getLogin() + "' and senha = '" + usuario.getSenha() + "'";

            MySqlCommand cnn = new MySqlCommand(sql, conn);


            conn.Open();

            MySqlDataReader dr = cnn.ExecuteReader();

            if (dr.Read())
            {
                if (txtUsuario.Text == "admin")
                {
                    Adm adm = new Adm();
                    this.Hide();
                    adm.Visible = true;
                }
                else
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.usu = Convert.ToInt16(dr["id"].ToString());
                    dashboard.Visible = true;
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Usuário ou senha inválidos!");



            cnn.Dispose();
            conn.Close();



            
            //Login provisório sem banco de dados
            if (txtUsuario.Text == "gerson" && txtSenha.Text == "123")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Visible = true;
                this.Hide();
            }
            else MessageBox.Show("Usuário ou senha inválidos");
            */
    }
    }
/*EXEMPLO PARA FAZER INSERT



 MySqlConnection conn = new MySqlConnection("server=localhost;uid=root;pwd='';database=dbanalise");
            String sql = "insert into softwares (idTipo,nome) values ("+ tipo +",'"+txtNome.Text+"')";

            MySqlCommand cnn = new MySqlCommand(sql, conn);


            if (!campoVazio())
            {
                conn.Open();
                try
                {

                    cnn.ExecuteNonQuery();
                    cnn.Dispose();
                    conn.Close();
                    MessageBox.Show("Software cadastrado com sucesso!!");
                    this.limpaTxt();
                }
                catch (Exception)
                {
                    MessageBox.Show("Não foi possível cadastrar");
                    throw;
                }
            }
            else MessageBox.Show("Por favor, preencha todos os campos solicitados.");
*/
