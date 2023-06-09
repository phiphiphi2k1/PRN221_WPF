using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using WPF_StudentManagement.ViewModels;
using System.Runtime.CompilerServices;

namespace WPF_StudentManagement.ViewModels
{
    public abstract class ViewModelBase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
