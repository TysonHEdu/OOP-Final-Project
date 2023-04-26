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


        if (Username is null)
            DisplayAlert("Denied.", "No Entry", "Try Again");
        else if (password is null)
            DisplayAlert("Denied.", "No Entry", "Try Again");
        else if (password.Equals("Password"))
            DisplayAlert("Hello", username + " Logged In ", "Close");
        else
            DisplayAlert("Denied", "", "Invalid Login");
        
    }
}
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}