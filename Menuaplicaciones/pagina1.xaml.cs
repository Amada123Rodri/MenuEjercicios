namespace Menuaplicaciones;

public partial class pagina1 : ContentPage
{
	public pagina1()
	{
		InitializeComponent();
        LoadData();
    }
    private void LoadData()
    {
        List<string> evenNumbers = new List<string>();

        for (int i = 0; i <= 100; i += 2)
        {
            evenNumbers.Add(i.ToString());
        }

        ListView listView = new ListView();
        listView.ItemsSource = evenNumbers;

        Content = listView;
    }
}