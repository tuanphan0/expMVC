using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
        Student GetById(int id);
        void Create(Student student);
        bool Delete(int id);

    }

    public class StudentJsonRepository : IStudentRepository
    {
        public void Create(Student student)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            return new List<Student>();
        }
    }
    public class StudentRepository: IStudentRepository
    {
        private QlSinhVienData data;
        public StudentRepository()
        {
            data = new QlSinhVienData();
        }

        void Create(Student student)
        {
            data.Student.Add(student);
            data.SaveChanges();
            
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudents()
        {
            return data.Student.OrderByDescending(x=>x.Id).ToList();
        }

        void IStudentRepository.Create(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
