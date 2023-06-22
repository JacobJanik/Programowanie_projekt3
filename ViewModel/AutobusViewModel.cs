using p4projekt3.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace p4projekt3.ViewModel
{
    public class AutobusViewModel
    {
        private readonly AutobusModel _autobusModel;

        public AutobusViewModel(AutobusModel autobusModel)
        {
            _autobusModel = autobusModel;
        }
        public string Nr_rejestracji
        {
            get => _autobusModel.Nr_rejestracji;
            set
            {
                _autobusModel.Nr_rejestracji = value;
                OnPropertyChanged();
            }
        }
        public List<int> KierowcaId { get; set; }
        public string Marka
        {
            get => _autobusModel.Marka;
            set
            {
                _autobusModel.Marka= value;
                OnPropertyChanged();
            }
        }
        public string Model
        {
            get => _autobusModel.Model;
            set
            {
                _autobusModel.Model = value;
                OnPropertyChanged();
            }
        }
        public string Rocznik
        {
            get=>_autobusModel.Rocznik;
            set
            {
                _autobusModel.Rocznik= value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangingEventHandler? PropertyChanged;
        
        protected virtual void OnPropertyChanged([CallerMemberName]string? propertyName=null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangingEventArgs(propertyName));
        }
    }
}
