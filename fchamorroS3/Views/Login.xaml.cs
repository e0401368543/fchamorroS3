namespace fchamorroS3.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}
    string user;
    string pasword;
    public Login(string usuario, string contrase�a)
    {
        InitializeComponent();
        user = usuario;
        pasword = contrase�a;
    }
    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Registro());
       

    }

    private void btnIngresar_Clicked(object sender, EventArgs e)
    {
        if (user == txtUauRIO.Text && pasword == txtUauRIO.Text)
        {
            Navigation.PushAsync(new Home(txtUauRIO.Text));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario incorrectos", "Ok");
        }

    }
}