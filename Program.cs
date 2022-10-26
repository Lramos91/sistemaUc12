
namespace sistemaUc12
{

    class program
    {

        static void Main(string[] args)
        {
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();


            List<PessoaFisica> listaPf = new List<PessoaFisica>();
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
!                                       !
!            PESSOA FISICA              !
!     1 - Cadastrar Pessoa Física       !
!     2 - Listar Pessoa Física          !
!     3 - Remover Pessoa Física         !
!                                       !          
!            PESSOA JURIDICA            !
!     4 - Cadastrar Pessoa Juridica     !
!     5 - Listar Pessoa Juridica        !
!     6 - Remover Pessoa Juridica       !                                       
=========================================
!              0 - Sair                 !     
=========================================          
");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        PessoaFisica pf = new PessoaFisica();
                        /*
                        //Cadastrar pessoa fisica
                        Endereco endPf = new Endereco();
                        Console.WriteLine("Digite seu logradouro");
                        endPf.logradouro = Console.ReadLine();

                        Console.WriteLine("Digite o número da sua residencia");
                        endPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine(@$"Digite o complemento da sua residencia (caso exista), senao,
                        digite enter para seguir");
                        endPf.complemento = Console.ReadLine();

                        Console.WriteLine("Este endereco é comercial? (S = SIM / N= NÃO");
                        string endComercial = Console.ReadLine().ToUpper();

                        if(endComercial == "S"){
                            endPf.enderecoComercial = true;
                        }else{
                            endPf.enderecoComercial = false;
                        }


                        pf.endereco = endPf;

 */
                        
   
                        Console.WriteLine("Digite seu Nome");
                        pf.nome = Console.ReadLine();
                        
                        Console.WriteLine("Digite seu CPF (Somente Numeros");
                        pf.cpf = Console.ReadLine();

                        //  Console.WriteLine("Digite o valor de seu salário");
                        // pf.salario = float.Parse(Console.ReadLine());

                        //  Console.WriteLine("Digite sua data denascimento [AA, MM, DD]");
                        //  pf.dataNascimento = DateTime.Parse(Console.ReadLine());

                        //  bool idadeValida = pf.ValidarDataNascimento(pf.dataNascimento);

                        //  if(idadeValida == true){
                        //      Console.WriteLine("Cadastro aprovado");
                        //      listaPf.Add(pf);
                        //      Console.WriteLine(pf.PagarImposto(pf.salario));
                        //  }
                        //StreamWriter sw = new StreamWriter($"{pf.nome}.txt");
                        //sw.Write($"{pf.nome}");
                        //sw.Close();

                        using (StreamWriter sw = new StreamWriter($"{pf.nome}.txt"))
                        {
                            sw.Write($"O nome do usuario é: {pf.nome}, o cpf é: {pf.cpf}");
                        }


                        break;
                    case "2":
                        //foreach (var cadaItem in listaPf)
                        //{
                        //    Console.WriteLine($"{cadaItem.nome}, {cadaItem.cpf}");
                       // }

                       Console.WriteLine("Digite o nome da pessoa a ser consultado");
                       string pessoa = Console.ReadLine();

                       using(StreamReader sr = new StreamReader($"{pessoa}.txt")){
                        string linha;
                        while ((linha = sr.ReadLine()) != null){
                            Console.WriteLine($"{linha}");
                        }
                        
                       }
                       Console.WriteLine($"Aperte 'Enter' para continuar");
                       Console.ReadLine();
                        break;
                    case "3":
                        //Remover pessoa fisica
                        Console.WriteLine("Digite o CPF da pessoa a ser removida");
                        string cpfProcurado = Console.ReadLine();
                        PessoaFisica pessoaEncontrada = listaPf.Find(cadaItem => cadaItem.cpf == cpfProcurado);

                        if (pessoaEncontrada != null)
                        {
                            listaPf.Remove(pessoaEncontrada);
                            Console.WriteLine("Cadastro removido");
                        }
                        else
                        {
                            Console.WriteLine("CPF não encontrado");
                        }

                        break;
                    case "4":
                        //Cadastrar pessoa juridica

                        novaPj.nome = "Nome PJ";
                        novaPj.cnpj = "00.000.000/0001-00";
                        novaPj.RazaoSocial = "Razao Social Pj";

                        novoEndPj.logradouro = "Alameda Barão de Limeira";
                        novoEndPj.numero = 539;
                        novoEndPj.complemento = "SENAI Informatica";
                        novoEndPj.enderecoComercial = true;

                        novaPj.endereco = novoEndPj;

                        metodoPj.Inserir(novaPj);


                        break;
                    case "5":
                        //Listar pessoa juridica
                        List<PessoaJuridica> listapj = metodoPj.Ler();
                        foreach(PessoaJuridica cadaItem in listapj){
                            Console.Clear();
                            Console.WriteLine(@$"
                            Nome: {novaPj.nome}
                            Razao Social: {novaPj.RazaoSocial}
                            CNPJ: {novaPj.cnpj}
                            ");
                            
                        }
                        Console.WriteLine($"Aperte 'Enter' para continuar");
                        Console.ReadLine();
                        break;
                    case "6":
                        //Remover pessoa juridica
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