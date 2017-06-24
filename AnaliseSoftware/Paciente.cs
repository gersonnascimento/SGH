using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseSoftware
{
    public class Paciente
    {
        public int id;
        public string nome;
        public string cpf;
        public string sexo;

        public Paciente(int id, string nome, string cpf, string sexo)
        {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;
            this.sexo = sexo;
        }
    }
}
