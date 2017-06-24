using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnaliseSoftware
{
    public partial class TriagemForm : Form
    {

        public bool vazio()
        {
            if (this.txtDescricao.Text == "" || this.txtTemperatura.Text == "" || this.txtPressao.Text == "")
                return true;
            else return false;
        }
        public void atTipo()//atribuir tipo do paciente para a variavel estática fila na classe Dao.
        {
            if (comum.Checked == true)
                Dao.fila = "COM";
            else if (preferencial.Checked == true)
                Dao.fila = "PRE";
            else if (emergencia.Checked == true)
                Dao.fila = "EME";
        }
        public void preenchePaciente(string nome, string cpf, string sexo)
        {
            this.lblNome.Text = nome;
            this.lblCpf.Text = cpf;
            this.lblSexo.Text = sexo;
        }
        public TriagemForm()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (!vazio())
            {
                atTipo();
                string alergia;
                if (sim.Checked == true)
                {
                    alergia = txtMedicamento.Text;
                }
                else if (nao.Checked == true)
                    alergia = "Não";
                else alergia = "Não informado";

                string tipo = "COM";

                string result = Dao.inserirTriagem(Consulta.pacienteSelecionado.id, txtDescricao.Text, txtPressao.Text, txtTemperatura.Text, alergia, tipo);
                if (result == "Triagem Cadastrada.")
                {
                   
                    int idt = Dao.pegaNfila(Dao.pegaTriagem().id);//id da triagem para gerar a senha;
                    
                    string nSenha;
                    if (idt <= 9)
                        nSenha = Dao.fila + "000" + idt;
                    else if (idt <= 99)
                        nSenha = Dao.fila + "00" + idt;
                    else if (idt < 999)
                        nSenha = Dao.fila + "0" + idt;
                    else nSenha = Convert.ToString(idt);

                    MessageBox.Show("Senha do paciente: " + nSenha);

                    Consulta c = new Consulta();
                    c.Show();
                    this.Hide();
                    Consulta.pacienteSelecionado = null;
                }
                else MessageBox.Show(result);
            }
            else MessageBox.Show("Preencha todos os Campos.");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
