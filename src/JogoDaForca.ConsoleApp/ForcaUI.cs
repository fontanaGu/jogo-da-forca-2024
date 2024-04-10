using System;
using System.Collections.Generic;

namespace JogoDaForca.ConsoleApp
{
    class ForcaUI
    {
        public void ApresentarInstrucoes()
        {
            // Apresenta as instruções do jogo
            Console.WriteLine("Bem vindo ao Jogo da Forca!");
            Console.WriteLine("O objetivo do jogo é acertar a palavra secreta.");
            Console.WriteLine("Você terá 5 tentativas para acertar a palavra secreta.");
            Console.WriteLine("Boa sorte!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        public void LimparTela()
        {
            // Limpa a tela
            Console.Clear();
        }

        public void ExibirForca()
        {
            // Exibe a forca com base no número de tentativas restantes
            int tentativas = 5;
            switch (tentativas)
            {
                case 5:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 4:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 3:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 2:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|   |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
                case 1:
                    Console.WriteLine("  +---+");
                    Console.WriteLine("  |   |");
                    Console.WriteLine("  O   |");
                    Console.WriteLine(" /|\\  |");
                    Console.WriteLine("      |");
                    Console.WriteLine("      |");
                    Console.WriteLine("=========");
                    break;
            }
        }

        public void ExibirPalavraSecreta(string palavraMascarada)
        {
            // Exibe a palavra secreta mascarada
            Console.WriteLine("Palavra: " + palavraMascarada);
        }

        public void ExibirLetrasErradas(List<char> letrasErradas)
        {
            // Exibe as letras erradas
            Console.Write("Letras erradas: ");
            foreach (char letra in letrasErradas)
            {
                Console.Write(letra + " ");
            }
            Console.WriteLine();
        }

        public void ExibirLetrasCorretas(List<char> letrasCorretas)
        {
            // Exibe as letras corretas
            Console.Write("Letras corretas: ");
            foreach (char letra in letrasCorretas)
            {
                Console.Write(letra + " ");
            }
            Console.WriteLine();
        }

        public void ExibirTentativasRestantes(int tentativasRestantes)
        {
            // Exibe o número de tentativas restantes
            Console.WriteLine("Tentativas restantes: " + tentativasRestantes);
        }

        public char ObterPalpite()
        {
            // Obtém o palpite do jogador
            Console.Write("Digite uma letra: ");
            char palpite = char.Parse(Console.ReadLine().ToUpper());
            return palpite;
        }

        public void ExibirMensagemVitoria(string palavra)
        {
            // Exibe mensagem de vitória
            Console.WriteLine("Parabéns! Você acertou a palavra secreta: " + palavra);
            Console.ReadKey();
        }

        public void ExibirMensagemDerrota(string palavra)
        {
            // Exibe mensagem de derrota
            Console.WriteLine("Que pena! Você perdeu. A palavra secreta era: " + palavra);
            Console.ReadKey();
        }
    }
}