namespace RecipeWinForms
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            BindData();
        }
        private void BindData()
        {           
                gMeal.DataSource = Recipe.GetAllRowsFromTable("MealGet");
                WindowsFormsUtility.FormatGridForSearchResults(gMeal, "Meal");            
        }
    }
}
