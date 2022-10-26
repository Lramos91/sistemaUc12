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

        public string caminho {get; private set;} = "Database/PessoaJuridica.csv";
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

        public void Inserir(PessoaJuridica pj){
            VerificarPastaArquivo(caminho);

            string[] pjstring = {$"{pj.nome}, {pj.cnpj}, {pj.RazaoSocial}"};

            File.AppendAllLines(caminho, pjstring);
        }

        public List<PessoaJuridica> Ler(){

            List<PessoaJuridica> listapj = new List<PessoaJuridica>();
            string[] linhas = File.ReadAllLines(caminho);

            foreach (string cadaLinha in linhas){
                string[] atributos = cadaLinha.Split(",");

                PessoaJuridica cadaPj = new PessoaJuridica();

                cadaPj.nome = atributos[0];
                cadaPj.cnpj = atributos [1];
                cadaPj.RazaoSocial = atributos[2];

                listapj.Add(cadaPj);
            }
            return listapj;
        }


    }
}