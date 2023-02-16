using BLL;
using Models;

internal class Program
{
  
    private static void Main(string[] args)
    {

        try
        {
            string opc;

            UsuarioBLL usuarioBLL = new UsuarioBLL();
            UsuarioBLL usuarioBLL1 = new UsuarioBLL();

            do
            {
                Console.WriteLine("Informe os dados: ");

                Usuario usuario = new Usuario();

                Console.WriteLine("Didite o nome completo: ");
                usuario.Nome = Console.ReadLine();

                Console.WriteLine("Digite o nome de usuario: ");
                usuario.NomeUsuario = Console.ReadLine();

                Console.WriteLine("Usuário [Ativo-(S)] ou [Desativado-(N)]");
                char opcao = Convert.ToChar(Console.ReadLine());

                if (opcao != 'S')
                
                    usuario.Ativo = true;
                else
                    usuario.Ativo = false;
                                                        
                Console.WriteLine("Digite o E-mail: ");
                usuario.Email = Console.ReadLine();

                Console.WriteLine("Digite o CPF: ");
                usuario.CPF = Console.ReadLine();

                Console.WriteLine("Digite uma Senha: ");
                usuario.Senha = Console.ReadLine();


                Console.WriteLine("Deseje cadastra outra pessoa: (S)-SIM (N)-NÃO ");
                opc = Console.ReadLine().ToUpper();

                usuarioBLL.Inserir(usuario);

            } while (opc == "S" );


        }

        catch (Exception ex)

        { 
        Console.WriteLine(ex.Message);
        }
    } 
}
