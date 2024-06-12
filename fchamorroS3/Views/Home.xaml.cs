using static System.Runtime.InteropServices.JavaScript.JSType;

namespace fchamorroS3.Views;

public partial class Home : ContentPage
{
	public Home(string nombre)
	{
		InitializeComponent();
        lblNombre.Text = nombre;
    }
}