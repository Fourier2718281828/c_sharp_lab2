using KMA.ProgrammingInCSharp2022.Practice4Navigation.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.ViewModels
{
    internal class ResultWindowViewModel : INavigatable<MainNavigationTypes>
    {
        #region Fields
        private readonly Action _exitNavigation;
        #endregion

        #region Constructors
        public ResultWindowViewModel(Action exitNavigation)
        {
            _exitNavigation = exitNavigation;
            return;
        }
        #endregion

        #region
        public MainNavigationTypes ViewType => MainNavigationTypes.Auth;
        #endregion
    }
}
