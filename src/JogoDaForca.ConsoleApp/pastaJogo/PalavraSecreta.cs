namespace JogoDaForca.ConsoleApp.pastaJogo;

internal class PalavraSecreta
{
    private readonly string[] palavrasSecretas =
    {
        "acabacate", "abacaxi", "acerola", "açai", "araça", "bacaba", "bacuri",
        "banana", "cajá", "cajú", "carambola",
        "cupuaçu", "graviola", "goiaba", "jabuticaba", "jenipapo",
        "maçã", "mangaba", "manga", "maracujá", "murici", "pequi", "pitanga", "pitaya", "sapoti", "tangerina", "umbu",
        "uva", "uvaia"
    };

    public PalavraSecreta()
    {
        // Seleciona uma palavra secreta aleatória
        var random = new Random();
        var indice = random.Next(0, palavrasSecretas.Length);
        Palavra = palavrasSecretas[indice].ToUpper();

        // Inicializa as listas de letras corretas e erradas
        LetrasErradas = new List<char>();
        LetrasCorretas = new List<char>();

        // Inicializa a palavra mascarada com underscores
        PalavraMascarada = new string('_', Palavra.Length);

        // Define o número de tentativas
        TentativasRestantes = 5;
    }

    public string Palavra { get; }
    public string PalavraMascarada { get; private set; }
    public List<char> LetrasErradas { get; }
    public List<char> LetrasCorretas { get; }
    public int TentativasRestantes { get; set; }

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

        // Adiciona a letra errada à lista de letras erradas
        LetrasErradas.Add(palpite);

        // Decrementa o número de tentativas restantes
        TentativasRestantes--;

        return false;
    }

    private void AtualizarPalavraMascarada(char palpite)
    {
        // Converte a palavra secreta e a palavra mascarada em arrays de caracteres
        var palavraArray = Palavra.ToCharArray();
        var palavraMascaradaArray = PalavraMascarada.ToCharArray();

        // Substitui os underscores pela letra correta nas posições correspondentes
        for (var i = 0; i < palavraArray.Length; i++)
            if (palavraArray[i] == palpite)
                palavraMascaradaArray[i] = palpite;

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