namespace RecipeWinForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //delete line below
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=HeartyHearthDB;", true, "recipeadmin", "TYHforeverything!");
            Application.Run(new frmMain());
        }
    }
}