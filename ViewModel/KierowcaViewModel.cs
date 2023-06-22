using p4projekt3.Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace p4projekt3.ViewModel
{
    public class KierowcaViewModel
    {
        private readonly KierowcaModel _kierowcaModel;
        public KierowcaViewModel()
        {
            _kierowcaModel = new KierowcaModel();
        }

        public string FirstName
        {
            get => _kierowcaModel.FirstName;
            set
            {
                _kierowcaModel.FirstName = value;
                OnPropertyChanged();
            }
        }
        public string LastName
        {
            get => _kierowcaModel.LastName;
            set
            {
                _kierowcaModel.LastName = value;
                OnPropertyChanged();
            }
        }
        public int Phone
        {
            get => _kierowcaModel.Nr_tel;
            set
            {
                _kierowcaModel.Nr_tel = value;
                OnPropertyChanged();
            }
        }
        public string Adres
        {
            get=> _kierowcaModel.Adres;
            set
            {
                _kierowcaModel.Adres = value;
                OnPropertyChanged();
            }
        }
        public DateTime Data_ur
        {
            get => _kierowcaModel.Data_ur;
            set
            {
                _kierowcaModel.Data_ur = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName =null)
        {
           PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
