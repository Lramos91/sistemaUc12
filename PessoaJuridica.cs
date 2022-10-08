using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sistemaUc12
{
    public class PessoaJuridica: Pessoa
    {
        public string cnpj {get; set;}
        public string RazaoSocial {get; set;}
        public override float PagarImposto(float rendimento){
            float Imposto =0;
            
            if (rendimento <= 5000)
          {
               Imposto = rendimento *6 / 100;
          }
          else if (rendimento > 5000 && rendimento <=10000)
          {
                Imposto = rendimento *8 / 100;
          }
          else if (rendimento > 10000)
          {
                Imposto = rendimento *10 / 100;
          }
          return Imposto;
        }

        public bool ValidarCNPJ(string cnpj){
            if(cnpj.Length >= 14 && (cnpj.Substring(cnpj.Length - 4)) == "0001"){
                return true;
            }else{
                return false;
            }
        }


    }
}