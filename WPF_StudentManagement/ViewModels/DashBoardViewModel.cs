using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using WPF_StudentManagement.Service;
using WPF_StudentManagement.ViewModels;

namespace WPF_StudentManagement.ViewModels
{
    public class DashBoardViewModel : ViewModelBase
    {
        private string _NumberOfUser;
        private string _NumberOfClass;
        private string _NumberOfStudent;


        public string NumberOfUser
        {
            get
            {
                return _NumberOfUser;
            }
            set
            {
                _NumberOfUser = value;
                OnPropertyChanged(nameof(NumberOfUser));
            }
        }

        public string NumberOfClass
        {
            get
            {
                return _NumberOfClass;
            }
            set
            {
                _NumberOfClass = value;
                OnPropertyChanged(nameof(NumberOfClass));
            }
        }

        public string NumberOfStudent
        {
            get
            {
                return _NumberOfStudent;
            }
            set
            {
                _NumberOfStudent = value;
                OnPropertyChanged(nameof(NumberOfStudent));
            }
        }

        public DashBoardViewModel()
        {
            //userRepository = new UserRepository();

            UserService u = new UserService();
            ClassService c = new ClassService();
            NumberOfUser = u.GetAll().Count().ToString();
            NumberOfClass = c.GetAll().Count().ToString();
            NumberOfStudent = u.GetAll().Where(p => p.Role.Equals("ST")).Count().ToString();
        }


    }
}
