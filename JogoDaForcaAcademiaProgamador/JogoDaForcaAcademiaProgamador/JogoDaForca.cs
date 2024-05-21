using System.Text;

namespace JogoDaForcaAcademiaProgamador
{
    class JogoDaForca
    {
        //BancoPalavras bancoDePalavras;
        public string palavraSorteada;
        private List<char> letrasChutadas;
        private int tentativasIncorretas;

        public JogoDaForca()
        {
            //bancoDePalavras = bancoDePalavras;
            letrasChutadas = new List<char>();

            IniciarJogo();
        }

        public void IniciarJogo()
        {
            var sorteio = new BancoPalavras();
            palavraSorteada = sorteio.SortearPalavra();

            //palavraSorteada = bancoDePalavras.SortearPalavra();
            letrasChutadas.Clear();
            tentativasIncorretas = 0;
        }

        public bool PalpiteLetra(char letra)
        {
            letra = char.ToUpper(letra);

            if (letrasChutadas.Contains(letra))
            {
                Console.WriteLine("Palpite repetido, por favor, escolha outra letra!");

                return false;
            }

            letrasChutadas.Add(letra);

            if (palavraSorteada.Contains(letra))
            {
                Console.WriteLine("\nLetra Correta!\n");

                return true;
            }
            else
            {
                Console.WriteLine("\nLetra incorreta, tente novamente!\n");

                tentativasIncorretas++;

                return false;
            }
        }

        public void MostrarLetrasAdivinhadas()
        {
            StringBuilder exibicao = new StringBuilder();

            foreach (char letra in palavraSorteada)
            {
                if (letrasChutadas.Contains(letra))
                {
                    exibicao.Append(letra + " ");
                }
                else
                {
                    exibicao.Append("_ ");
                }
            }

            Console.WriteLine(exibicao.ToString().Trim());
        }

        public bool AdivinhouPalavra()
        {
            foreach (char letra in palavraSorteada)
            {
                if (!letrasChutadas.Contains(letra))
                {
                    return false;
                }
            }

            return true;
        }

        public bool TentativasExcedidas()
        {
            return tentativasIncorretas >= 5;
        }
    }
}
