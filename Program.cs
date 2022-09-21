
namespace sistemaUc12
{
    
class program{

static void Main(string[] args)
     {

        Console.ForegroundColor = ConsoleColor.Green;
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

      Console.Write("Iniciando ");
      Thread.Sleep(500);

      for (var contador = 0; contador <10; contador++){
        Console.Write("#");
        Thread.Sleep(500);
      }

Console.Clear();
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
  
  switch (opcao){
    case "1":
    break;
    case "2":
    break;
    case "0":
    break;
    default:
    Console.WriteLine("Opção invalida, digite novamente uma das opções apresentadas");
    break;
  }
}while (opcao != "0");
      Console.ResetColor();


     }
    }
}