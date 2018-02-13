using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorariosMundiais.models
{
    public class BolsasModel
    {
        public string Sigla { get; set; }

        public string Bandeira { get; set; }

        public string NomeBolsa { get; set; }

        public int GMT { get; set; }

        public TimeSpan Abertura { get; set; }

        public TimeSpan Fechamento { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1}", NomeBolsa, Sigla);
        }


        public static IList<BolsasModel> CarregarDados()
        {
            IList<BolsasModel> bolsasMundiais = new List<BolsasModel>();

            bolsasMundiais.Add(new BolsasModel()
            {
                Sigla = "ASX",
                Bandeira = "au",
                NomeBolsa = "Australia Stock Exchange",
                GMT = 10,
                Abertura = new TimeSpan(10,0,0),
                Fechamento = new TimeSpan(16,0,0)
            });


            bolsasMundiais.Add(new BolsasModel()
            {
                Sigla = "BM&F",
                Bandeira = "br",
                NomeBolsa = "Brazilian Stock Exchange",
                GMT = -3,
                Abertura = new TimeSpan(9, 0, 0),
                Fechamento = new TimeSpan(18, 0, 0)
            });

            bolsasMundiais.Add(new BolsasModel()
            {
                Sigla = "Bovespa",
                Bandeira = "br",
                NomeBolsa = "Brazilian Stock Exchange",
                GMT = -3,
                Abertura = new TimeSpan(10, 0, 0),
                Fechamento = new TimeSpan(17, 30, 0)
            });


            bolsasMundiais.Add(new BolsasModel()
            {
                Sigla = "LSE",
                Bandeira = "gb",
                NomeBolsa = "London Stock Exchange",
                GMT = 0,
                Abertura = new TimeSpan(8, 0, 0),
                Fechamento = new TimeSpan(16, 30, 0)
            });

            bolsasMundiais.Add(new BolsasModel()
            {
                Sigla = "NASDAQ",
                Bandeira = "us",
                NomeBolsa = "NASDAQ Stock Exchange",
                GMT = -5,
                Abertura = new TimeSpan(09, 30, 0),
                Fechamento = new TimeSpan(16, 00, 0)
            });

            bolsasMundiais.Add(new BolsasModel()
            {
                Sigla = "NYSE",
                Bandeira = "us",
                NomeBolsa = "New York Stock Exchange",
                GMT = -5,
                Abertura = new TimeSpan(09, 30, 0),
                Fechamento = new TimeSpan(16, 00, 0)
            });

            bolsasMundiais.Add(new BolsasModel()
            {
                Sigla = "SSE",
                Bandeira = "cn",
                NomeBolsa = "Shanghai Stock Exchange",
                GMT = 8,
                Abertura = new TimeSpan(09, 30, 0),
                Fechamento = new TimeSpan(15, 00, 0)
            });

            bolsasMundiais.Add(new BolsasModel()
            {
                Sigla = "JPX",
                Bandeira = "jp",
                NomeBolsa = "Tokyo Stock Exchange",
                GMT = 9,
                Abertura = new TimeSpan(09, 00, 0),
                Fechamento = new TimeSpan(15, 00, 0)
            });


            return bolsasMundiais;
        }
    }

    

}
