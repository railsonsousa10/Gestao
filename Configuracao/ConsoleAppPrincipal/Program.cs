using BLL;
using Models;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

internal class Program

{

    private static void Main(string[] args)
    {
        int opcao = 0;

        Console.WriteLine("Escolha uma opcão: ");
        Console.WriteLine("1 - Cadastrar usuário: ");
        Console.WriteLine("2 - Excluir usuário: ");
        Console.WriteLine("3 - Buscar todos os usuário: ");

        opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                CadastrarUsuario();
                break;
            case 2:
                ExcluirUsuario();
                break;
            case 3:
                BuscarTodosOsUsuarios();
                break;

        }

    }
    private static void BuscarTodosOsUsuarios()
    {
        try
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            List<Usuario> usuarios = usuarioBLL.BuscarTodos();

            foreach (Usuario item in usuarios)

            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("Nome de Usuário: " + item.NomeUsuario);
                Console.WriteLine("E-mail: " + item.Email);
            }

        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    private static void CadastrarUsuario()
    {
        try
        {
            Usuario usuario = new Usuario();
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            usuario.Nome = "Railson Sousa Silva";
            usuario.NomeUsuario = "railson";

            Console.WriteLine("O usuário estará ativo (S) ou (N)");
            usuario.Ativo = true;

            usuario.Email = "railsonsousa846@gmail.com.br";
            usuario.CPF = "058.712.611-67";
            usuario.Senha = "ra49832";

            usuarioBLL.Inserir(usuario);

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
    private static void ExcluirUsuario()
    {

    }
}