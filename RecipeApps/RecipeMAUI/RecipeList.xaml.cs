using RecipeSystem;
using System.Data;

namespace RecipeMAUI;

public partial class RecipeList : ContentPage
{
	public RecipeList()
	{
		InitializeComponent();
		BindData();
	}

	private void BindData()
	{
		DataTable dt = Recipe.GetAllRowsFromTable("RecipeGet");
		RecipeLst.ItemsSource = dt.Rows;
	}
}