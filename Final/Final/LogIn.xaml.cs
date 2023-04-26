namespace Final;

public partial class LogIn : ContentPage
{
	public LogIn()
	{
		InitializeComponent();
	}
}
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
}