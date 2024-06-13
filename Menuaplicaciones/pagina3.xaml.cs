namespace Menuaplicaciones;

public partial class pagina3 : ContentPage
{
	public pagina3()
	{
		InitializeComponent();
        List<string> tablaMultiplicar = new List<string>();

        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                tablaMultiplicar.Add($"{i} x {j} = {i * j}");
            }
            tablaMultiplicar.Add(""); // Agrega una línea en blanco después de cada tabla de multiplicar
        }

        tablaMultiplicarListView.ItemsSource = tablaMultiplicar;
    }
}