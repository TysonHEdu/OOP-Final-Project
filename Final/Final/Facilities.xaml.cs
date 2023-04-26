using System.Diagnostics.Metrics;

namespace Final;

public partial class Facilities : ContentPage
{
	public Facilities()
	{
		InitializeComponent();
	}

    private void OrderButton_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Order Placed", " ", "Close");
    }
}