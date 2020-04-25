using System;
using System.Collections.Generic;
using System.Text;

namespace TrabalhandoComTasks.UI
{
    public class GenericUI
    {
        public static string ShowTelaInicial()
        {
            Console.Clear();
            Console.WriteLine("######## Sistema #######");
            Console.WriteLine("");
            Console.WriteLine(" 1. Para gerenciar pessoas");
            Console.WriteLine(" 2. Para gerenciar grupos");
            Console.WriteLine(" X - Sair");
            Console.WriteLine("");
            return Console.ReadLine();
        }

        public static string ShowOpcoes(string titulo)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(titulo);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");

            Console.WriteLine(" 1. Cadastrar ");
            Console.WriteLine(" 2. Editar ");
            Console.WriteLine(" 3. Excluir ");
            Console.WriteLine(" 4. Lista ");
            Console.WriteLine(" X  Voltar");
            Console.WriteLine("");

            return Console.ReadLine();
        }
    }
}
