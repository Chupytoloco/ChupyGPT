using Microsoft.VisualBasic;

namespace ChupyGPT
{
	public partial class MainPage : ContentPage
	{
		int count = 0;

		public MainPage()
		{
			InitializeComponent();
		}
		private void OnEntryCompleted(object sender, EventArgs e)
		{
			responseLabel.Text = "Yo también te quiero";
		}
	}

}
