namespace PagesQ22024.Tabbed;

public partial class Pestana2 : ContentPage
{
	public Pestana2()
	{
		InitializeComponent();
	}

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
		try
		{
            if (validarCampos())
            {
                double suma = double.Parse(txtN1.Text) + double.Parse(txtN2.Text);
                txtResultado.Text = $"La suma es: {suma}";
            }
        } catch (Exception ex)
        {
            DisplayAlert("ERROR", ex.Message, "Aceptar");
        }
    }

    private bool validarCampos()
    {
        if (txtN1.Text is null || txtN1.Text == "") {
            DisplayAlert("ADVERTENCIA", "Campo primer número en blanco", "Aceptar");
            return false;
        } else if (txtN2.Text is null || txtN2.Text == "")
        {
            DisplayAlert("ADVERTENCIA", "Campo segundo número en blanco", "Aceptar");
            return false;
        } else
        {
            return true;
        }
    }

    private void btnLimpiar_Clicked(object sender, EventArgs e)
    {
        txtN1.Text = "";
        txtN2.Text = "";
        txtResultado.Text = "";
    }
}