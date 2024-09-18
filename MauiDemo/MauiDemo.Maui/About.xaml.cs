namespace MauiDemo.Maui;

public partial class About : ContentPage
{
	public About()
	{
		InitializeComponent();
	}
	private void Button_Clicked(object sender, EventArgs e)
	{
		var button = (Button)sender;
		button.BackgroundColor = Colors.Blue;
		button.Text = "Changed Color to Blue";
	}

}