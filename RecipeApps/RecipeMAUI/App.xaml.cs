namespace RecipeMAUI
{
    public partial class App : Application
    {
        public static bool loggedin = false;
        public static string ConnStringSetting = "";
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}