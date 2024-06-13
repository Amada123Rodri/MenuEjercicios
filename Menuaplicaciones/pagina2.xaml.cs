namespace Menuaplicaciones;

public partial class pagina2 : ContentPage
{
    private int _countdownValue;
    public pagina2()
	{
		InitializeComponent();
	}
    private void OnStartButtonClicked(object sender, EventArgs e)
    {
        _countdownValue = 10;
        CountdownLabel.Text = _countdownValue.ToString();

        Device.StartTimer(TimeSpan.FromSeconds(1), () =>
        {
            _countdownValue--;
            CountdownLabel.Text = _countdownValue.ToString();

            if (_countdownValue <= 0)
            {
                return false; // Detiene el temporizador
            }

            return true; // Continua el temporizador
        });
    }
}