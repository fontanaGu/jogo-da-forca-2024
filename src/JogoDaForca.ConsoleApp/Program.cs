using System;

namespace JogoDaForca.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia um novo jogo
            JogoDaForca jogo = new JogoDaForca();

            // Inicia o jogo
            jogo.Iniciar();
        }
    }
}