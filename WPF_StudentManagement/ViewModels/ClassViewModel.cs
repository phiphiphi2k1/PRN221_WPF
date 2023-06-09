using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using Microsoft.VisualBasic.ApplicationServices;
using WPF_StudentMagement.Models;
using WPF_StudentManagement.Models;
using WPF_StudentManagement.Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WPF_StudentManagement.ViewModels
{
    public class ClassViewModel : ViewModelBase
    {

        private string _subjectName;
        public string subjectName { get => _subjectName; set { _subjectName = value; OnPropertyChanged(); } }



        private string _search;
        public string search { get => _search; set { _search = value; OnPropertyChanged(); LoadClassData(); } }


        private ObservableCollection<DisplayClass> _ClassList;

        public ObservableCollection<DisplayClass> ClassList { get => _ClassList; set { _ClassList = value; OnPropertyChanged(); } }




        private DisplayClass _SelectedItem;

        public DisplayClass SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    subjectName = SelectedItem.SubjectNameV.ToString();
                }

            }
        }

        void LoadClassData()
        {
            var u = new UserService();
            var c = new ClassService();
            ClassList = new ObservableCollection<DisplayClass>();
            var List = c.GetAll().ToList();
            if (!String.IsNullOrEmpty(search))
            {
                List = c.GetAll().Where(p => p.Subject.ToUpper().Trim().Contains(search.ToUpper().Trim())).ToList();
            }
            foreach (var item in List)
            {
                DisplayClass classDisplay = new DisplayClass();
                classDisplay.ClassIdV = item.ClassId;
                classDisplay.SubjectNameV = item.Subject;
                classDisplay.NumberOfStudentV = u.GetAll().Where(p => p.ClassId == item.ClassId && !p.Role.Equals("TC")).Count();

                ClassList.Add(classDisplay);
            }
        }




        public ICommand AddCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand DeleteCommand { get; }

        public ClassViewModel()
        {
            LoadClassData();
            AddCommand = new ViewModelCommand(ExecuteAddCommand, CanExecuteAddCommand);
            UpdateCommand = new ViewModelCommand(ExecuteUpdateCommand, CanExecuteUpdateCommand);
            DeleteCommand = new ViewModelCommand(ExecuteDeleteCommand, CanExecuteDeleteCommand);
        }


        private bool CanExecuteAddCommand(object obj)
        {
            if (String.IsNullOrEmpty(subjectName) || (subjectName.Length > 50))
            {
                return false;
            }

            return true;

        }
        private void ExecuteAddCommand(object obj)
        {
            var u = new UserService();
            var c = new ClassService();

            Class classRoom = new Class();
            if (c.GetAll().FirstOrDefault(p => p.Subject.ToUpper().Trim().Equals(subjectName.ToUpper().Trim())) != null)
            {
                MessageBox.Show("Subject Already Exist");
                return;
            }
            classRoom.Subject = subjectName.ToUpper();
            c.Create(classRoom);
            MessageBox.Show("Add New Class successful");

            ClearForm();
            LoadClassData();
        }


        private bool CanExecuteDeleteCommand(object obj)
        {
            var u = new UserService();
            if (SelectedItem != null)
            {
                if (u.GetAll().Where(p => p.ClassId == SelectedItem.ClassIdV).Count() > 0)
                {
                    return false;
                }
            }

            if (String.IsNullOrEmpty(subjectName) || (subjectName.Length > 50))
            {
                return false;
            }
            if (SelectedItem == null)
            {
                return false;
            }

            return true;
        }
        private void ExecuteDeleteCommand(object obj)
        {
            var c = new ClassService();

            Models.Class _class = c.GetAll().Where(p => p.ClassId == SelectedItem.ClassIdV).FirstOrDefault();
            if (_class != null)
            {
                c.Delete(_class);
                MessageBox.Show("Delete successful");
            }
            else
            {
                MessageBox.Show("Delete unsuccessful");
                return;
            }

            ClearForm();
            LoadClassData();
        }
        private bool CanExecuteUpdateCommand(object obj)
        {
            if (String.IsNullOrEmpty(subjectName) || (subjectName.Length > 50))
            {
                return false;
            }
            if (SelectedItem == null)
            {
                return false;
            }

            return true;

        }
        private void ExecuteUpdateCommand(object obj)
        {
            var u = new UserService();
            var c = new ClassService();

            Class _class = c.GetAll().Where(p => p.ClassId == SelectedItem.ClassIdV).FirstOrDefault();
            if (_class != null)
            {
                if (c.GetAll().FirstOrDefault(p => p.Subject.ToUpper().Trim().Equals(subjectName.ToUpper().Trim())) != null)
                {
                    if (!subjectName.Equals(SelectedItem.SubjectNameV))
                    {
                        MessageBox.Show("Subject Already Exist");
                        return;
                    }
                }
                _class.Subject = subjectName.ToUpper();
                c.Update(_class);
                MessageBox.Show("Update successful");
            }
            else
            {
                MessageBox.Show("Update unsuccessful");
                return;
            }
            ClearForm();
            LoadClassData();
        }

        private void ClearForm()
        {
            subjectName = "";
            search = "";
            SelectedItem = null;
        }
    }
}
