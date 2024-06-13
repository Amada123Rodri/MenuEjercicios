namespace Menuaplicaciones;

public partial class pagina6 : ContentPage
{

    private const double ExchangeRate = 0.05; // Tasa de cambio de ejemplo (1 peso mexicano = 0.05
    public pagina6()
	{
		InitializeComponent();
	}

    private void OnConvertButtonClicked(object sender, EventArgs e)
    {
        if (double.TryParse(PesosEntry.Text, out double pesos))
        {
            double dollars = pesos * ExchangeRate;
            ResultLabel.Text = $"${pesos} pesos mexicanos son ${dollars:F2} dólares";
        }
        else
        {
            DisplayAlert("Error", "Por favor ingrese un valor numérico válido", "OK");
        }
    }
}