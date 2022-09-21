
namespace sistemaUc12
{
    
class program{

static void Main(string[] args)
     {
      /*
        Endereco end = new Endereco();
        end.logradouro = "Rua X";
        end.numero = 100;
        end.complemento = "Qualquer coisa";
        end.enderecoComercial = false;

        PessoaFisica pf = new PessoaFisica();
        pf.endereco = end;
        pf.nome = "Lucas";
        pf.cpf = "756577";
        pf.dataNascimento = new DateTime (1991, 06, 20);

      //interpolação
      Console.WriteLine($"Rua: {pf.endereco.logradouro},{pf.endereco.numero}");
      //concatenaçao
      Console.WriteLine("0 " + pf.nome + " mora na" + pf.endereco.logradouro );


      bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);

      if (idadeValida == true)
      {
        System.Console.WriteLine("Cadastro Aprovado com sucesso");
      }else{
        Console.WriteLine("Cadastro Reprovado");
      }


      */

      PessoaJuridica pj = new PessoaJuridica();

      Endereco end = new Endereco();
        end.logradouro = "Rua X";
        end.numero = 100;
        end.complemento = "Qualquer coisa";
        end.enderecoComercial = true;

        pj.endereco = end;
        pj.cnpj = "98765432110001";
        pj.RazaoSocial = "Pessoa Juridica";

        if (pj.ValidarCNPJ(pj.cnpj)){
          Console.WriteLine("cnpj valido");
        }else{
          Console.WriteLine("cnpj invalido");
        }
        


     }
    }
}