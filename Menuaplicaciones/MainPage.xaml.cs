namespace Menuaplicaciones
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
          
        }

        private async void OnPage1ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pagina1());
        }

        private async void OnPage2ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pagina2());
        }
        private async void OnPage3ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pagina3());
        }

        private async void OnPage4ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pagina4());
        }

        private async void OnPage5ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pagina5());
        }

        private async void OnPage6ButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new pagina6());
        }
    }

}
