using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HwansPaint.ViewModels
{
    public abstract class ViewModel : INotifyPropertyChanged
    {
        #region Constructors

        public ViewModel()
        {
        }

        #endregion


        #region Fields
        #endregion


        #region Bindable Properties
        #endregion


        #region Helpers

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(storage, value))
                return false;

            storage = value;
            OnPropertyChanged(propertyName);
            return true;
        }

        #endregion


        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName ?? string.Empty));
        }

        #endregion
    }
}