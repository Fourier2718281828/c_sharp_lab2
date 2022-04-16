using KMA.ProgrammingInCSharp2022.Practice4Navigation.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.ViewModels
{
    internal class MainWindowViewModel : BaseNavigatableViewModel<MainNavigationTypes>
    {
        public MainWindowViewModel()
        {
            Navigate(MainNavigationTypes.Auth);
        }

        protected override INavigatable<MainNavigationTypes> CreateViewModel(MainNavigationTypes type)
        {
            switch (type)
            {
                case MainNavigationTypes.Auth:
                    return new AuthWindowViewModel(() => Navigate(MainNavigationTypes.Result));
                case MainNavigationTypes.Result:
                    return new ResultWindowViewModel(() => Navigate(MainNavigationTypes.Auth));
                default:
                    return null;
            }
        }
    }
}
