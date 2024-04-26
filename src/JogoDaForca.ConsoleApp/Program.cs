using System;

namespace JogoDaForca.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instancia um novo jogo
            pastaJogo.JogoDaForca jogo = new pastaJogo.JogoDaForca();

            // Inicia o jogo
            jogo.Iniciar();
        }
    }
}