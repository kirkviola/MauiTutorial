namespace MauiTutorial;

public partial class MainPage : ContentPage
{
	int count = 0;
	int index = 0;
	List<string> colors = new List<string>() { "#fff", "#1f1f1f", "#000000" };

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void OnFunClicked(object sender, EventArgs e)
	{
		// To Do: Figure out how to change background color property
	}
}

