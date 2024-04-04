namespace JogoDaForca.ConsoleApp
{
    internal class Program

    {
        static void Main(string[] args)
        {
            // Nosso próximo desafio é desenvolver um jogo de forca. O computador escolherá, de maneira aleatória, uma palavra entre várias possibilidades*, e o jogador deve chutar, letra por letra, até adivinhá-la.
            // Se o jogador chutar 5 letras erradas, ele perde.
            // Se o jogador adivinhar a palavra antes de chutar 5 letras erradas, ele vence.

            // Introdução ao usuario com instruções
            Console.WriteLine("Bem vindo ao Jogo da Forca!");
            Console.WriteLine("O objetivo do jogo é acertar a palavra secreta.");
            Console.WriteLine("Você terá 5 tentativas para acertar a palavra secreta.");
            Console.WriteLine("Boa sorte!");
            Console.WriteLine("Pressione qualquer tecla para continuar...");
            Console.ReadKey();

            // Palavras secretas
            string[] palavrasSecretas = { "acabacate", "abacaxi", "acerola", "açai", "araça", "bacaba", "bacuri",
                "banana", "cajá", "cajú", "carambola",
                "cupuaçu", "graviola", "goiaba", "jabuticaba", "jenipapo",
                "maçã", "mangaba", "manga", "maracujá", "murici", "pequi", "pitanga", "pitaya", "sapoti", "tangerina", "umbu", "uva", "uvaia" };

            // Sorteio da palavra secreta
            Random random = new Random();
            int indice = random.Next(0, palavrasSecretas.Length);
            string palavraSecreta = palavrasSecretas[indice].ToUpper();

            // Numero de tentativas
            int tentativas = 5;

            // Letras erradas
            List<char> letrasErradas = new List<char>();

            // Letras corretas
            List<char> letrasCorretas = new List<char>();

            // Palavra secreta
            char[] palavra = new char[palavraSecreta.Length];
            for (int i = 0; i < palavra.Length; i++)
            {
                palavra[i] = '_';
            }
            // Loop do jogo
            while (tentativas > 0)
            {
                Console.Clear();
                // Feedback para o jogador, para cada erro uma parte do corpo do boneco é desenhada
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

                // Palavra secreta
                Console.Write("Palavra: ");
                foreach (char letra in palavra)
                {
                    Console.Write(letra + " ");
                }
                Console.WriteLine();

                // Letras erradas
                Console.Write("Letras erradas: ");
                foreach (char letra in letrasErradas)
                {
                    Console.Write(letra + " ");
                }
                Console.WriteLine();

                // Letras corretas
                Console.Write("Letras corretas: ");
                foreach (char letra in letrasCorretas)
                {
                    Console.Write(letra + " ");
                }
                Console.WriteLine();

                // Tentativas
                Console.WriteLine("Tentativas restantes: " + tentativas);

                // Palpite do jogador
                Console.Write("Digite uma letra: ");
                char palpite = char.Parse(Console.ReadLine().ToUpper());

                // Verifica se a letra já foi chutada
                if (letrasErradas.Contains(palpite) || letrasCorretas.Contains(palpite))
                {
                    Console.WriteLine("Você já chutou essa letra.");
                    Console.ReadKey();
                    continue;
                }

                // Verifica se a letra está na palavra secreta
                if (palavraSecreta.Contains(palpite))
                {
                    for (int i = 0; i < palavraSecreta.Length; i++)
                    {
                        if (palavraSecreta[i] == palpite)
                        {
                            palavra[i] = palpite;
                        }
                    }
                    letrasCorretas.Add(palpite);
                }
                else
                {
                    letrasErradas.Add(palpite);
                    tentativas--;
                }

                // Verifica se o jogador venceu ou perdeu
                if (!palavra.Contains('_'))
                {
                    Console.Clear();
                    Console.WriteLine("Parabéns! Você acertou a palavra secreta: " + palavraSecreta);
                    Console.ReadKey();
                    break;
                }
                if (tentativas == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Que pena! Você perdeu. A palavra secreta era: " + palavraSecreta);
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}













