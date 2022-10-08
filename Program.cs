
namespace sistemaUc12
{

    class program
    {

        static void Main(string[] args)
        {

          static void BarraCarregamento(string texto)
          {
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(texto);
            Thread.Sleep(500);

            for (var contador = 0; contador < 10; contador++)
            {
                Console.Write("#");
                Thread.Sleep(500);
            }

          }

            
            Console.WriteLine(@$"
=========================================
!                                       !
!         Bem vindo ao sistema de       !
!         cadastro de pessoas           !
!         Fisica e Juridica             !
!                                       !
!                                       !     
=========================================          
");
    BarraCarregamento("Iniciando ");



            string? opcao;
            do
            {
                Console.WriteLine(@$"
=========================================
!     Escolha uma das opções abaixo     !
=========================================
!          1 - Pessoa Física            !
!          2 - Pessoa Juridica          !
!                                       !
!          0 - Sair                     !     
=========================================          
");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                    Endereco endPF = new Endereco();

                    endPF.logradouro = "Rua Um";
                    endPF.numero= 999;
                    endPF.complemento = "Casa";
                    endPF.enderecoComercial = false;

                    PessoaFisica Lucas = new PessoaFisica();
                    Lucas.cpf = "44455566677";
                    Lucas.dataNascimento = new DateTime (1991, 06, 20);
                    Lucas.endereco = endPF;
                    Lucas.nome = "Lucas Ramos";
                    float impostoapagar = Lucas.PagarImposto(5600);


                    Console.WriteLine(@$"Imposto a pagar:{impostoapagar}
Nome: {Lucas.nome}
CPF: {Lucas.cpf}
Nascido em {Lucas.dataNascimento.ToString("dd/MM/yyyy")}
Endereço: {endPF.logradouro}, {endPF.numero}");


                    
                    Console.WriteLine ();
                        break;

                    case "2":
                    Endereco endPJ = new Endereco();

                    endPJ.logradouro = "Rua Um";
                    endPJ.numero= 999;
                    endPJ.complemento = "Casa";
                    endPJ.enderecoComercial = true;

                    PessoaJuridica pj = new PessoaJuridica();
                    pj.cnpj = "59965100000123";
                    pj.endereco = endPJ;
                    pj.RazaoSocial = "Pessoa Juridica";
                    pj.nome = "Empresa X";
                    float impostopj = pj.PagarImposto(5000);
                    Console.WriteLine(impostopj);

                    Console.WriteLine(pj.cnpj);
                        break;

                        
                    case "0":
                        Console.WriteLine("Agradecemos por usar nosso sistema");
                        BarraCarregamento("Finalizando ");

                        break;
                    default:
                        Console.WriteLine("Opção invalida, digite novamente uma das opções apresentadas");
                        break;
                }
            } while (opcao != "0");
            Console.ResetColor();


        }
    }
}