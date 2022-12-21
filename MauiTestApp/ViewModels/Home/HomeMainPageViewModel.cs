using System.Windows.Input;
using MauiTestApp.Service;

namespace MauiTestApp.ViewModels
{
    public class HomeMainPageViewModel : BaseViewModel
    {
        #region Private Properties
        private readonly INavigationService _navigationService;
        #endregion

        #region Public Properties

        #endregion

        #region Command
        public ICommand Abc => new Command(async () => await AbcExecute());
        #endregion

        #region Constructors
        public HomeMainPageViewModel()
        {
            _navigationService = Resolver.Resolve<INavigationService>();
            Data = "Welcome to .NET MAUI!111";
        }

        public override void Dispose()
        {
            base.Dispose();
        }
        #endregion

        #region Get Set
        private string _data;
        public string Data
        {
            get { return _data; }
            set { SetProperty(ref _data, value); }
        }
        #endregion

        #region Private Implementation
        private async Task AbcExecute()
        {
            await _navigationService.NavigateToAsync("MainPage", null);
        }
        #endregion

        #region Public Implementation

        #endregion
    }
}

