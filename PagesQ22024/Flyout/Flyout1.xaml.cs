namespace PagesQ22024.Flyout;

public partial class Flyout1 : FlyoutPage
{
	public Flyout1()
	{
		InitializeComponent();
	}

    private void btnPagina2_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Page2());
    }
}