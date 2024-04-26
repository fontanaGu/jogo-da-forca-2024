namespace JogoDaForca.ConsoleApp.pastaJogo;

internal class JogoDaForca
{
    private readonly ForcaUI forcaUI;
    private readonly PalavraSecreta palavraSecreta;

    public JogoDaForca()
    {
        // Inicializa a interface do jogo e a palavra secreta
        forcaUI = new ForcaUI();
        palavraSecreta = new PalavraSecreta();
    }

    public void Iniciar()
    {
        // Apresenta as instruções do jogo
        forcaUI.ApresentarInstrucoes();

        // Loop principal do jogo
        while (true)
        {
            // Limpa a tela antes de cada rodada
            forcaUI.LimparTela();

            // Exibe os elementos do jogo (forca, palavra secreta, letras corretas/erradas, etc.)
            forcaUI.ExibirForca();
            forcaUI.ExibirPalavraSecreta(palavraSecreta.PalavraMascarada);
            forcaUI.ExibirLetrasErradas(palavraSecreta.LetrasErradas);
            forcaUI.ExibirLetrasCorretas(palavraSecreta.LetrasCorretas);
            forcaUI.ExibirTentativasRestantes(palavraSecreta.TentativasRestantes);

            // Obtém o palpite do jogador
            var palpite = forcaUI.ObterPalpite();

            // Verifica se o palpite do jogador está correto
            if (palavraSecreta.VerificarPalpite(palpite))
            {
                // Verifica se o jogador venceu
                if (palavraSecreta.VerificarVitoria())
                {
                    // Exibe mensagem de vitória e encerra o jogo
                    forcaUI.LimparTela();
                    forcaUI.ExibirMensagemVitoria(palavraSecreta.Palavra);
                    break;
                }
            }
            else
            {
                // Verifica se o jogador perdeu
                if (palavraSecreta.VerificarDerrota())
                {
                    // Exibe mensagem de derrota e encerra o jogo
                    forcaUI.LimparTela();
                    forcaUI.ExibirMensagemDerrota(palavraSecreta.Palavra);
                    break;
                }
            }
        }
    }
}