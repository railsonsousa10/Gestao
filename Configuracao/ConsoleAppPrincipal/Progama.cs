using BLL;
using Models;

internal class Program
{
        private static void Main(string[] args)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuario = new Usuario();
            usuario.Nome = "Railson Sousa Silva";
            usuario.NomeUsuario = "railson";
            usuario.Ativo = true;
            usuario.Email = "railsonsousa846@gmail.com";
            usuario.CPF = "058.712.611-67";
            usuario.Senha = "123";
            usuarioBLL.Inserir(usuario);
        }
}
