using System;

namespace LOGIN
{
    class Program
    {
        static void Main(string[] args)
        {
            string usuario_correto = "marcos";
            string senha_correta = "gv";

            string usuario_digitado;
            string senha_digitada;

            int MAX_NUM_tentativas = 3;

            for (int i = 1; i < MAX_NUM_tentativas; i++)
            {
                Console.Clear();

                Console.WriteLine("LOGIN DO SISTEMA");
                Console.WriteLine("Digite seu nome: ");
                usuario_digitado = Console.ReadLine();

                Console.WriteLine("Digite sua senha: ");
                senha_digitada = Console.ReadLine();

                if (usuario_digitado == usuario_correto && senha_correta == senha_digitada)
                {
                    Console.Clear();
                    Console.WriteLine("Parabens! Deu certo! Bem vindo ao sistema.");
                    break;

                }
                else
                {
                    Console.WriteLine("Dados incorretos :) ");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Sair do sistemas? S/n?");

                    if (Console.ReadLine().ToUpper() == "S")
                        break;
                }


                Console.WriteLine("Vc saiu do loop while");
            }
        }
    }
}
