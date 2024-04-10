using System;
using System.Collections.Generic;

namespace JogoDaForca.ConsoleApp
{
    class PalavraSecreta
    {
        private string[] palavrasSecretas = { "acabacate", "abacaxi", "acerola", "açai", "araça", "bacaba", "bacuri",
            "banana", "cajá", "cajú", "carambola",
            "cupuaçu", "graviola", "goiaba", "jabuticaba", "jenipapo",
            "maçã", "mangaba", "manga", "maracujá", "murici", "pequi", "pitanga", "pitaya", "sapoti", "tangerina", "umbu", "uva", "uvaia" };

        public string Palavra { get; private set; }
        public string PalavraMascarada { get; private set; }
        public List<char> LetrasErradas { get; private set; }
        public List<char> LetrasCorretas { get; private set; }
        public int TentativasRestantes { get; private set; }

        public PalavraSecreta()
        {
            // Seleciona uma palavra secreta aleatória
            Random random = new Random();
            int indice = random.Next(0, palavrasSecretas.Length);
            Palavra = palavrasSecretas[indice].ToUpper();

            // Inicializa as listas de letras corretas e erradas
            LetrasErradas = new List<char>();
            LetrasCorretas = new List<char>();

            // Inicializa a palavra mascarada com underscores
            PalavraMascarada = new string('_', Palavra.Length);

            // Define o número de tentativas
            TentativasRestantes = 5;
        }

        public bool VerificarPalpite(char palpite)
        {
            // Verifica se a letra está na palavra secreta
            if (Palavra.Contains(palpite))
            {
                // Atualiza a palavra mascarada com a letra correta
                AtualizarPalavraMascarada(palpite);

                // Adiciona a letra correta à lista de letras corretas
                LetrasCorretas.Add(palpite);

                return true;
            }
            else
            {
                // Adiciona a letra errada à lista de letras erradas
                LetrasErradas.Add(palpite);

                // Decrementa o número de tentativas restantes
                TentativasRestantes--;

                return false;
            }
        }

        private void AtualizarPalavraMascarada(char palpite)
        {
            // Converte a palavra secreta e a palavra mascarada em arrays de caracteres
            char[] palavraArray = Palavra.ToCharArray();
            char[] palavraMascaradaArray = PalavraMascarada.ToCharArray();

            // Substitui os underscores pela letra correta nas posições correspondentes
            for (int i = 0; i < palavraArray.Length; i++)
            {
                if (palavraArray[i] == palpite)
                {
                    palavraMascaradaArray[i] = palpite;
                }
            }

            // Atualiza a palavra mascarada
            PalavraMascarada = new string(palavraMascaradaArray);
        }

        public bool VerificarVitoria()
        {
            // Verifica se não há mais underscores na palavra mascarada
            return !PalavraMascarada.Contains('_');
        }

        public bool VerificarDerrota()
        {
            // Verifica se não há mais tentativas restantes
            return TentativasRestantes == 0;
        }
    }
}