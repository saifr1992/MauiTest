using System;
using MauiTestApp.Interface;
using MauiTestApp.Views;

namespace MauiTestApp.ViewModels
{
	public class HomeMainPageViewModel : BaseViewModel
    {
        #region Private Properties

        #endregion

        #region Public Properties

        #endregion

        #region Command

        #endregion

        #region Constructors
        public HomeMainPageViewModel()
        {
            Data = "Welcome to .NET MAUI!111";
            IPlatformDiTestService platformDiTestService = Resolver.Resolve<IPlatformDiTestService>();
            Data = platformDiTestService.SayYourPlatformName();
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

        #endregion

        #region Public Implementation

        #endregion
    }
}

