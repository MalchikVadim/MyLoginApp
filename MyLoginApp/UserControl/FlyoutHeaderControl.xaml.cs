namespace MyLoginApp.UserControl;

public partial class FlyoutHeaderControl : ContentView
{
	public FlyoutHeaderControl()
	{
		InitializeComponent();
		if (App.UserInfo != null)
		{
			lblUserName.Text = "Logged in as: " + App.UserInfo.UserName;
            lblUserEmail.Text = App.UserInfo.UserName; //Set Email From API
        }
		else
		{
            lblUserName.Text = "Logged in as: Admin";
            lblUserEmail.Text = "Admin";
        }
	}
}