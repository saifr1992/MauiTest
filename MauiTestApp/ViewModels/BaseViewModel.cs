using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MauiTestApp.ViewModels
{
	public class BaseViewModel : INotifyPropertyChanged, IDisposable
    {
        #region Private Properties

        #endregion

        #region Public Properties
        public event PropertyChangedEventHandler PropertyChanged;

        public virtual void Dispose()
        {
        }
        #endregion

        #region Command

        #endregion

        #region Constructors

        #endregion

        #region Get Set

        #endregion

        #region Private Implementation

        #endregion

        #region Protected Implementation
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        #endregion

        #region Public Implementation

        #endregion
    }
}

