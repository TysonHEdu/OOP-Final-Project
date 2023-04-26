using System.Diagnostics.Metrics;

namespace Final;

public partial class Facilities : ContentPage
{
	int count = 0;
	public Facilities()
	{
		InitializeComponent();
	}

    private void OrderButton_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("1", "Has Been Ordered", "Close");
    }
}