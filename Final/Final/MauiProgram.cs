using Microsoft.Extensions.Logging;

namespace Final;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
private void LoginButton_Click(object sender, RoutedEventArgs e)
{
    string username = UsernameTextBox.Text;
    string password = PasswordBox.Password;

    // Check if the username and password are correct
    if (username == "myusername" && password == "mypassword")
    {
        // Navigate to the main page
        Frame.Navigate(typeof(MainPage));
    }
    else
    {
        // Show an error message
        ErrorMessage.Text = "Invalid username or password";
        ErrorMessage.Visibility = Visibility.Visible;
    }
}