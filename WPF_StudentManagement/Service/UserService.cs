using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_StudentManagement.Models;
using WPF_StudentManagement.Repository;

namespace WPF_StudentManagement.Service
{
    public class UserService
    {
        UserRepository repository;
        public UserService()
        {
            repository = new UserRepository();
        }
        public List<User> GetAll()
        {
            return repository.GetAll().ToList();
        }
        public void Create(User obj)
        {
            repository.Create(obj);
        }
        public void Update(User obj)
        {
            repository.Update(obj);
        }
        public void Delete(User obj)
        {
            repository.Delete(obj);
        }
    }

}
