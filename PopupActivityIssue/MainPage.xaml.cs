using CommunityToolkit.Maui.Views;

namespace PopupActivityIssue
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            var popup = new Popup()
            {
                Content = new Label() { Text = "Hello, World!" },
            };

            this.ShowPopup(popup);

            await Task.Delay(10000);

            popup.Close();
        }
    }

}
