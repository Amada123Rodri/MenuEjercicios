namespace Menuaplicaciones;

public partial class pagina4 : ContentPage
{
	public pagina4()
	{
		InitializeComponent();
	}

    private void CalcularSueldoSemana_Clicked(object sender, EventArgs e)
    {
        if (double.TryParse(horasEntry.Text, out double horas) &&
            double.TryParse(pagoPorHoraEntry.Text, out double pagoPorHora))
        {
            double sueldoSemana = horas * pagoPorHora * 7; // 7 días en una semana
            sueldoLabel.Text = $"Sueldo semanal: {sueldoSemana:C}";
        }
        else
        {
            sueldoLabel.Text = "Por favor ingresa valores válidos.";
        }
    }
}