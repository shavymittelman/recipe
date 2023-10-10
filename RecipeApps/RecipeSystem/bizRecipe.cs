using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class bizRecipe : bizObject
    {
        public bizRecipe()
        {
        }
        private int _recipeid;
        private int _userrefid;
        private int _cuisineid;
        private string _recipename = "";
        private int _caloriesperserving;
        private DateTime _datedrafted;
        private DateTime _datepublished;
        private DateTime _datearchived;

        public int RecipeId
        {
            get { return _recipeid; }
            set
            {
                if (_recipeid != value)
                {
                    _recipeid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int UserRefId
        {
            get { return _userrefid; }
            set
            {
                if (_userrefid != value)
                {
                    _userrefid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CuisineId
        {
            get { return _cuisineid; }
            set
            {
                if (_cuisineid != value)
                {
                    _cuisineid = value;
                    InvokePropertyChanged();
                }
            }
        }

        public string RecipeName
        {
            get { return _recipename; }
            set
            {
                if (_recipename != value)
                {
                    _recipename = value;
                    InvokePropertyChanged();
                }
            }
        }

        public int CaloriesPerServing
        {
            get { return _caloriesperserving; }
            set
            {
                if (_caloriesperserving != value)
                {
                    _caloriesperserving = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateDrafted
        {
            get { return _datedrafted; }
            set
            {
                if (_datedrafted != value)
                {
                    _datedrafted = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DatePublished
        {
            get { return _datepublished; }
            set
            {
                if (_datepublished != value)
                {
                    _datepublished = value;
                    InvokePropertyChanged();
                }
            }
        }

        public DateTime DateArchived
        {
            get { return _datearchived; }
            set
            {
                if (_datearchived != value)
                {
                    _datearchived = value;
                    InvokePropertyChanged();
                }
            }
        }

    }    
}
