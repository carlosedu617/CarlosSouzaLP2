using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UltimoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
           
            while (true)
            {
                if (usuario == null)
                {
                    LogicaPrincipal();
                    UsuarioLogado();
                }
                Console.WriteLine("Você deseja fazer o que ?");
                Console.WriteLine("1 - Nada");
                Console.WriteLine("2 - Logout");

                var opcao = int.Parse(Console.ReadLine());
                if (opcao == 2)
                {
                    Logout();
                }
            }
           
        }

        private static void Logout()
        {
            usuario.DataUltAcesso = DateTime.Now;
            BancoDeDados bd = new BancoDeDados();
            bd.UpdateData(usuario);
            Console.WriteLine("Até mais tarde "+usuario.Nome+" !");
            usuario = null;
            login = string.Empty;
            pwd = string.Empty;
        }

        private static void UsuarioLogado()
        {
            Console.WriteLine("Seja bem-vindo "+usuario.Nome+"!");
            Console.WriteLine("Seu último acesso foi em : " + usuario.DataUltAcesso);
           

        }

        private static void LogicaPrincipal()
        {
            Console.WriteLine("Seja bem-vindo!");
            while (usuario == null)
            {
                MenuPrincipal();
                if (string.IsNullOrEmpty(login)||string.IsNullOrEmpty(pwd))
                {
                    ExibirErroDeLogin();
                    continue;
                }
                usuario = VerificarLogin();
                if (usuario == null)
                {
                    ExibirErroDeLogin();
                }
            }
        }

        private static void ExibirErroDeLogin()
        {
            Console.WriteLine("Login ou senha incorretos. Tente novamente!");
        }

        private static Usuario usuario;
        private static string login;
        private static string pwd;
       
        public static void MenuPrincipal()
        {
         
            Console.WriteLine("Insira seu Login e Senha para entrar no sistema.");
            Console.WriteLine("Login:");
            login = Console.ReadLine();
            Console.WriteLine("Senha:");
            pwd = Console.ReadLine();
        }

        public static Usuario  VerificarLogin()
        {
            BancoDeDados bd = new BancoDeDados();
            MySqlDataReader reader = bd.PegarDados(login,pwd);
            reader.Read();
            if (!reader.HasRows)
            {
                return null;
            }
            Usuario user = new Usuario(reader);
            reader.Close();
            return user;
        }
    }
}
