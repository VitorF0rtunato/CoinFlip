using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlip.ViewModel
{
    public class Coin
    {
        public string Lado { get; set; }

        public string Jogar()
        {
            int ladoSort = new Random().Next(2);
            Lado = ladoSort == 0 ? "cara" : "coroa";
            return (Lado);
        }
        public string Jogar(string ladoEscolhido)
        {
            int ladoSort = new Random().Next(2);
            Lado = ladoSort == 0 ? "cara" : "coroa";
            string resultado = Lado == ladoEscolhido ?
                $"Parabéns, você pediu {ladoEscolhido} e deu {Lado}" :
                $"Que pena, você pediu {ladoEscolhido} e deu {Lado}";
            return (resultado);
        }
    }
}
