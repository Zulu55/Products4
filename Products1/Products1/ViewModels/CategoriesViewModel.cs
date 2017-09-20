namespace Products1.ViewModels
{
    using System.Collections.ObjectModel;
    using Models;

    public class CategoriesViewModel
    {
        #region Properties
        public ObservableCollection<Category> Categories
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public CategoriesViewModel()
        {
            LoadCategories();
        }
        #endregion

        #region Methods
        void LoadCategories()
        {
            
        }
        #endregion
    }
}
