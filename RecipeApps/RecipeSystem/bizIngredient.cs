using System.Data.SqlClient;
using System.Data;

namespace RecipeSystem
{
    public class bizIngredient : bizObject<bizIngredient>
    {
        private int _ingredientid;
        private string _ingredientdesc = "";

        public List<bizIngredient> Search(string ingredientdescval)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(this.GetSprocName);
            SQLUtility.SetParamValue(cmd, "IngredientDesc", ingredientdescval);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return this.GetListFromDataTable(dt);
        }

        public int IngredientId
        {
            get { return _ingredientid; }
            set
            {
                if (_ingredientid != value)
                {
                    _ingredientid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string IngredientDesc
        {
            get { return _ingredientdesc; }
            set
            {
                if (_ingredientdesc != value)
                {
                    _ingredientdesc = value;
                    InvokePropertyChanged();
                }
            }
        }
    }
}
