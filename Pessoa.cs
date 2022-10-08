using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaUc12
{
    public abstract class Pessoa
    {
        //Atributos
        public string? nome { get; set; }
        public Endereco endereco { get; set; }
        //Metodos
        public abstract float PagarImposto(float rendimento);

        
        
    }
}

