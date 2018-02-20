using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

using five.Models;
using five.Services;

using Windows.UI.Xaml.Controls;

namespace five.Views
{
    public sealed partial class GridPage : Page, INotifyPropertyChanged
    {
        // TODO WTS: Change the grid as appropriate to your app.
        // For help see http://docs.telerik.com/windows-universal/controls/raddatagrid/gettingstarted
        // You may also want to extend the grid to work with the RadDataForm http://docs.telerik.com/windows-universal/controls/raddataform/dataform-gettingstarted
        public GridPage()
        {
            InitializeComponent();
        }

        public ObservableCollection<Order> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return OrderDataService.GetOrderData();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
            {
                return;
            }

            storage = value;
            OnPropertyChanged(propertyName);
        }

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
