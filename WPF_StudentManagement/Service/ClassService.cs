using System.Collections.Generic;
using System.Linq;
using WPF_StudentManagement.Models;
using WPF_StudentManagement.Repository;

namespace WPF_StudentManagement.Service
{
    public class ClassService
    {
        ClassRepository repository;
        public ClassService()
        {
            repository = new ClassRepository();
        }
        public List<Class> GetAll()
        {
            return repository.GetAll().ToList();
        }
        public void Create(Class obj)
        {
            repository.Create(obj);
        }
        public void Update(Class obj)
        {
            repository.Update(obj);
        }
        public void Delete(Class obj)
        {
            repository.Delete(obj);
        }
    }
}
