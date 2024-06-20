using CoinFlip.Models;
using CoinFlip.ViewModel;

namespace CoinFlip.View;

public partial class CoinFlip : ContentPage
{
	public CoinFlip()
	{
		InitializeComponent();
        BindingContext = new CoinViewModel();
    }
}