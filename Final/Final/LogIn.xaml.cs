namespace Final;

public partial class LogIn : ContentPage
{
	public LogIn()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        string username = this.Username.Text;
        string password = this.Password.Text;


        DisplayAlert("Hello" , username + " Logged In ", "Close");
    }
}
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}