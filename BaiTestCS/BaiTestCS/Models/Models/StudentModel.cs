using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BaiTestCS.Models.Models
{
    public class StudentModel
    {
        public string ID { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string BirthDay { get; set; }

        public string Gender { get; set; }
        public StudentModel()
        { }
        public void Output()
        {
            Console.WriteLine("ID:{0}\nFullName:{1}\nAddress:{2}\nBirthDay:{3}\nGender:{4}\n");
        }
    }
    public class StudentList
    {
        public List<StudentModel> getJsonSV(string path = null)
        {
            var content = System.IO.File.ReadAllText(@"F:\Hoc Tap\Aps.Net MVC\BaiTestCS\BaiTestCS\Models\Json\data.json");
            Console.WriteLine(content);
            var students = Newtonsoft.Json.JsonConvert.DeserializeObject<List<StudentModel>>(content);
            Console.WriteLine("Sinh Vien Thu Nhat: \n" + students.Count);
            return students;
        }
        public void Output_List(List<StudentModel> studentmodel)
        {
            foreach (StudentModel std in studentmodel)
            {
                std.Output();
            }
        }
    }
}