
using Microsoft.VisualBasic.ApplicationServices;
using System.Linq;
using System.Threading;
using WPF_StudentManagement.Models;
using WPF_StudentManagement.Repository;
using WPF_StudentManagement.Service;

namespace WPF_StudentManagement.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ViewModelCommand StudentManagementCommand { get; set; }
        public ViewModelCommand ClassCommand { get; set; }
        public ViewModelCommand DashBoardCommand { get; set; }
        public ViewModelBase StudentMagementViewModel { get; set; }
        public ViewModelBase ClassViewModel { get; set; }
        public ViewModelBase DashBoardViewModel { get; set; }


        private object _currentView;
        private Models.User _currentUserAccount;
        UserService a;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public Models.User CurrentUserAccount
        {
            get
            {
                return _currentUserAccount;
            }

            set
            {
                _currentUserAccount = value;
                OnPropertyChanged(nameof(CurrentUserAccount));
            }
        }
        public MainViewModel()
        {
            StudentMagementViewModel = new StudentMagementViewModel();
            ClassViewModel = new ClassViewModel();
            DashBoardViewModel = new DashBoardViewModel();

            CurrentView = DashBoardViewModel;

            StudentManagementCommand = new ViewModelCommand(o =>
            {
                CurrentView = StudentMagementViewModel;
            });

            ClassCommand = new ViewModelCommand(o =>
            {
                CurrentView = ClassViewModel;
            });

            DashBoardCommand = new ViewModelCommand(o =>
            {
                CurrentView = DashBoardViewModel;
            });


            CurrentUserAccount = new Models.User();
            a = new UserService();

            LoadCurrentUserData();
        }

        private void LoadCurrentUserData()
        {
            UserService a = new UserService();
            var user = a.GetAll().Where(p => p.Username.Trim().ToUpper().Equals(Thread.CurrentPrincipal.Identity.Name.Trim().ToUpper())).FirstOrDefault();
            if (user != null)
            {
                CurrentUserAccount.Username = user.Username;
                CurrentUserAccount.FullName = $"Welcome {user.FullName}";
            }
            else
            {
                CurrentUserAccount.Username = "Invalid user, not logged in";
                //Hide child views.
            }
        }


    }



}

