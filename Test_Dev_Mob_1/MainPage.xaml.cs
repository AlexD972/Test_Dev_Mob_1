namespace Test_Dev_Mob_1
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}

		private void OnCounterClicked(object sender, EventArgs e)
		{
			count++;
			CounterBtn.Text = $"Cliqué {count} fois";

			SemanticScreenReader.Announce(CounterBtn.Text);
		}
	}

}
