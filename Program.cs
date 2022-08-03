
namespace sistemaUc12
{
    
class program{

static void Main(string[] args)
     {
        Pessoa lucas = new Pessoa ();
        Pessoa caique = new Pessoa ();
        Pessoa andre = new Pessoa ();
        Pessoa daniel = new Pessoa ();

        lucas.Endereco = "rua x";
        lucas.nome = "lucas ramos";

        Console.WriteLine(lucas.Endereco);
        Console.WriteLine(lucas.nome);

     }
    }
}