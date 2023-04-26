namespace Final;

public partial class ContactUs : ContentPage
{
	public ContactUs()
	{
		InitializeComponent();
	}

    private void Trainer1Contact_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Phone Number: 999-999-9999 ", "Email: BobLayabout@mail.mail", "Close");
    }

    private void Trainer2Contact_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Phone Number: 888-888-8888", "Email: LarryLayabout@mail.mail", "Close");
    }

    private void Trainer3Contact_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Phone Number: 777-777-7777", "Email: JillValentine@STARS.RC", "Close");
    }

    private void Trainer4Contact_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Phone Number: 666-666-6666", "Email: Uroboros@STARS.UC", "Close");
    }
}