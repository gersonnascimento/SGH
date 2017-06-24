using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnaliseSoftware
{
    public class Triagem
    {
        public int id;
        public int idPaciente;
        public string descricao;
        public string pressao;
        public string temperatura;
        public string alergia;
        public string data;
        public string tipo;
       
        public Triagem(int id, int idpaciente, string descricao, string pressao, string temperatura, string alergia, string data, string tipo)
        {
            this.id = id;
            this.idPaciente = idpaciente;
            this.descricao = descricao;
            this.pressao = pressao;
            this.temperatura = temperatura;
            this.alergia = alergia;
            this.data = data;
            this.tipo = tipo;
    }

    }

}
