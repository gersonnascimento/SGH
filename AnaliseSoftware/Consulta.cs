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
    public partial class Consulta : Form
    {
        public static Paciente pacienteSelecionado;
        public Consulta()
        {
            InitializeComponent();
        }
        public bool vazio()
        {
            if (txtCpf.Text == "")
                return true;
            else return false;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (!vazio())
            {
                Paciente p = Dao.pegaPaciente(txtCpf.Text);
                if (p != null)
                {
                    pacienteSelecionado = p;
                    TriagemForm t = new TriagemForm();
                    t.preenchePaciente(p.nome, p.cpf, p.sexo);
                    this.Hide();
                    t.Show();
                }
                else
                {
                    CadastroPaciente c = new CadastroPaciente();
                    c.preencheCpf(this.txtCpf.Text);
                    this.Hide();
                    c.Show();
                }
            }
            else MessageBox.Show("Informe o cpf!");
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
