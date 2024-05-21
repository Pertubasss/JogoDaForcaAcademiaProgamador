namespace JogoDaForcaAcademiaProgamador
{
    class BancoPalavras
    {
        private List<string> listaDePalavras;

        public BancoPalavras()
        {
            listaDePalavras = new List<string>();

            CarregarBancoPalavras();
        }

        public string SortearPalavra()
        {
            var random = new Random();
            string palavraSorteada = listaDePalavras[random.Next(0, listaDePalavras.Count)];

            return palavraSorteada;
        }

        public void CarregarBancoPalavras()
        {
            string diretorioBancoPalavras = "C:\\Users\\Henrique\\OneDrive\\Área de Trabalho\\FrutasForca.txt";//alterar para diretório correto

            if (File.Exists(diretorioBancoPalavras))
            {
                string[] palavras = File.ReadAllLines(diretorioBancoPalavras);

                listaDePalavras.AddRange(palavras);
            }
            else
            {
                throw new FileNotFoundException("Não foi possivel carregar o banco de palavras.");
            }
        }
    }
}
