using CoinFlip.ViewModel;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CoinFlip.Models
{
    public partial class CoinViewModel : ObservableObject
    {
        [ObservableProperty]
        public string _ladoEscolhido;

        [ObservableProperty]
        public string _imagem;

        [ObservableProperty]
        public string _resultado;

        public ICommand FlipCommand { get; }

        public CoinViewModel()
        {
            FlipCommand = new Command(Flip);
        }

        public void Flip()
        {
            Coin coin = new Coin();
            Resultado = coin.Jogar(LadoEscolhido);
            Imagem = $"{coin.Lado}.png";
        }
    }
}
