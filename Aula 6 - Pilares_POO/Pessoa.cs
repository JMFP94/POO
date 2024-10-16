using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_6___Pilares_POO
{
    internal class Pessoa:Colaborador
    {
    

        public Pessoa(int idadeParametro, string nomeParametro) 
        {
            this.idade=idadeParametro;
            this.nome = nomeParametro; 

        }
    }
}
