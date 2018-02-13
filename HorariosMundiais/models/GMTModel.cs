using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorariosMundiais.models
{
    public class GMTModel
    {
        public int Chave { get; set; }

        public string Valor { get; set; }

        public override string ToString()
        {
            return this.Valor;
        }

        public static IList<GMTModel> CarregarDados()
        {
            IList<GMTModel> list = new List<GMTModel>();

            list.Add(new GMTModel() { Chave = 14, Valor = "+14" });
            list.Add(new GMTModel() { Chave = 13, Valor = "+13" });
            list.Add(new GMTModel() { Chave = 12, Valor = "+12" });
            list.Add(new GMTModel() { Chave = 11, Valor = "+11" });
            list.Add(new GMTModel() { Chave = 10, Valor = "+10" });
            list.Add(new GMTModel() { Chave = 9, Valor = "+9" });
            list.Add(new GMTModel() { Chave = 8, Valor = "+8" });
            list.Add(new GMTModel() { Chave = 7, Valor = "+7" });
            list.Add(new GMTModel() { Chave = 6, Valor = "+6" });
            list.Add(new GMTModel() { Chave = 5, Valor = "+5" });
            list.Add(new GMTModel() { Chave = 4, Valor = "+4" });
            list.Add(new GMTModel() { Chave = 3, Valor = "+3" });
            list.Add(new GMTModel() { Chave = 2, Valor = "+2" });
            list.Add(new GMTModel() { Chave = 1, Valor = "+1" });
            list.Add(new GMTModel() { Chave = 0, Valor = "0" });
            list.Add(new GMTModel() { Chave = -1, Valor = "-1" });
            list.Add(new GMTModel() { Chave = -2, Valor = "-2" });
            list.Add(new GMTModel() { Chave = -3, Valor = "-3" });
            list.Add(new GMTModel() { Chave = -4, Valor = "-4" });
            list.Add(new GMTModel() { Chave = -5, Valor = "-5" });
            list.Add(new GMTModel() { Chave = -6, Valor = "-6" });
            list.Add(new GMTModel() { Chave = -7, Valor = "-7" });
            list.Add(new GMTModel() { Chave = -8, Valor = "-8" });
            list.Add(new GMTModel() { Chave = -9, Valor = "-9" });
            list.Add(new GMTModel() { Chave = -10, Valor = "-10" });
            list.Add(new GMTModel() { Chave = -11, Valor = "-11" });
            list.Add(new GMTModel() { Chave = -12, Valor = "-12" });            

            return list;
        }

        
    }
}
