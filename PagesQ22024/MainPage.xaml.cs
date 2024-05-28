namespace PagesQ22024
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnFlyout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Flyout.Flyout1());
        }

        private void btnTabbed_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Tabbed.Tab1());
        }
    }

}
