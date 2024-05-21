namespace JogoDaForcaAcademiaProgamador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var banco = new BancoPalavras();
            var jogoForca = new JogoDaForca();

            Console.WriteLine(">>> Jogo da Forca <<<");

            while (!jogoForca.AdivinhouPalavra() && !jogoForca.TentativasExcedidas())
            {
                Console.Write("Digite uma letra: ");
                char letraDigitada = Console.ReadLine()[0];

                jogoForca.PalpiteLetra(letraDigitada);
                jogoForca.MostrarLetrasAdivinhadas();
            }

            if (jogoForca.AdivinhouPalavra())
            {
                Console.WriteLine("Parabéns! Você adivinhou a palavra: " + jogoForca.palavraSorteada);
            }
            else
            {
                Console.WriteLine("Você perdeu! A palavra era: " + jogoForca.palavraSorteada);
            }
        }
    }
}
