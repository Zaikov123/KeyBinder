using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyBinderV1.ViewModel
{
    public class AddBind : ViewModelBase
    {
        private string _selectedBind;

        public ObservableCollection<string> AvailableBinds { get; set; }

        public string SelectedBind
        {
            get => _selectedBind;
            set
            {
                _selectedBind = value;
                OnPropertyChanged(nameof(SelectedBind));
            }
        }
    }
}
