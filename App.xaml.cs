namespace StudentFirestore;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();
		MainPage = new StudentPage();
	}
}
