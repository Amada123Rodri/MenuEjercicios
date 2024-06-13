namespace Menuaplicaciones;

public partial class pagina5 : ContentPage
{
	public pagina5()
	{
		InitializeComponent();
	}
    private void OnCalcularPresupuestoClicked(object sender, EventArgs e)
    {
        if (int.TryParse(entryNumeroPersonas.Text, out int numeroPersonas))
        {
            double costoPorPersona;

            if (numeroPersonas <= 200)
            {
                costoPorPersona = 95.00;
            }
            else if (numeroPersonas <= 300)
            {
                costoPorPersona = 85.00;
            }
            else
            {
                costoPorPersona = 75.00;
            }

            double presupuestoTotal = numeroPersonas * costoPorPersona;
            labelResultado.Text = $"El presupuesto total es: ${presupuestoTotal:F2}";
        }
        else
        {
            labelResultado.Text = "Por favor, ingrese un número válido de personas.";
        }
    }
}