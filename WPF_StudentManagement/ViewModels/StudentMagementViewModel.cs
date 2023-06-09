using FontAwesome.Sharp;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OfficeOpenXml.Table.PivotTable;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPF_StudentManagement.Models;
using WPF_StudentManagement.Service;
using WPF_StudentManagement.ViewModels;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WPF_StudentManagement.ViewModels
{
    public class StudentMagementViewModel : ViewModelBase
    {
        private string _fullName;
        public string fullName { get => _fullName; set { _fullName = value; OnPropertyChanged(); } }

        private string _gender;
        public string gender { get => _gender; set { _gender = value; OnPropertyChanged(); } }


        private DateTime _DOB;
        public DateTime DOB { get => _DOB; set { _DOB = value; OnPropertyChanged(); } }

        private String _username;
        public string username { get => _username; set { _username = value; OnPropertyChanged(); } }

        private string _roleName;
        public string roleName { get => _roleName; set { _roleName = value; OnPropertyChanged(); } }

        private string _className;
        public string className { get => _className; set { _className = value; OnPropertyChanged(); } }

        private string _search;
        public string search { get => _search; set { _search = value; OnPropertyChanged(); LoadUserData(); } }

        private ObservableCollection<DisplayUser> _UserList;

        public ObservableCollection<DisplayUser> UserList { get => _UserList; set { _UserList = value; OnPropertyChanged(); } }

        private ObservableCollection<String> _roleList;

        public ObservableCollection<String> roleList { get => _roleList; set { _roleList = value; OnPropertyChanged(); } }


        private ObservableCollection<String> _classList;

        public ObservableCollection<String> classList { get => _classList; set { _classList = value; OnPropertyChanged(); } }


        private ObservableCollection<String> _genderList;

        public ObservableCollection<String> genderList { get => _genderList; set { _genderList = value; OnPropertyChanged(); } }


        private DisplayUser _SelectedItem;

        public DisplayUser SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();
                if (SelectedItem != null)
                {
                    fullName = SelectedItem.FullNameV.ToString();
                    gender = SelectedItem.GenderV;
                    DOB = SelectedItem.DOBV;
                    username = SelectedItem.StudentNumberV;
                    roleName = SelectedItem.RoleV;
                    className = SelectedItem.ClassV;
                }

            }
        }

        void LoadUserData()
        {
            var u = new UserService();
            var c = new ClassService();
            UserList = new ObservableCollection<DisplayUser>();
            var List = u.GetAll().Where(p => (p.Role.Equals("ST") || p.Role.Equals("TC"))); ;
            if (!String.IsNullOrEmpty(search))
            {
                List = u.GetAll().Where(p => (p.Role.Equals("ST") || p.Role.Equals("TC")) && p.FullName.Trim().ToUpper().Contains(search.Trim().ToUpper()));
            }
            foreach (var user in List)
            {
                DisplayUser Displayuser = new DisplayUser();

                Displayuser.IdV = user.UserId;
                Displayuser.FullNameV = user.FullName;
                Displayuser.GenderV = (bool)user.Gender ? "Male" : "Female";
                Displayuser.DOBV = user.Dob.Value.Date;
                Displayuser.StudentNumberV = user.Username;
                Displayuser.RoleV = user.Role;

                if (user.ClassId != null)
                {
                    Displayuser.ClassV = (c.GetAll().Where(p => p.ClassId == user.ClassId).FirstOrDefault()).Subject;
                }
                else
                {
                    Displayuser.ClassV = "Not Found";
                }

                Displayuser.Object = user;

                UserList.Add(Displayuser);
            }
        }

        void LoadComboBoxData()
        {
            var u = new UserService();
            var c = new ClassService();
            var listClass = c.GetAll();

            classList = new ObservableCollection<String>();
            foreach (var item in listClass)
            {
                classList.Add(item.Subject);
            }

            roleList = new ObservableCollection<String>();
            roleList.Add("ST");
            roleList.Add("TC");

            genderList = new ObservableCollection<String>();
            genderList.Add("Male");
            genderList.Add("Female");
        }


        public ICommand AddCommand { get; }
        public ICommand UpdateCommand { get; }
        public ICommand DeleteCommand { get; }
        public ICommand ExportCommand { get; }

        public StudentMagementViewModel()
        {
            LoadUserData();
            LoadComboBoxData();
            AddCommand = new ViewModelCommand(ExecuteAddCommand, CanExecuteAddCommand);
            UpdateCommand = new ViewModelCommand(ExecuteUpdateCommand, CanExecuteUpdateCommand);
            DeleteCommand = new ViewModelCommand(ExecuteDeleteCommand, CanExecuteDeleteCommand);
            ExportCommand = new ViewModelCommand(ExecuteExportCommand, CanExecuteExportCommand);
        }


        private bool CanExecuteAddCommand(object obj)
        {
            if (String.IsNullOrEmpty(fullName) || (fullName.Length > 50))
            {
                return false;
            }
            if (String.IsNullOrEmpty(username) || (username.Length > 50))
            {
                return false;
            }

            return true;

        }
        private void ExecuteAddCommand(object obj)
        {
            var u = new UserService();
            var c = new ClassService();
            Models.User user = new Models.User();
            user.FullName = fullName;
            if (gender.Equals("Female"))
            {
                user.Gender = false;
            }
            else
            {
                user.Gender = true;
            }
            user.Dob = DOB;
            if (u.GetAll().FirstOrDefault(p => p.Username.ToUpper().Trim().Equals(username.ToUpper().Trim())) != null)
            {
                MessageBox.Show("Student Number Already Exist");
                return;
            }
            user.Username = username.ToUpper();
            user.Role = roleName;
            user.Status = true;
            user.Password = "123456";
            user.ClassId = c.GetAll().Where(p => p.Subject.Equals(className)).FirstOrDefault().ClassId;
            u.Create(user);
            MessageBox.Show("Add successful");

            ClearForm();
            LoadUserData();
        }
        private bool CanExecuteDeleteCommand(object obj)
        {
            if (String.IsNullOrEmpty(fullName) || (fullName.Length > 50))
            {
                return false;
            }
            if (String.IsNullOrEmpty(username) || (username.Length > 50))
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
            var u = new UserService();
            var c = new ClassService();
            Models.User user = u.GetAll().Where(p => p.UserId == SelectedItem.IdV).FirstOrDefault();
            if (user != null)
            {
                u.Delete(user);
                MessageBox.Show("Delete successful");
            }
            else
            {
                MessageBox.Show("Delete unsuccessful");
                return;
            }

            ClearForm();
            LoadUserData();
        }
        private bool CanExecuteUpdateCommand(object obj)
        {
            if (String.IsNullOrEmpty(fullName) || (fullName.Length > 50))
            {
                return false;
            }
            if (String.IsNullOrEmpty(username) || (username.Length > 50))
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
            Models.User user = u.GetAll().Where(p => p.UserId == SelectedItem.IdV).FirstOrDefault();
            if (user != null)
            {
                user.FullName = fullName;
                if (gender.Equals("Female"))
                {
                    user.Gender = false;
                }
                else
                {
                    user.Gender = true;
                }
                user.Dob = DOB;
                if (u.GetAll().FirstOrDefault(p => p.Username.ToUpper().Trim().Equals(username.ToUpper().Trim())) != null)
                {
                    if (!username.Equals(SelectedItem.StudentNumberV))
                    {
                        MessageBox.Show("Student Number Already Exist");
                        return;
                    }
                }            
                user.Username = username.ToUpper();
                user.Role = roleName;
                user.Status = true;
                user.Password = "123456";
                user.ClassId = c.GetAll().Where(p => p.Subject.Equals(className)).FirstOrDefault().ClassId;
                u.Update(user);
                MessageBox.Show("Update successful");

            }
            else
            {
                MessageBox.Show("Update unsuccessful");
                return;
            }
            ClearForm();
            LoadUserData();
        }


        private void ExecuteExportCommand(object obj)
        {
            string filePath = "";
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel | *.xlsx | Execel 2003 | *.xls";
            if (dialog.ShowDialog() == true)
            {
                filePath = dialog.FileName;
            }
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Export Fail");
                return;
            }
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            try
            {
                using (ExcelPackage e = new ExcelPackage())
                {
                    e.Workbook.Properties.Author = "Phi Nguyen";
                    e.Workbook.Properties.Title = "Student Management";
                    e.Workbook.Worksheets.Add("User");
                    ExcelWorksheet ws = e.Workbook.Worksheets[0];

                    ws.Name = "User";
                    ws.Cells.Style.Font.Size = 13;
                    ws.Cells.Style.Font.Name = "Time New Romans";

                    String[] arrColumHeader =
                    {
                        "UserId"
                        ,"FullName"
                        ,"Gender"
                        ,"Dob"
                        ,"Username"
                        ,"Role"
                        ,"ClassName"
                    };
                    var countColHeader = arrColumHeader.Count();

                    ws.Cells[1, 1].Value = "List Of User";
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    int colIndex = 1;
                    int rowIndex = 2;

                    foreach (var item in arrColumHeader)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];

                        var fill = cell.Style.Fill;
                        fill.PatternType = ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                        var border = cell.Style.Border;
                        border.Bottom.Style
                            = border.Top.Style
                            = border.Left.Style
                            = border.Right.Style = ExcelBorderStyle.Medium;

                        cell.Value = item;
                        colIndex++;
                    }
                    foreach (var item in UserList)
                    {
                        colIndex = 1;
                        rowIndex++;
                        ws.Cells[rowIndex, colIndex++].Value = item.IdV;
                        ws.Cells[rowIndex, colIndex++].Value = item.FullNameV;
                        ws.Cells[rowIndex, colIndex++].Value = item.GenderV;
                        ws.Cells[rowIndex, colIndex++].Value = item.DOBV.ToString();
                        ws.Cells[rowIndex, colIndex++].Value = item.StudentNumberV;
                        ws.Cells[rowIndex, colIndex++].Value = item.RoleV;
                        ws.Cells[rowIndex, colIndex++].Value = item.ClassV;
                    }
                    Byte[] bin = e.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }
                MessageBox.Show("Export Successful");
            }
            catch
            {
                MessageBox.Show("Export Fail");
            }
        }
        private bool CanExecuteExportCommand(object obj)
        {
            return true;
        }
        private void ClearForm()
        {
            fullName = "";
            gender = "";
            DOB = DateTime.Now;
            username = "";
            search = "";
            SelectedItem = null;
        }
    }
}

