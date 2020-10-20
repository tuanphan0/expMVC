using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using PagedList;
namespace Data
{
    public class KhoaRepository
    {
        QlSinhVienData data;
        public KhoaRepository() {
            data = new QlSinhVienData();
        }
        public IEnumerable<Student> GetAll(int page,int pagesize)
        {
            return data.Student.OrderByDescending(x=>x.Id).ToPagedList(page, pagesize);
        }

        public void Create(Student stu)
        {
            data.Student.Add(stu);
            data.SaveChanges();
        }
        public bool Delete (int id)
        {
            try
            {
                var student = data.Student.SingleOrDefault(x => x.Id == id);
                data.Student.Remove(student);
                data.SaveChanges();
                return true;
            }
            catch { return false; }
        }
        public Student GetById(int id)
        {
            var student = data.Student.SingleOrDefault(x => x.Id == id);
            return student;
        }
        public List<Khoa> GetAllKhoa()
        {
            return data.Khoa.OrderByDescending(x => x.Id).ToList();
        }
        public List<Student> GetAllStu()
        {
            return data.Student.OrderByDescending(x => x.Id).ToList();

        }
    }
}
